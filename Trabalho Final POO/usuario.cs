using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoFinal
{
    class usuario
    {
        // atributos

        private String m_CPF;
        private String m_nome;
        private String m_email;
        private String m_telefone;

        // construtor padrão
        public usuario()
        {
            m_nome = "";
            m_CPF = "";
            m_telefone = "";
            m_email = "";

        }

        // construtor com argumentos
        public usuario(String nome, String CPF, String telefone, String email)
        {
            m_nome = nome;
            m_CPF = CPF;
            m_telefone = telefone;
            m_email = email;
        }

        // getters
        public String getNome()
        {
            return (m_nome);
        }

        public String getCPF()
        {
            return (m_CPF);
        }

        public String getTelefone()
        {
            return (m_telefone);
        }

        public String getEmail()
        {
            return (m_email);
        }

        // setters
        public void setNome(String nome)
        {
            m_nome = nome;
        }

        public void setCPF(String CPF)
        {
            m_CPF = CPF;
        }

        public void setTelefone(String telefone)
        {
            m_telefone = telefone;
        }

        public void setEmail(String email)
        {
            m_email = email;
        }

    }
}
