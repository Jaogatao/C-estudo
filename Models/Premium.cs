using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Antônio.Desktop.CrudTeste
{
    public class Premium
    {
       [Key]
       [DisplayName("Id")]
       public int Id {get; set; }
       
       [Required{ErrorMessage = "Informe o título do Premium"}]
       [StringLength(80, ErrorMessage = "O título deve conter 80 caracteres")]
       [MinLength(5, ErrorMessage = "O título deve conter no mínimo 5 caracteres")]
       [DisplayName = ("Título")]
       
       public string title ={get; set; } = string.Empty;

       [Datatype(Datatype.DateTime)]
      // [Greaterthantoday]
       [DisplayName("Ínicio")]
        public DateTime StartDate {get; set; }

        [Datatype(Datatype.DateTime)]
        [DisplayName("Término")]
        public DateTime EndDate {get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno Inválido")]
        public int StudentId {get; set; }

        public Student? Student {get; set; }

    }
}