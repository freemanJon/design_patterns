using Design_patterns.Classes.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Classes.NotaFiscal
{
    public class NotaFiscal
    {
     
        public String RazaoSocial { get; set; }
        public String CNPJ { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> itemDaNotas{ get; set; }
        public String Observacoes { get; set; }


    }
}
