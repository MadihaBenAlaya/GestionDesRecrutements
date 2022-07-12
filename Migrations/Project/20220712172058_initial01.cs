using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRecrutement.Migrations.Project
{
    public partial class initial01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Pays = table.Column<string>(type: "text", nullable: true),
                    Ville = table.Column<string>(type: "text", nullable: true),
                    Niveau_etude = table.Column<string>(type: "text", nullable: true),
                    Specialite = table.Column<string>(type: "text", nullable: true),
                    Nb_annees_experience = table.Column<int>(type: "integer", nullable: false),
                    Date_naissance = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departements",
                columns: table => new
                {
                    DepartementID = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Libelle = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departements", x => x.DepartementID);
                });

            migrationBuilder.CreateTable(
                name: "Offres",
                columns: table => new
                {
                    OffreID = table.Column<Guid>(type: "uuid", nullable: false),
                    NomOffre = table.Column<string>(type: "text", nullable: false),
                    Pays = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false),
                    Date_debut = table.Column<string>(type: "text", nullable: true),
                    Qualites_interpersonnelles = table.Column<string>(type: "text", nullable: true),
                    Competences_techniques = table.Column<string>(type: "text", nullable: true),
                    Diplome_demande = table.Column<string>(type: "text", nullable: false),
                    Experience_demandee = table.Column<int>(type: "integer", nullable: false),
                    salaire = table.Column<long>(type: "bigint", nullable: false),
                    Type_contrat = table.Column<string>(type: "text", nullable: true),
                    departement = table.Column<string>(type: "text", nullable: true),
                    DepartementsDepartementID = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offres", x => x.OffreID);
                    table.ForeignKey(
                        name: "FK_Offres_Departements_DepartementsDepartementID",
                        column: x => x.DepartementsDepartementID,
                        principalTable: "Departements",
                        principalColumn: "DepartementID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidatures",
                columns: table => new
                {
                    CandidatureID = table.Column<Guid>(type: "uuid", nullable: false),
                    Date_postulation = table.Column<string>(type: "text", nullable: true),
                    Etat = table.Column<string>(type: "text", nullable: true),
                    Curriculum_Vitae = table.Column<string>(type: "text", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false),
                    OffreFK = table.Column<Guid>(type: "uuid", nullable: false),
                    CandidatId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatures", x => x.CandidatureID);
                    table.ForeignKey(
                        name: "FK_Candidatures_ApplicationUser_CandidatId",
                        column: x => x.CandidatId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatures_Offres_OffreFK",
                        column: x => x.OffreFK,
                        principalTable: "Offres",
                        principalColumn: "OffreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntretienRHs",
                columns: table => new
                {
                    EntretienID = table.Column<Guid>(type: "uuid", nullable: false),
                    Destination = table.Column<string>(type: "text", nullable: true),
                    Equipe_recrutement = table.Column<string>(type: "text", nullable: true),
                    Type_entretien = table.Column<string>(type: "text", nullable: true),
                    Localisation = table.Column<string>(type: "text", nullable: false),
                    Duree = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: false),
                    Heure = table.Column<int>(type: "integer", nullable: false),
                    RendezVousCandidatureID = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntretienRHs", x => x.EntretienID);
                    table.ForeignKey(
                        name: "FK_EntretienRHs_Candidatures_RendezVousCandidatureID",
                        column: x => x.RendezVousCandidatureID,
                        principalTable: "Candidatures",
                        principalColumn: "CandidatureID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestTechniques",
                columns: table => new
                {
                    TestID = table.Column<Guid>(type: "uuid", nullable: false),
                    Destination = table.Column<string>(type: "text", nullable: true),
                    Date_depot = table.Column<string>(type: "text", nullable: true),
                    Duree = table.Column<string>(type: "text", nullable: false),
                    lien_test = table.Column<string>(type: "text", nullable: false),
                    TestCandidatureID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTechniques", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_TestTechniques_Candidatures_TestCandidatureID",
                        column: x => x.TestCandidatureID,
                        principalTable: "Candidatures",
                        principalColumn: "CandidatureID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatures_CandidatId",
                table: "Candidatures",
                column: "CandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatures_OffreFK",
                table: "Candidatures",
                column: "OffreFK");

            migrationBuilder.CreateIndex(
                name: "IX_EntretienRHs_RendezVousCandidatureID",
                table: "EntretienRHs",
                column: "RendezVousCandidatureID");

            migrationBuilder.CreateIndex(
                name: "IX_Offres_DepartementsDepartementID",
                table: "Offres",
                column: "DepartementsDepartementID");

            migrationBuilder.CreateIndex(
                name: "IX_TestTechniques_TestCandidatureID",
                table: "TestTechniques",
                column: "TestCandidatureID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntretienRHs");

            migrationBuilder.DropTable(
                name: "TestTechniques");

            migrationBuilder.DropTable(
                name: "Candidatures");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "Offres");

            migrationBuilder.DropTable(
                name: "Departements");
        }
    }
}
