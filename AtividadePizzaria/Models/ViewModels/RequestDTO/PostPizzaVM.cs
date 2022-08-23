using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePizzaria.Models.ViewModels.RequestDTO
{
    public class PostPizzaVM
    {

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Nome é obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O Preço é obrigatório!")]
        public decimal Preco { get; set; }

        [Display(Name = "Imagem")]
        [Required(ErrorMessage = "A imagem é obrigatóra!")]
        public string FotoURL { get; set; }

        [Display(Name = "Informe os Sabores")]
        [Required(ErrorMessage = "Sabores é Obrigatório")]
        public List<int> SaboresId { get; set; }


        [Display(Name = "Informe o Tamanho")]
        [Required(ErrorMessage = "Tamanho é Obrigatório")]
        public int TamanhoId { get; set; }

    }
}
