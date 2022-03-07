using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace backend.Models
{
    [Table("Stanar")]
    public class Stanar
    {
        [Key]
        public int ID { get; set; }

        public string Email { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string Password { get; set; }

        public int BrStana { get; set; }

        public int BrSprata { get; set; }

        public string Status { get; set; }

        public string Jmbg { get; set; }

        public string BrojTelefona { get; set; }

       

        [JsonIgnore]
        public  Stan StanRef { get; set; }

        [JsonIgnore]
        public  Zgrada ZgradaRef { get; set; }

       

    }
}