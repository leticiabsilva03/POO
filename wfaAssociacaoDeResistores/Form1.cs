using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaAssociacaoDeResistores
{
    public partial class Form1 : Form
    {
        // membros da classe
        Resistor resistor1;
        Resistor resistor2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resistor1 = new Resistor();
            resistor2 = new Resistor();

            resistor1.setResistencia(double.Parse(tbResistor1.Text));
            resistor2.setResistencia(double.Parse(tbResistor2.Text));

            textBox3.Text = resistor1.associacaoSerie(resistor2).ToString();
            textBox4.Text = resistor1.associacaoParalelo(resistor2).ToString();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbResistor1.Clear();
            tbResistor2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            tbResistor1.Focus();
        }
    }

}
