using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExercicio3
{
    class Tempo
    {
        // atributos da classe
        public int t_hora;
        public int t_min;
        public int t_segs;

        // construtor padrão

        public Tempo()
        {
            t_hora = 00;
            t_min = 00;
            t_segs = 00;
        }

        // construtor que inicialize os dados pelo teclado
        public Tempo (int hora, int min, int segs)
        {
            t_hora = hora;
            t_min = min;
            t_segs = segs;
        }

        // método para imprimir hh:mm:ss
        public int getHora()
        {
            return t_hora;
        }
        public int getMinutos()
        {
            return t_min;
        }
        public int getSegundos()
        {
            return t_segs;
        }
        public void setHora(int hora)
        {
            t_hora = hora;
        }
        public void setMinutos(int min)
        {
            t_min = min;
        }
        public void setSegundos(int segs)
        {
            t_segs = segs;
        }
        public int Tempo_Hora()
        {
            return (t_hora);
        }
        public int Tempo_Minutos()
        {
            return (t_min);
        }
        public int Tempo_Segundos()
        {
            return (t_segs);
        }
    }
}
