using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2EnricaPittau.Factory
{
    public class RimborsiFactory
    {
        public IRimborso GetAll(string categoria)
        {
            IRimborso quotaRimborsata = null;
  
            switch (categoria)
            {
               
                case "Viaggio":
                //    quotaRimborsata = new Viaggio() { Categoria = categoria };
                //    break;
                //case :
                    
                //    break;
                //case :
                   
                //    break;
                default:
                    quotaRimborsata = null;
                    break;
            }

            return quotaRimborsata;
        }
    }
}
