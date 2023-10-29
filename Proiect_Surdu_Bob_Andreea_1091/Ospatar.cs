using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Surdu_Bob_Andreea_1091
{
    [Serializable]
    public class Ospatar
    {
        private string cod;
        private string cnp;
        private string nume;
        private string prenume;
        private DateTime dataAngajare;

        public Ospatar(string cod, string cnp, string nume, string prenume, DateTime dataAngajare)
        {
            this.Cod = cod;
            this.Cnp = cnp;
            this.Nume = nume;
            this.Prenume = prenume;
            this.DataAngajare = dataAngajare;
        }

        public string Cod { get => cod; set => cod = value; }
        public string Cnp { get => cnp; set => cnp = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public DateTime DataAngajare { get => dataAngajare; set => dataAngajare = value; }

        public override string ToString()
        {
            return prenume + " " + nume;
        }
    }
}
