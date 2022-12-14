using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBdPickTheWinner.Domain
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O nome do usuário é obrigatório!")]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O e-mail do usuário é obrigatório!")]
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "A senha deve conter entre 5 e 30 caracteres.")]
        public string Password { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "A senha deve conter entre 5 e 30 caracteres.")]
        public string FavoriteCountry { get; set; } = string.Empty;
    }
}
