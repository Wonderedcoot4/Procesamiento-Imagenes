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
        private Image<Bgr, byte> originalImage;
        private Image<Bgr, byte> editedImage;
        private HistoForm Histoform;

        private int anchoVentana, altoVentana;
        private int ValorTrackerBar;
        public Fotografias()
        {
            InitializeComponent();

            resultante = new Bitmap(FotoFiltroPicBox.Width, FotoFiltroPicBox.Height);
            anchoVentana = 800;
            altoVentana = 600;
            trackBarEdicion.ValueChanged += TrackerBar_ValueChanged;
            
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
            int x = 0;
            int y = 0;
            int a = ValorTrackerBar;

            int r = 0;
            int g = 0;
            int b = 0;

            resultante = new Bitmap(original.Width, original.Height);

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
            Bitmap bmpRes = resultante;
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

        private void FotoFiltroPicBox_Paint(object sender, PaintEventArgs e)
        {
  
        }
    }
}
