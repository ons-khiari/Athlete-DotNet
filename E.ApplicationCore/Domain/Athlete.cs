using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public enum CathegoryAthelete
    {
        Benjamin,
        Cadet,
        Junior,
        Senior,
        Veteran
    }
    public class Athlete
    {
        [Key]
        public int NumeroLicenece { get; set; }
        public String Adresse { get; set; }
        public DateTime DateNaissance { get; set; }
        public String NomAthlete { get; set; }
        
        public String PrenomAthelete { get; set; }
        [Required]
        public CathegoryAthelete CathegoryAthelete { get; set; }
        public virtual IList<PlanEntrainement> PlanEntrainements { get; set; }

    }
}
