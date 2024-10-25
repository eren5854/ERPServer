using ED.Result;
using MediatR;

namespace ERPServer.Application.Features.Auth.Login;
public sealed record LoginCommand(
    string EmailOrUserName,
    string Password) : IRequest<Result<LoginCommandResponse>>;
