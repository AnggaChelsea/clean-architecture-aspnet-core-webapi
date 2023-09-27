using MediatR;

namespace SystemSchoolV1.Application.Common.Interface.Authentication.Commands.Login;

public record LoginQueriesCommands(string Email, string Password): IRequest<AuthentiactionResult>;