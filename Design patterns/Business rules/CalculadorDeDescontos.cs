using Design_patterns.Classes.Descontos;
using Design_patterns.Interfaces;
using Design_patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Business_rules
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto descontoMais5Itens = new DescontoMaisDe5Itens();
            IDesconto descontoValorMaior500 = new DescontoValorMaior500();
            IDesconto semDesconto = new SemDesconto();
            descontoMais5Itens.Proximo = descontoValorMaior500;
            descontoValorMaior500.Proximo = semDesconto;
            return descontoMais5Itens.Desconta(orcamento);
        }
    }
}
