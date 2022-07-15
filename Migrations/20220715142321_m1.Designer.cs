﻿// <auto-generated />
using System;
using AppRecrutement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AppRecrutement.Migrations
{
    [DbContext(typeof(AuthenticationContext))]
    [Migration("20220715142321_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AppRecrutement.Models.Candidature", b =>
                {
                    b.Property<Guid>("CandidatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CandidatFK")
                        .HasColumnType("text");

                    b.Property<string>("Curriculum_Vitae")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Date_postulation")
                        .HasColumnType("text");

                    b.Property<string>("Etat")
                        .HasColumnType("text");

                    b.Property<Guid>("OffreFK")
                        .HasColumnType("uuid");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.HasKey("CandidatureID");

                    b.HasIndex("CandidatFK");

                    b.HasIndex("OffreFK");

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

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("text");

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

                    b.Property<string>("departement")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AppRecrutement.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Date_naissance")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<int>("Nb_annees_experience")
                        .HasColumnType("integer");

                    b.Property<string>("Niveau_etude")
                        .HasColumnType("text");

                    b.Property<string>("Pays")
                        .HasColumnType("text");

                    b.Property<string>("Specialite")
                        .HasColumnType("text");

                    b.Property<string>("Ville")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("AppRecrutement.Models.Candidature", b =>
                {
                    b.HasOne("AppRecrutement.Models.ApplicationUser", "Candidat")
                        .WithMany("Candidatures")
                        .HasForeignKey("CandidatFK");

                    b.HasOne("AppRecrutement.Models.Offre", "Correspondance")
                        .WithMany("CandidaturesOffre")
                        .HasForeignKey("OffreFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("AppRecrutement.Models.ApplicationUser", b =>
                {
                    b.Navigation("Candidatures");
                });
#pragma warning restore 612, 618
        }
    }
}