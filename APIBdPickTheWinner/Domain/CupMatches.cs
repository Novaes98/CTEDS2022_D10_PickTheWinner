using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBdPickTheWinner.Domain
{
    [Table("Matches")]
    public class CupMatch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMatch { get; set; }

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O campo de seleção deve ser preenchido!")]
        public string FirstCountry { get; set; } = string.Empty;

        [Column(TypeName = "INTEGER")]
        [Required(ErrorMessage = "A quantidade de gols deve ser preenchida!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "A senha deve conter entre 5 e 30 caracteres.")]
        public int FirstCountryScore { get; set; }

        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "O campo de seleção deve ser preenchido!")]
        public string SecondCountry { get; set; } = string.Empty;

        [Column(TypeName = "INTEGER")]
        [Required(ErrorMessage = "A quantidade de gols deve ser preenchida!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "A senha deve conter entre 5 e 30 caracteres.")]
        public int SecondCountryScore { get; set; }

    }
}
