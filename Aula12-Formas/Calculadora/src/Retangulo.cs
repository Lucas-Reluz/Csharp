using System.Collections.Generic;
using System;
namespace Calculadora.src
{
    public class Retangulo : Formas
    {

        public Retangulo(string _nome, double _base, double _altura) : base(_nome, _base, _altura)
        {
        }
        public override double CalcularArea()
        {
        double area = Base * Altura;
        return area;
        }
    }
}