using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SpClima.Models;

[Table("Usuario")]
public class Usuario : IdentityUser
{
    [Required(ErrorMessage = "Por favor informe seu Nome")]
    [StringLength(60,ErrorMessage = "O nome deve possuior no máximo 60 caracteres")]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    public DateTime? DataNascimento { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
}
