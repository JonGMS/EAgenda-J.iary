using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloCategoria
{
    public class ValidadorCategoria : AbstractValidator<Categoria>
    {
        public ValidadorCategoria()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O campo 'NOME' é obrigatório!")
                .NotNull().WithMessage("O campo 'NOME' é obrigatório!")
                .MinimumLength(3).WithMessage("O campo 'NOME' deve ter no mínimo 3 (três) caracteres!");

            RuleFor(x => x.Cor)
              .NotEmpty().WithMessage("O campo 'COR' é obrigatório!")
              .NotNull().WithMessage("O campo 'COR' é obrigatório!");

        }
    }
}
