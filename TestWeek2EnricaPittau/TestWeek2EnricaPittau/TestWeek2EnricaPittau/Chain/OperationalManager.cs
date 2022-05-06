using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek2EnricaPittau.Handler;

namespace TestWeek2EnricaPittau.Chain
{
    public class OperationalManager : AbstractHandler
    {
        public override string Handle(Spese importo)
        {
            if (importo.Importo >= 401 && importo.Importo < 1000)
                return $"Per gli Operational Manager sono approvate le spese da 401 fino a 1000 euro.";
            else
                return base.Handle(importo);
        }
    }
}
