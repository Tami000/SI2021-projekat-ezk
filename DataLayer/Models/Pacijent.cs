namespace DataLayer.Models
{
    public class Pacijent
    {
        public int BrojKartona { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }

        public Pacijent()
        {

        }

        public Pacijent(int BrojKartona, string Ime, string Prezime, string JMBG, string Adresa, string BrojTelefona)
        {
            this.BrojKartona = BrojKartona;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.JMBG = JMBG;
            this.Adresa = Adresa;
            this.BrojTelefona = BrojTelefona;
        }

        public override string ToString()
        {
            return $"Broj kartona: {BrojKartona}, Ime: {Ime}, Prezime: {Prezime}, JMBG: {JMBG}, Adresa: {Adresa}, Broj telefona: {BrojTelefona}";
        }
    }
}
