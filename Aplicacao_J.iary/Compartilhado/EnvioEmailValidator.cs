using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_J.iary.Compartilhado
{
    internal class EnvioEmailValidator
    {
        private readonly string _smtpHost;
        private readonly int _smtpPort;
        private readonly string _smtpUser;
        private readonly string _smtpPassword;

        public EnvioEmailValidator(string smtpHost, int smtpPort, string smtpUser, string smtpPassword)
        {
            _smtpHost = smtpHost;
            _smtpPort = smtpPort;
            _smtpUser = smtpUser;
            _smtpPassword = smtpPassword;
        }


        public bool ValidarEmail(string email)
        {
            try
            {
                var endereco = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void EnviarEmail(string destinatario, string assunto, string mensagem)
        {
            if (!ValidarEmail(destinatario))
                throw new ArgumentException("E-mail inválido.");

            using (var client = new SmtpClient(_smtpHost, _smtpPort))
            {
                client.Credentials = new NetworkCredential(_smtpUser, _smtpPassword);
                client.EnableSsl = true; // depende do servidor SMTP

                var mail = new MailMessage(_smtpUser, destinatario, assunto, mensagem);
                client.Send(mail);
            }
        }


//        var emailValidator = new EnvioEmailValidator(
//    smtpHost: "smtp.seuprovedor.com",
//    smtpPort: 587,
//    smtpUser: "seuemail@dominio.com",
//    smtpPassword: "suasenha"
//);

//        emailValidator.EnviarEmail("destinatario@teste.com", "Assunto Teste", "Mensagem de teste");

    }
}
