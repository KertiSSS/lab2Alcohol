using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2Alcohol
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> naczynia = new Dictionary<string, double>
        {
            { "Kieliszek 25 ml", 25 },
            { "Kieliszek 50 ml", 50 },
            { "Szklanka 200 ml", 200 },
            { "Szklanka 250 ml", 250 },
            { "Butelka 330 ml", 330 },
            { "Butelka 500 ml", 500 },
            { "Karafka 750 ml", 750 },
            { "Kufel 1 L", 1000 },
        };

        private Dictionary<string, double> napoje = new Dictionary<string, double>
        {
            { "Wino", 12.0 },
            { "Piwo", 5.5 },
            { "Whisky", 40.0 },
            { "Rum", 37.5 },
            { "Tequila", 38.0 },
            { "Likier", 20.0 },
            { "Cydr", 4.5 },
            { "Koniak", 40.0 },
            { "Aperol", 11.0 },
            { "Martini", 15.0 }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Wynik_Click(object sender, EventArgs e)
        {
            double vesselVolume;
            double alcoholPercentage;

            int vesselCount = int.Parse(textBox1.Text);

            double totalVolume = vesselVolume * vesselCount;

            double pureAlcoholVolume = totalVolume * (alcoholPercentage / 100);

            label7.Text = totalVolume.ToString("F2") + " ml";
            label8.Text = pureAlcoholVolume.ToString("F2") + " ml";
        }
    }
}
