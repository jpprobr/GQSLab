using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GQSLab.Model
{
    public class Produto
    {
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1)]
        [Display(Name = "Descrição", Description = "Descrição do Produto.")]
        [Required(ErrorMessage = "Descrição é obrigatória.")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do nome são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos na descrição.")]
        public string Descricao { get; set; } 

        [Column(Order = 2)]
        [Display(Name = "Quantidade")]
        [DisplayFormat(DataFormatString = "{0:n2}", NullDisplayText = "Estoque vazio")]
        [Range(10, 25, ErrorMessage = "A Qtde deverá ser entre 10 e 25.")]
        [RegularExpression(@"^\d*[0-9]$", ErrorMessage = "Quantidade deve ser um valor inteiro")]
        public double Qtde { get; set; }
        
        [Column(Order = 3)]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Sem preço")]
        [Range(3, 500, ErrorMessage = "O preço deverá ser entre 3 e 500.")]
        [RegularExpression(@"^\d*[0-9](\,\d*[0-9])?$", ErrorMessage = "Preço deve ser um valor decimal")]
        public decimal Preco { get; set; }

        [Column(Order = 4)]
        [Display(Name = "Vencimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Data de Vencimento é obrigatória.")]
        public DateTime DataVencimento { get; set; }
    }
}