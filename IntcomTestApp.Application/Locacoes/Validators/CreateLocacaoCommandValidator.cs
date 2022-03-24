using FluentValidation;
using IntcomTestApp.Application.Locacoes.Commands;

namespace IntcomTestApp.Application.Locacoes.Validators
{
    public class CreateLocacaoCommandValidator : AbstractValidator<CreateLocacaoCommand>
    {
        public CreateLocacaoCommandValidator()
        {
            RuleFor(l => l.ClienteId).NotEmpty().WithMessage("Id de cliente inválido.");
            RuleFor(l => l.FilmeId).NotEmpty().WithMessage("Id de filme inválido.");
            RuleFor(l => l.Ativa).NotNull().WithMessage("Valor do campo Ativa inválido. O campo deve ser booleano.");
        }
    }
}
