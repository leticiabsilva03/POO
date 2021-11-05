using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    class BancoDados
    {
        // CONEXÃO COM O BANCO DE DADOS
        private static SQLiteConnection conexao;

        private static SQLiteConnection conexaoBancoDados()
        {
            conexao = new SQLiteConnection("Data Source = D:\\UFU\\20212\\Programação Orientada a Objetos\\Trabalho Final\\TrabalhoFinal\\Filmes.db"); // declarando e instanciando a conexão com o banco de dados
            conexao.Open(); // fazendo a conexão com o banco de dados
            return (conexao);
        }
        // método INSERT Usuários
        public static void insertUsuario(usuario Usuario)
        {
            if (existeCPF(Usuario))
            {
                MessageBox.Show("Usuário já cadastrado!");
                return;
            }
            try
            {
                var cmd = conexaoBancoDados().CreateCommand();
                cmd.CommandText = "INSERT INTO usuarios (CPF, nome, email, telefone) VALUES (@cpf, @nome, @email, @telefone)";


                cmd.Parameters.AddWithValue("@cpf", Usuario.getCPF());
                cmd.Parameters.AddWithValue("@nome", Usuario.getNome());
                cmd.Parameters.AddWithValue("@telefone", Usuario.getTelefone());
                cmd.Parameters.AddWithValue("@email", Usuario.getEmail());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo usuário cadastrado!");

                conexaoBancoDados().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo usuário!");
                throw ex;
            }
        }

        // método INSERT Filmes
        public static void insertFilmes(Filmes filmes)
        {
            if (existeFilme(filmes))
            {
                MessageBox.Show("Filme já cadastrado!");
                return;
            }
            try
            {
                var cmd = conexaoBancoDados().CreateCommand();
                cmd.CommandText = "INSERT INTO filmes (nome, diretor, genero, ano, duracao) VALUES (@nome, @diretor, @genero, @ano, @duracao)";


                cmd.Parameters.AddWithValue("@nome", filmes.getNome());
                cmd.Parameters.AddWithValue("@diretor", filmes.getDiretor());
                cmd.Parameters.AddWithValue("@genero", filmes.getGenero());
                cmd.Parameters.AddWithValue("@ano", filmes.getAno());
                cmd.Parameters.AddWithValue("@duracao", filmes.getDuracao());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo filme cadastrado!");

                conexaoBancoDados().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo filme!");
                throw ex;
            }
        }

        // método INSERT Locação
        public static void insertLocacao(Locacoes locacao)
        {
            if (existeLocacoes(locacao))
            {
                MessageBox.Show("Locação já cadastrada!");
                return;
            }
            try
            {
                var cmd = conexaoBancoDados().CreateCommand();
                cmd.CommandText = "INSERT INTO locacoes (cpf_usuario, id_filme, data_emprestimo, data_devolucao) VALUES (@CPF, @filme, @emprestimo, @devolucao)";

                cmd.Parameters.AddWithValue("@CPF", locacao.getUsuario().getCPF());
                cmd.Parameters.AddWithValue("@filme", locacao.getFilmes().getID());
                cmd.Parameters.AddWithValue("@emprestimo", locacao.getDataLocacao());
                cmd.Parameters.AddWithValue("@devolucao", locacao.getDataDevolucao());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Nova locação cadastrada!");

                conexaoBancoDados().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir nova locação!");
                throw ex;
            }
        }


        // método para verificar se existe CPF cadastrado - Usuário
        public static bool existeCPF(usuario Usuario)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            // buscando CPF no banco de dados
            var cmd = conexaoBancoDados().CreateCommand();
            cmd.CommandText = "SELECT CPF FROM usuarios WHERE CPF = '" + Usuario.getCPF() + "'";

            // verificando o número de retornos da QUERY
            data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
            data_adapter.Fill(data_table);
            if (data_table.Rows.Count > 0)
            {
                conexaoBancoDados().Close();
                return (true);
            }
            else
            {
                conexaoBancoDados().Close();
                return (false);
            }
        }

        // método para verificar se existe Filme cadastrado
        public static bool existeFilme(Filmes filmes)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            // buscando CPF no banco de dados
            var cmd = conexaoBancoDados().CreateCommand();
            cmd.CommandText = "SELECT nome, ano FROM filmes WHERE nome = '" + filmes.getNome() + "'" + "AND ano = " + filmes.getAno();

            // verificando o número de retornos da QUERY
            data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
            data_adapter.Fill(data_table);
            if (data_table.Rows.Count > 0)
            {
                conexaoBancoDados().Close();
                return (true);
            }
            else
            {
                conexaoBancoDados().Close();
                return (false);
            }
        }

        // método para verificar se existe Locação cadastrada
        public static bool existeLocacoes(Locacoes locacoes)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            // buscando CPF no banco de dados
            var cmd = conexaoBancoDados().CreateCommand();
            cmd.CommandText = "SELECT * FROM locacoes WHERE cpf_usuario = '" + locacoes.getUsuario().getCPF() + "'" + "AND id_filme = " + locacoes.getFilmes().getID();

            // verificando o número de retornos da QUERY
            data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
            data_adapter.Fill(data_table);
            if (data_table.Rows.Count > 0)
            {
                conexaoBancoDados().Close();
                return (true);
            }
            else
            {
                conexaoBancoDados().Close();
                return (false);
            }
        }

        // método SELECT * FROM de usuários
        public static DataTable getUsuario()
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "SELECT CPF as 'CPF', nome as 'Nome', email as 'e-mail', telefone as 'Telefone' FROM usuarios";

                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }

        }

        // método SELECT * FROM de filmes
        public static DataTable getFilmes()
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "SELECT id_filmes as 'ID', nome as 'Nome', diretor as 'Diretor', genero as 'Gênero', ano as 'Ano', duracao as 'Duração' FROM filmes";

                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }

        }

        // método SELECT * FROM de locações
        public static DataTable getLocacao()
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "SELECT locacoes.id_locacao as 'ID Locação', locacoes.cpf_usuario as 'CPF', usuarios.nome as 'Nome', locacoes.id_filme as 'ID Filme', filmes.nome as 'Nome do Filme', usuarios.telefone as 'Telefone', usuarios.email as 'e-mail', data_emprestimo as 'Data de Empréstimo', data_devolucao as 'Data de Devolução' FROM locacoes INNER JOIN usuarios ON usuarios.cpf = locacoes.cpf_usuario, filmes ON filmes.id_filmes = locacoes.id_filme ORDER BY id_locacao";

                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }

        }

        // método SELECT usuário
        public static DataTable selectUsuario(String CPF)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM usuarios WHERE CPF = '" + CPF + "'";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método SELECT filmes
        public static DataTable selectFilmes(int ID)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM filmes WHERE id_filmes = " + ID;
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método UPDATE Usuário
        public static void updateUsuario(usuario Usuario)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "UPDATE usuarios SET nome = '" + Usuario.getNome() +
                    "', telefone ='" +
                    Usuario.getTelefone() + "', email = '" + Usuario.getEmail() + "'" +
                    "WHERE CPF = '" + Usuario.getCPF() + "'";

                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());

                    cmd.ExecuteNonQuery(); // executando a QUERY

                    MessageBox.Show("Dados do usuário atualizados com sucesso!");

                    conexaoBancoDados().Close();
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método UPDATE Filme
        public static void updateFilmes(Filmes filmes)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "UPDATE filmes SET nome = '" + filmes.getNome() +
                        "', diretor = '" + filmes.getDiretor() +
                        "', genero = '" + filmes.getGenero() +
                        "', ano = " + filmes.getAno() +
                        ", duracao = " + filmes.getDuracao() + " WHERE id_filmes = " + filmes.getID();

                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());

                    cmd.ExecuteNonQuery(); // executando a QUERY

                    MessageBox.Show("Dados do usuário atualizados com sucesso!");

                    conexaoBancoDados().Close();

                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método UPDATE Locação
        public static void updateLocacao(Locacoes locacoes)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "UPDATE locacoes SET cpf_usuario = '" + locacoes.getUsuario().getCPF() +
                    "', id_filme = " +
                    locacoes.getFilmes().getID() + ", data_emprestimo = '" + locacoes.getDataLocacao() +
                    "', data_devolucao = '" + locacoes.getDataDevolucao() +
                    "' WHERE id_locacao = " + locacoes.getIdLocacao();

                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());

                    cmd.ExecuteNonQuery(); // executando a QUERY

                    MessageBox.Show("Dados da locação atualizados com sucesso!");

                    conexaoBancoDados().Close();

                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método DELETE Usuário
        public static void deleteUsuario(string cpf)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM usuarios WHERE CPF = '" + cpf + "'";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    cmd.ExecuteNonQuery(); // executando a QUERY
                    MessageBox.Show("Dados excluídos com sucesso!");
                    conexaoBancoDados().Close();
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }


        }

        // método DELETE Filme
        public static void deleteFilmes(int id)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM filmes WHERE id_filmes = " + id;
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    cmd.ExecuteNonQuery(); // executando a QUERY
                    MessageBox.Show("Dados excluídos com sucesso!");
                    conexaoBancoDados().Close();
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método DELETE Locação
        public static void deleteLocacao(int ID)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM locacoes WHERE id_locacao = " + ID + "";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    cmd.ExecuteNonQuery(); // executando a QUERY
                    MessageBox.Show("Dados excluídos com sucesso!");
                    conexaoBancoDados().Close();
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }


        // método para pesquisar usuário pelo CPF
        public static DataTable selectUsuarioByCPF(String CPF)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();
            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "SELECT CPF as 'CPF', nome as 'Nome', email as 'e-mail', telefone as 'Telefone' FROM usuarios WHERE CPF LIKE '%" + CPF + "%'";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método para pesquisar usuário pelo Nome
        public static DataTable selectUsuarioByNome(string nome)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "SELECT CPF as 'CPF', nome as 'Nome', email as 'e-mail', telefone as 'Telefone' FROM usuarios WHERE nome LIKE '%" + nome + "%'";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método para pesquisar filme pelo Nome
        public static DataTable selectFilmeByNome(string nome)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {

                    cmd.CommandText = "SELECT id_filmes as 'ID', nome as 'Nome', diretor as 'Diretor', genero as 'Gênero', ano as 'Ano', duracao as 'Duração' FROM filmes WHERE nome LIKE '%" + nome + "%'";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método para pesquisar filme pelo nome do diretor
        public static DataTable selectFilmeByDiretor(string diretor)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {

                    cmd.CommandText = "SELECT id_filmes as 'ID', nome as 'Nome', diretor as 'Diretor', genero as 'Gênero', ano as 'Ano', duracao as 'Duração' FROM filmes WHERE diretor LIKE '%" + diretor + "%'";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método para pesquisar filme pelo gênero
        public static DataTable selectFilmeByGenero(string genero)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {

                    cmd.CommandText = "SELECT id_filmes as 'ID', nome as 'Nome', diretor as 'Diretor', genero as 'Gênero', ano as 'Ano', duracao as 'Duração' FROM filmes WHERE genero LIKE '%" + genero + "%'";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método para pesquisar filme pelo ano
        public static DataTable selectFilmeByAno(int ano)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {

                    cmd.CommandText = "SELECT id_filmes as 'ID', nome as 'Nome', diretor as 'Diretor', genero as 'Gênero', ano as 'Ano', duracao as 'Duração' FROM filmes WHERE ano LIKE %" + ano + "%";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();
                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método SELECT locação
        public static DataTable selectLocacao(String id)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM locacoes WHERE id_locacao = '" + id + "'";
                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());
                    data_adapter.Fill(data_table);
                    conexaoBancoDados().Close();

                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }

        // método para pesquisar empréstimo pelo CPF do usuário
        public static DataTable selectLocacaoByCPFLeitor(string cpf)
        {
            SQLiteDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBancoDados().CreateCommand())
                {
                    cmd.CommandText = "SELECT locacoes.id_locacao as 'ID Locação', locacoes.cpf_usuario as 'CPF', usuarios.nome as 'Nome', locacoes.id_filme as 'ID Filme', filmes.nome as 'Nome do Filme', usuarios.telefone as 'Telefone', usuarios.email as 'e-mail', data_emprestimo as 'Data de Empréstimo', data_devolucao as 'Data de Devolução' FROM locacoes INNER JOIN usuarios ON usuarios.cpf = locacoes.cpf_usuario, filmes ON filmes.id_filmes = locacoes.id_filme ORDER BY id_locacao WHERE locacoes.cpf_usuario LIKE '%" + cpf + "%' ORDER BY locacoes.id_locacao";

                    data_adapter = new SQLiteDataAdapter(cmd.CommandText, conexaoBancoDados());

                    data_adapter.Fill(data_table);

                    conexaoBancoDados().Close();

                    return (data_table);
                }
            }
            catch (Exception ex)
            {
                conexaoBancoDados().Close();
                throw ex;
            }
        }
    }
}
