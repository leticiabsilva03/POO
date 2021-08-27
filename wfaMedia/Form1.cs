using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

            textBox1.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Número 1 não informado!");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Número 2 não informado!");
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Número 3 não informado!");
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Número 4 não informado!");
                textBox4.Focus();
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Número 5 não informado!");
                textBox5.Focus();
            }
            else;


                double media, mediana, maximo, minimo, nro1, nro2, nro3, nro4, nro5;


            nro1 = Convert.ToDouble(textBox1.Text);
            nro2 = Convert.ToDouble(textBox2.Text);
            nro3 = Convert.ToDouble(textBox3.Text);
            nro4 = Convert.ToDouble(textBox4.Text);
            nro5 = Convert.ToDouble(textBox5.Text);

            List<double> lista = new List<double>();
            lista.Add(nro1);
            lista.Add(nro2);
            lista.Add(nro3);
            lista.Add(nro4);
            lista.Add(nro5);

            lista.Sort();

            media = lista.Average();
            mediana = lista.ElementAt(2);
            maximo = lista.Max();
            minimo = lista.Min();

            textBox6.Text = Convert.ToString(media);
            textBox7.Text = Convert.ToString(mediana);
            textBox8.Text = Convert.ToString(maximo);
            textBox9.Text = Convert.ToString(minimo);

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
