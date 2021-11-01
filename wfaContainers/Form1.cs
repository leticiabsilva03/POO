﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaContainers
{
    public partial class Form1 : Form
    {
        Pilha[] locais = new Pilha[4];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < locais.Length; i++)
            {
                locais[i] = new Pilha();
            }
        }
        private void LimparCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                                       
                    // variáveis para obter a menor pilha
                    Pilha menor_pilha = locais[0];
                    int menor_tamanho = menor_pilha.lenght();
                    int local_empilhar = 0;

                    // flag para verificar se há contêiner empilhado
                    bool codigoLivre = true;

                    // percorrer pilhas
                    for (int i = 0; i < locais.Length; i++)
                    {
                        // obter a menor pilha
                        if (locais[i].lenght() < menor_tamanho)
                        {
                            menor_tamanho = locais[i].lenght(); // atualiza o menor tamanho de pilha
                            menor_pilha = locais[i]; // atualiza o local que tem a menor pilha
                            local_empilhar = i; // local com o menor empilhamento
                        }

                        // procurar por código repetido
                        NohPilha topo = locais[i].peek();

                        while (topo != null)
                        {
                            if (topo.getData() == int.Parse(textBox1.Text))
                            {
                                codigoLivre = false;
                            }
                            topo = topo.getNext();
                        }
                    }

                    // código repetido
                    if (!codigoLivre)
                    {
                        throw new FormatException();
                    }

                    // empilhando na menor pilha
                    if (menor_tamanho < 3)
                    {
                        locais[local_empilhar].push(int.Parse(textBox1.Text));

                        LimparCampos();

                        textBox4.Text = locais[0].print(); // local 1
                        textBox6.Text = locais[1].print(); // local 2
                        textBox5.Text = locais[2].print(); // local 3
                        textBox3.Text = locais[3].print(); // local 4
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Informar código do contêiner",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    LimparCampos();
                    textBox1.Focus();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show(
                "Código invalido!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                LimparCampos();
                textBox1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show(
                "Impossível Empilhar!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                LimparCampos();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "")
                {                    
                    
                    // Verificando em qual pilha contém o contêiner
                    int local = -1;

                    for (int i = 0; locais.Length > i; i++)
                    {
                        if (locais[i].indexOf(int.Parse(textBox2.Text)) != -1)
                        {
                            local = i;
                        }
                    }

                    if (local != -1)
                    {
                        if (locais[local].peek().getData() == int.Parse(textBox2.Text)) // se o contêiner estiver no topo da pilha
                        {
                            locais[local].pop(); // desempilha

                        }
                        else
                        {
                            throw new Exception();
                        }

                        textBox4.Text = locais[0].print(); // local 1
                        textBox6.Text = locais[1].print(); // local 2
                        textBox5.Text = locais[2].print(); // local 3
                        textBox3.Text = locais[3].print(); // local 4

                    }
                    else if (locais[0].isEmpty() && locais[1].isEmpty() && locais[2].isEmpty() && locais[3].isEmpty()) // todas as pilhas vazias
                    {
                        throw new Exception();
                    }
                    else
                    {
                        throw new FormatException();
                    }

                }
                else
                {
                    MessageBox.Show(
                    "Informar código do contêiner",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                    LimparCampos();

                    textBox2.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                "Código invalido!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                LimparCampos();

                textBox2.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show(
                "Impossível Empilhar!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                LimparCampos();

                textBox2.Focus();

            }
        }
    }
}

