using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2EnricaPittau.Factory
{
    public class Viaggio : IRimborso
    {
        string IRimborso.Categoria { get ; set ; }

        public string CalcolaRimborso(string categoria)
        {
            throw new NotImplementedException();
        }
    }
}
