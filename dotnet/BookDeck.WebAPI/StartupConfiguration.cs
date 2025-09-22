using BookDeck.DomainModule;
using BookDeck.WebAPI.EndpointMaps;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BookDeck.WebAPI;

public static class StartupConfiguration
{
    public static void SetupApplication(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<ConnectionStrings>(
            builder.Configuration.GetSection(nameof(ConnectionStrings)));
        builder.Services.AddOpenApi();
        builder.Services.AddSingleton<EndpointMapBase, BookEndpointMap>();
    }
    
}