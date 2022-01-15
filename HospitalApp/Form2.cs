using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Pacijent> list = new List<Pacijent>();
            PacijentBusiness pacijentBusiness = new PacijentBusiness();
            list = pacijentBusiness.GetPacijent();
            listBox1.Items.Add("Informacije o pacijentima:\n");
            foreach (Pacijent p in list)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Pacijent> list = new List<Pacijent>();
            PacijentBusiness pacijentBusiness = new PacijentBusiness();
            list = pacijentBusiness.GetPacijent().Where(x => x.BrojKartona == Convert.ToInt32(textBoxBrojKartona.Text)).ToList();
            listBox1.Items.Add("Informacije o pacijentu sa zadatim brojem kartona:\n");
            foreach (Pacijent p in list)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pacijent p = new Pacijent(1, textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, textBoxAdresa.Text, textBoxBrojTelefona.Text);
            PacijentBusiness pacijentBusiness = new PacijentBusiness();
            if (pacijentBusiness.InsertPacijent(p) == true)
                MessageBox.Show("Uspešno ste dodali pacijenta!");
            else
                MessageBox.Show("Niste uspeli da dodate pacijenta. Pokušajte ponovo!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PacijentBusiness pacijentBusiness = new PacijentBusiness();
            Pacijent p = new Pacijent(Convert.ToInt32(textBoxBrojKartona.Text), textBoxIme.Text, textBoxPrezime.Text, textBoxJMBG.Text, textBoxAdresa.Text, textBoxBrojTelefona.Text);
            if (pacijentBusiness.UpdatePacijent(p) == true)
            {
                pacijentBusiness.UpdatePacijent(p);
                MessageBox.Show("Uspešno ste promenili informacije o pacijentu");
            }

            else
                MessageBox.Show("Niste uspeli da promenite informacije o pacijentu");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pacijent p = new Pacijent();
            PacijentBusiness pacijentBusiness = new PacijentBusiness();
            int pid = Convert.ToInt32(textBoxBrojKartona.Text);
            if (pacijentBusiness.DeletePacijent(pid) == true)
                MessageBox.Show("Uspešno ste izbrisali informacicje o pacijentu");
            else
                MessageBox.Show("Pacijent nije izbrisan!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Karton> list = new List<Karton>();
            KartonBusiness kartonBusiness = new KartonBusiness();
            list = kartonBusiness.GetKarton().Where(x => x.BrojKartona == Convert.ToInt32(textBoxBrojKartona.Text)).ToList();
            listBox1.Items.Add("Informacije o kartonu pacijenta:\n");
            foreach (Karton k in list)
            {
                listBox1.Items.Add(k.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }
    }
}
