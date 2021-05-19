using Design_patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Interfaces
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public Imposto(Imposto imposto)
        {
            this.OutroImposto = imposto;
        }

        protected Imposto(){
            this.OutroImposto = null;
        }

        public abstract double  Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;

            return OutroImposto.Calcula(orcamento);
        }
    }
}
