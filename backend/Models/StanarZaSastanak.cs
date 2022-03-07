using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    [Table("StanarZaSastanak")]
    public class StanarZaSastanak
    {
        [Key]
        public int ID { get; set; }

        public int StanarId { get; set; }

        public int SastanakId { get; set; }

        
    }
}