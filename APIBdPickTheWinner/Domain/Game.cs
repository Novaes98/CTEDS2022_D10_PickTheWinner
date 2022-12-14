using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBdPickTheWinner.Domain
{
    [Table("Games")]
    public class Game
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGame { get; set; }

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
        public string Name { get; set; } = string.Empty;

        [ForeignKey("IdUser")]
        public User IdUser { get; set; }

        [Column(TypeName = "INTEGER")]
        [Required(ErrorMessage = "O nome do jogo é obrigatório!")]
        public int TotalGamePoints { get; set; }
    }

}
