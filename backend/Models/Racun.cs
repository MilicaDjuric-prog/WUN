using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace backend.Models
{
      [Table("Racun")]
    public class Racun
    {
        [Key]
        public int ID { get; set; }

        public string Mesec { get; set; }

        public int Godina {get; set;}

        public DateTime DatumPlacanja {get; set;}

        public int Iznos { get; set; }

        public string  Status { get; set; }
        [JsonIgnore]
        public Stan StanRef { get; set; }

    }
}