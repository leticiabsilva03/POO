using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class AtualizarLocacao : Form  
    {
        int id_locacao = -1;
        public AtualizarLocacao()
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
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m_row = dataGridView1.SelectedRows[0].Index; // linha selecionada

            usuario m_usuario = new usuario(); // instanciando usuário

            DataTable usuarios = BancoDados.selectUsuario(textBox3.Text);

            // definindo os dados do usuário selecionado
            m_usuario.setNome(usuarios.Rows[0].Field<string>("nome"));
            m_usuario.setCPF(usuarios.Rows[0].Field<string>("cpf"));            
            m_usuario.setTelefone(usuarios.Rows[0].Field<string>("telefone"));
            m_usuario.setEmail(usuarios.Rows[0].Field<string>("email"));

            Filmes m_filme = new Filmes(); // instanciando filme

            DataTable filme = BancoDados.selectFilmes(int.Parse(textBox2.Text));

            // definindo os dados do filme selecionado
            
            m_filme.setNome(filme.Rows[0].Field<string>("nome"));
            m_filme.setDiretor(filme.Rows[0].Field<string>("diretor"));
            m_filme.setGenero(filme.Rows[0].Field<string>("genero"));
            m_filme.setDuracao(int.Parse(filme.Rows[0].Field<Int64>("duracao").ToString()));
            m_filme.setAno(int.Parse(filme.Rows[0].Field<Int64>("ano").ToString()));
            m_filme.setID(int.Parse(filme.Rows[0].Field<Int64>("id_filmes").ToString()));

            // definindo os dados do livro selecionado
            m_filme.setNome(textBox4.Text);
            

            Locacoes m_locacao = new Locacoes();

            m_locacao.setUsuario(m_usuario);
            m_locacao.setFilmes(m_filme);
            m_locacao.setIdLocacao(id_locacao);

            // validando a data de devolução

            if (textBox5.Text != "")
            {
                if ((DateTime.Parse(textBox5.Text) < DateTime.Parse(m_locacao.setToday())) | (DateTime.Parse(textBox5.Text) < DateTime.Parse(m_locacao.set3dias())))
                {
                    if (DateTime.Parse(textBox5.Text) < DateTime.Parse(m_locacao.setToday()))
                    {
                        MessageBox.Show("Data inválida!");
                    }
                    else
                    {
                        MessageBox.Show("Devolução prevista para menos de 3 dias úteis!");
                    }



                    textBox5.Text = m_locacao.set3dias();
                    textBox5.Focus();
                    return;
                }
                else
                {
                    m_locacao.setDataDevolucao(textBox5.Text);
                }
            }

            // validando a data de empréstimo

            if (textBox6.Text != "")
            {
                if (DateTime.Parse(textBox6.Text) != DateTime.Parse(m_locacao.setToday()))
                {
                    MessageBox.Show("Data inválida!");



                    textBox6.Text = m_locacao.setToday();
                    textBox6.Focus();
                    return;
                }
                else
                {
                    m_locacao.setDataLocacao(textBox6.Text);
                }

            }


            if (textBox1.Text != "" & textBox3.Text != "" &
            textBox4.Text != "" & textBox2.Text != "" &
            textBox5.Text != "" & textBox6.Text != "")
            {
                if (id_locacao != -1)
                {
                    DataTable m_data_table = new DataTable();
                    m_data_table = BancoDados.selectLocacao(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    BancoDados.updateLocacao(m_locacao);
                    dataGridView1.DataSource = BancoDados.getLocacao();
                    dataGridView1.CurrentCell = dataGridView1[0, m_row];

                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Dados da locação não informados!");
                }
            }
            else
            {
                MessageBox.Show("Dados da locação não informados!");

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Informar usuário!");
                    textBox1.Focus();
                }
                else if (textBox6.Text == "")
                {
                    MessageBox.Show("Informar a data de empréstimo!");
                    textBox6.Focus();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Informar id do Filme!");
                    textBox2.Focus();
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("Informar a data de devolução!");
                    textBox5.Focus();
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Informar CPF do usuário!");
                    textBox3.Focus();
                }
                else
                {
                    MessageBox.Show("Informar nome do Filme!");
                    textBox4.Focus();
                }
                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView m_data_grid_view = (DataGridView)sender;

            if (m_data_grid_view.SelectedRows.Count > 0)
            {
                DataTable m_data_table = new DataTable();
                m_data_table = BancoDados.selectLocacao(m_data_grid_view.SelectedRows[0].Cells[0].Value.ToString());

                id_locacao = int.Parse(m_data_grid_view.SelectedRows[0].Cells[0].Value.ToString());

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

        private void AtualizarLocacao_Load(object sender, EventArgs e)
        {
            // Atualizando o data grid view
            dataGridView1.DataSource = BancoDados.getLocacao();
        }
    }
}
