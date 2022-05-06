using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek2EnricaPittau.Handler;

namespace TestWeek2EnricaPittau.Chain
{
    public class Manager : AbstractHandler
    {
        public override string Handle(Spese importo)
        {
            if (importo.Importo <= 400)
                return $"Per i Manager sono approvate le spese fino a 400.";
            else
                return base.Handle(importo);
        }
    }
}
