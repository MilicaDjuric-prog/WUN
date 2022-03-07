using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace backend.Models
{
      [Table("Sastanak")]
    public class Sastanak
    {
        [Key]
        public int ID { get; set; }


        public DateTime Vreme { get; set; }

        public string Mesto { get; set; }

        public string Povod { get; set; }

        public int BrZainteresovanih { get; set; }

        public int BrNezainteresovasnih { get; set; }

       

        [JsonIgnore]

        public Zgrada ZgradaRef { get; set; }

    }
}