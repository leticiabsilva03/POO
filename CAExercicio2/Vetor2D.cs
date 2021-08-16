using System;
using System.Collections.Generic;
using System.Text;

namespace CAExercicio2
{
    class Vetor2D
    {
        // atributos da classe
        private double m_x;
        private double m_y;
        double m_modulo;
        double m_angulo;

        // contrutores

        // construtor default para criar vetor nulo
        public Vetor2D()
        {
            m_x = 0.0;
            m_y = 0.0;
        }

        // construtor que receberá valores de x e y
        public Vetor2D(double x, double y)
        {
            m_x = x;
            m_y = y;
        }

        // getters
        public double getX()
        {
            return (m_x);
        }
        public double getY()
        {
            return (m_y);
        }

        // setters
        public void setX(double x)
        {
            m_x = x;
        }
        public void setY(double y)
        {
            m_y = y;
        }

        // função membro para retornar módulo do vetor
        public double modulo()
        {
            m_modulo = Math.Sqrt(Math.Pow(m_x, 2) + Math.Pow(m_y, 2));
            return (m_modulo);
        }

        // função produto escalar entre dois vetores 2D
        public double produtoEscalar(Vetor2D V)
        {
            double produto_escalar = (m_x * V.m_x) + (m_y * V.m_y);
            return (produto_escalar);
        }

        // função angulo entre dois vetores 2D
        public double angulo(Vetor2D V)
        {
            m_angulo = Math.Acos(produtoEscalar(V)/ Math.Sqrt(Math.Pow(m_x, 2) + Math.Pow(m_y, 2))*V.modulo());
            m_angulo = m_angulo * (180 / Math.PI);
            return (m_angulo);
        }

    }
}
