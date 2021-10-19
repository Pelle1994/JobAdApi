using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceHeroWebApi.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobAds",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    headline = table.Column<string>(nullable: true),
                    publication_date = table.Column<DateTime>(nullable: false),
                    descriptionText = table.Column<string>(nullable: true),
                    duration_concept_id = table.Column<string>(nullable: true),
                    duration_label = table.Column<string>(nullable: true),
                    workingHoursType_label = table.Column<string>(nullable: true),
                    employer_organization_number = table.Column<string>(nullable: true),
                    employer_name = table.Column<string>(nullable: true),
                    employer_workplace = table.Column<string>(nullable: true),
                    applicationDetails_email = table.Column<string>(nullable: true),
                    applicationDetails_url = table.Column<string>(nullable: true),
                    occupation_concept_id = table.Column<string>(nullable: true),
                    occupation_label = table.Column<string>(nullable: true),
                    occupationGroup_concept_id = table.Column<string>(nullable: true),
                    occupationGroup_label = table.Column<string>(nullable: true),
                    workplaceAddress_street_address = table.Column<string>(nullable: true),
                    workplaceAddress_postcode = table.Column<string>(nullable: true),
                    workplaceAddress_city = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAds", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobAds");
        }
    }
}
