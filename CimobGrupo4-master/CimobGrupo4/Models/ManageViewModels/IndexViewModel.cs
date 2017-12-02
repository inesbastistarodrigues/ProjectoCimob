using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CimobGrupo4.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Phone]
        [Display(Name = "Numero De Telefone")]
        public string PhoneNumber { get; set; }


        [Display(Name = "País")]
        public string Pais { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public string StatusMessage { get; set; }
    }
}
