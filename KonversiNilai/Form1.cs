using System;
using System.Windows.Forms;

namespace KonversiNilai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int inputNilai))
            {
                string predikat;
                if (inputNilai >= 91 && inputNilai <= 100)
                {
                    predikat = "Amat Baik";
                }
                else if (inputNilai >= 81 && inputNilai <= 90)
                {
                    predikat = "Baik";
                }
                else if (inputNilai >= 71 && inputNilai <= 80)
                {
                    predikat = "Cukup Baik";
                }
                else if (inputNilai >= 61 && inputNilai <= 70)
                {
                    predikat = "Cukup";
                }
                else
                {
                    predikat = "Kurang";
                }
                outputText.Text = predikat;
            }
            else
            {
                MessageBox.Show("Masukkan nilai yang valid.");
            }
        }
    }
}
