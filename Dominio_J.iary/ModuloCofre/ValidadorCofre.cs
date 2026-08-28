using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloCofre
{
    public class ValidadorCofre : AbstractValidator<Cofre>
    {
        public ValidadorCofre()
        {
            RuleFor(x => x.Senha).NotEmpty().WithMessage("O campo 'SENHA' é obrigatório")
            .NotNull().WithMessage("O campo 'SENHA' é obrigatório")
            .MinimumLength(8).WithMessage("O campo 'SENHA' deve ter o mínimo 8 (oito) caracteres!");
        }
    }
}
