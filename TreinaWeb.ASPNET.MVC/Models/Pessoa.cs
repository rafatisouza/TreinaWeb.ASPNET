using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreinaWeb.ASPNET.MVC.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Digite o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Digite a idade")]
        public int Idade { get; set; }
        [Display(Name  = "Endereço")]
        public string Endereco { get; set; }
        public DateTime Aniversario { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "E-mail obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage ="E-mail invalido")]
        public string Email { get; set; }

        public bool Ativo { get; set; }



    }
}