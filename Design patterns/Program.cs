using Design_patterns.Business_rules;
using Design_patterns.Classes;
using Design_patterns.Interfaces;
using Design_patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Lapis", 100));
            orcamento.AdicionaItem(new Item("Caneta", 100));
            orcamento.AdicionaItem(new Item("Caderno", 100));
            orcamento.AdicionaItem(new Item("Canetinha", 100));
            orcamento.AdicionaItem(new Item("Giz", 100));
            orcamento.AdicionaItem(new Item("Papel A4", 100));
            CalculadorDeImpostos calculadorImpostos = new CalculadorDeImpostos();
            CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();
            calculadorImpostos.RealizaCalculo(orcamento, iss);
            calculadorImpostos.RealizaCalculo(orcamento, icms);
            calculadorDeDescontos.Calcula(orcamento);
            Console.ReadKey();
        }
    }
}
