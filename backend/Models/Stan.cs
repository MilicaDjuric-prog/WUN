using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace backend.Models
{
      [Table("Stan")]
    public class Stan
    {
        [Key]
        public int ID { get; set; }


        public int BrStana { get; set; }

        public int IznosDugovanja { get; set; }

        public virtual  List<Stanar> StanariRef { get; set; }

        public  virtual List<Racun> RacuniRef { get; set; }

        [JsonIgnore]
        public Zgrada ZgradaRef { get; set; }


    }
}