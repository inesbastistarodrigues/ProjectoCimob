using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CimobGrupo4.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve conter no minimo 2 caracteres.", MinimumLength = 2)]
        [Display(Name = "Nome")]
        public string Nome{ get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve conter no minimo 2 caracteres.", MinimumLength = 2)]
        [Display(Name = "Apelido")]
        public string Apelido { get; set; }

        [Required]
        [Display(Name = "Numero De Aluno")]
        public int NumeroAluno { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }



        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Palavra Passe")]
        public string PalavraPasse { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Palavra Passe")]
        [Compare("PalavraPasse", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmarPalavraPasse { get; set; }


    }
}
