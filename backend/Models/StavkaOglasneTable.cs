using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Text.Json.Serialization;


namespace backend.Models
{
      [Table("StavkaOglasneTable")]
    public class StavkaOglasneTable
    {
        [Key]

        public int ID { get; set; }

        public string Tekst { get; set; }

        public DateTime Vreme { get; set; }

        public Stanar Autor { get; set; }

        [JsonIgnore]
        public Zgrada ZgradaRef { get; set; }

    }
}