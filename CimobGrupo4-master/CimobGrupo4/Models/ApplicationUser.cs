using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CimobGrupo4.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
       
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int NumeroAluno { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento;
        public string PalavraPasse { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Descricao { get; set; }

    }
}
