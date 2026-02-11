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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            string imePrezime, mjestoRodjenja, vozackaDozvola, mobilni, spol, fakultet;
            DateTime datumRodjenja, danasnjiDatum;
            imePrezime = txtIme.Text;
            mjestoRodjenja = cbMjestoRodjenja.SelectedItem.ToString();
            vozackaDozvola = cbB.Text;
            if (rbMusko.Checked == true)
                spol = "Muško";
            else
                spol = "Žensko";

            fakultet = lbFakultet.SelectedItem.ToString();
            datumRodjenja = dtpDatumRodjenja.Value;
            danasnjiDatum = DateTime.Now;

            MessageBox.Show("Ime i Prezime: " + imePrezime + "\ndatum rođenja:" + datumRodjenja.ToShortDateString() + "\nMjesto rođenja:" + mjestoRodjenja + "\nFakultet:" + fakultet);
        }
    }
}
