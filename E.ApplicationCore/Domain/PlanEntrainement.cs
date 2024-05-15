using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class PlanEntrainement
    {
        public int IdPlanEntrainement { get; set; }
        [Required]
        [Range(0, int.MaxValue)]    
        public int DistanceParcours { get; set; }
        public virtual Athlete Athlete  { get; set; }
        public virtual Entrainement Entrainement { get; set; }

        public int NumLicenseFk { get; set; }
        public int NumEntrainementFk { get; set; }
    }
}
