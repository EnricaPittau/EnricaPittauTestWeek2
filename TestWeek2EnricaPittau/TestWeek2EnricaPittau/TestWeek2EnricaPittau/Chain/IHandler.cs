using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2EnricaPittau.Handler
{
    public interface IHandler
    {
       
        IHandler SetNext(IHandler handler); //setta anello successivo
        string Handle(Spese importo);//gestisce la richiesta
    }
}
