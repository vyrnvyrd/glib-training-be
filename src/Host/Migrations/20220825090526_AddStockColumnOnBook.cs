using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garuda.Host.Migrations
{
    public partial class AddStockColumnOnBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("07e87c49-180f-4f00-99e2-7322c0638a2d"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2144142f-4fea-4e39-92c6-75097b01cd80"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2259be39-3027-4aaf-b7d4-6a5d7f196c0d"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("246857d8-d23b-4287-9e70-bd3101ec4df8"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("64f03301-c574-46c2-b1e6-2922eaaa826a"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6607d37e-dc2b-4ea8-8de5-32bbf7d1ccd3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6d8a282b-2728-4c07-a28f-93ac06977ef6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("702e4653-2abc-41f1-86f5-c1543ab7d585"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77b62aa0-5794-41fb-9005-a197c50385e0"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c5ab91a-5a1b-4b52-a643-ade5b42f862c"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("82ace0f9-6a4f-4a53-b524-306caf258b6d"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b4ab5dec-b541-4a99-b998-511d093207cd"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf5aa817-c923-40ea-9394-de0da2335866"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("db5c3fdc-6d75-42a5-97bb-2a0edfbfe45a"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e59e9251-d424-4ae1-b0c7-bdd01a4a1fee"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fd27fabc-218a-4163-89ee-469f38611af3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 32, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 28, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 28, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 28, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("049dde67-5798-4e74-8fff-503400311161"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08d3fe57-51f3-40d7-8cbc-75899871abf2"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("293f7746-eac8-4bd1-9550-87347467ebd2"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5026c85e-04f4-4d65-9fd2-bff26ad90013"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6906ffec-78d6-4631-977d-b0375351fb70"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77118193-d70c-4e36-97a0-683b9e825569"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77af2b15-1d76-489c-89b7-8f003d19acff"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7f2302be-efd5-43f1-b6c9-8e8886c8460c"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("806f809b-cdd3-4591-a553-085ac97037b9"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8f735cdf-bd01-4ae3-89c6-b122bdd59b8b"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9f54020e-85c1-46fb-9da3-c6150a3e327b"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d73f2bc0-8b65-46f2-9e06-9bd52e990283"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f0663ca2-ffb8-42c2-b022-38479c7c84af"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f1e6588e-ef55-4fcd-9be2-ad71fce2e678"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 26, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("045a0ec7-04e9-4136-b0a6-5ef1d529ea92"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 34, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("5db13726-605c-4a00-b1c4-d6ce3ba507b3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 34, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("77c9ef27-2f65-473e-8b61-ff4ce9693655"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 34, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 38, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 38, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 38, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5b11f06f-426b-44f1-9023-170cb85797e3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 38, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 38, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 38, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 38, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 234, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 234, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 234, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 234, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 234, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("ec211d37-2400-4877-8696-62ac17faeecb"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 234, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 234, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 234, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("00a5ad59-340c-45cb-b423-51aaab6d4ee8"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 241, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("25ec2241-215e-4d2f-890a-88bad0f4127a"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 241, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("43e29254-3301-4b3c-a53b-2eaddb5aa4c3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 241, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("57d4d61b-5814-4f7f-b00f-f5b5a1026908"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 241, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("8f536667-9dcb-4ec4-96a9-8397b0dbf2c6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 241, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("a3f3920a-6ac6-4774-9b73-ef58c346e0df"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 241, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("d280a08e-1090-4b71-8e7c-8dc391bddafc"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 241, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 42, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("784d69e6-abc3-47f9-9245-9527d6b2f17c"),
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2022, 8, 25, 16, 5, 22, 42, DateTimeKind.Local).AddTicks(2088), "$2a$11$wWampqhpcNIiX03kaXXMk.AU.UE13r/bbg5WRLachBFZ/o2AiY2I2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81314787-537b-474f-999a-9152c9703bbb"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 42, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 42, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 42, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 25, 16, 5, 22, 42, DateTimeKind.Local).AddTicks(1986));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("07e87c49-180f-4f00-99e2-7322c0638a2d"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2144142f-4fea-4e39-92c6-75097b01cd80"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2259be39-3027-4aaf-b7d4-6a5d7f196c0d"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("246857d8-d23b-4287-9e70-bd3101ec4df8"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("64f03301-c574-46c2-b1e6-2922eaaa826a"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6607d37e-dc2b-4ea8-8de5-32bbf7d1ccd3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6d8a282b-2728-4c07-a28f-93ac06977ef6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("702e4653-2abc-41f1-86f5-c1543ab7d585"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77b62aa0-5794-41fb-9005-a197c50385e0"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c5ab91a-5a1b-4b52-a643-ade5b42f862c"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("82ace0f9-6a4f-4a53-b524-306caf258b6d"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b4ab5dec-b541-4a99-b998-511d093207cd"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf5aa817-c923-40ea-9394-de0da2335866"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("db5c3fdc-6d75-42a5-97bb-2a0edfbfe45a"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e59e9251-d424-4ae1-b0c7-bdd01a4a1fee"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fd27fabc-218a-4163-89ee-469f38611af3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 405, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 381, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 381, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 381, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("049dde67-5798-4e74-8fff-503400311161"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08d3fe57-51f3-40d7-8cbc-75899871abf2"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("293f7746-eac8-4bd1-9550-87347467ebd2"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5026c85e-04f4-4d65-9fd2-bff26ad90013"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6906ffec-78d6-4631-977d-b0375351fb70"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77118193-d70c-4e36-97a0-683b9e825569"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77af2b15-1d76-489c-89b7-8f003d19acff"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7f2302be-efd5-43f1-b6c9-8e8886c8460c"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("806f809b-cdd3-4591-a553-085ac97037b9"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8f735cdf-bd01-4ae3-89c6-b122bdd59b8b"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9f54020e-85c1-46fb-9da3-c6150a3e327b"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d73f2bc0-8b65-46f2-9e06-9bd52e990283"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f0663ca2-ffb8-42c2-b022-38479c7c84af"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f1e6588e-ef55-4fcd-9be2-ad71fce2e678"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 352, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("045a0ec7-04e9-4136-b0a6-5ef1d529ea92"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 410, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("5db13726-605c-4a00-b1c4-d6ce3ba507b3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 410, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("77c9ef27-2f65-473e-8b61-ff4ce9693655"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 410, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 458, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 458, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 458, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5b11f06f-426b-44f1-9023-170cb85797e3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 458, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 458, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 458, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 458, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 250, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 250, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 250, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 250, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 248, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("ec211d37-2400-4877-8696-62ac17faeecb"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 250, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 250, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 250, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("00a5ad59-340c-45cb-b423-51aaab6d4ee8"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 267, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("25ec2241-215e-4d2f-890a-88bad0f4127a"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 267, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("43e29254-3301-4b3c-a53b-2eaddb5aa4c3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 267, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("57d4d61b-5814-4f7f-b00f-f5b5a1026908"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 267, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("8f536667-9dcb-4ec4-96a9-8397b0dbf2c6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 267, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("a3f3920a-6ac6-4774-9b73-ef58c346e0df"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 267, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("d280a08e-1090-4b71-8e7c-8dc391bddafc"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 27, 267, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 468, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("784d69e6-abc3-47f9-9245-9527d6b2f17c"),
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2022, 8, 24, 12, 56, 26, 468, DateTimeKind.Local).AddTicks(3977), "$2a$11$2AZbjrq/oZ6l9vv/OEnPXOoXwMYPktJvpL0EJPuzrqkGw5kYIbigC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81314787-537b-474f-999a-9152c9703bbb"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 468, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 468, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 468, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 12, 56, 26, 468, DateTimeKind.Local).AddTicks(3923));
        }
    }
}
