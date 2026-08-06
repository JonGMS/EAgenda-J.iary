using Dominio_J.iary.ModuloUsuario;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloTarefa
{
    public class ValidadorTarefa : AbstractValidator<Tarefa>
    {
        public ValidadorTarefa()
        {
            RuleFor(x => x.Titulo)
                .NotEmpty().WithMessage("O campo 'TITULO' é obrigatório!")
                .NotNull().WithMessage("O campo 'TITULO' é obrigatório!")
                .MinimumLength(3).WithMessage("O campo 'TITULO' deve ter no mínimo 3 (três) caracteres!");

            RuleFor(x => x.Descricao)
              .NotEmpty().WithMessage("O campo 'DESCRIÇÃO' é obrigatório!")
              .NotNull().WithMessage("O campo 'DESCRIÇÃO' é obrigatório!")
              .MinimumLength(8).WithMessage("'DESCRIÇÃO' deve ter no mínimo 8 (oito) caracteres!");

            RuleFor(x => x.Prioridade).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("O campo 'PRIORIDADE' é obrigatório!")
                .NotNull().WithMessage("O campo 'PRIORIDADE' é obrigatório!")
                .Must(p => p == 'B' || p == 'M' || p == 'A' || p == 'U').WithMessage("O campo 'Prioridade' deve ser BAIXA, MÉDIA, ALTA ou URGENTE!");


            RuleFor(x => x.Status).NotEmpty().WithMessage("O campo 'STATUS' é obrigatório!")
                .NotNull().WithMessage("O campo 'STATUS' é obrigatório!")
                .Must(p => p == 'A' || p == 'F' || p == 'C').WithMessage("O campo 'Prioridade' deve ser baixa, média, alta ou Urgente!");

            RuleFor(x => x.Armazenamento).NotEmpty().WithMessage("O campo 'ARMAZENAMENTO' é obrigatório!")
                .NotNull().WithMessage("O campo 'ARMAZENAMENTO' é obrigatório!")
                .Must(p => p == 'P' || p == 'C').WithMessage("O campo 'Prioridade' deve ser PADRÃO ou COFRE!");
        }
    }
}
