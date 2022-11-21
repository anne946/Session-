using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session
{
    internal class SPT
    {

        int noApp;
        double frais;
        string vehicule;
        double pourcentageSPT;

        public int NoApp { get => noApp; set => noApp = value; }
        public double Frais { get => frais; set => frais = value; }
        public string Vehicule { get => vehicule; set => vehicule = value; }
        public double PourcentageSPT { get => pourcentageSPT; set => pourcentageSPT = value; }

        public override string ToString()
        {
            return noApp + " " + frais + " " + vehicule + " " + pourcentageSPT;
        }
    }
}
