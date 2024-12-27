using CatalogoAPI.ApiEndpoints;
using CatalogoAPI.AppServicesExtensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.AddApiSwagger();
        builder.AddPersistence();
        builder.Services.AddCors();
        builder.AddAutenticationJwt();
    
        var app = builder.Build();
      
       app.MapAutenticacaoEndpoints();  
       app.MapCategoriasEndpoints();
       app.MapProdutosEndpoints();

        var environment = app.Environment;
        app.UserExceptionHandling(environment)
            .UseSwaggerMiddleware()
            .UseAppCors();

        app.UseAuthentication();
        app.UseAuthorization();

        app.Run();
    }
}