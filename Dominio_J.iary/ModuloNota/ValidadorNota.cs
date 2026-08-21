using Dominio_J.iary.ModuloTarefa;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloNota
{
    public class ValidadorNota : AbstractValidator<Nota>
    {
        public ValidadorNota()
        {
            RuleFor(x => x.Titulo).NotEmpty().WithMessage("O campo 'TITULO' é obrigatório")
                .NotNull().WithMessage("O campo 'TITULO' é obrigatório")
                .MinimumLength(3).WithMessage("O campo 'TITULO' deve ter o mínimo 3 (três) caracteres!");
            RuleFor(x => x.Categoria).NotEmpty().WithMessage("O campo 'CATEGORIA' é obrigatório")
                .NotNull().WithMessage("O campo 'CATEGORIA' é obrigatório");
            RuleFor(x => x.Armazenamento).NotEmpty().WithMessage("O campo 'ARMAZENAMENTO' é obrigatório!")
               .NotNull().WithMessage("O campo 'ARMAZENAMENTO' é obrigatório!")
               .Must(p => p == 'P' || p == 'C').WithMessage("O campo 'Prioridade' deve ser PADRÃO ou COFRE!");
        }
    }
}
