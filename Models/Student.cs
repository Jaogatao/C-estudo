using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Antônio.Desktop.CrudTeste.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]

        public int Id {get; set;}

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter até 5 caracteres" )]
        [DisplayName("Nome Completo")]
        public string Name {get; set;} = string.Empty;

        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        [DisplayName("E-mail")]

        public string Email {get; set;} = string.Empty;
        public List<Premium> Premiums {get; set;} new();
    }
}