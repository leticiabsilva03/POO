using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class ExcluirFilmes : Form
    {
        public ExcluirFilmes()
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
            DataTable m_data_table = new DataTable();
            m_data_table = BancoDados.selectFilmes(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));

            textBox1.Text = m_data_table.Rows[0].Field<string>("nome");
            maskedTextBox1.Text = m_data_table.Rows[0].Field<Int64>("ano").ToString();
            maskedTextBox2.Text = m_data_table.Rows[0].Field<Int64>("duracao").ToString();
            textBox3.Text = m_data_table.Rows[0].Field<string>("diretor");
            textBox2.Text = m_data_table.Rows[0].Field<string>("genero");

            DialogResult res = MessageBox.Show("Realmente deseja excluir?", "Excluir dados?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                BancoDados.deleteFilmes(int.Parse(m_data_table.Rows[0].Field<Int64>("id_filmes").ToString()));

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                LimparCampos();

            }
        }

        private void ExcluirFilmes_Load(object sender, EventArgs e)
        {
            // Atualizando o data grid view
            dataGridView1.DataSource = BancoDados.getFilmes();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView m_data_grid_view = (DataGridView)sender;

            if (m_data_grid_view.SelectedRows.Count > 0)
            {
                DataTable m_data_table = new DataTable();
                m_data_table = BancoDados.selectFilmes(int.Parse(m_data_grid_view.SelectedRows[0].Cells[0].Value.ToString()));

                textBox1.Text = m_data_table.Rows[0].Field<string>("nome");
                maskedTextBox1.Text = m_data_table.Rows[0].Field<Int64>("ano").ToString();
                maskedTextBox2.Text = m_data_table.Rows[0].Field<Int64>("duracao").ToString();
                textBox3.Text = m_data_table.Rows[0].Field<string>("diretor");
                textBox2.Text = m_data_table.Rows[0].Field<string>("genero");
            }
        }
    }
}
