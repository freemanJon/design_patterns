using Design_patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Interfaces
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
