using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Doktor> list = new List<Doktor>();
            DoktorBusiness doktorBusiness = new DoktorBusiness();
            list = doktorBusiness.GetDoktor();
            listBox1.Items.Add("Informacije o doktorima:\n");
            foreach (Doktor d in list)
            {
                listBox1.Items.Add(d.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Doktor> list = new List<Doktor>();
            DoktorBusiness doktorBusiness = new DoktorBusiness();
            list = doktorBusiness.GetDoktor().Where(x => x.IdDoktora == Convert.ToInt32(textBoxIdDoktora.Text)).ToList();
            listBox1.Items.Add("Informacije o doktoru:\n");
            foreach (Doktor d in list)
            {
                listBox1.Items.Add(d.ToString());
            }
        }

        private void textBoxIdDoktora_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorBusiness doktorBusiness = new DoktorBusiness();
            Doktor d = new Doktor(Convert.ToInt32(textBoxIdDoktora.Text), textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, textBoxSpecijalnost.Text, textBoxBrojTelefona.Text, textBoxKorisnickoIme.Text, textBoxLozinka.Text);
            if (doktorBusiness.UpdateDoktor(d) == true)
            {
                doktorBusiness.UpdateDoktor(d);
                MessageBox.Show("Uspešno ste promenili informacije o doktoru");
            }

            else
                MessageBox.Show("Niste uspeli da promenite informacije o doktoru");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Doktor d = new Doktor(Convert.ToInt32(textBoxIdDoktora.Text), textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, textBoxSpecijalnost.Text, textBoxBrojTelefona.Text, textBoxKorisnickoIme.Text, textBoxLozinka.Text);
            DoktorBusiness pacijentBusiness = new DoktorBusiness();
            if (pacijentBusiness.InsertDoktor(d) == true)
                MessageBox.Show("Uspešno ste dodali novog doktora!");
            else
                MessageBox.Show("Niste uspeli da dodate doktora. Pokušajte ponovo!");
        }
    }
}
