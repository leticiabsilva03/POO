using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoFinal
{
    class Locacoes
    {
        //  atributos
        private usuario m_usuario;
        private Filmes m_filmes;
        private String m_dataLocacao;
        private String m_dataDevolucao;
        private int m_id;

        public Locacoes()
        {
            m_usuario = new usuario();
            m_filmes = new Filmes();
            m_dataLocacao = setToday();
            m_dataDevolucao = set3dias();
            m_id = -1;
        }

        // método para verificar se a data de devolução não é sábado ou domingo
        public bool isDiaUtil(DateTime x)
        {
            if (x.DayOfWeek == DayOfWeek.Sunday || x.DayOfWeek == DayOfWeek.Saturday)
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }

        // método para gerar data atual
        public String setToday()
        {
            DateTime data = DateTime.Now;
            string dataAtual = data.Day.ToString() + "/" + data.Month.ToString() + "/" + data.Year.ToString();
            return (dataAtual);
        }

        // método para gerar o dia de devolução
        public String set3dias()
        {
            DateTime data = DateTime.Now;
            int dias = 0;
            while (dias < 3)
            {
                data = data.AddDays(1);
                if (isDiaUtil(data))
                {
                    dias++;
                }
            }

            string devolucao = data.Day.ToString() + "/" + data.Month.ToString() + "/" + data.Year.ToString();

            return (devolucao);
        }

        // getters
        public String getDataLocacao()
        {
            return (m_dataLocacao);
        }

        public String getDataDevolucao()
        {
            return (m_dataDevolucao);
        }

        public usuario getUsuario()
        {
            return (m_usuario);
        }
        public Filmes getFilmes()
        {
            return (m_filmes);
        }

        public int getIdLocacao()
        {
            return (m_id);
        }

        // setters
        public void setDataLocacao(String dataLocacao)
        {
            m_dataLocacao = dataLocacao;
        }

        public void setDataDevolucao(String dataDevolucao)
        {
            m_dataDevolucao = dataDevolucao;
        }

        public void setUsuario(usuario Usuario)
        {
            m_usuario = Usuario;
        }

        public void setFilmes(Filmes filmes)
        {
            m_filmes = filmes;
        }

        public void setIdLocacao(int ID)
        {
            m_id = ID;
        }
    }
}
