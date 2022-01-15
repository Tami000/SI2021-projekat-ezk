using System;

namespace DataLayer.Models
{
    public class Karton
    {
        public int BrojKartona { get; set; }
        public int IdDoktora{ get; set; }
        public string  Recept { get; set; }
        public string  Bolest { get; set; }
        public string  Alergija { get; set; }
        public string  Simptom { get; set; }
        public string  Terapija { get; set; }
        public DateTime DatumPoslednjePosete { get; set; }

        public Karton()
        {

        }

        public Karton(int BrojKartona, int IdDoktora, string Recept, string Bolest, string Alergija, string Simptom, string Terapija, DateTime DatumPoslednjePosete)
        {
            this.BrojKartona = BrojKartona;
            this.IdDoktora = IdDoktora;
            this.Recept = Recept;
            this.Bolest = Bolest;
            this.Alergija = Alergija;
            this.Simptom = Simptom;
            this.Terapija = Terapija;
            this.DatumPoslednjePosete = DatumPoslednjePosete;
        }

        public override string ToString()
        {
            return $"Broj kartona: {BrojKartona}, ID doktora: {IdDoktora}, Recept: {Recept}, Bolest: {Bolest}, Alergija: {Alergija}, Simptom: {Simptom}, Terapija: {Terapija}, Datum poslednje posete: {DatumPoslednjePosete}";
        }
    }
}
