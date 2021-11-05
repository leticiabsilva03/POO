using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarUsuario cadastrarUsuario = new CadastrarUsuario();
            cadastrarUsuario.ShowDialog();
            this.Visible = true;
        }

        private void atualizarDadosDoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtualizarUsuario atualizarUsuario = new AtualizarUsuario();
            atualizarUsuario.ShowDialog();
            this.Visible = true;
        }

        private void excluirUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcluirUsuario excluirUsuario = new ExcluirUsuario();
            excluirUsuario.ShowDialog();
            this.Visible = true;
        }

        private void pesquisarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PesquisarUsuario pesquisarUsuario = new PesquisarUsuario();
            pesquisarUsuario.ShowDialog();
            this.Visible = true;
        }

        private void cadastrarFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarFilmes cadastrarfilmes = new CadastrarFilmes();
            cadastrarfilmes.ShowDialog();
            this.Visible = true;
        }

        private void atualizarDadosDoFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtualizarFilmes atualizarfilmes = new AtualizarFilmes();
            atualizarfilmes.ShowDialog();
            this.Visible = true;
        }

        private void excluirFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcluirFilmes excluirfilmes = new ExcluirFilmes();
            excluirfilmes.ShowDialog();
            this.Visible = true;
        }

        private void pesquisarFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PesquisarFilmes pesquisarfilmes = new PesquisarFilmes();
            pesquisarfilmes.ShowDialog();
            this.Visible = true;
        }

        private void cadastrarLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarLocacao cadastrarLocacao = new CadastrarLocacao();
            cadastrarLocacao.ShowDialog();
            this.Visible = true;
        }

        private void atualizarDadosDaLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AtualizarLocacao atualizarLocacao = new AtualizarLocacao();
            atualizarLocacao.ShowDialog();
            this.Visible = true;
        }

        private void excluirLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcluirLocacao excluirLocacao = new ExcluirLocacao();
            excluirLocacao.ShowDialog();
            this.Visible = true;
        }

        private void pesquisarLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PesquisarLocacao pesquisarLocacao = new PesquisarLocacao();
            pesquisarLocacao.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
