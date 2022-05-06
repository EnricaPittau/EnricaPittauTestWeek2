using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2EnricaPittau
{
    public class RepositorySpeseFile
    {   
        public static List<Spese> GetAll()
        {
            string path = @"C:\Users\enrica.pittau\Desktop\TestWeek2EnricaPittau\TestWeek2EnricaPittau\TestWeek2EnricaPittau\Spese.txt";

            List<Spese> spese = new List<Spese>();
            using (StreamReader sr = new StreamReader(path))
            {
                string contenutoFile = sr.ReadToEnd();

                if (string.IsNullOrEmpty(contenutoFile))
                {
                    return spese;
                }
                else
                {
                    var righeDelFile = contenutoFile.Split("\r\n");
                    for (int i = 0; i < righeDelFile.Length - 1; i++)
                    {
                        var campiDellaRiga = righeDelFile[i].Split(",");
                        Spese r = new Spese();
                        r.Data = DateTime.Parse(campiDellaRiga[0]);
                        r.Categoria = campiDellaRiga[1];
                        r.Descrizione = campiDellaRiga[2];
                        r.Importo = double.Parse(campiDellaRiga[3]);
                        spese.Add(r);
                    }
                }
                return spese;
            }
        }
    }
}
