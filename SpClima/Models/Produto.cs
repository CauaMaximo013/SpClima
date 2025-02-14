using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mysqlx;

namespace SpClima.Models;

[Table("produto")]
public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Categoria")]
    public int CategoriaId { get; set; }

    [ForeignKey(nameof(CategoriaId))]
    public Categoria Categoria { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir o máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição", Prompt = "Descrição")]
    [StringLength(1000, ErrorMessage = "a Descrição deve possuir o máximo 1000 caracteres")]
    public string Descricao { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Qtde { get; set; } = 0;

    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")] 
    public decimal ValorCusto { get; set; } = 0;

    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")] 
    public decimal ValorVenda { get; set; } 
}