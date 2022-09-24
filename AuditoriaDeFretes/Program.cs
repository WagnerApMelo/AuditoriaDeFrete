// See https://aka.ms/new-console-template for more information
using AuditoriaDeFretes;


var _repo = new RepositorioTabela();

ImprimeLista(_repo.Imprimir);


static void ImprimeLista(ListaTabela lista)
{
    Console.WriteLine(lista);
    Console.ReadLine();

}

