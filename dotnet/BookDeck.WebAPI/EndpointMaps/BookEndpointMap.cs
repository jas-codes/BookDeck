using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookDeck.WebAPI.EndpointMaps;

public class BookEndpointMap : EndpointMapBase
{
    public override void Map(WebApplication app)
    {
        app.MapGet("/Books", GetBooks).WithName("Get All Books");
    }
    
    [HttpGet]
    private IResult GetBooks()
    {
        return Results.Ok();
    } 
}