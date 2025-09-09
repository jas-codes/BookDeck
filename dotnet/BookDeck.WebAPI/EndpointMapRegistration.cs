using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BookDeck.WebAPI;

public static class EndpointMapRegistration
{
    public static void MapEndpoints(this WebApplication app)
    {
        foreach (var endpoints in app.Services.GetServices<EndpointMapBase>())
        {
            endpoints.Map(app);
        }
    } 
}