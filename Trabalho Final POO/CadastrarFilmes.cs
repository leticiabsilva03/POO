using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class CadastrarFilmes : Form
    {
        public CadastrarFilmes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & maskedTextBox1.Text != "" & maskedTextBox2.Text != "")
            {
                Filmes m_filmes = new Filmes();

                m_filmes.setNome(textBox1.Text);
                m_filmes.setDiretor(textBox3.Text);
                m_filmes.setGenero(textBox2.Text);
                m_filmes.setAno(int.Parse(maskedTextBox1.Text));
                m_filmes.setDuracao(int.Parse(maskedTextBox2.Text));
                

                BancoDados.insertFilmes(m_filmes);
                LimparCampos();
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Informar nome do Filme!!!");
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Informar Gênero!!!");
                    textBox2.Focus();
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Informar Diretor!!!");
                    textBox2.Focus();
                }
                else if (maskedTextBox1.Text == "")
                {
                    MessageBox.Show("Informar Ano de Lançamento!!!");
                    maskedTextBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Informar Duração!!!");
                    maskedTextBox2.Focus();
                }

            }
        }
    }
}
