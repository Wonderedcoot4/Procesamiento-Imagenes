using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WindowsFormsApp1
{

   
    public partial class CamaraForm : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoDevice;
        Bitmap Blanco;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(@"C:\Users\isaac\Desktop\Programacion\PROCImagenes\Procesamiento-Imagenes\PIAImagenes\haarcascade_frontalface_alt_tree.xml");


        public CamaraForm()
        {
            InitializeComponent();
        }

       

        private void startScreenButton_Click(object sender, EventArgs e)
        {
            if (videoDevice.IsRunning)
            {
                videoDevice.Stop();
                camaraBox.Image = Blanco;
            }
            this.Close();
        }

        private void CamaraForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInfoCollection)
            {
                cbCamera.Items.Add(filterInfo.Name);
                cbCamera.SelectedIndex = 0;
                videoDevice = new VideoCaptureDevice();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
            videoDevice.NewFrame += VideoDevice_NewFrame;
            videoDevice.Start();
        }

        private void VideoDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
            // Asignar colores a cada cara detectada
            Dictionary<Rectangle, Color> colorsMap = AssignColorsToRectangles(rectangles);

            // Dibujar los resultados en el Bitmap original
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {

                foreach (var kvp in colorsMap)
                {
                    Rectangle rectangle = kvp.Key;
                    Color color = kvp.Value;

                    using (Pen pen = new Pen(color, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }

            camaraBox.Image = bitmap;
        }

        private void CamaraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoDevice.IsRunning)
            {
                videoDevice.Stop();
                camaraBox.Image = Blanco;
            }
        }

        private void CloseCameraBttn_Click(object sender, EventArgs e)
        {
            if (videoDevice != null && videoDevice.IsRunning)
            {
                videoDevice.Stop();
                camaraBox.Image = Blanco;
            }
        }

        private Dictionary<Rectangle, Color> AssignColorsToRectangles(Rectangle[] rectangles)
        {
            Dictionary<Rectangle, Color> colorsMap = new Dictionary<Rectangle, Color>();
            Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Purple };

            for (int i = 0; i < rectangles.Length; i++)
            {
                if (i < colors.Length)
                {
                    colorsMap.Add(rectangles[i], colors[i]);
                }
                else
                {
                    colorsMap.Add(rectangles[i], Color.Gray); // Usar un color predeterminado para caras adicionales
                }
            }

            return colorsMap;
        }
    }

}
