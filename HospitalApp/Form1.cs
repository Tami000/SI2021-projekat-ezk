using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Doktor> lista = new List<Doktor>();
            DoktorBusiness doktorBusiness = new DoktorBusiness();
            lista = doktorBusiness.GetDoktor();
            foreach (Doktor d in lista)
            {
                if (textBox1.Text == d.KorisnickoIme && textBox2.Text == d.Lozinka)
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
            }
        }
    }
}
