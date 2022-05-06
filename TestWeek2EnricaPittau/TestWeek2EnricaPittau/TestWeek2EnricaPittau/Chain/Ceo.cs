using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek2EnricaPittau.Handler;

namespace TestWeek2EnricaPittau.Chain
{
    internal class Ceo : AbstractHandler
    {
        public override string Handle(Spese importo)
        {
            if (importo.Importo >= 401 && importo.Importo < 1000)
                return $"Per i CEO sono approvate le spese sopra i 1000 euro.";
            else
                return base.Handle(importo);
        }
    }
}
