using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using AracKiralamaOtomasyonu.Models.Context;

namespace AracKiralamaOtomasyonu.Models.Map
{
    public class BooksMap : EntityTypeConfiguration<Books>
    {
        public BooksMap()
        {
            this.ToTable("Books");
            this.Property(p => p.ID).HasColumnType("int");
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.IDWritter).HasColumnType("int");
            this.Property(p => p.Title).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(p => p.Text).HasColumnType("nvarchar").HasMaxLength(250);
            this.Property(p => p.CoverPhoto).HasColumnType("nvarchar").HasMaxLength(250);
        }

    }
}