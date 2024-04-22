using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkleForm_Click(object sender, EventArgs e)
        {
            FormSarkiEkle formSarkiEkle = new FormSarkiEkle();
            formSarkiEkle.ShowDialog();

        }

        private void btnListeForm_Click(object sender, EventArgs e)
        {
            FormTumSarkilar formTumSarkilar = new FormTumSarkilar();
            formTumSarkilar.ShowDialog();
        }
    }
}
