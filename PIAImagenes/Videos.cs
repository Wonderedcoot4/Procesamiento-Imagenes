using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Videos : Form
    {
        public Videos()
        {
            InitializeComponent();
            InitializePictureBox();
        }

        private VideoCapture capture;
        private bool isCapturing = false;
        private int filtro = 0;

        private void InitializePictureBox()
        {
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = null;
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayVidBttn_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                if (!isCapturing)
                {
                    capture.Start(); // Comienza la captura de video
                    isCapturing = true;
                    playText.Text = "Reanudar";
                }
            
            }
            else
            {
                MessageBox.Show("No hay ningún video cargado."); // Muestra un mensaje al usuario
            }
        }

        private void UploadVideoBttn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de video|*.avi;*.mp4;*.wmv|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaVideo = openFileDialog.FileName;

                if (capture != null)
                {
                    capture.Stop(); // Detiene la captura de video
                    capture.Dispose(); // Libera los recursos
                    capture = null;
                    pictureBox1.Image = null; // Limpia el PictureBox
                    isCapturing = false;
                    playText.Text = "Iniciar";
                }

                capture = new VideoCapture(rutaVideo); // Especifica la ruta del video seleccionado
                capture.ImageGrabbed += Capture_NewFrame; // Suscribirse al evento ImageGrabbed
            }
        }

        private void Capture_NewFrame(object sender, EventArgs e)
        {
            if (capture != null && capture.Ptr != IntPtr.Zero)
            {
                Mat frame = new Mat();
                capture.Retrieve(frame); // Obtener el fotograma capturado

                // Convertir el fotograma a un formato de EmguCV
                Image<Bgr, byte> emguFrame = frame.ToImage<Bgr, byte>();
                Image<Bgr, byte> filteredFrame = emguFrame.Copy();

                int trackBarValue = 10; // Valor por defecto
                if (trackBar1.InvokeRequired)
                {
                    trackBar1.Invoke(new MethodInvoker(delegate {
                        trackBarValue = trackBar1.Value;
                    }));
                }
                else
                {
                    trackBarValue = trackBar1.Value;
                }


                switch (filtro)
                {
                    case 0:
                        break;
                    case 1:
                        filteredFrame = ApplyPixelationFilter(emguFrame, trackBarValue);
                        break;
                    case 2:
                        filteredFrame = ApplyCustomColorFilter(emguFrame, trackBarValue);
                       break;
                    case 3:
                        filteredFrame = ApplyColorize(emguFrame, trackBarValue);
                        break;
                    case 4:
                        filteredFrame = EspejoFiltro(emguFrame);
                        break;
                    case 5:
                        filteredFrame = ApplyNegativeFilter(emguFrame);
                        break;
                    case 6:
                        filteredFrame = ApplyGradientFilter(emguFrame);
                        break;
                        //case 7:
                        //    emguFrame = CambiarTonoGradual(emguFrame);
                        //    break;
                        //case 8:
                        //    emguFrame = AplicarGamma(emguFrame);
                        //    break;
                        //case 9:
                        //    emguFrame = ModificarContraste(emguFrame);
                        //    break;
                        //case 10:
                        //    emguFrame = FlipHorizontal(emguFrame);
                        //    break;
                        //default:

                        break;
                }

                byte[] imageBytes = emguFrame.ToJpegData();
                Bitmap bitmap = new Bitmap(new System.IO.MemoryStream(imageBytes));
                byte[] filteredImageBytes = filteredFrame.ToJpegData();
                Bitmap filteredBitmap = new Bitmap(new System.IO.MemoryStream(filteredImageBytes));

                // Mostrar el fotograma en el PictureBox
                pictureBox1.Image = bitmap;
                pictureBox2.Image = filteredBitmap;
            }
        }

        private Image<Bgr, byte> ApplyColorize(Image<Bgr, byte> original, int trackBar)
        {
            double rc = 120 / 255.0;
            double gc = 160 / 255.0;
            double bc = 245 / 255.0;
            Image<Bgr, byte> resultante = original.CopyBlank();

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Bgr pixelColor = original[y, x];
                    int r = (int)(pixelColor.Red * rc);
                    int g = (int)(pixelColor.Green * gc);
                    int b = (int)(pixelColor.Blue * bc);
                    resultante[y, x] = new Bgr(b, g, r); // Modifica la copia
                }
            }

            return resultante;
        }

        private Image<Bgr, byte> ApplyPixelationFilter(Image<Bgr, byte> original, int trackBar)
        {
            int pixelSize = 10; // Define el tamaño del pixelado directamente en el método

            Image<Bgr, byte> resultante = original.CopyBlank();
            for (int y = 0; y < original.Height; y += trackBar)
            {
                for (int x = 0; x < original.Width; x += trackBar)
                {
                    // Obtén el color del pixel en la esquina superior izquierda del bloque de píxeles
                    Bgr pixelColor = original[y, x];

                    // Rellena el bloque de píxeles con el color obtenido
                    for (int yy = y; yy < y + trackBar && yy < original.Height; yy++)
                    {
                        for (int xx = x; xx < x + trackBar && xx < original.Width; xx++)
                        {
                            resultante[yy, xx] = pixelColor;
                        }
                    }
                }
            }
            return resultante;
        }

        private Image<Bgr, byte> ApplyCustomColorFilter(Image<Bgr, byte> original, int a)
        {
            Image<Bgr, byte> resultante = original.Copy();

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Bgr currentColor = original[y, x];

                    double r = currentColor.Red;
                    double g = currentColor.Green;
                    double b = currentColor.Blue;

                    if (x + a < original.Width)
                    {
                        r = original[y, x + a].Red;
                    }
                    else
                    {
                        r = 0;
                    }

                    if (x - a >= 0)
                    {
                        b = original[y, x - a].Blue;
                    }
                    else
                    {
                        b = 0;
                    }

                    resultante[y, x] = new Bgr(b, g, r);
                }
            }

            return resultante;
        }


        private void PauseBttn_Click(object sender, EventArgs e)
        {
            if (capture.IsOpened)
            {
                capture.Pause(); // Pausa la captura de video
                isCapturing = false;
                playText.Text = "Pausar";
            }
        }

        private void PixelFiltroBttn_Click(object sender, EventArgs e)
        {
            filtro = 1;
        }

        private void AbeCromaticaBttn_Click(object sender, EventArgs e)
        {
            filtro = 2;
        }

        private void ColorizarBttn_Click(object sender, EventArgs e)
        {
            filtro = 3;
        }

        private Image<Bgr, byte> EspejoFiltro(Image<Bgr, byte> imagenBGR)
        {
            Image<Bgr, byte> imagenFlipHorizontal = new Image<Bgr, byte>(imagenBGR.Width, imagenBGR.Height);

            for (int y = 0; y < imagenBGR.Height; y++)
            {
                for (int x = 0; x < imagenBGR.Width; x++)
                {
                    Bgr pixelBGR = imagenBGR[y, x];
                    imagenFlipHorizontal[y, imagenBGR.Width - x - 1] = pixelBGR;
                }
            }

            return imagenFlipHorizontal;
        }

        private void EspejoFiltroBttn_Click(object sender, EventArgs e)
        {
            filtro = 4;
        }
        private Image<Bgr, byte> ApplyNegativeFilter(Image<Bgr, byte> original)
        {
            Image<Bgr, byte> resultante = original.Copy();

            for (int x = 0; x < original.Width; x++)
             {
                for (int y = 0; y < original.Height; y++)
            {
                    Bgr pixelColor = original[y, x];
                    Bgr negativeColor = new Bgr(255 - pixelColor.Blue, 255 - pixelColor.Green, 255 - pixelColor.Red);
                    resultante[y, x] = negativeColor;
                }
            }

            return resultante;
        }

        private void NegatvioFiltroBttn_Click(object sender, EventArgs e)
        {
            filtro = 5;
        }

        private Image<Bgr, byte> ApplyGradientFilter(Image<Bgr, byte> original)
        {
            Image<Bgr, byte> resultante = original.Copy();
            float r1 = 130;
            float g1 = 230;
            float b1 = 120;

            float r2 = 230;
            float g2 = 100;
            float b2 = 200;

            float dr = (r2 - r1) / original.Width;
            float dg = (g2 - g1) / original.Width;
            float db = (b2 - b1) / original.Width;

            int r = 0;
            int g = 0;
            int b = 0;

            for (int x = 0; x < original.Width; x++)
        {
                for (int y = 0; y < original.Height; y++)
            {
                    Bgr oColor = original[y, x];

                    r = (int)((r1 / 255.0f) * oColor.Red);
                    g = (int)((g1 / 255.0f) * oColor.Green);
                    b = (int)((b1 / 255.0f) * oColor.Blue);

                    r = Clamp(r, 0, 255);
                    g = Clamp(g, 0, 255);
                    b = Clamp(b, 0, 255);

                    resultante[y, x] = new Bgr(b, g, r);
                }

                r1 += dr;
                g1 += dg;
                b1 += db;
            }

            return resultante;
        }

        private int Clamp(int value, int min, int max)
        {
            return (value <min) ? min: (value > max) ? max: value;
        }

        private void GradianteFiltroBttn_Click(object sender, EventArgs e)
        {
            filtro = 6;
        }
    }
}
