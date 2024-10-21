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
        private Dictionary<string, double> pojemniki = new Dictionary<string, double>
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

        private void Całkowitaobjętośćnapoju_Click(object sender, EventArgs e)
        {

        }

        private void Objętośćczystegoalkoholu_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
