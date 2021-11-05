using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class PesquisarLocacao : Form
    {
        public PesquisarLocacao()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (comboBox1.Text == "Todos")
                {
                    textBox1.Clear();
                    dataGridView1.DataSource = BancoDados.getLocacao();
                    LimparCampos();
                    comboBox1.Focus();
                }
                else
                {
                    if (textBox1.Text != "")
                    {
                        switch (comboBox1.Text)
                        {                            
                            case "CPF": // CPF
                                dataGridView1.DataSource = BancoDados.selectLocacaoByCPFLeitor(textBox1.Text);
                                LimparCampos();
                                comboBox1.Focus();
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
