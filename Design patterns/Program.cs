using Design_patterns.Business_rules;
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
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Orcamento orcamento = new Orcamento(500);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            Console.ReadKey();
        }
    }
}
