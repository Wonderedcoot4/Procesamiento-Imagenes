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

                switch (filtro)
                {
                    case 0:
                        break;
                    case 1:
                        emguFrame = ApplyPixelationFilter(emguFrame);
                        break;
                    //case 2:
                    //    emguFrame = FiltroComponenteColor(emguFrame);
                    //    break;
                    //case 3:
                    //    emguFrame = FiltroAberracion(emguFrame);
                    //    break;
                    //case 4:
                    //    emguFrame = FiltroColorizar(emguFrame);
                    //    break;
                    //case 5:
                    //    emguFrame = FiltroRuido(emguFrame);
                    //    break;
                    //case 6:
                    //    emguFrame = ModificarBrillo(emguFrame);
                    //    break;
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

                // Mostrar el fotograma en el PictureBox
                pictureBox1.Image = bitmap;
            }
        }

        private Image<Bgr, byte> ApplyPixelationFilter(Image<Bgr, byte> original)
        {
            int pixelSize = 10; // Define el tamaño del pixelado directamente en el método

            Image<Bgr, byte> resultante = original.CopyBlank();
            for (int y = 0; y < original.Height; y += pixelSize)
            {
                for (int x = 0; x < original.Width; x += pixelSize)
                {
                    // Obtén el color del pixel en la esquina superior izquierda del bloque de píxeles
                    Bgr pixelColor = original[y, x];

                    // Rellena el bloque de píxeles con el color obtenido
                    for (int yy = y; yy < y + pixelSize && yy < original.Height; yy++)
                    {
                        for (int xx = x; xx < x + pixelSize && xx < original.Width; xx++)
                        {
                            resultante[yy, xx] = pixelColor;
                        }
                    }
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
    }
}
