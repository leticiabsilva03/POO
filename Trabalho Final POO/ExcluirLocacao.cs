using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class ExcluirLocacao : Form
    {
        
        public ExcluirLocacao()
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
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable m_data_table = new DataTable();
            m_data_table = BancoDados.selectLocacao(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            DataTable usuarios = BancoDados.selectUsuario(m_data_table.Rows[0].Field<string>("cpf_usuario"));
            DataTable filmes = BancoDados.selectFilmes(int.Parse(m_data_table.Rows[0].Field<Int64>("id_filme").ToString()));

            
            textBox1.Text = usuarios.Rows[0].Field<string>("nome");
            textBox3.Text = usuarios.Rows[0].Field<string>("CPF");
            textBox4.Text = filmes.Rows[0].Field<string>("nome");
            textBox2.Text = filmes.Rows[0].Field<Int64>("id_filmes").ToString();
            textBox6.Text = m_data_table.Rows[0].Field<string>("data_emprestimo");
            textBox5.Text = m_data_table.Rows[0].Field<string>("data_devolucao");



            DialogResult res = MessageBox.Show("Realmente deseja excluir?", "Excluir dados?", MessageBoxButtons.YesNo);



            if (res == DialogResult.Yes)
            {
                BancoDados.deleteLocacao(int.Parse(m_data_table.Rows[0].Field<Int64>("id_locacao").ToString()));
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                LimparCampos();
            }
        }

        private void ExcluirLocacao_Load(object sender, EventArgs e)
        {
            // Atualizando o data grid view
            dataGridView1.DataSource = BancoDados.getLocacao();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView m_data_grid_view = (DataGridView)sender;

            if (m_data_grid_view.SelectedRows.Count > 0)
            {
                DataTable m_data_table = new DataTable();
                m_data_table = BancoDados.selectLocacao(m_data_grid_view.SelectedRows[0].Cells[0].Value.ToString());

               

                DataTable usuarios = BancoDados.selectUsuario(m_data_table.Rows[0].Field<string>("cpf_usuario"));
                DataTable filmes = BancoDados.selectFilmes(int.Parse(m_data_table.Rows[0].Field<Int64>("id_filme").ToString()));


                textBox1.Text = usuarios.Rows[0].Field<string>("nome");
                textBox3.Text = usuarios.Rows[0].Field<string>("CPF");
                textBox4.Text = filmes.Rows[0].Field<string>("nome");
                textBox2.Text = filmes.Rows[0].Field<Int64>("id_filmes").ToString();
                textBox6.Text = m_data_table.Rows[0].Field<string>("data_emprestimo");
                textBox5.Text = m_data_table.Rows[0].Field<string>("data_devolucao");

            }
        }
    }
}
