using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class OknoKalkulacka : Form
    {
        Kalkulacka kalkulacka; 
        string operText = "";
        double druheCislo = 0;
        public OknoKalkulacka()
        {
            InitializeComponent();
            kalkulacka = new Kalkulacka();
        }

        private void Kalkulačka_Load(object sender, EventArgs e)
        {
            labelZobrazPocitani.Text = "0";
        }

        private void buttonSmazJedno_Click(object sender, EventArgs e)
        {
            if(textBoxVysledek.Text.Length > 0)
            {
                textBoxVysledek.Text = textBoxVysledek.Text.Remove(textBoxVysledek.Text.Length - 1);
            }

            labelZobrazPocitani.Text = "0";
        }

        private void buttonSmazVse_Click(object sender, EventArgs e)
        {
            textBoxVysledek.Clear();
            textBoxVysledek.Text = "0";
            labelZobrazPocitani.Text = "0";
        }

        private void buttonDesetinnaCarka_Click(object sender, EventArgs e)
        {           
            if(!(textBoxVysledek.Text.Contains(",")))
            {
                textBoxVysledek.Text = textBoxVysledek.Text + ",";
            }
        }

        private void buttonCislo_Click(object sender, EventArgs e)
        {
            if(textBoxVysledek.Text == "0")
            {
                textBoxVysledek.Clear();
            }
            Button buttonCislo = (Button)sender;
            textBoxVysledek.Text = textBoxVysledek.Text + buttonCislo.Text;
        }

        private void buttonOper_Click(object sender, EventArgs e)
        {          
            Button buttonOper = (Button)sender;

            kalkulacka.Vysledek = double.Parse(textBoxVysledek.Text);

            operText = buttonOper.Text;

            kalkulacka.OverOperatora(operText);
            if(kalkulacka.OverOperatora(operText) == true)
            {
                textBoxVysledek.Text = textBoxVysledek.Text + buttonOper.Text;
                labelZobrazPocitani.Text = (kalkulacka.Vysledek + " " + operText);
            }

            textBoxVysledek.Clear();
        }

        private void buttonRovnaSe_Click(object sender, EventArgs e)
        {
            druheCislo = double.Parse(textBoxVysledek.Text);
            labelZobrazPocitani.Text = (kalkulacka.Vysledek + " " + operText + " " + druheCislo + " =");

            if (operText == "+")
            {
                kalkulacka.Pricti(druheCislo);
                textBoxVysledek.Text = kalkulacka.Vysledek.ToString();
            }

            else if (operText == "-")
            {
                kalkulacka.Odecti(druheCislo);
                textBoxVysledek.Text = kalkulacka.Vysledek.ToString();
            }

            else if (operText == "*")
            {
                kalkulacka.Vynasob(druheCislo);
                textBoxVysledek.Text = kalkulacka.Vysledek.ToString();
            }

            else if (operText == "/")
            {
                kalkulacka.Vydel(druheCislo);
                textBoxVysledek.Text = kalkulacka.Vysledek.ToString();
            }

            else if (operText == "^")
            {
                kalkulacka.Umocni(druheCislo);
                textBoxVysledek.Text = kalkulacka.Vysledek.ToString();
            }
        }
    }
}
