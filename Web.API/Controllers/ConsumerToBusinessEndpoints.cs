using Application.ConsumerToBusiness.Commands;
using Carter;
using Mapster;
using MediatR;
using Web.API.Models;

namespace Web.API.Controllers
{
    //https://www.youtube.com/watch?v=gsAuFIhXz3g

    public class ConsumerToBusinessEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/c2b");

            group.MapPost("", ProcessConsumerToBusiness);
        }

        public static async Task<IResult> ProcessConsumerToBusiness(
        ConsumerToBusinessRequest consumerToBusinessRequest,
        ISender sender,CancellationToken cancellationToken)
        {
            var command = consumerToBusinessRequest.Adapt<CreateConsumerToBusinessCommand>();
            var response = await sender.Send(command, cancellationToken);
            return Results.Ok(response);
        }
    }
}
