using FluentValidation;
using IntcomTestApp.Application.Locacoes.Commands;
using System;

namespace IntcomTestApp.Application.Locacoes.Validators
{
    public class UpdateLocacaoCommandValidator : AbstractValidator<UpdateLocacaoCommand>
    {
        public UpdateLocacaoCommandValidator()
        {
            RuleFor(l => l.Id).NotEmpty().WithMessage("Id de locação inválida.");
            RuleFor(l => l.ClienteId).NotEmpty().WithMessage("Id de cliente inválido.");
            RuleFor(l => l.FilmeId).NotEmpty().WithMessage("Id de filme inválido.");
            RuleFor(l => l.Ativa).NotNull().WithMessage("Valor do campo Ativa inválido. O campo deve ser booleano.");
        }
    }
}
