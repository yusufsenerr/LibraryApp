using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using AracKiralamaOtomasyonu.Models.Context;

namespace AracKiralamaOtomasyonu.Models.Map
{
    public class FilesMap : EntityTypeConfiguration<Files>
    {
        public FilesMap()
        {
            this.ToTable("Files");
            this.Property(p => p.ID).HasColumnType("int");
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Url).HasColumnType("nvarchar").HasMaxLength(100);
            this.Property(p => p.Type).HasColumnType("nvarchar").HasMaxLength(30);
        }

    }
}