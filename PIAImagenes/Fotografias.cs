using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace WindowsFormsApp1
{
    public partial class Fotografias : Form
    {
        private Bitmap original;
        private Bitmap resultante;
        private int[] histograma = new int[256];
        private int[] histogramaR = new int[256];
        private int[] histogramaG = new int[256];
        private int[] histogramaB = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;

        private int anchoVentana, altoVentana;
        private int ValorTrackerBar;
        public Fotografias()
        {
            InitializeComponent();

            resultante = new Bitmap(FotoFiltroPicBox.Width, FotoFiltroPicBox.Height);
            anchoVentana = 800;
            altoVentana = 600;
            trackBarEdicion.ValueChanged += TrackerBar_ValueChanged;
            trackBarEdicion.Value = 20;
            
        }

        private void TrackerBar_ValueChanged(object sender, EventArgs e)
        {
            // Actualizar la etiqueta con el valor seleccionado del TrackBar
            label1.Text = "Valor seleccionado: " + trackBarEdicion.Value.ToString();
            ValorTrackerBar = trackBarEdicion.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StartScreenBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubirFotoBtn_Click(object sender, EventArgs e)
        {
            // OBJ para abrir el explorador
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Ruta de la imagen
                string rutaImagen = openFileDialog1.FileName;
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                // Aquí puedes trabajar con la ruta de la imagen seleccionada, por ejemplo, cargarla en un PictureBox
                FotoOriginalPictureBox.Image = Image.FromFile(rutaImagen);
                original = (Bitmap)FotoOriginalPictureBox.Image;
                anchoVentana = original.Width;
                altoVentana = original.Height;
                

                resultante = original;

                this.Invalidate();
            }
        }

        private void FiltroPixeladoBtn_Click(object sender, EventArgs e)
        {
            resultante = original;
            Bitmap imagenBlanca = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(imagenBlanca))
            {
                g.Clear(Color.White);
            }

            // Asignar la imagen blanca a los PictureBox
            FotoFiltroPicBox.Image = imagenBlanca;

            int valorTracker = ValorTrackerBar;
            //FiltroPixeladoBtn.BackColor = Color.Magenta;
            Image imagenConFiltro = (Image)FotoOriginalPictureBox.Image.Clone();

            // Aplicar el filtro de pixelado
            imagenConFiltro = FilterBitmap(imagenConFiltro, valorTracker);

            // Mostrar la imagen con filtro en el PictureBox FotoConFiltroPictureBox
            FotoFiltroPicBox.Image = imagenConFiltro;
        }

        //Pixelado de imagen
        private Bitmap FilterBitmap(Image image, int pixelSize)
        {
            Bitmap bmp = new Bitmap(image);
            for (int y = 0; y < bmp.Height; y += pixelSize)
            {
                for (int x = 0; x < bmp.Width; x += pixelSize)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    for (int yy = y; yy < y + pixelSize && yy < bmp.Height; yy++)
                    {
                        for (int xx = x; xx < x + pixelSize && xx < bmp.Width; xx++)
                        {
                            bmp.SetPixel(xx, yy, pixelColor);
                        }
                    }
                }
            }
            resultante = bmp;
            return bmp;
        }
        private void Fotografias_Load(object sender, EventArgs e)
        {
         
            Bitmap imagenBlanca = new Bitmap(100, 100); 
            using (Graphics g = Graphics.FromImage(imagenBlanca))
            {
                g.Clear(Color.White);
            }

            // Asignar la imagen blanca a los PictureBox
            FotoOriginalPictureBox.Image = imagenBlanca;
            FotoFiltroPicBox.Image = imagenBlanca;
            
        }

        private void HistoButton_Click(object sender, EventArgs e)
        {
            //HistoButton_Click(sender, e);
            int x = 0;
            int y = 0;
            Color rColor = new Color();

            for(x = 0; x < original.Width; x++)
            {
                for(y=0; y < original.Height; y++)
                {
                    rColor = resultante.GetPixel(x, y);
                    histogramaR[rColor.R]++;
                    histogramaG[rColor.G]++;
                    histogramaB[rColor.B]++;
                }
            }

            HistoForm hForm = new HistoForm(histogramaR, histogramaB, histogramaG);

            hForm.Show();
        }

        private void SaveImgBttn_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "Archivos de imagen PNG (*.png)|*.png|Todos los archivos (*.*)|*.*";
            SaveFileDialog1.Title = "Guardar imagen";
            SaveFileDialog1.DefaultExt = "png";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void FiltroPixeladoBtn_MouseHover(object sender, EventArgs e)
        {
            FiltroPixeladoBtn.BackColor = Color.Magenta;
        }

        private void FiltroPixeladoBtn_MouseLeave(object sender, EventArgs e)
        {
            FiltroPixeladoBtn.BackColor = Color.FromArgb(192,0,0);
        }

        private void AberracionCromaBttn_Click(object sender, EventArgs e)
        {
            Bitmap res;
            resultante = original;
            Bitmap imagenBlanca = new Bitmap(100, 100);
            Graphics gr;
            using (gr = Graphics.FromImage(imagenBlanca))
            {
                gr.Clear(Color.White);
            }

            // Asignar la imagen blanca a los PictureBox
            FotoFiltroPicBox.Image = imagenBlanca;
            int x = 0;
            int y = 0;
            int a = ValorTrackerBar;

            int r = 0;
            int g = 0;
            int b = 0;
            res = new Bitmap(original.Width, original.Height);

            for ( x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    //Verde
                    g = original.GetPixel(x, y).G;

                    if (x + a < original.Width)
                    {
                        r = original.GetPixel(x + a, y).R;


                    }
                    else
                        r = 0;

                    if (x - a >= 0)
                    {
                        b = original.GetPixel(x - a, y).B;
                    }
                    else
                        b = 0;

                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                 
                }

            }
            //Bitmap bmpRes = resultante;
            FotoFiltroPicBox.Image = resultante;

        }

        private void AberracionCromaBttn_MouseHover(object sender, EventArgs e)
        {
            AberracionCromaBttn.BackColor = Color.Magenta;
        }

        private void AberracionCromaBttn_MouseLeave(object sender, EventArgs e)
        {
            AberracionCromaBttn.BackColor = Color.FromArgb(192,0,0);
        }

        private void ColorizarFiltroBttn_Click(object sender, EventArgs e)
        {
            Bitmap res;
            res = original; //Quitale esto si quieres que los filtros se acumulen, lo agregue en todos los filtros
            int x = 0;
            int y = 0;

            double rc = 150 / 255.0;
            double gc = 220 / 255.0;
            double bc = 245 / 255.0;

            Color MyColor = new Color();
            int r = 0;
            int g = 0;
            int b = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    MyColor = res.GetPixel(x, y);
                    r = (int)(MyColor.R * rc);
                    g = (int)(MyColor.G * gc);
                    b = (int)(MyColor.B * bc);
                    res.SetPixel(x, y, Color.FromArgb(r, g, b));
                }

            }
            resultante = res;
            FotoFiltroPicBox.Image = res;
        }

        private void ColorizarFiltroBttn_MouseHover(object sender, EventArgs e)
        {
            ColorizarFiltroBttn.BackColor = Color.Magenta;
        }

        private void ColorizarFiltroBttn_MouseLeave(object sender, EventArgs e)
        {
            ColorizarFiltroBttn.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void NegativoFiltroBttn_Click(object sender, EventArgs e)
        {
            resultante = original;
            int x = 0;
            int y = 0;

            Color rColor = new Color(); //Color resultante del filtro
            Color oColor = new Color(); //Color original

            for ( x = 0; x < original.Width; x++)
            {
                for ( y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);


                    resultante.SetPixel(x, y, rColor);
                }
            }
            FotoFiltroPicBox.Image = resultante;
        }

        private void NegativoFiltroBttn_MouseHover(object sender, EventArgs e)
        {
            NegativoFiltroBttn.BackColor = Color.Magenta;
        }

        private void NegativoFiltroBttn_MouseLeave(object sender, EventArgs e)
        {
            NegativoFiltroBttn.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void GradianteFiltroBttn_Click(object sender, EventArgs e)
        {
            resultante = original;
            float r1 = 130;
            float g1 = 230;
            float b1 = 120;

            float r2 = 230;
            float g2 = 100;
            float b2 = 200;

            int r = 0;
            int g = 0;
            int b = 0;
            //Diferencias de intensidad
            float dr = (r2 - r1) / original.Width;
            float dg = (g2 - g1) / original.Width;
            float db = (b2 - b1) / original.Width;

            int x = 0;
            int y = 0;

            Color oColor;

            for ( x = 0; x < original.Width; x++)
            {
                for ( y = 0; y < original.Height; y++)
                {
                    oColor = resultante.GetPixel(x, y);

                    r = (int)((r1 / 255.0f) * oColor.R);
                    g = (int)((g1 / 255.0f) * oColor.G);
                    b = (int)((b1 / 255.0f) * oColor.B);

                    if (r > 255)
                    {
                        r = 255;
                    }
                    else if (r < 0)
                        r = 0;

                    if (g > 255)
                    {
                        g = 255;
                    }
                    else if (g < 0)
                        g = 0;

                    if (b > 255)
                    {
                        b = 255;
                    }
                    else if (b < 0)
                        b = 0;


                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                }

                r1 = (r1 + dr);
                g1 = (g1 + dg);
                b1 = (b1 + db);
            }
            FotoFiltroPicBox.Image = resultante;
        }

        private void GradianteFiltroBttn_MouseHover(object sender, EventArgs e)
        {
            GradianteFiltroBttn.BackColor = Color.Magenta; 
        }

        private void GradianteFiltroBttn_MouseLeave(object sender, EventArgs e)
        {
            GradianteFiltroBttn.BackColor = Color.FromArgb(192, 0, 0);
        }
        //6 filtro
        private void ContrasteFiltroBttn_Click(object sender, EventArgs e)
        {
            int contraste = ValorTrackerBar;

            //Hago una division
            float c = (100.0f + contraste) / 100.0f;
            c *= c;

            int x = 0;
            int y = 0;

            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();


            float r = 0;
            float g = 0;
            float b = 0;


            for ( x = 0; x < original.Width; x++)
            {
                for ( y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    r = ((((oColor.R / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (r> 255)
                    {
                        r = 255;
                    }
                    if (r < 0)
                    {
                        r = 0;
                    }
                    g = ((((oColor.G / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (g < 0)
                    {
                        g = 0;
                    }

                    b = ((((oColor.B / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (b > 255)
                    {
                        b = 255;
                    }
                    if (b < 0)
                    {
                        b = 0;
                    }

                    rColor = Color.FromArgb((int)r, (int)g, (int)b);


                    resultante.SetPixel(x, y, rColor);
                }
            }
            FotoFiltroPicBox.Image = resultante;
        }
        //7 Filtro
        private void EspejoFiltroBttn_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            resultante = new Bitmap(original.Width, original.Height);

            Color rColor = new Color();
            Color oColor = new Color();

            float g = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    rColor = Color.FromArgb(oColor.R, oColor.G, oColor.B);

                    resultante.SetPixel(original.Width - x - 1, y, rColor);
                }
            }

            FotoFiltroPicBox.Image = resultante;
        }
        //8 Filtro
        private void FiltroRojoBttn_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    rColor = Color.FromArgb(oColor.R, 0, 0);

                    resultante.SetPixel(x, y, rColor);
                }
            }
            FotoFiltroPicBox.Image = resultante;
        }
        //9 Filtro
        private void CanalAzulFiltroBttn_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    oColor = original.GetPixel(x, y);

                    rColor = Color.FromArgb(0, 0, oColor.B);

                    resultante.SetPixel(x, y, rColor);
                }
            }
            FotoFiltroPicBox.Image = resultante;

        }

        private void CanalAzulFiltroBttn_MouseHover(object sender, EventArgs e)
        {
            CanalAzulFiltroBttn.BackColor = Color.Magenta;
        }

        private void CanalAzulFiltroBttn_MouseLeave(object sender, EventArgs e)
        {
            CanalAzulFiltroBttn.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void FiltroRojoBttn_MouseHover(object sender, EventArgs e)
        {
            FiltroRojoBttn.BackColor = Color.Magenta;
        }

        private void FiltroRojoBttn_MouseLeave(object sender, EventArgs e)
        {
            FiltroRojoBttn.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void EspejoFiltroBttn_MouseHover(object sender, EventArgs e)
        {
            EspejoFiltroBttn.BackColor = Color.Magenta;
        }

        private void EspejoFiltroBttn_MouseLeave(object sender, EventArgs e)
        {
            EspejoFiltroBttn.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void ContrasteFiltroBttn_MouseHover(object sender, EventArgs e)
        {
            ContrasteFiltroBttn.BackColor = Color.Magenta;
        }

        private void ContrasteFiltroBttn_MouseLeave(object sender, EventArgs e)
        {
            ContrasteFiltroBttn.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void SobelFiltroBttn_Click(object sender, EventArgs e)
        {
            int[,] sobel0 = new int[,]
            {
                {1,2,1 },
                {0,0,0 },
                {-1,-2,-1 } };
            int[,] sobel1 = new int[,]
           {
                {2,1,0 },
                {1,0,-1 },
                {0,-1,-2 } };
           int[,] sobel2 = new int[,]
           {
                {1,0,-1 },
                {2,0,-2 },
                {1,0,-1} };
            int[,] sobel3 = new int[,]
          {
                {0,-1,-2 },
                {1,0,-1 },
                {2,1,0} };
         int[,] sobel4 = new int[,]
          {
                {-1,-2,-1 },
                {0,0,0 },
                {1,2,1} };
         int[,] sobel5 = new int[,]
          {
                {-2,-1,0 },
                {-1,0,1},
                {0,1,2} };
         int[,] prewitt6 = new int[,]
              {
                {-1,0,1 },
                {-2,0,2},
                {-1,0,1} };
            int[,] sobel7 = new int[,]
              {
                {0,1,2},
                {-1,0,1},
                {-2,-1,0} };

            Bitmap intermedio = (Bitmap)resultante.Clone();

            ConvGris(sobel3, intermedio, 0, 255);
        }

        private void ConvGris(int[,] pMatriz, Bitmap pImagen, int pInferior, int pSuperior)
        {
            int x = 0;
            int y = 0;
            int a = 0;
            int b = 0;
            Color oColor;

            int suma = 0;

            for ( x = 1; x < pImagen.Width -1; x++)
            {
                for ( y = 1; y < pImagen.Height - 1; y++)
                {
                    suma = 0;
                    for (a= -1; a < 2; a++)
                    {
                        for ( b = -1; b < 2; b++)
                        {
                            oColor = pImagen.GetPixel(x + a, y + b);
                            suma = suma + (oColor.R * pMatriz[a + 1, b + 1]);
                        }
                    }
                    if (suma <pInferior)
                    {
                        suma = 0;
                    }
                    else if (suma > pSuperior)
                    {
                        suma = 255;
                    }
                    resultante.SetPixel(x, y, Color.FromArgb(suma, suma, suma));
                }
            }
            pImagen = resultante;
            FotoFiltroPicBox.Image = pImagen;
        }

        private void SobelFiltroBttn_MouseLeave(object sender, EventArgs e)
        {
            SobelFiltroBttn.BackColor = Color.Magenta;
        }

        private void SobelFiltroBttn_MouseHover(object sender, EventArgs e)
        {
            SobelFiltroBttn.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void FotoFiltroPicBox_Paint(object sender, PaintEventArgs e)
        {
  
        }



    }
}
