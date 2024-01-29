using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data.Configurations
{
    internal class BomConfigurations : IEntityTypeConfiguration<BOM>
    {
        public void Configure(EntityTypeBuilder<BOM> builder)
        {
            builder.Property(B => B.Id)
                .UseIdentityColumn(10, 10);
        }
    }
}
