using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2EnricaPittau.Handler
{
    public abstract class AbstractHandler : IHandler
    {
        public IHandler _nextHandler { get; private set; }

        public virtual string Handle(Spese importo)
        {
            if (_nextHandler != null) //qualcuno può rispondere alla richiesta che viene inviata             
                return _nextHandler.Handle(importo);
            else
                return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}
