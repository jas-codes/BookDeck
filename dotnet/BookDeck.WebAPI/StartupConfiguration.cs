using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BookDeck.WebAPI;

public static class StartupConfiguration
{
    public static void SetupApplication(this WebApplicationBuilder builder)
    { 
        builder.Services.AddOpenApi();
    }
    
}