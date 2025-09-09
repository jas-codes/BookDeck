using Microsoft.AspNetCore.Builder;

namespace BookDeck.WebAPI;

public abstract class EndpointMapBase
{
    public abstract void Map(WebApplication app);
}