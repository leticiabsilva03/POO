
namespace TrabalhoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarDadosDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarDadosDoFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarDadosDaLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.locaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.atualizarDadosDoUsuárioToolStripMenuItem,
            this.excluirUsuárioToolStripMenuItem,
            this.pesquisarUsuárioToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // atualizarDadosDoUsuárioToolStripMenuItem
            // 
            this.atualizarDadosDoUsuárioToolStripMenuItem.Name = "atualizarDadosDoUsuárioToolStripMenuItem";
            this.atualizarDadosDoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.atualizarDadosDoUsuárioToolStripMenuItem.Text = "Atualizar Dados do Usuário";
            this.atualizarDadosDoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.atualizarDadosDoUsuárioToolStripMenuItem_Click);
            // 
            // excluirUsuárioToolStripMenuItem
            // 
            this.excluirUsuárioToolStripMenuItem.Name = "excluirUsuárioToolStripMenuItem";
            this.excluirUsuárioToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.excluirUsuárioToolStripMenuItem.Text = "Excluir Usuário";
            this.excluirUsuárioToolStripMenuItem.Click += new System.EventHandler(this.excluirUsuárioToolStripMenuItem_Click);
            // 
            // pesquisarUsuárioToolStripMenuItem
            // 
            this.pesquisarUsuárioToolStripMenuItem.Name = "pesquisarUsuárioToolStripMenuItem";
            this.pesquisarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.pesquisarUsuárioToolStripMenuItem.Text = "Pesquisar Usuário";
            this.pesquisarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.pesquisarUsuárioToolStripMenuItem_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFilmeToolStripMenuItem,
            this.atualizarDadosDoFilmeToolStripMenuItem,
            this.excluirFilmeToolStripMenuItem,
            this.pesquisarFilmeToolStripMenuItem});
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.filmesToolStripMenuItem.Text = "Filmes";
            // 
            // cadastrarFilmeToolStripMenuItem
            // 
            this.cadastrarFilmeToolStripMenuItem.Name = "cadastrarFilmeToolStripMenuItem";
            this.cadastrarFilmeToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.cadastrarFilmeToolStripMenuItem.Text = "Cadastrar Filme";
            this.cadastrarFilmeToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFilmeToolStripMenuItem_Click);
            // 
            // atualizarDadosDoFilmeToolStripMenuItem
            // 
            this.atualizarDadosDoFilmeToolStripMenuItem.Name = "atualizarDadosDoFilmeToolStripMenuItem";
            this.atualizarDadosDoFilmeToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.atualizarDadosDoFilmeToolStripMenuItem.Text = "Atualizar Dados do Filme";
            this.atualizarDadosDoFilmeToolStripMenuItem.Click += new System.EventHandler(this.atualizarDadosDoFilmeToolStripMenuItem_Click);
            // 
            // excluirFilmeToolStripMenuItem
            // 
            this.excluirFilmeToolStripMenuItem.Name = "excluirFilmeToolStripMenuItem";
            this.excluirFilmeToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.excluirFilmeToolStripMenuItem.Text = "Excluir Filme";
            this.excluirFilmeToolStripMenuItem.Click += new System.EventHandler(this.excluirFilmeToolStripMenuItem_Click);
            // 
            // pesquisarFilmeToolStripMenuItem
            // 
            this.pesquisarFilmeToolStripMenuItem.Name = "pesquisarFilmeToolStripMenuItem";
            this.pesquisarFilmeToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.pesquisarFilmeToolStripMenuItem.Text = "Pesquisar Filme";
            this.pesquisarFilmeToolStripMenuItem.Click += new System.EventHandler(this.pesquisarFilmeToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLocaçãoToolStripMenuItem,
            this.atualizarDadosDaLocaçãoToolStripMenuItem,
            this.excluirLocaçãoToolStripMenuItem,
            this.pesquisarLocaçãoToolStripMenuItem});
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.locaçãoToolStripMenuItem.Text = "Locações";
            // 
            // cadastrarLocaçãoToolStripMenuItem
            // 
            this.cadastrarLocaçãoToolStripMenuItem.Name = "cadastrarLocaçãoToolStripMenuItem";
            this.cadastrarLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.cadastrarLocaçãoToolStripMenuItem.Text = "Cadastrar Locação";
            this.cadastrarLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLocaçãoToolStripMenuItem_Click);
            // 
            // atualizarDadosDaLocaçãoToolStripMenuItem
            // 
            this.atualizarDadosDaLocaçãoToolStripMenuItem.Name = "atualizarDadosDaLocaçãoToolStripMenuItem";
            this.atualizarDadosDaLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.atualizarDadosDaLocaçãoToolStripMenuItem.Text = "Atualizar Dados da Locação";
            this.atualizarDadosDaLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.atualizarDadosDaLocaçãoToolStripMenuItem_Click);
            // 
            // excluirLocaçãoToolStripMenuItem
            // 
            this.excluirLocaçãoToolStripMenuItem.Name = "excluirLocaçãoToolStripMenuItem";
            this.excluirLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.excluirLocaçãoToolStripMenuItem.Text = "Excluir Locação";
            this.excluirLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.excluirLocaçãoToolStripMenuItem_Click);
            // 
            // pesquisarLocaçãoToolStripMenuItem
            // 
            this.pesquisarLocaçãoToolStripMenuItem.Name = "pesquisarLocaçãoToolStripMenuItem";
            this.pesquisarLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.pesquisarLocaçãoToolStripMenuItem.Text = "Pesquisar Locação";
            this.pesquisarLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarLocaçãoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de Filmes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarDadosDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarDadosDoFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarDadosDaLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarLocaçãoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

