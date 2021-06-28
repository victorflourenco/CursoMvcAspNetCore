using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'E-mail' é obrigatório!")]
        [EmailAddress(ErrorMessage = "O campo 'E-mail' é inválido!")]
        public string email { get; set; }
        [Required(ErrorMessage = "O campo 'Senha' é obrigatório!")]
        public string senha { get; set; }
    }
}
