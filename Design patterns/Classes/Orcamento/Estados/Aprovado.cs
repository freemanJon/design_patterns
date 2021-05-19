using Design_patterns.Interfaces;
using Design_patterns.Classes.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_patterns.Interfaces.Estados;

namespace Design_patterns.Classes.Orcamento.Estados
{
    public class Aprovado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Impossivel mudanca de estado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Impossivel mudanca de estado!");
        }
    }
}
