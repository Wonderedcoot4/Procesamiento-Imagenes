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

        private Image<Bgr, byte> originalImage;
        private Image<Bgr, byte> editedImage;
        public Fotografias()
        {
            InitializeComponent();
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

                // Aquí puedes trabajar con la ruta de la imagen seleccionada, por ejemplo, cargarla en un PictureBox
                FotoOriginalPictureBox.Image = Image.FromFile(rutaImagen);
            }
        }

        private void FiltroPixeladoBtn_Click(object sender, EventArgs e)
        {
            FiltroPixeladoBtn.BackColor = Color.Magenta;
            Image imagenConFiltro = (Image)FotoOriginalPictureBox.Image.Clone();

            // Aplicar el filtro de pixelado
            imagenConFiltro = FilterBitmap(imagenConFiltro, 10); // Puedes ajustar el tamaño del pixelado aquí

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
            return bmp;
        }

        //private void ApplyChanges(object sender, EventArgs e)
        //{
        //    editedImage._EqualizeHist();

        //    // Mostrar la imagen editada en un PictureBox
        //    FotoFiltroPicBox.Image = editedImage.Bitmap;

        //    // Calcular y mostrar el histograma de la imagen editada
        //    CalculateAndDisplayHistogram(editedImage);
        //}

        //private void CalculateAndDisplayHistogram(Image<Bgr, byte> image)
        //{
        //    // Calcular el histograma de la imagen
        //    DenseHistogram histogram = new DenseHistogram(256, new RangeF(0, 256));
        //    histogram.Calculate(new Image<Gray, byte>[] { image[0], image[1], image[2] }, false, null);

        //    // Normalizar el histograma para mostrarlo correctamente en un PictureBox
        //    Mat histMat = new Mat();
        //    histogram.CopyTo(histMat);
        //    CvInvoke.Normalize(histMat, histMat, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);

        //    // Convertir el histograma a una imagen para mostrarlo en un PictureBox
        //    Image<Gray, byte> histImage = histMat.ToImage<Gray, byte>();
        //    histogramBox1.Image = histImage.Bitmap;
        //}


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
    }
}
