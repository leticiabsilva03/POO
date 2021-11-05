using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class PesquisarUsuario : Form
    {
        public PesquisarUsuario()
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
                    dataGridView1.DataSource = BancoDados.getUsuario();
                    DefinirTamanho();
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        switch (comboBox1.Text)
                        {
                            case "Nome":
                                dataGridView1.DataSource = BancoDados.selectUsuarioByNome(textBox1.Text);
                                DefinirTamanho();
                                break;
                            
                            default:
                                if (textBox1.Text.Length == 11)
                                {
                                    dataGridView1.DataSource = BancoDados.selectUsuarioByCPF(textBox1.Text);
                                    DefinirTamanho();
                                }
                                else if (textBox1.Text.Length == 11)
                                {
                                    MessageBox.Show("Informe o CPF sem pontos e hífen! \nExemplo: 00000000000");
                                }
                                
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

        private void DefinirTamanho()
        {
            dataGridView1.Columns[0].Width = 165;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 165;
        }
    }
}
