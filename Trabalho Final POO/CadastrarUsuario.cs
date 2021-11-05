using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
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
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" & textBox2.Text != "" & maskedTextBox1.Text != "" & maskedTextBox2.Text != "")
            {
                usuario m_usuario = new usuario();

                m_usuario.setNome(textBox1.Text);
                m_usuario.setCPF(maskedTextBox1.Text);
                m_usuario.setTelefone(maskedTextBox2.Text);
                m_usuario.setEmail(textBox2.Text);

                BancoDados.insertUsuario(m_usuario);
                LimparCampos();
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Informar nome de Usuário!!!");
                    textBox1.Focus();
                }
                else if (maskedTextBox1.Text == "")
                {
                    MessageBox.Show("Informar CPF de Usuário!!!");
                    maskedTextBox1.Focus();
                }
                else if(textBox2.Text == "")
                {
                    MessageBox.Show("Informar email do Usuário!!!");
                    textBox2.Focus();
                }
                else
                {
                    MessageBox.Show("Informar telefone de Usuário!!!");
                    maskedTextBox2.Focus();
                }

            }
        }
    }
}
