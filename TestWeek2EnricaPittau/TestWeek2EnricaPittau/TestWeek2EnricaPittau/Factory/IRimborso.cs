using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2EnricaPittau.Factory
{
    public interface IRimborso
    {
        public string Categoria { get; internal set; }
        public string CalcolaRimborso(string categoria);
    }
}
