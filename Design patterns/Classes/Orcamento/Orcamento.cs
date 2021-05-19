using Design_patterns.Classes;
using Design_patterns.Classes.Estados;
using Design_patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Classes.Orcamento
{
    public class Orcamento
    {
  
        public IEstadoOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set;}
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }
        
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }
        public void Aprova()
        {
            EstadoAtual = new Aprovado();
        }

        public void Finaliza()
        {
            EstadoAtual = new Finalizado();
        }

        public void Reprova()
        {
            EstadoAtual = new Reprovado();
        }
    }
}
