using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure.Configuration
{
    public class PlanEntrainementConfiguration : IEntityTypeConfiguration<PlanEntrainement>
    {
        public void Configure(EntityTypeBuilder<PlanEntrainement> builder)
        {
            builder.HasOne(l => l.Athlete).WithMany(r => r.PlanEntrainements)
                .HasForeignKey(r => r.NumLicenseFk);
            builder.HasOne(l => l.Entrainement).WithMany(r => r.PlanEntrainements)
                .HasForeignKey(r => r.NumEntrainementFk);
            builder.HasKey(r => new
            {
                r.NumEntrainementFk,
                r.NumLicenseFk,
                r.IdPlanEntrainement
            });
        }
    }
}
