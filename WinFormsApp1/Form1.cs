using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1 
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int no, faktorial;

            no = Convert.ToInt32(txtFaktorial.Text);
            int hasil = no;

            for (int i = no-1; i > 0; i--)
            {
                faktorial = hasil;
                hasil *= i;
                
                txtHasil.Text += Convert.ToString(faktorial + " * " + i + " = " + hasil) + "\r\n";
            }
            txtHasil.Text += Convert.ToString("Hasil Faktorial Dari " + no + " Adalah " + hasil);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHasil.Clear();
        }
    }
}
