using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Piscine
    {
        [Key]
        public int NumPiscine { get; set; }
        public int PiscineId { get; set; }
        [Display(Name ="l adresse de la piscine est ")]
        public String AdressePiscine { get; set; }
        public String NomPiscine { get; set; }
       


        public virtual IList<Entrainement> Entrainements { get; set; }
    }
}
