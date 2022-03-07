using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace backend.Models
{
      [Table("Predlog")]
    public class Predlog
    {
        [Key]
        public int ID { get; set; }

        public string Naslov { get; set; }

        public string Opis { get; set; }

        public int BrZa { get; set; }

        public int BrProtiv { get; set; }

        public DateTime DatumObjave { get; set; }

        public int idAutora { get; set; }

        //[ForeignKey("StanariZa")]
       // public virtual List<Stanar> StanariZa { get; set; }

       // [ForeignKey("StanariProtiv")]

        //public virtual List<Stanar> StanariProtiv { get; set; }
        
        [JsonIgnore]
        public Zgrada ZgradaRef { get; set; }

    }
}