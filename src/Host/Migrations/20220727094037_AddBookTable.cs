using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garuda.Host.Migrations
{
    public partial class AddBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Author = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Cover = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("07e87c49-180f-4f00-99e2-7322c0638a2d"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2144142f-4fea-4e39-92c6-75097b01cd80"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2259be39-3027-4aaf-b7d4-6a5d7f196c0d"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("246857d8-d23b-4287-9e70-bd3101ec4df8"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("64f03301-c574-46c2-b1e6-2922eaaa826a"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6607d37e-dc2b-4ea8-8de5-32bbf7d1ccd3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6d8a282b-2728-4c07-a28f-93ac06977ef6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("702e4653-2abc-41f1-86f5-c1543ab7d585"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77b62aa0-5794-41fb-9005-a197c50385e0"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c5ab91a-5a1b-4b52-a643-ade5b42f862c"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("82ace0f9-6a4f-4a53-b524-306caf258b6d"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b4ab5dec-b541-4a99-b998-511d093207cd"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf5aa817-c923-40ea-9394-de0da2335866"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("db5c3fdc-6d75-42a5-97bb-2a0edfbfe45a"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e59e9251-d424-4ae1-b0c7-bdd01a4a1fee"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fd27fabc-218a-4163-89ee-469f38611af3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 794, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 781, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 781, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 781, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("049dde67-5798-4e74-8fff-503400311161"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08d3fe57-51f3-40d7-8cbc-75899871abf2"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("293f7746-eac8-4bd1-9550-87347467ebd2"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5026c85e-04f4-4d65-9fd2-bff26ad90013"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6906ffec-78d6-4631-977d-b0375351fb70"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77118193-d70c-4e36-97a0-683b9e825569"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77af2b15-1d76-489c-89b7-8f003d19acff"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7f2302be-efd5-43f1-b6c9-8e8886c8460c"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("806f809b-cdd3-4591-a553-085ac97037b9"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8f735cdf-bd01-4ae3-89c6-b122bdd59b8b"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9f54020e-85c1-46fb-9da3-c6150a3e327b"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d73f2bc0-8b65-46f2-9e06-9bd52e990283"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f0663ca2-ffb8-42c2-b022-38479c7c84af"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f1e6588e-ef55-4fcd-9be2-ad71fce2e678"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 778, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("045a0ec7-04e9-4136-b0a6-5ef1d529ea92"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 796, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("5db13726-605c-4a00-b1c4-d6ce3ba507b3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 796, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("77c9ef27-2f65-473e-8b61-ff4ce9693655"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 796, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 800, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 800, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 800, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5b11f06f-426b-44f1-9023-170cb85797e3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 800, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 800, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 800, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 800, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 992, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 992, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 992, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 992, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 992, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("ec211d37-2400-4877-8696-62ac17faeecb"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 992, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 992, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 992, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("00a5ad59-340c-45cb-b423-51aaab6d4ee8"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 998, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("25ec2241-215e-4d2f-890a-88bad0f4127a"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 998, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("43e29254-3301-4b3c-a53b-2eaddb5aa4c3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 998, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("57d4d61b-5814-4f7f-b00f-f5b5a1026908"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 998, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("8f536667-9dcb-4ec4-96a9-8397b0dbf2c6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 998, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("a3f3920a-6ac6-4774-9b73-ef58c346e0df"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 998, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("d280a08e-1090-4b71-8e7c-8dc391bddafc"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 998, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 802, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("784d69e6-abc3-47f9-9245-9527d6b2f17c"),
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2022, 7, 27, 16, 40, 31, 802, DateTimeKind.Local).AddTicks(3372), "$2a$11$/zvi3oaD3IZmKpyZLNusQuWib0H4Q4WY/pGSegEElgrEHb2jSS70a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81314787-537b-474f-999a-9152c9703bbb"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 802, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 802, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 802, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 16, 40, 31, 802, DateTimeKind.Local).AddTicks(3349));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("07e87c49-180f-4f00-99e2-7322c0638a2d"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2144142f-4fea-4e39-92c6-75097b01cd80"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2259be39-3027-4aaf-b7d4-6a5d7f196c0d"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("246857d8-d23b-4287-9e70-bd3101ec4df8"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("64f03301-c574-46c2-b1e6-2922eaaa826a"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6607d37e-dc2b-4ea8-8de5-32bbf7d1ccd3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6d8a282b-2728-4c07-a28f-93ac06977ef6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("702e4653-2abc-41f1-86f5-c1543ab7d585"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77b62aa0-5794-41fb-9005-a197c50385e0"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c5ab91a-5a1b-4b52-a643-ade5b42f862c"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("82ace0f9-6a4f-4a53-b524-306caf258b6d"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b4ab5dec-b541-4a99-b998-511d093207cd"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf5aa817-c923-40ea-9394-de0da2335866"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("db5c3fdc-6d75-42a5-97bb-2a0edfbfe45a"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e59e9251-d424-4ae1-b0c7-bdd01a4a1fee"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fd27fabc-218a-4163-89ee-469f38611af3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 504, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 497, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 497, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 497, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("049dde67-5798-4e74-8fff-503400311161"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08d3fe57-51f3-40d7-8cbc-75899871abf2"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("293f7746-eac8-4bd1-9550-87347467ebd2"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5026c85e-04f4-4d65-9fd2-bff26ad90013"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6906ffec-78d6-4631-977d-b0375351fb70"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77118193-d70c-4e36-97a0-683b9e825569"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77af2b15-1d76-489c-89b7-8f003d19acff"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7f2302be-efd5-43f1-b6c9-8e8886c8460c"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("806f809b-cdd3-4591-a553-085ac97037b9"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8f735cdf-bd01-4ae3-89c6-b122bdd59b8b"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9f54020e-85c1-46fb-9da3-c6150a3e327b"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d73f2bc0-8b65-46f2-9e06-9bd52e990283"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f0663ca2-ffb8-42c2-b022-38479c7c84af"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f1e6588e-ef55-4fcd-9be2-ad71fce2e678"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 496, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("045a0ec7-04e9-4136-b0a6-5ef1d529ea92"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 505, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("5db13726-605c-4a00-b1c4-d6ce3ba507b3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 505, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("77c9ef27-2f65-473e-8b61-ff4ce9693655"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 505, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 510, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 510, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 510, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5b11f06f-426b-44f1-9023-170cb85797e3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 510, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 510, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 510, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 510, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 697, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 697, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 697, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 697, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 697, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("ec211d37-2400-4877-8696-62ac17faeecb"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 697, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 697, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 697, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("00a5ad59-340c-45cb-b423-51aaab6d4ee8"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 703, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("25ec2241-215e-4d2f-890a-88bad0f4127a"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 703, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("43e29254-3301-4b3c-a53b-2eaddb5aa4c3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 703, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("57d4d61b-5814-4f7f-b00f-f5b5a1026908"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 703, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("8f536667-9dcb-4ec4-96a9-8397b0dbf2c6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 703, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("a3f3920a-6ac6-4774-9b73-ef58c346e0df"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 703, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("d280a08e-1090-4b71-8e7c-8dc391bddafc"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 703, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 514, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("784d69e6-abc3-47f9-9245-9527d6b2f17c"),
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2022, 7, 26, 15, 17, 32, 514, DateTimeKind.Local).AddTicks(158), "$2a$11$V.euh8IrN52sgej5Q7KZB.hSreXXCoyzETl2GfrAPZfi3ijhkSBbK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81314787-537b-474f-999a-9152c9703bbb"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 513, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 514, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 514, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 26, 15, 17, 32, 514, DateTimeKind.Local).AddTicks(124));
        }
    }
}
