using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner_Nicolas_Bonn
{
    public partial class Form1 : Form
    {
        string sZahl;
        public Form1()
        {
            InitializeComponent();
            sZahl = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            sZahl = "0";
            Ergebnis.Text = sZahl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sZahl = "1";
            Ergebnis.Text = sZahl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sZahl = "2";
            Ergebnis.Text = sZahl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sZahl = "3";
            Ergebnis.Text = sZahl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sZahl = "4";
            Ergebnis.Text = sZahl;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sZahl = "5";
            Ergebnis.Text = sZahl;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sZahl = "6";
            Ergebnis.Text = sZahl;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sZahl = "7";
            Ergebnis.Text = sZahl;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sZahl = "8";
            Ergebnis.Text = sZahl;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sZahl = "9";
            Ergebnis.Text = sZahl;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ergebnis.Text = sZahl;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(sZahl);
            Ergebnis.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(sZahl);
            Ergebnis.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(sZahl);
            Ergebnis.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(sZahl);
            Ergebnis.Clear();
        }
    }
}
