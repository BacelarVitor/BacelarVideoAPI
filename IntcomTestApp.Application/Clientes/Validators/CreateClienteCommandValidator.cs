using FluentValidation;
using IntcomTestApp.Application.Clientes.Commands;

namespace IntcomTestApp.Application.Clientes.Validators
{
    public class CreateClienteCommandValidator : AbstractValidator<CreateClienteCommand>
    {
        public CreateClienteCommandValidator()
        {
            RuleFor(c => c.Nome).NotEmpty().WithMessage("Obrigatório preenchimento do Nome.");
            RuleFor(c => c.Email).NotEmpty().EmailAddress().WithMessage("Obrigatório preenchimento de um E-mail válido.");
            RuleFor(c => c.Senha).NotEmpty().WithMessage("Obrigatório preenchimento da Senha.");
        }
    }
}
