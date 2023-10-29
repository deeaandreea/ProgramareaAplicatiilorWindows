using System;

namespace Proiect_Surdu_Bob_Andreea_1091
{
    [Serializable]
    public class Produs : IComparable, ICloneable, IValoare
    {
        private int cod;
        private string denumire;
        private double pret;
        private double stoc;

        public Produs(int cod, string denumire, double pret, double stoc)
        {
            this.Cod = cod;
            this.Denumire = denumire;
            this.Pret = pret;
            this.Stoc = stoc;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public double Pret { get => pret; set => pret = value; }
        public double Stoc { get => stoc; set => stoc = value; }

        public static explicit operator double(Produs p)
        {
            return (p.stoc * p.pret);
        }

        public int CompareTo(object obj)
        {
            Produs p = (Produs)obj;
            if ((double)this < (double)p)
                return -1;
            else
                if ((double)this > (double)p)
                return 1;
            else
                return this.stoc.CompareTo(p.stoc);
        }

        public object Clone()
        {
            Produs clona = (Produs)this.MemberwiseClone();
            return clona;
        }

        public override string ToString()
        {
            return "Produsul " + denumire + " cu codul " + cod +
                " are pretul " + pret +
                " si stocul " + stoc;
        }

        public double calculeazaValoare()
        {
            return (double)this;
        }
    }
}
