using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpClima.Models;

[Table("Produto_foto")]
public class ProdutoFoto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Produto")]
    public int ProdutoId { get; set; }


    [ForeignKey(nameof(ProdutoId))]
    public Produto Produto { get; set; }

    [Required]
    [StringLength(300)]
    [Display(Name = "Arquivo da foto")]
    public string ArquivoFoto { get; set; }

    [StringLength(30, ErrorMessage = "A Descrição deve possuir no máximo 30 caractere")]
    public string Descrição { get; set; }
}
