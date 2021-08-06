using System;
using System.Collections.Generic;
using System.Text;

namespace CAExercicio1
{
    class Aluno
    {
        // atributos da classe
        private String m_nome;
        private String m_matricula;
        private String m_telefone;

        // construtor padrão
        public Aluno()
        {
            m_nome = "";
            m_matricula = "";
            m_telefone = "";
        }

        // construtor com argumentos
        public Aluno(String nome, String matricula, String telefone)
        {
            m_nome = nome;
            m_matricula = matricula;
            m_telefone = telefone;
        }

        // getters
        public String getNome()
        {
            return (m_nome);
        }

        public String getMatricula()
        {
            return (m_matricula);
        }

        public String getTelefone()
        {
            return (m_telefone);
        }

        // setters
        public void setNome(String nome)
        {
            m_nome = nome;
        }

        public void setMatricula(String matricula)
        {
            m_matricula = matricula;
        }

        public void setTelefone(String telefone)
        {
            m_telefone = telefone;
        }

        public void imprimirDados()
        {
            Console.WriteLine("\t\t\t" + "Dados do Aluno");
            Console.WriteLine("\nNome: " + m_nome);
            Console.WriteLine("Número de Matrícula: " + m_matricula);
            Console.WriteLine("Número do Telefone: " + m_telefone);
        }
    }
}
