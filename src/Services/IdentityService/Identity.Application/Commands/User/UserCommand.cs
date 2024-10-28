using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Commands.User
{
    public record UserCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "Reqired")]
        public required string Name { get; set; }
    }
}
