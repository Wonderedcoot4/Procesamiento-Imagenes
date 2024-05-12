using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HistoForm : Form
    {
        private int[] histogramar;
        private int[] histogramag;
        private int[] histogramab;
        private int mayor;
        private int mayor2;
        private int mayor3;
        public HistoForm(int[] HistogramaR, int[] HistogramaB, int[] HistogramaG)
        {
            InitializeComponent();
            histogramar = HistogramaR;
            histogramag = HistogramaG;
            histogramab = HistogramaB;
            int n = 0;

            mayor = 0;
            mayor2 = 0;
            mayor3 = 0;

            for ( n = 0; n < 256; n++)
            {
                if (histogramar[n] > mayor)
                {
                    mayor = histogramar[n];
                }
                

            }
            for (n = 0; n < 256; n++)
            {
                if (histogramag[n] > mayor2)
                {
                    mayor2 = histogramag[n];
                }


            }
            for (n = 0; n < 256; n++)
            {
                if (histogramab[n] > mayor3)
                {
                    mayor3 = histogramab[n];
                }


            }
            for (n = 0; n < 256; n++)
            {
                histogramar[n] = (int)((float)histogramar[n] / (float)mayor * 256.0f);
                histogramag[n] = (int)((float)histogramag[n] / (float)mayor2 * 256.0f);
                histogramab[n] = (int)((float)histogramab[n] / (float)mayor3 * 256.0f);
            }


            this.Invalidate();
        }
        //private void HistoForm_Paint(object sender, PaintEventArgs e)
        //{
        //    int n = 0;
        //    int altura = 0;
        //    Graphics g = e.Graphics;
        //    Pen plumaH = new Pen(Color.Black);
        //    Pen plumaEjes = new Pen(Color.Coral);
        //    g.DrawLine(plumaEjes, 19, 271, 277, 271);
        //    g.DrawLine(plumaEjes, 19, 270, 19, 14);

        //    for ( n = 0; n < 256; n++)
        //    {
        //        g.DrawLine(plumaH, n + 20, 270, n + 20, 270 - histograma[n]);
        //    }
        //}
        //No olvidar poner el enveto de algun form en el diseñador
        private void HistoForm_Paint_1(object sender, PaintEventArgs e)
        {
            int n = 0;
            int altura = 0;
            Graphics g = e.Graphics;
            Pen plumaRojita = new Pen(Color.Red);
            Pen plumaAzul = new Pen(Color.Blue);
            Pen plumaGreen = new Pen(Color.Green);
            Pen PenEjes = new Pen(Color.Coral);
            g.DrawLine(PenEjes, 19, 271, 277, 271);
            g.DrawLine(PenEjes, 19, 270, 19, 14);

            for (n = 0; n < 256; n++)
            {
                g.DrawLine(plumaRojita, n + 20, 270, n + 20, 270 - histogramar[n]);
                g.DrawLine(plumaAzul, n + 20, 270, n + 20, 270 - histogramab[n]);
                g.DrawLine(plumaGreen, n + 20, 270, n + 20, 270 - histogramag[n]);
            }
        }
    }
}
