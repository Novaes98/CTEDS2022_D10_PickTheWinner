using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBdPickTheWinner.Domain
{
    [Table("UsersMatches")]
    public class UserMatches
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUserMatches { get; set; }

        [ForeignKey("IdUser")]
        public User IdUser { get; set; }

        [ForeignKey("IdMatch")]
        public CupMatch IdMatch { get; set; }

        [Column(TypeName = "INTEGER")]
        public string FirstCountryScore_User { get; set; } = string.Empty;

        [Column(TypeName = "INTEGER")]
        public string SecondCountryScore_User { get; set; } = string.Empty;
    }
}
