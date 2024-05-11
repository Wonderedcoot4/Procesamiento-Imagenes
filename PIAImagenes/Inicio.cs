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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void FotosBttn_Click(object sender, EventArgs e)
        {
            Fotografias FotoForm = new Fotografias();
            FotoForm.ShowDialog();
        }

        private void CamaraBtton_Click(object sender, EventArgs e)
        {
            CamaraForm camForm = new CamaraForm();
            camForm.ShowDialog();
        }

        private void VideosBttn_Click(object sender, EventArgs e)
        {
            Videos videoForm = new Videos();
            videoForm.ShowDialog();
        }
    }
}
