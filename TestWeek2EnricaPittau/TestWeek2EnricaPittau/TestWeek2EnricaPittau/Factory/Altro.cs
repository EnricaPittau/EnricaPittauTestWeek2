using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2EnricaPittau.Factory
{
    internal class Altro : IRimborso
    {
        string IRimborso.Categoria { get ; set ; }

        public string CalcolaRimborso(string categoria)
        {
            throw new NotImplementedException();
        }
    }
}
