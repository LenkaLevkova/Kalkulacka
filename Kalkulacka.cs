using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    class Kalkulacka
    {

        public double Vysledek;

        public void Pricti(double druheCislo)
        {
            Vysledek = Vysledek + druheCislo;
        }
        public void Odecti(double druheCislo)
        {
            Vysledek = Vysledek - druheCislo;
        }
        public void Vynasob(double druheCislo)
        {
            Vysledek = Vysledek * druheCislo;
        }
        public void Vydel(double druheCislo)
        {
            Vysledek = Vysledek / druheCislo;
        }
        public void Umocni(double druheCislo)
        {
            double vysledek;
            vysledek = Vysledek;
            for (int i = 1; i <= (druheCislo - 1); i++)
            {
                Vysledek = Vysledek * vysledek;
            }
        }
        public bool OverOperatora(string operText)
        {
            if (operText == "+" || operText == "-" || operText == "*" || operText == "/" || operText == "^")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
