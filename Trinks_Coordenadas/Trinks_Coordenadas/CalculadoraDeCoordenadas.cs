using System;
using System.Drawing;

namespace Trinks_Coordenadas
{
    public class CalculadoraDeCoordenadas
    {
        public Point ponto;

        public CalculadoraDeCoordenadas(int x, int y)
        {
            ponto = new Point(x, y);
        }

        public void Mover(Direcao direcao, int intensidade)
        {
            switch (direcao)
            {
                case Direcao.N:
                    ponto.Y += intensidade;                    
                    break;
                case Direcao.S:
                    ponto.Y -= intensidade;                    
                    break;
                case Direcao.L:
                    ponto.X += intensidade;
                    break;
                case Direcao.O:
                    ponto.X -= intensidade;
                    break;
            }
        }
    }
}
