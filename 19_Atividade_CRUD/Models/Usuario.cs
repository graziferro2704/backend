using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _19_Atividade_CRUD.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome do usuário")]
        public string Nome { get; set; }
        [Display(Name = "Imagem do usuário")]
        public string? Imagem { get; set; }
        [Required(ErrorMessage = "Login é obrigatório")]
        [Display(Name = "Login do usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha é obrigatório")]
        [Display(Name = "Senha do usuário")]
        public string Senha { get; set; }
    }
}