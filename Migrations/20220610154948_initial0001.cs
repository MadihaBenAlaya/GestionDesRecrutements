using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppRecrutement.Migrations
{
    public partial class initial0001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Languages",
                columns: table => new
                {
                    LanguageID = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Libelle = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "Offres",
                columns: table => new
                {
                    OffreID = table.Column<Guid>(type: "uuid", nullable: false),
                    NomOffre = table.Column<string>(type: "text", nullable: false),
                    Département = table.Column<string>(type: "text", nullable: false),
                    Pays = table.Column<string>(type: "text", nullable: false),
                    Région = table.Column<string>(type: "text", nullable: false),
                    Date_début = table.Column<string>(type: "text", nullable: true),
                    Activités_principales = table.Column<string>(type: "text", nullable: true),
                    Qualités_interpersonnelles = table.Column<string>(type: "text", nullable: true),
                    Compétences_techniques = table.Column<string>(type: "text", nullable: true),
                    Diplome_démandé = table.Column<string>(type: "text", nullable: false),
                    Experience_démandée = table.Column<string>(type: "text", nullable: false),
                    Niveau_démandé = table.Column<string>(type: "text", nullable: false),
                    salaire = table.Column<long>(type: "bigint", nullable: false),
                    Type_contrat = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offres", x => x.OffreID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Pays = table.Column<string>(type: "text", nullable: true),
                    Ville = table.Column<string>(type: "text", nullable: true),
                    Niveau_etude = table.Column<string>(type: "text", nullable: true),
                    Ecole = table.Column<string>(type: "text", nullable: true),
                    Spécialité = table.Column<string>(type: "text", nullable: true),
                    Situation_emploi_actuelle = table.Column<string>(type: "text", nullable: true),
                    Nb_années_expérience = table.Column<int>(type: "integer", nullable: false),
                    Date_naissance = table.Column<string>(type: "text", nullable: true),
                    Date_début_dispo = table.Column<string>(type: "text", nullable: true),
                    Score = table.Column<float>(type: "real", nullable: false),
                    DepartementsDepartementID = table.Column<Guid>(type: "uuid", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_ApplicationUser_Departements_DepartementsDepartementID",
                        column: x => x.DepartementsDepartementID,
                        principalTable: "Departements",
                        principalColumn: "DepartementID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntretienRHs",
                columns: table => new
                {
                    EntretienID = table.Column<Guid>(type: "uuid", nullable: false),
                    Equipe_recrutement = table.Column<string>(type: "text", nullable: true),
                    Localisation = table.Column<string>(type: "text", nullable: false),
                    Durée = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<int>(type: "integer", nullable: false),
                    Heure = table.Column<int>(type: "integer", nullable: false),
                    RendezVousOffreID = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntretienRHs", x => x.EntretienID);
                    table.ForeignKey(
                        name: "FK_EntretienRHs_Offres_RendezVousOffreID",
                        column: x => x.RendezVousOffreID,
                        principalTable: "Offres",
                        principalColumn: "OffreID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestTechniques",
                columns: table => new
                {
                    TestID = table.Column<Guid>(type: "uuid", nullable: false),
                    Destination = table.Column<string>(type: "text", nullable: true),
                    Date_dépot = table.Column<string>(type: "text", nullable: true),
                    Durée = table.Column<int>(type: "integer", nullable: false),
                    lien_test = table.Column<string>(type: "text", nullable: false),
                    OffreTestOffreID = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTechniques", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_TestTechniques_Offres_OffreTestOffreID",
                        column: x => x.OffreTestOffreID,
                        principalTable: "Offres",
                        principalColumn: "OffreID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidatures",
                columns: table => new
                {
                    CandidatureID = table.Column<Guid>(type: "uuid", nullable: false),
                    Date_postulation = table.Column<string>(type: "text", nullable: true),
                    Etat = table.Column<int>(type: "integer", nullable: false),
                    Motivation_poste = table.Column<string>(type: "text", nullable: false),
                    Questions = table.Column<string>(type: "text", nullable: true),
                    Curriculum_Vitae = table.Column<string>(type: "text", nullable: false),
                    Letrre_motivation = table.Column<string>(type: "text", nullable: false),
                    CandidatId = table.Column<string>(type: "text", nullable: true),
                    CorrespondanceOffreID = table.Column<Guid>(type: "uuid", nullable: true)
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
                        name: "FK_Candidatures_Offres_CorrespondanceOffreID",
                        column: x => x.CorrespondanceOffreID,
                        principalTable: "Offres",
                        principalColumn: "OffreID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NiveauMaitrises",
                columns: table => new
                {
                    UserFk = table.Column<string>(type: "text", nullable: false),
                    LangageFk = table.Column<Guid>(type: "uuid", nullable: false),
                    Mention = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NiveauMaitrises", x => new { x.UserFk, x.LangageFk });
                    table.ForeignKey(
                        name: "FK_NiveauMaitrises_ApplicationUser_UserFk",
                        column: x => x.UserFk,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NiveauMaitrises_Languages_LangageFk",
                        column: x => x.LangageFk,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_DepartementsDepartementID",
                table: "ApplicationUser",
                column: "DepartementsDepartementID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatures_CandidatId",
                table: "Candidatures",
                column: "CandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatures_CorrespondanceOffreID",
                table: "Candidatures",
                column: "CorrespondanceOffreID");

            migrationBuilder.CreateIndex(
                name: "IX_EntretienRHs_RendezVousOffreID",
                table: "EntretienRHs",
                column: "RendezVousOffreID");

            migrationBuilder.CreateIndex(
                name: "IX_NiveauMaitrises_LangageFk",
                table: "NiveauMaitrises",
                column: "LangageFk");

            migrationBuilder.CreateIndex(
                name: "IX_TestTechniques_OffreTestOffreID",
                table: "TestTechniques",
                column: "OffreTestOffreID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatures");

            migrationBuilder.DropTable(
                name: "EntretienRHs");

            migrationBuilder.DropTable(
                name: "NiveauMaitrises");

            migrationBuilder.DropTable(
                name: "TestTechniques");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Offres");

            migrationBuilder.DropTable(
                name: "Departements");
        }
    }
}
