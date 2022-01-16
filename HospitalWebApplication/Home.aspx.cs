using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace HospitalWebApplication
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getId_ServerClick(object sender, EventArgs e)
        {
            List<Pacijent> lista = new List<Pacijent>();
            PacijentBusiness pacijentBusiness = new PacijentBusiness();
            lista = pacijentBusiness.GetPacijent();
            HtmlGenericControl pacijentList = new HtmlGenericControl("P");
            foreach (Pacijent p in lista)
            {
                HtmlGenericControl pacijent = new HtmlGenericControl("H5");
                pacijent.InnerText = p.ToString();
                pacijentList.Controls.Add(pacijent);
            }

            pacijentiId.Controls.Add(pacijentList);
        }

        protected void insertId_ServerClick(object sender, EventArgs e)
        {
            PacijentBusiness pacijentBusiness = new PacijentBusiness();
            //int brojKartona = Convert.ToInt32(BrojKartona.Value);
            string ime = Ime.Value;
            string prezime = Prezime.Value;
            string jmbg = JMBG.Value;
            string adresa = Adresa.Value;
            string brojTelefona = BrojTelefona.Value;
            Pacijent p= new Pacijent(1, ime, prezime, jmbg, adresa, brojTelefona);
            pacijentBusiness.InsertPacijent(p);
        }

        protected void updateId_ServerClick(object sender, EventArgs e)
        {
            PacijentBusiness pacijentBusiness = new PacijentBusiness();
            int brojKartona = Convert.ToInt32(BrojKartona.Value);
            string ime = Ime.Value;
            string prezime = Prezime.Value;
            string jmbg = JMBG.Value;
            string adresa = Adresa.Value;
            string brojTelefona = BrojTelefona.Value;
            Pacijent p = new Pacijent(brojKartona, ime, prezime, jmbg, adresa, brojTelefona);
            pacijentBusiness.UpdatePacijent(p);
        }

        protected void deleteId_ServerClick(object sender, EventArgs e)
        {
            PacijentBusiness pacijentBusiness = new PacijentBusiness();
            int brojKartona = Convert.ToInt32(BrojKartona.Value);
            pacijentBusiness.DeletePacijent(brojKartona);
        }

        protected void kartonId_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Kartoni.aspx");
        }
    }
}