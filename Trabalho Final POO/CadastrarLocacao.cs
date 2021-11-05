using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class CadastrarLocacao : Form
    {
        Locacoes m_locacao = new Locacoes();
        usuario m_usuario = new usuario();
        Filmes m_filme = new Filmes();

        public CadastrarLocacao()
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
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_locacao.getUsuario().getCPF() != "" && m_locacao.getFilmes().getID().ToString() != "")
            {
                BancoDados.insertLocacao(m_locacao);
                MessageBox.Show("Locação realizada com sucesso!" +
                    "\nNome do Usuário: " + m_locacao.getUsuario().getNome() +
                    "\nCPF: " + m_locacao.getUsuario().getCPF() +
                    "\nFilme Alugado: " + m_locacao.getFilmes().getNome());
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Inserir dados da locação!");
                comboBox1.Focus();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" & textBox2.Text != "")
            {
                switch (comboBox2.Text)
                {
                    case "Nome do Filme":
                        dataGridView2.DataSource = BancoDados.selectFilmeByNome(textBox2.Text);
                        break;
                    default:                        
                            dataGridView2.DataSource = BancoDados.selectFilmeByGenero(textBox2.Text);                                                
                        break;
                }
            }
            else
            {
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Informar o tipo de busca!");
                    comboBox2.Focus();
                }
                else
                {
                    MessageBox.Show("Informar o item de busca!");
                    textBox2.Focus();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView m_data_grid_view = (DataGridView)sender;

            if (m_data_grid_view.SelectedRows.Count > 0)
            {
                DataTable m_data_table = new DataTable();
                m_data_table = BancoDados.selectUsuario(m_data_grid_view.SelectedRows[0].Cells[0].Value.ToString());

                m_usuario.setNome(m_data_table.Rows[0].Field<string>("nome"));
                m_usuario.setCPF(m_data_table.Rows[0].Field<string>("cpf"));
                m_usuario.setTelefone(m_data_table.Rows[0].Field<string>("telefone"));
                m_usuario.setEmail(m_data_table.Rows[0].Field<string>("email"));              

                m_locacao.setUsuario(m_usuario);

                LimparCampos();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView m_data_grid_view = (DataGridView)sender;

            if (m_data_grid_view.SelectedRows.Count > 0)
            {
                DataTable m_data_table = new DataTable();
                m_data_table = BancoDados.selectFilmes(int.Parse(m_data_grid_view.SelectedRows[0].Cells[0].Value.ToString()));

                m_filme.setNome(m_data_table.Rows[0].Field<string>("nome"));
                m_filme.setDiretor(m_data_table.Rows[0].Field<string>("diretor"));
                m_filme.setGenero(m_data_table.Rows[0].Field<string>("genero"));
                m_filme.setDuracao(int.Parse(m_data_table.Rows[0].Field<Int64>("duracao").ToString()));
                m_filme.setAno(int.Parse(m_data_table.Rows[0].Field<Int64>("ano").ToString()));
                m_filme.setID(Int32.Parse(m_data_table.Rows[0].Field<Int64>("id_filmes").ToString()));
              
                m_locacao.setFilmes(m_filme);

                LimparCampos();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" & textBox1.Text != "")
            {
                switch (comboBox1.Text)
                {
                    case "Nome":
                        dataGridView1.DataSource = BancoDados.selectUsuarioByNome(textBox1.Text);
                        break;
                    default:
                        if (textBox1.Text.Length == 11)
                        {
                            dataGridView1.DataSource = BancoDados.selectUsuarioByCPF(textBox1.Text);
                        }
                        else if (textBox1.Text.Length != 11)
                        {
                            MessageBox.Show("Informe o CPF sem pontos e hífen! \nExemplo: 00000000000");
                        }
                        break;
                }
            }
            else
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Informar o tipo de busca!");
                    comboBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Informar o item de busca!");
                    textBox1.Focus();
                }
            }
        }
    }
}
