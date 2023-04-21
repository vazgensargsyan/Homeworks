﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApi2.Models;

#nullable disable

namespace TestApi2.Migrations
{
    [DbContext(typeof(VegaVestaNewContext))]
    partial class VegaVestaNewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestApi2.Models.VegaBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("VegaBrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__VegaBran__3214EC2734112A8F");

                    b.ToTable("VegaBrand", (string)null);
                });

            modelBuilder.Entity("TestApi2.Models.VegaCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("VegaDevice")
                        .HasColumnType("bit");

                    b.Property<bool?>("VegaFurniture")
                        .HasColumnType("bit");

                    b.Property<bool?>("VegaKitchen")
                        .HasColumnType("bit");

                    b.Property<string>("VegaObject")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__VegaCate__3214EC27067F376F");

                    b.ToTable("VegaCategory", (string)null);
                });

            modelBuilder.Entity("TestApi2.Models.VegaDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("VegaBrand")
                        .HasColumnType("int");

                    b.Property<int?>("VegaDiscountSize")
                        .HasColumnType("int");

                    b.Property<int?>("VegaObjectId")
                        .HasColumnType("int")
                        .HasColumnName("VegaObjectID");

                    b.Property<decimal>("VegaPrice")
                        .HasColumnType("money");

                    b.HasIndex("VegaBrand");

                    b.HasIndex("VegaObjectId");

                    b.ToTable("VegaDiscount", (string)null);
                });

            modelBuilder.Entity("TestApi2.Models.VegaDiscount", b =>
                {
                    b.HasOne("TestApi2.Models.VegaBrand", "VegaBrandNavigation")
                        .WithMany()
                        .HasForeignKey("VegaBrand")
                        .HasConstraintName("FK__VegaDisco__VegaB__286302EC");

                    b.HasOne("TestApi2.Models.VegaCategory", "VegaObject")
                        .WithMany()
                        .HasForeignKey("VegaObjectId")
                        .HasConstraintName("FK__VegaDisco__VegaO__276EDEB3");

                    b.Navigation("VegaBrandNavigation");

                    b.Navigation("VegaObject");
                });
#pragma warning restore 612, 618
        }
    }
}
