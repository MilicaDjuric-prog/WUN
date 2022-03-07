using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace backend.Models
{
    public class NotifikacijeStanara
    {
        [Key]
        public int ID { get; set; }

        public bool NotifikacijaOglasna { get; set; }

        public bool NotifikacijaObavestenja { get; set; }

        public bool NotifikacijaCet { get; set; }

        public bool NotifikacijaPredlozi { get; set; }

        public bool NotifikacijaSastanci { get; set; }

        public bool NotifikacijaTroskovi {get; set;}
       
        public int IdStanara { get; set; }


    }
}