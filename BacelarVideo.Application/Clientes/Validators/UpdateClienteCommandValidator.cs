using FluentValidation;
using IntcomTestApp.Application.Clientes.Commands;

namespace IntcomTestApp.Application.Clientes.Validators
{
    public class UpdateClienteCommandValidator : AbstractValidator<UpdateClienteCommand>
    {
        public UpdateClienteCommandValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("Id de Cliente inválido.");
            RuleFor(c => c.Nome).NotEmpty().WithMessage("Obrigatório preenchimento do Nome.");
            RuleFor(c => c.Email).NotEmpty().WithMessage("Obrigatório preenchimento do E-mail.");
            RuleFor(c => c.Senha).NotEmpty().WithMessage("Obrigatório preenchimento da Senha.");
        }
    }
}
