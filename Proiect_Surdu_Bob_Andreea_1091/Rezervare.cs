using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Surdu_Bob_Andreea_1091
{
    public class Rezervare : IValoare
    {
        private string codRezervare;
        private DateTime dataRezervare;
        private string nume;
        private string codMasa;
        private string codOspatar;
        private Dictionary<Produs, int> produseComanda;

        public static int idRezervareMax = 0;

        public Rezervare(string codRezervare, DateTime dataRezervare, string nume, 
            string codMasa, string codOspatar, Dictionary<Produs, int> produseComanda)
        {
            this.CodRezervare = codRezervare;
            this.DataRezervare = dataRezervare;
            this.Nume = nume;
            this.CodMasa = codMasa;
            this.CodOspatar = codOspatar;
            this.ProduseComanda = produseComanda;
        }

        public string CodRezervare { get => codRezervare; set => codRezervare = value; }
        public DateTime DataRezervare { get => dataRezervare; set => dataRezervare = value; }
        public string Nume { get => nume; set => nume = value; }
        public string CodMasa { get => codMasa; set => codMasa = value; }
        public string CodOspatar { get => codOspatar; set => codOspatar = value; }
        public Dictionary<Produs, int> ProduseComanda { get => produseComanda; set => produseComanda = value; }

        public double calculeazaValoare()
        {
            double valoare = 0.0;
            foreach (KeyValuePair<Produs, int> item in produseComanda)
            {
                Produs produs = item.Key;
                int nr = item.Value;
                valoare += produs.Pret * nr;
            }
            return valoare;
        }

        public override string ToString()
        {
            return "Rezervare " + codRezervare + " pe numele " + nume + " din data " + dataRezervare.Date + " pentru masa " + codMasa;
        }
    }
}
