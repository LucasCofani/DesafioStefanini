using DesafioStefanini.Client;
using DesafioStefanini.Client.Network;
using DesafioStefanini.Client.Service;
using DesafioStefanini.Shared.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var server = new Uri(builder.HostEnvironment.BaseAddress);
builder.Services.AddRefitClient<DesafioApi>(new RefitSettings(new NewtonsoftJsonContentSerializer()))
                .ConfigureHttpClient(c => c.BaseAddress = server);

builder.Services.AddScoped<ICidadeService, CidadeService>();
builder.Services.AddScoped<IPessoaService, PessoaService>();

await builder.Build().RunAsync();
