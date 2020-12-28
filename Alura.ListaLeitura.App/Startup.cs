
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.ListaLeitura.App
{

    /* A classe Startup é usada para realizar a inicialização do servidor, mais especificamente no seu método Configure()*/
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            /*disponibiliza o serviço de roteamento padrão do Asp.Net Core no servidor*/
            services.AddRouting();
            services.AddMvc();
        }
        /* O método Configure é usado para especificar como o aplicativo responde às solicitações HTTP. */
        /* O tipo que é utilizado para definir o fluxo requisição-resposta da aplicação é a interface IApplicationBuilder. */
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
        }

        
    }
}