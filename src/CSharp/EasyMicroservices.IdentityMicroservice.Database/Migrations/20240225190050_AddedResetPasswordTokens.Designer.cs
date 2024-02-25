﻿// <auto-generated />
using System;
using EasyMicroservices.IdentityMicroservice.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyMicroservices.IdentityMicroservice.Migrations
{
    [DbContext(typeof(IdentityContext))]
    [Migration("20240225190050_AddedResetPasswordTokens")]
    partial class AddedResetPasswordTokens
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EasyMicroservices.IdentityMicroservice.Database.Entities.ResetPasswordTokenEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasConsumed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("ResetPasswordToken");
                });
#pragma warning restore 612, 618
        }
    }
}
