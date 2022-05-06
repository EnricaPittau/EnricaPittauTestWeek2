// See https://aka.ms/new-console-template for more information
using TestWeek2EnricaPittau;
using TestWeek2EnricaPittau.Chain;
using TestWeek2EnricaPittau.Handler;

Console.WriteLine("Gestione spese!");
Console.WriteLine("Visualizza le spese inserite.");

List<Spese> listaFile = RepositorySpeseFile.GetAll();



//IRepository<Spese> repoSpese = new RepositorySpeseFile();


//var listaRecuperata = repoSpese.GetAll();
var listaRecuperata = RepositorySpeseFile.GetAll();
if (listaRecuperata.Count == 0)
{
    Console.WriteLine("Lista vuota");
}
else
{
    Console.WriteLine("Ecco l'elenco delle spese: ");
    foreach (var r in listaRecuperata)
    {
        Console.WriteLine(r.InfoSpesa());
    }
}



IHandler manager = new Manager();
IHandler operationalManager = new OperationalManager();
IHandler ceo = new Ceo();


//stabilisco l'ordine in cui verrà gestita la richiesta dall'inizio alla fine
manager.SetNext(operationalManager).SetNext(ceo);

foreach (var item in listaRecuperata)
{
    if (item.Importo > 2500)
    {
        Console.WriteLine("Spesa non approvata");
    }
    else 
    {
        Console.WriteLine("Spesa approvata");
    }

}

