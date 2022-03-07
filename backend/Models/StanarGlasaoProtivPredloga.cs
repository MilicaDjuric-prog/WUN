using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    [Table("StanarGlasaoProtivPredloga")]
    public class StanarGlasaoProtivPredloga
    {
        [Key]
        public int ID { get; set; }

        public int StanarId { get; set; }

        public int PredlogId { get; set; }

        
    }
}