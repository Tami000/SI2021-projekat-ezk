namespace DataLayer.Models
{
    public class Doktor
    {
        public int IdDoktora { get; set; }
        public string Ime { get; set; }
        public string  Prezime { get; set; }
        public string  JMBG { get; set; }
        public string  Specijalnost { get; set; }
        public string  BrojTelefona { get; set; }
        public string  KorisnickoIme { get; set; }
        public string  Lozinka { get; set; }

        public Doktor()
        {
                
        }

        public Doktor(int IdDoktora, string Ime, string Prezime, string JMBG, string Specijalnost, string BrojTelefona, string KorisnickoIme, string Lozinka)
        {
            this.IdDoktora = IdDoktora;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.JMBG = JMBG;
            this.Specijalnost = Specijalnost;
            this.BrojTelefona = BrojTelefona;
            this.KorisnickoIme = KorisnickoIme;
            this.Lozinka = Lozinka;
        }

        public override string ToString()
        {
            return $"Id doktora: {IdDoktora}, Ime: {Ime}, Prezime: {Prezime}, JMBG: {JMBG}, Specijalnost: {Specijalnost}, Broj telefona: {BrojTelefona}";
        }
    }
}
