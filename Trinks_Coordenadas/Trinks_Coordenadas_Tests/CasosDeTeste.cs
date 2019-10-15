using System;
using Trinks_Coordenadas;
using Xunit;

namespace Trinks_Coordenadas_Tests
{
    public class CasosDeTeste
    {
        [Fact]
        public void CasoDeTeste_1()
        {
            var calculadora = new CalculadoraDeCoordenadas(8, 12);
            calculadora.Mover(Direcao.N, 23);
            calculadora.Mover(Direcao.O, 7);
            calculadora.Mover(Direcao.S, 40);
            calculadora.Mover(Direcao.L, 33);
            calculadora.Mover(Direcao.N, 15);
            Assert.Equal(34, calculadora.ponto.X);
            Assert.Equal(10, calculadora.ponto.Y);
        }

        [Fact]
        public void CasoDeTeste_2()
        {
            var calculadora = new CalculadoraDeCoordenadas(8, 12);
            calculadora = new CalculadoraDeCoordenadas(-10, 0);
            calculadora.Mover(Direcao.L, 14);
            calculadora.Mover(Direcao.N, 27);
            calculadora.Mover(Direcao.O, 33);
            calculadora.Mover(Direcao.S, 20);
            calculadora.Mover(Direcao.L, 15);
            Assert.Equal(-14, calculadora.ponto.X);
            Assert.Equal(7, calculadora.ponto.Y);
        }
    }
}
