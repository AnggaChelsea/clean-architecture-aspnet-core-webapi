using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace SystemSchoolV1.Application.Common.Interface.Authentication.Commands.Register
{
    public record RegisterCommand(
        string FirsName,
        string LasName,
        string Email,
        string Password): IRequest<AuthentiactionResult>;
        }