using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PrimeiroProjetoMVC.Models
{
    public class Aluno
    {
        public int Id { get; set; }

    [StringLength(50, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e caracteres." )]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome{ get; set; } = string.Empty;
    [Required(ErrorMessage ="O Email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email {get; set;} = string.Empty;
        [Range(16,100, ErrorMessage = "Idade deve ser entre 16 e 100")]
        public int Idade {get; set;}
    }
}