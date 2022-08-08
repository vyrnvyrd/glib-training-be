using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garuda.Host.Migrations
{
    public partial class AddColumnForCustomerInfoInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PrivacyPolicy",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("07e87c49-180f-4f00-99e2-7322c0638a2d"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2144142f-4fea-4e39-92c6-75097b01cd80"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2259be39-3027-4aaf-b7d4-6a5d7f196c0d"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("246857d8-d23b-4287-9e70-bd3101ec4df8"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("64f03301-c574-46c2-b1e6-2922eaaa826a"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6607d37e-dc2b-4ea8-8de5-32bbf7d1ccd3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6d8a282b-2728-4c07-a28f-93ac06977ef6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("702e4653-2abc-41f1-86f5-c1543ab7d585"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77b62aa0-5794-41fb-9005-a197c50385e0"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c5ab91a-5a1b-4b52-a643-ade5b42f862c"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("82ace0f9-6a4f-4a53-b524-306caf258b6d"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b4ab5dec-b541-4a99-b998-511d093207cd"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf5aa817-c923-40ea-9394-de0da2335866"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("db5c3fdc-6d75-42a5-97bb-2a0edfbfe45a"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e59e9251-d424-4ae1-b0c7-bdd01a4a1fee"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fd27fabc-218a-4163-89ee-469f38611af3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 518, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 510, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 510, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 510, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("049dde67-5798-4e74-8fff-503400311161"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08d3fe57-51f3-40d7-8cbc-75899871abf2"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("293f7746-eac8-4bd1-9550-87347467ebd2"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5026c85e-04f4-4d65-9fd2-bff26ad90013"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6906ffec-78d6-4631-977d-b0375351fb70"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77118193-d70c-4e36-97a0-683b9e825569"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77af2b15-1d76-489c-89b7-8f003d19acff"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7f2302be-efd5-43f1-b6c9-8e8886c8460c"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("806f809b-cdd3-4591-a553-085ac97037b9"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8f735cdf-bd01-4ae3-89c6-b122bdd59b8b"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 507, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9f54020e-85c1-46fb-9da3-c6150a3e327b"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d73f2bc0-8b65-46f2-9e06-9bd52e990283"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f0663ca2-ffb8-42c2-b022-38479c7c84af"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f1e6588e-ef55-4fcd-9be2-ad71fce2e678"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 508, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("045a0ec7-04e9-4136-b0a6-5ef1d529ea92"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 519, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("5db13726-605c-4a00-b1c4-d6ce3ba507b3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 519, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("77c9ef27-2f65-473e-8b61-ff4ce9693655"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 519, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 522, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 522, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 522, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5b11f06f-426b-44f1-9023-170cb85797e3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 522, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 522, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 522, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 522, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 714, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 714, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 714, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 714, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 714, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("ec211d37-2400-4877-8696-62ac17faeecb"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 714, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 714, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 714, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("00a5ad59-340c-45cb-b423-51aaab6d4ee8"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 720, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("25ec2241-215e-4d2f-890a-88bad0f4127a"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 720, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("43e29254-3301-4b3c-a53b-2eaddb5aa4c3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 720, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("57d4d61b-5814-4f7f-b00f-f5b5a1026908"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 720, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("8f536667-9dcb-4ec4-96a9-8397b0dbf2c6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 720, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("a3f3920a-6ac6-4774-9b73-ef58c346e0df"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 720, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("d280a08e-1090-4b71-8e7c-8dc391bddafc"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 720, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 524, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("784d69e6-abc3-47f9-9245-9527d6b2f17c"),
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2022, 8, 8, 10, 4, 17, 524, DateTimeKind.Local).AddTicks(7218), "$2a$11$SVWK9pHVWC25oLXYClLeh.KB4KS4KdyrvYwqNOn8XAMQqRl7NXgm." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81314787-537b-474f-999a-9152c9703bbb"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 524, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 524, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 524, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                column: "CreatedDate",
                value: new DateTime(2022, 8, 8, 10, 4, 17, 524, DateTimeKind.Local).AddTicks(7198));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PrivacyPolicy",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("07e87c49-180f-4f00-99e2-7322c0638a2d"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2144142f-4fea-4e39-92c6-75097b01cd80"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2259be39-3027-4aaf-b7d4-6a5d7f196c0d"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("246857d8-d23b-4287-9e70-bd3101ec4df8"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("64f03301-c574-46c2-b1e6-2922eaaa826a"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6607d37e-dc2b-4ea8-8de5-32bbf7d1ccd3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("6d8a282b-2728-4c07-a28f-93ac06977ef6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("702e4653-2abc-41f1-86f5-c1543ab7d585"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("77b62aa0-5794-41fb-9005-a197c50385e0"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7c5ab91a-5a1b-4b52-a643-ade5b42f862c"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("82ace0f9-6a4f-4a53-b524-306caf258b6d"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b4ab5dec-b541-4a99-b998-511d093207cd"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cf5aa817-c923-40ea-9394-de0da2335866"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("db5c3fdc-6d75-42a5-97bb-2a0edfbfe45a"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e59e9251-d424-4ae1-b0c7-bdd01a4a1fee"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "GroupMenuPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fd27fabc-218a-4163-89ee-469f38611af3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 489, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1ce881eb-4ae2-4b04-83d9-7062e6cfffd5"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 481, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9ee09365-b140-4bc0-a5a1-79098ddbeed7"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 481, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa997ce4-5b76-447c-9b08-5f448f185ad3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 481, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("049dde67-5798-4e74-8fff-503400311161"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08d3fe57-51f3-40d7-8cbc-75899871abf2"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("293f7746-eac8-4bd1-9550-87347467ebd2"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5026c85e-04f4-4d65-9fd2-bff26ad90013"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6906ffec-78d6-4631-977d-b0375351fb70"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77118193-d70c-4e36-97a0-683b9e825569"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("77af2b15-1d76-489c-89b7-8f003d19acff"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7f2302be-efd5-43f1-b6c9-8e8886c8460c"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("806f809b-cdd3-4591-a553-085ac97037b9"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8f735cdf-bd01-4ae3-89c6-b122bdd59b8b"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9f54020e-85c1-46fb-9da3-c6150a3e327b"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d73f2bc0-8b65-46f2-9e06-9bd52e990283"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f0663ca2-ffb8-42c2-b022-38479c7c84af"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f1e6588e-ef55-4fcd-9be2-ad71fce2e678"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 477, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("045a0ec7-04e9-4136-b0a6-5ef1d529ea92"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 490, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("5db13726-605c-4a00-b1c4-d6ce3ba507b3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 490, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Schemes",
                keyColumn: "Id",
                keyValue: new Guid("77c9ef27-2f65-473e-8b61-ff4ce9693655"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 490, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("21cf75f0-c7c6-427b-a392-fce59cb50bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 493, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("23ebbe54-45aa-4435-935d-6fad0d650b86"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 493, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("29ec8ffc-c508-4dd5-8c3d-4675ed6af4cc"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 493, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5b11f06f-426b-44f1-9023-170cb85797e3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 493, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("80f560d6-1f61-460e-95ac-ea5b9c001df5"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 493, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("af82ee9b-e754-4cb5-ae58-213419183dcf"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 493, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("b1f30d87-b5a6-4fdb-9f72-76f06db7f7a5"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 493, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("10195c34-4e6d-4795-bbde-bbd17e2c1b0b"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 675, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("145e7f39-120c-4cdd-baac-fbbd74b72a69"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 675, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("4b894dac-7e06-4891-8498-6521ba85dcac"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 675, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("d050c114-fc5f-45c8-a736-b0cacdfc47e6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 675, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("e5c455f1-f239-4f29-bebd-8bc4239e15fb"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 675, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("ec211d37-2400-4877-8696-62ac17faeecb"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 675, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("f1a56c59-0128-4799-826d-50ce44921cb6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 675, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("fe9b8375-2bab-4449-88a1-efe80155054e"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 675, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("00a5ad59-340c-45cb-b423-51aaab6d4ee8"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 683, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("25ec2241-215e-4d2f-890a-88bad0f4127a"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 683, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("43e29254-3301-4b3c-a53b-2eaddb5aa4c3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 683, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("57d4d61b-5814-4f7f-b00f-f5b5a1026908"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 683, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("8f536667-9dcb-4ec4-96a9-8397b0dbf2c6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 683, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("a3f3920a-6ac6-4774-9b73-ef58c346e0df"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 683, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "UserUnits",
                keyColumn: "Id",
                keyValue: new Guid("d280a08e-1090-4b71-8e7c-8dc391bddafc"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 683, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2446aa92-3c84-4072-8c5e-d8c41deac9c4"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 495, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("784d69e6-abc3-47f9-9245-9527d6b2f17c"),
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2022, 7, 28, 15, 37, 59, 495, DateTimeKind.Local).AddTicks(9723), "$2a$11$V1APmPM.FUL1QoiGgjskNeRF3aNT1iMGst6ep7rW5BlNW6.ZklBXi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81314787-537b-474f-999a-9152c9703bbb"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 495, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b3c44cb-244b-4f13-b2a0-22020ae26bc6"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 495, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5a93e5d-e159-4c69-b90d-ae3239a692d3"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 495, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa3876d9-b8ce-4029-9df6-2e8ee94a3d78"),
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 15, 37, 59, 495, DateTimeKind.Local).AddTicks(9697));
        }
    }
}
