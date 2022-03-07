using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;


namespace backend.Models
{
      [Table("Zgrada")]
    public class Zgrada
    {
        [Key]
        public int ID { get; set; }

        public string SifraZgrade { get; set; }

        public virtual List<Stanar> StanariRef { get; set; }

        public virtual List<Stan> StanoviRef { get; set; }

        public virtual List<Sastanak> SastanciRef { get; set; }

        public virtual List<Poruka> Cet { get; set; }

        public virtual List<Predlog> PredloziRef { get; set; }

        public virtual List<StavkaOglasneTable> OglasnaTablaRef { get; set; }

        public virtual List<Obavestenje> ObavestenjaRef { get; set; }

    }
}