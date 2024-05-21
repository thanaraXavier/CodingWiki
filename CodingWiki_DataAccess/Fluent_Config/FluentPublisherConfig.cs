﻿using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingWiki_DataAccess.Fluent_Config
{
    public class FluentPublisherConfig : IEntityTypeConfiguration<Fluent_Publisher>
    {
        public void Configure(EntityTypeBuilder<Fluent_Publisher> modelBuilder)
        {
            // Fluent_Publisher
            modelBuilder.Property(u => u.Name).IsRequired();
            modelBuilder.HasKey(u => u.Publisher_Id);
        }
    }
}
