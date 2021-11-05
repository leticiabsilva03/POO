using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class AtualizarFilmes : Form
    {
        int id = 0;

        public AtualizarFilmes()
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
            int m_row = dataGridView1.SelectedRows[0].Index; // linha selecionada


            Filmes m_filmes = new Filmes(); // instanciando leitor

            // definindo os dados do leitor selecionado
            m_filmes.setNome(textBox1.Text);
            m_filmes.setGenero(textBox2.Text);
            m_filmes.setDiretor(textBox3.Text);
            m_filmes.setAno(int.Parse(maskedTextBox1.Text));
            m_filmes.setDuracao(int.Parse(maskedTextBox2.Text));
            m_filmes.setID(id);
           

            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & maskedTextBox1.Text != "" & maskedTextBox2.Text != "")
            {
                DataTable m_data_table = new DataTable();
                m_data_table = BancoDados.selectFilmes(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                BancoDados.updateFilmes(m_filmes);
                dataGridView1.DataSource = BancoDados.getFilmes();
                dataGridView1.CurrentCell = dataGridView1[0, m_row];
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView m_data_grid_view = (DataGridView)sender;

            if (m_data_grid_view.SelectedRows.Count > 0)
            {
                DataTable m_data_table = new DataTable();
                m_data_table = BancoDados.selectFilmes(int.Parse(m_data_grid_view.SelectedRows[0].Cells[0].Value.ToString()));

                id = int.Parse(m_data_grid_view.SelectedRows[0].Cells[0].Value.ToString());

                textBox1.Text = m_data_table.Rows[0].Field<string>("nome");
                maskedTextBox1.Text = m_data_table.Rows[0].Field<Int64>("ano").ToString();
                maskedTextBox2.Text = m_data_table.Rows[0].Field<Int64>("duracao").ToString();
                textBox3.Text = m_data_table.Rows[0].Field<string>("diretor");
                textBox2.Text = m_data_table.Rows[0].Field<string>("genero");
            }
        }

        private void AtualizarFilmes_Load(object sender, EventArgs e)
        {
            // Atualizando o data grid view
            dataGridView1.DataSource = BancoDados.getFilmes();
        }
    }
}
