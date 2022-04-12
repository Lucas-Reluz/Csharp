using System;
using Calculadora.src;

namespace Venda.src

{
    public class VendedorA : Bonus
    {
        public string Nome { get; set; }
        public double Venda { get; set; }
        public double Bonus { get; set; }
        public string Cargo { get; set; }
        public double TotalReceber { get; set; }
        
        private Calc _calculadora;

        public VendedorA(string nome, double venda, string cargo, double salario)
        {
            _calculadora = new Calc();
            
            Nome = nome;
            Venda = venda;
            Bonus = CalculaBonus(venda);
            TotalReceber = _calculadora.Somar(salario, Bonus);
            Cargo = cargo;
        }
        public override double CalculaBonus(double venda)
        {
            return venda * 0.05;
        }

        public override string ToString()
        {
        return $"Nome: {Nome}\nVenda: {Venda}\nBonus: {Bonus}\nTotal a Receber: {TotalReceber}\nCargo: {Cargo}";
        }
    }

}