using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class AtualizarUsuario : Form
    {
        public AtualizarUsuario()
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

            int m_row = dataGridView1.SelectedRows[0].Index; // linha selecionada


            usuario m_usuario = new usuario(); // instanciando leitor

            // definindo os dados do leitor selecionado
            m_usuario.setNome(textBox1.Text);
            m_usuario.setCPF(maskedTextBox1.Text);
            m_usuario.setTelefone(maskedTextBox2.Text);
            m_usuario.setEmail(textBox2.Text);

            if (textBox1.Text != "" & textBox2.Text != "" & maskedTextBox1.Text != "" & maskedTextBox2.Text != "")
            {
                DataTable m_data_table = new DataTable();
                m_data_table = BancoDados.selectUsuario(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                BancoDados.updateUsuario(m_usuario);
                dataGridView1.DataSource = BancoDados.getUsuario();
                dataGridView1.CurrentCell = dataGridView1[0, m_row];
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
                else if (textBox2.Text == "")
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

        private void AtualizarUsuario_Load(object sender, EventArgs e)
        {
            // Atualizando o data grid view
            dataGridView1.DataSource = BancoDados.getUsuario();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView m_data_grid_view = (DataGridView)sender;

            if (m_data_grid_view.SelectedRows.Count > 0)
            {
                DataTable m_data_table = new DataTable();
                m_data_table = BancoDados.selectUsuario(m_data_grid_view.SelectedRows[0].Cells[0].Value.ToString());

                textBox1.Text = m_data_table.Rows[0].Field<string>("nome");
                maskedTextBox1.Text = m_data_table.Rows[0].Field<string>("cpf");
                maskedTextBox2.Text = m_data_table.Rows[0].Field<string>("telefone");
                textBox2.Text = m_data_table.Rows[0].Field<string>("email");
            }
        }
    }
}
