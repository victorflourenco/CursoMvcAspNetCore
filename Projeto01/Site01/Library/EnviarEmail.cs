using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Site01.Library
{
    public class EnviarEmail
    {
        public static void EnviarEmailContato(Contato contato)
        {
            string conteudo = string.Format("Nome {0}<br /> Email {1}<br /> Assunto {2}<br /> Mensagem {3}", contato.nome, contato.email, contato.assunto, contato.mensagem);

            MailMessage mail = new MailMessage();
            //Cria o Remetente (administrador do sistema)
            string remetente = "victor.flourenco@outlook.com";
            string destinatario = "victor.flourenco@outlook.com";
            //define os endereços
            mail.From = new MailAddress(destinatario);
            mail.To.Add(destinatario);
            //define o conteúdo
            mail.Subject = "Curso de .NET CORE MVC";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;//colocando msg no padrao utf8
            mail.IsBodyHtml = true;
            mail.Body = "<h1>Dados do Formulário</h1> " + conteudo;
            //Credenciais para acesso ao E-mail
            //smtp para hotmail, pois utilizei o hotmail para enviar a mensagem
            SmtpClient smtp = new SmtpClient("SMTP.office365.com");
            //Recursos adicionais para o envio da mensagem
            smtp.EnableSsl = true;
            smtp.Port = 587;//aqui foi onde resolvi a questão
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;

            //Autenticação
            smtp.Credentials = new NetworkCredential(remetente, "ghavive02");

            //envia a mensagem
            smtp.Send(mail);

        }
    }
}
