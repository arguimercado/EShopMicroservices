using FluentResults;
using MediatR;

namespace BuildingBlocks.CQRS
{
    internal interface IQuery<TResponse> : IRequest<Result<TResponse>>
        where TResponse : notnull
    {
    }
}
