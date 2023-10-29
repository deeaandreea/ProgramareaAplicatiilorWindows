using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Surdu_Bob_Andreea_1091
{
    [Serializable]
    public class Masa
    {
        private string cod;
        private string descriere;
        private int nrLocuri;

        public Masa(string cod, string descriere, int nrLocuri)
        {
            this.Cod = cod;
            this.Descriere = descriere;
            this.NrLocuri = nrLocuri;
        }

        public string Cod { get => cod; set => cod = value; }
        public string Descriere { get => descriere; set => descriere = value; }
        public int NrLocuri { get => nrLocuri; set => nrLocuri = value; }

        public override string ToString()
        {
            return descriere + " cu " + nrLocuri + " locuri";
        }
    }
}
