﻿// <auto-generated />
using System;
using AppRecrutement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AppRecrutement.Migrations.Project
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AppRecrutement.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Date_naissance")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Nb_annees_experience")
                        .HasColumnType("integer");

                    b.Property<string>("Niveau_etude")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("Pays")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Specialite")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("Ville")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("AppRecrutement.Models.Candidature", b =>
                {
                    b.Property<Guid>("CandidatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CandidatId")
                        .HasColumnType("text");

                    b.Property<Guid?>("CorrespondanceOffreID")
                        .HasColumnType("uuid");

                    b.Property<string>("Curriculum_Vitae")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Date_postulation")
                        .HasColumnType("text");

                    b.Property<int>("Etat")
                        .HasColumnType("integer");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.HasKey("CandidatureID");

                    b.HasIndex("CandidatId");

                    b.HasIndex("CorrespondanceOffreID");

                    b.ToTable("Candidatures");
                });

            modelBuilder.Entity("AppRecrutement.Models.Departement", b =>
                {
                    b.Property<Guid>("DepartementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Libelle")
                        .HasColumnType("text");

                    b.HasKey("DepartementID");

                    b.ToTable("Departements");
                });

            modelBuilder.Entity("AppRecrutement.Models.EntretienRH", b =>
                {
                    b.Property<Guid>("EntretienID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Date")
                        .HasColumnType("integer");

                    b.Property<string>("Destination")
                        .HasColumnType("text");

                    b.Property<string>("Duree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Equipe_recrutement")
                        .HasColumnType("text");

                    b.Property<int>("Heure")
                        .HasColumnType("integer");

                    b.Property<string>("Localisation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("RendezVousCandidatureID")
                        .HasColumnType("uuid");

                    b.Property<string>("Type_entretien")
                        .HasColumnType("text");

                    b.HasKey("EntretienID");

                    b.HasIndex("RendezVousCandidatureID");

                    b.ToTable("EntretienRHs");
                });

            modelBuilder.Entity("AppRecrutement.Models.Offre", b =>
                {
                    b.Property<Guid>("OffreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Competences_techniques")
                        .HasColumnType("text");

                    b.Property<string>("Date_debut")
                        .HasColumnType("text");

                    b.Property<Guid?>("DepartementsDepartementID")
                        .HasColumnType("uuid");

                    b.Property<string>("Diplome_demande")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Experience_demandee")
                        .HasColumnType("integer");

                    b.Property<string>("NomOffre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Qualites_interpersonnelles")
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type_contrat")
                        .HasColumnType("text");

                    b.Property<long>("salaire")
                        .HasColumnType("bigint");

                    b.HasKey("OffreID");

                    b.HasIndex("DepartementsDepartementID");

                    b.ToTable("Offres");
                });

            modelBuilder.Entity("AppRecrutement.Models.TestTechnique", b =>
                {
                    b.Property<Guid>("TestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Date_depot")
                        .HasColumnType("text");

                    b.Property<string>("Destination")
                        .HasColumnType("text");

                    b.Property<string>("Duree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TestCandidatureID")
                        .HasColumnType("uuid");

                    b.Property<string>("lien_test")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TestID");

                    b.HasIndex("TestCandidatureID");

                    b.ToTable("TestTechniques");
                });

            modelBuilder.Entity("AppRecrutement.Models.Candidature", b =>
                {
                    b.HasOne("AppRecrutement.Models.ApplicationUser", "Candidat")
                        .WithMany("Candidatures")
                        .HasForeignKey("CandidatId");

                    b.HasOne("AppRecrutement.Models.Offre", "Correspondance")
                        .WithMany("CandidaturesOffre")
                        .HasForeignKey("CorrespondanceOffreID");

                    b.Navigation("Candidat");

                    b.Navigation("Correspondance");
                });

            modelBuilder.Entity("AppRecrutement.Models.EntretienRH", b =>
                {
                    b.HasOne("AppRecrutement.Models.Candidature", "RendezVous")
                        .WithMany("EntretienRHs")
                        .HasForeignKey("RendezVousCandidatureID");

                    b.Navigation("RendezVous");
                });

            modelBuilder.Entity("AppRecrutement.Models.Offre", b =>
                {
                    b.HasOne("AppRecrutement.Models.Departement", "Departements")
                        .WithMany("Offres")
                        .HasForeignKey("DepartementsDepartementID");

                    b.Navigation("Departements");
                });

            modelBuilder.Entity("AppRecrutement.Models.TestTechnique", b =>
                {
                    b.HasOne("AppRecrutement.Models.Candidature", "Test")
                        .WithMany("Tests")
                        .HasForeignKey("TestCandidatureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("AppRecrutement.Models.ApplicationUser", b =>
                {
                    b.Navigation("Candidatures");
                });

            modelBuilder.Entity("AppRecrutement.Models.Candidature", b =>
                {
                    b.Navigation("EntretienRHs");

                    b.Navigation("Tests");
                });

            modelBuilder.Entity("AppRecrutement.Models.Departement", b =>
                {
                    b.Navigation("Offres");
                });

            modelBuilder.Entity("AppRecrutement.Models.Offre", b =>
                {
                    b.Navigation("CandidaturesOffre");
                });
#pragma warning restore 612, 618
        }
    }
}