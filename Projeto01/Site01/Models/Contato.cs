using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Contato
    {
        [Required(ErrorMessage = "O campo 'Nome' é Obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo 'Nome' deve contar o máximo de 50 caracteres!")]
        public string nome     { get; set; }
        [Required(ErrorMessage = "O campo 'email' é Obrigatório!")]
        [MaxLength(70, ErrorMessage = "O campo 'E-mail' deve contar o máximo de 70 caracteres!")]
        [EmailAddress(ErrorMessage  = "O campo 'Email' é inválido!")]
        public string email    { get; set; }
        [Required(ErrorMessage =      "Campo 'assunto' é Obrigatório!")]
        [MaxLength(70, ErrorMessage = "O campo 'Assunto' deve contar o máximo de 70 caracteres!")]
        public string assunto  { get; set; }
        [Required(ErrorMessage = "Campo 'mensagem' é Obrigatório!")]
        [MaxLength(2000, ErrorMessage = "O campo 'Mensagem' deve contar o máximo de 2000 caracteres!")]
        public string mensagem { get; set; }
    }
}
