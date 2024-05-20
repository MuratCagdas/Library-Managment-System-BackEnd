using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("ef64bd4b-9642-4cf1-a8f0-2d6ad7b9606c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1aa20857-4596-4dbd-b36d-fb09eb34102a"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 388, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 389, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 391, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 391, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 391, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 391, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 391, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 391, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 392, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 393, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 393, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 393, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 393, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 16, 56, 20, 393, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 395, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 13, 56, 20, 396, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 10, 13, 56, 20, 399, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("cf4d0033-d20f-49d4-a742-6d6e90cca4fb"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 13, 231, 74, 201, 134, 196, 216, 42, 211, 133, 90, 198, 154, 195, 68, 158, 91, 112, 219, 29, 185, 134, 172, 115, 221, 65, 44, 240, 150, 44, 192, 98, 158, 111, 176, 192, 197, 147, 143, 85, 230, 150, 177, 149, 162, 36, 136, 131, 45, 93, 93, 7, 42, 100, 108, 187, 65, 196, 57, 7, 133, 122, 189, 57 }, new byte[] { 42, 96, 152, 67, 197, 147, 242, 5, 15, 46, 215, 102, 55, 215, 206, 109, 205, 26, 180, 228, 73, 7, 244, 57, 179, 194, 101, 194, 255, 108, 192, 255, 37, 40, 248, 96, 94, 14, 93, 211, 108, 217, 11, 40, 184, 69, 67, 28, 50, 231, 246, 0, 127, 103, 177, 20, 145, 20, 217, 61, 44, 137, 38, 19, 104, 155, 13, 243, 5, 97, 90, 119, 213, 116, 220, 147, 166, 134, 37, 91, 122, 198, 250, 11, 184, 214, 110, 251, 189, 80, 49, 138, 249, 103, 249, 122, 2, 227, 35, 160, 20, 123, 214, 38, 109, 161, 124, 255, 170, 214, 246, 115, 188, 25, 218, 160, 127, 112, 166, 162, 239, 62, 14, 235, 230, 237, 171, 85 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("0ac0a6cd-1c6f-4b22-b669-616287864fc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("cf4d0033-d20f-49d4-a742-6d6e90cca4fb") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("0ac0a6cd-1c6f-4b22-b669-616287864fc6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf4d0033-d20f-49d4-a742-6d6e90cca4fb"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 860, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 861, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 862, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 23, 34, 45, 862, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 863, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 14, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 4, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 9, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 6, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 20, 34, 45, 864, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 20, 34, 45, 865, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("1aa20857-4596-4dbd-b36d-fb09eb34102a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 85, 95, 176, 222, 123, 148, 210, 255, 196, 35, 146, 199, 39, 231, 235, 161, 85, 14, 44, 131, 128, 92, 167, 169, 101, 232, 55, 70, 25, 167, 223, 168, 163, 30, 142, 30, 99, 20, 124, 97, 37, 236, 118, 98, 106, 95, 135, 158, 199, 135, 129, 218, 98, 232, 95, 55, 147, 176, 90, 189, 75, 197, 87, 240 }, new byte[] { 34, 27, 90, 75, 125, 213, 50, 55, 39, 10, 102, 82, 167, 122, 184, 18, 164, 232, 106, 45, 235, 64, 5, 179, 16, 134, 250, 135, 185, 139, 68, 148, 57, 235, 143, 222, 185, 84, 124, 171, 4, 144, 177, 76, 9, 72, 106, 106, 132, 245, 164, 219, 148, 244, 221, 175, 150, 110, 4, 224, 135, 163, 8, 167, 71, 146, 180, 101, 164, 142, 158, 57, 134, 121, 132, 185, 162, 71, 194, 209, 89, 18, 102, 164, 120, 167, 238, 179, 189, 51, 70, 22, 49, 14, 93, 90, 39, 65, 84, 255, 147, 105, 180, 76, 229, 13, 33, 73, 253, 227, 106, 18, 243, 75, 242, 107, 100, 253, 124, 80, 94, 103, 32, 22, 73, 233, 212, 222 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("ef64bd4b-9642-4cf1-a8f0-2d6ad7b9606c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("1aa20857-4596-4dbd-b36d-fb09eb34102a") });
        }
    }
}
