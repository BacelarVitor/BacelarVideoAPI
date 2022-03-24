using FluentValidation;
using IntcomTestApp.Application.Filmes.Commands;
using System;

namespace IntcomTestApp.Application.Filmes.Validators
{
    public class UpdateFilmeCommandValidator : AbstractValidator<UpdateFilmeCommand>
    {
        public UpdateFilmeCommandValidator()
        {
            RuleFor(f => f.Id).NotEmpty().WithMessage("Id de filme inválido.");
            RuleFor(f => f.Titulo).NotEmpty().WithMessage("Obrigatório preenchimento do Título.");
            RuleFor(f => f.Sinopse).NotEmpty().WithMessage("Obrigatório preenchimento da Sinopse.");
            RuleFor(f => f.Direcao).NotEmpty().WithMessage("Obrigatório preenchimento da Direção.");
            RuleFor(f => f.Capa).NotEmpty().WithMessage("Obrigatório preenchimento da Capa.");
            RuleFor(f => f.Generos).NotEmpty().WithMessage("Obrigatório preenchimento de Genêros.");
            RuleFor(f => f.Duracao).NotEmpty().WithMessage("Obrigatório preenchimento de Duração.");
            RuleFor(f => f.AnoLancamento).ExclusiveBetween(1895, Convert.ToInt32(DateTime.Today.Year)).WithMessage("Ano de lançamento não pode ser no futuro .");
        }
    }
}

