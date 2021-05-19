using Design_patterns.Interfaces;
using Design_patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Classes.Impostos
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto imposto) : base(imposto) { }

        public TemplateDeImpostoCondicional() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
            }
            return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        public abstract double MinimaTaxacao(Orcamento orcamento);

        public abstract double MaximaTaxacao(Orcamento orcamento);

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
