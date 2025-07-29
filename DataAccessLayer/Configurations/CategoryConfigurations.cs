using BusinessLogic.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> cat)
        {
            cat.ToTable("Categories", schema: "MasterSchema");

            cat.HasKey(c => c.id);

            cat.Property(c => c.catName).IsRequired().HasMaxLength(50);

            cat.Property(c => c.catOrder).IsRequired();

            cat.Ignore(c => c.createdDate);

            cat.Property(c => c.markedAsDeleted).HasColumnName("isDeleted");

            //indexing

            cat.HasIndex(c => c.catName);

        }
    }
}
