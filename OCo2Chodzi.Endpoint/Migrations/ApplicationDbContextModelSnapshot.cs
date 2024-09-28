﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using OCo2Chodzi.Service.Infrastructure;

#nullable disable

namespace OCo2Chodzi.Endpoint.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Oco2Chodzi.Models.Absorbions.AbsorbionArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AbsorbionDefinitionId")
                        .HasColumnType("int");

                    b.Property<int>("AbsorbionGroupId")
                        .HasColumnType("int");

                    b.Property<Polygon>("Area")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.Property<decimal>("AverageDensityPerSquareMeter")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("AbsorbionDefinitionId");

                    b.HasIndex("AbsorbionGroupId");

                    b.ToTable("AbsorbionArea");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Absorbions.AbsorbionDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AbsorbionKilogramsPerGrowingSeason")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AgeYears")
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("GrowingSeasonWeeks")
                        .HasColumnType("int");

                    b.Property<int>("HeightMeters")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AbsorbionDefinition");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Absorbions.AbsorbionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("AbsorbionGroup");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Absorbions.PredefinedAbsorbionRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AbsorbionType")
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Absorbions");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Emissions.EmissionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("EmissionGroups");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Emissions.LinearEmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("EmissionPerKm")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("LinearEmissions");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Emissions.MassEmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("EmissionPerKilo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("MassEmissions");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Emissions.SingularEmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Emission")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("SingularEmissions");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Absorbions.AbsorbionArea", b =>
                {
                    b.HasOne("Oco2Chodzi.Models.Absorbions.AbsorbionDefinition", "AbsorbionDefinition")
                        .WithMany()
                        .HasForeignKey("AbsorbionDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oco2Chodzi.Models.Absorbions.AbsorbionGroup", "AbsorbionGroup")
                        .WithMany("AbsorbionAreas")
                        .HasForeignKey("AbsorbionGroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AbsorbionDefinition");

                    b.Navigation("AbsorbionGroup");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Emissions.MassEmission", b =>
                {
                    b.HasOne("Oco2Chodzi.Models.Emissions.EmissionGroup", "Group")
                        .WithMany("MassEmissions")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Emissions.SingularEmission", b =>
                {
                    b.HasOne("Oco2Chodzi.Models.Emissions.EmissionGroup", "Group")
                        .WithMany("SingularEmissions")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Absorbions.AbsorbionGroup", b =>
                {
                    b.Navigation("AbsorbionAreas");
                });

            modelBuilder.Entity("Oco2Chodzi.Models.Emissions.EmissionGroup", b =>
                {
                    b.Navigation("MassEmissions");

                    b.Navigation("SingularEmissions");
                });
#pragma warning restore 612, 618
        }
    }
}
