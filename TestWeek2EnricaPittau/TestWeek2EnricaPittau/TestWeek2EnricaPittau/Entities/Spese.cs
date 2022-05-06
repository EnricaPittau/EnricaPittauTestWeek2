using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2EnricaPittau
{
    public class Spese
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public double Importo { get; set; }
        public Spese()
        {

        }
        public Spese(DateTime data, string categoria, string descrizione, double importo)
        {
            Data = data;
            Categoria = categoria;  
            Descrizione = descrizione;  
            Importo = importo; 
        }
        public string InfoSpesa()
        {
            return $"Data spesa: {Data} - Categoria: {Categoria} - Descrizione: {Descrizione} - Importo: {Importo}";
        }
    }
}
