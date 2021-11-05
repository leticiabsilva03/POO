using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class PesquisarFilmes : Form
    {
        public PesquisarFilmes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0)
            {
                if (comboBox1.Text == "Todos")
                {
                    textBox1.Clear();
                    dataGridView1.DataSource = BancoDados.getFilmes();
                    
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        switch (comboBox1.Text)
                        {
                            case "Nome":
                                dataGridView1.DataSource = BancoDados.selectFilmeByNome(textBox1.Text);
                                break;

                            case "Diretor":
                                dataGridView1.DataSource = BancoDados.selectFilmeByDiretor(textBox1.Text);
                                break;

                            case "Gênero":
                                dataGridView1.DataSource = BancoDados.selectFilmeByGenero(textBox1.Text);
                                break;

                            default:                                
                                 dataGridView1.DataSource = BancoDados.selectFilmeByAno(int.Parse(textBox1.Text));
                                 break;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Informar o item de busca!");
                        textBox1.Focus();

                    }
                }
            }
            else
            {
                MessageBox.Show("Informar o tipo de busca!");
                comboBox1.Focus();
            }
        }
    }
}
