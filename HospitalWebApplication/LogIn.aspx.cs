using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;

namespace HospitalWebApplication
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void login_ServerClick(object sender, EventArgs e)
        {
            string username = usernameId.Value;
            string password = passwordId.Value;
            DoktorBusiness doktorBusiness = new DoktorBusiness();
            List<Doktor> lista = new List<Doktor>();
            lista = doktorBusiness.GetDoktor();
            foreach (Doktor d in lista)
            {
                if (username == d.KorisnickoIme && password == d.Lozinka)
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }
    }
}