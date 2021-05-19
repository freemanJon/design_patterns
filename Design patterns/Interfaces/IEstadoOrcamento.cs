using Design_patterns.Interfaces;
using Design_patterns.Classes.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_patterns.Interfaces.Estados;
namespace Design_patterns.Interfaces.Estados
{
    public interface IEstadoOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
