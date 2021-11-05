using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoFinal
{
    class Filmes
    {
        // atributos

        private Int32 m_id;
        private String m_nome;
        private String m_diretor;
        private String m_genero;
        private int m_ano;
        private int m_duracao;

        // construtor padrão
        public Filmes()
        {
            m_id = 0;
            m_nome = "";
            m_diretor = "";
            m_genero = "";
            m_ano = 0;
            m_duracao = 0;
        }
        // construtor com argumentos
        public Filmes(Int32 id, String nome, String diretor, String genero, int ano, int duracao)
        {
            m_id = id;
            m_nome = nome;
            m_diretor = diretor;
            m_genero = genero;
            m_ano = ano;
            m_duracao = duracao;
        }
        // getters
        public Int32 getID()
        {
            return (m_id);
        }
        public String getNome()
        {
            return (m_nome);
        }

        public String getDiretor()
        {
            return (m_diretor);
        }

        public String getGenero()
        {
            return (m_genero);
        }

        public int getAno()
        {
            return (m_ano);
        }
        public int getDuracao()
        {
            return (m_duracao);
        }

        // setters
        public void setID(Int32 id)
        {
            m_id = id;
        }
        public void setNome(String nome)
        {
            m_nome = nome;
        }

        public void setDiretor(String diretor)
        {
            m_diretor = diretor;
        }

        public void setGenero(String genero)
        {
            m_genero = genero;
        }

        public void setAno(int ano)
        {
            m_ano = ano;
        }
        public void setDuracao(int duracao)
        {
            m_duracao = duracao;
        }
    }
}
