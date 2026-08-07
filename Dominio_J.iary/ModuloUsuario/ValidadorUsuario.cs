using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_J.iary.ModuloUsuario
{
    public class ValidadorUsuario : AbstractValidator<Usuario>
    {
        public ValidadorUsuario()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("O campo 'Username' é obrigatório!")
                .NotNull().WithMessage("O campo 'Username' é obrigatório!")
                .Matches(@"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]*$").WithMessage("O campo 'Username' não aceita caracteres especiais e números!")
                .MinimumLength(4).WithMessage("O campo 'Username' deve ter no mínimo 4 (dois) caracteres!");

            RuleFor(x => x.Username)
              .NotEmpty().WithMessage("O campo 'Password' é obrigatório!")
              .NotNull().WithMessage("O campo 'Password' é obrigatório!")
              .MinimumLength(8).WithMessage("'Password' deve ter no mínimo 8 (oito) caracteres!");

            RuleFor(x => x.Email)
              .NotEmpty().WithMessage("O campo 'Email' é obrigatório!")
              .NotNull().WithMessage("O campo 'Email' é obrigatório!")
              .Matches(@"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]*$").WithMessage("O campo 'Username' não aceita caracteres especiais e números!")
              .MinimumLength(6).WithMessage("O campo 'Email' deve ter no mínimo 6 (seis) caracteres!");
        }
    }
}
