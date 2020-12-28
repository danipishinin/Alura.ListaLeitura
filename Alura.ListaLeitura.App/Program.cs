using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Alura.ListaLeitura.App
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebHost host = new WebHostBuilder() //interface do nosso hospedeiro
                .UseKestrel() // indica que usaremos nesse host o servidor Kestrel
                .UseStartup<Startup>() // indicar a classe de inicialização do servidor web
                .Build(); //construir um hospedeiro web

            host.Run(); // disponibilizando o hospedeiro

            //ImprimeLista(_repo.ParaLer);
            //ImprimeLista(_repo.Lendo);
            //ImprimeLista(_repo.Lidos);
        }

        static void ImprimeLista(ListaDeLeitura lista)
        {
            Console.WriteLine(lista);
        }
    }
}
