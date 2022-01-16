using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace HospitalWebApplication
{
    public partial class Kartoni : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getId_ServerClick(object sender, EventArgs e)
        {
            List<Karton> lista = new List<Karton>();
            KartonBusiness kartonBusiness = new KartonBusiness();
            lista = kartonBusiness.GetKarton();
            HtmlGenericControl kartonList = new HtmlGenericControl("P");
            foreach (Karton k in lista)
            {
                HtmlGenericControl karton = new HtmlGenericControl("H5");
                karton.InnerText = k.ToString();
                kartonList.Controls.Add(karton);
            }

            kartoniId.Controls.Add(kartonList);
        }

        protected void insertId_ServerClick(object sender, EventArgs e)
        {
            KartonBusiness kartonBusiness = new KartonBusiness();
            int brojKartona = Convert.ToInt32(BrojKartona.Value);
            int idDoktora = Convert.ToInt32(IdDoktora.Value);
            string recept = Recept.Value;
            string bolest = Bolest.Value;
            string alergija = Alergija.Value;
            string simptom = Simptom.Value;
            string terapija = Terapija.Value;
            DateTime datumPoslednjePosete = Convert.ToDateTime(DatumPoslednjeIzmene.Value);
            Karton k = new Karton(brojKartona, idDoktora, recept, bolest, alergija, simptom, terapija, datumPoslednjePosete);
            kartonBusiness.InsertKarton(k);
        }

        protected void updateId_ServerClick(object sender, EventArgs e)
        {
            KartonBusiness kartonBusiness = new KartonBusiness();
            int brojKartona = Convert.ToInt32(BrojKartona.Value);
            int idDoktora = Convert.ToInt32(IdDoktora.Value);
            string recept = Recept.Value;
            string bolest = Bolest.Value;
            string alergija = Alergija.Value;
            string simptom = Simptom.Value;
            string terapija = Terapija.Value;
            DateTime datumPoslednjePosete = Convert.ToDateTime(DatumPoslednjeIzmene.Value);
            Karton k = new Karton(brojKartona, idDoktora, recept, bolest, alergija, simptom, terapija, datumPoslednjePosete);
            kartonBusiness.UpdateKarton(k);
        }

        protected void deleteId_ServerClick(object sender, EventArgs e)
        {

        }
    }
}