using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormNewProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedreclamations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Defauts",
                keyColumn: "Id",
                keyValue: new Guid("cb663965-79bc-416d-887c-bb179b217e26"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("78610462-3bab-4cf2-83ff-489f31e80671"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("86aa310e-a6df-46db-9fe6-27a35d86e95c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("aeed1f2d-03e6-4232-be6d-3c3c0fe0eafe"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b28c00bb-811c-41da-8e07-db16a6ec1626"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c671b314-47f9-4e4f-aeac-a46d35c9cf4d"));

            migrationBuilder.InsertData(
                table: "Reclamations",
                columns: new[] { "Id", "Chaine", "Num_Paquet", "OF", "Operation", "Operatrice", "Opn_Id" },
                values: new object[,]
                {
                    { new Guid("00194635-a943-4683-849b-2cca087ecdce"), "GHNP", 66, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("0034524d-d3cf-4c3f-9fe0-547c395a3ea9"), "SM CL", 30, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("00a69d2e-3b6e-4705-a85e-3bdcd80cf115"), "GHNP", 31, "23A1E2330526", "SORTIE PRODUCTION", "AZZA MONTAGE", 5999 },
                    { new Guid("00f3e4fd-4ecf-42c7-af9e-8183115d0134"), "GHNP", 10, "1715C720448", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("013e0244-7c7d-483f-a2f3-e7c8215a12fc"), "GHNP", 18, "17X15C319448", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("0144ec8f-f2fb-4755-99c7-13e8a2362fa0"), "SM STOCK", 27, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("016edaca-e87e-463f-8fb4-94bdd549a8f3"), "SM AUDIT", 6, "2412X63088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("026619fe-1560-46df-be01-571d19081b6c"), "GHNP", 40, "2412X72088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("02a16567-fc63-4740-ae09-2bb3b1d1b689"), "SM AUDIT", 9, "22X1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("03035563-0e9c-480d-9a04-1ccd08df5d47"), "SM CL", 21, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("031bdbce-32d7-499d-99ce-4953db4f90c3"), "GHNP", 3, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("036be02e-8063-4124-8d9a-2cd60b8a884e"), "SM CL", 22, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("039ebc4b-74af-4d57-b835-46d9d58d019f"), "SM CL", 10, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("03ba292e-1faf-4e54-abe2-c24ed62686b9"), "SM STOCK", 30, "181E2710346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("0430fe44-03f4-4a25-b0a2-c7c7b80a3263"), "GHNP", 16, "22Y1E2319346", "SORTIE PRODUCTION", "THOURAYA MONTAGE", 5999 },
                    { new Guid("050cf0b6-a9b7-4d5f-a1e8-d236ded51eb9"), "SM AUDIT", 53, "23A1E2330526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("053068c2-f078-4b48-b8ef-36cdc7922a48"), "SM COL", 1, "08Y131343406", "ENGAGEMENT", "COLLECTION  SIMOTEX", 1999 },
                    { new Guid("055c8fdb-1961-4ab7-a517-78f3f7628aeb"), "GHNP", 11, "26Y12X33011", "ENGAGEMENT", "WAFA MONTAGE", 1999 },
                    { new Guid("05d1c595-1cfa-4594-b739-d6a7a988bd26"), "SM CL", 11, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("05e39e1b-95a8-4952-b2c3-666af3ca54b9"), "GHNP", 34, "23B1E2330526", "RECEPTION QUALITE", "AZZA MONTAGE", 9090 },
                    { new Guid("06157af9-80a8-4832-ae36-ceaead63f04a"), "SM AUDIT", 20, "23X1E2330526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("06371176-54ec-4423-be07-8137aab79bed"), "SM AUDIT", 96, "1612X630088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("0678a092-3d56-48e9-afb6-55b790cf2615"), "SG 3", 4, "17X15C319448", "MONTAGE GORGE", "MANSRI RADHIA", 2140 },
                    { new Guid("06805421-7218-45e4-8da9-9f79b0a5f26f"), "SM STOCK", 10, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("0718af5f-bad7-4acc-9731-61f3e103fa72"), "GHNP", 27, "26X12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("0767ddc7-0d79-4290-b300-be302aeca10d"), "GHNP", 36, "23X1E2330526", "SORTIE PRODUCTION", "WAFA MONTAGE", 5999 },
                    { new Guid("07d5b2cc-c746-4492-90f1-b62ce271c636"), "GHNP", 60, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("080a1707-4813-4f16-9766-46d8840b61dc"), "SM CL", 44, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("0853383a-8f5e-4936-bc8b-b58023e22d59"), "SM AUDIT", 34, "23X1E2330346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("096aedad-f4c6-4156-ba79-e17768348fc3"), "SM AUDIT", 44, "20X1E533015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("09b18dab-8983-4f8d-9e73-30c1f95160df"), "GHNP", 28, "20Y1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("09e18ecc-5387-49e4-a5ef-4c8a023be0c9"), "SM STOCK", 64, "211E5720612", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("0aa4a53e-4f37-4c07-87e6-901bb344250b"), "SG 1", 6, "2612X320709", "MONTAGE GORGE", "HAMRAOUI CHAIMA", 2140 },
                    { new Guid("0ab40c47-c62f-4a44-9f1e-a246c2f915db"), "SM STOCK", 38, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("0ad6eb6f-c212-4d25-8e1b-d66cd392573d"), "SM AUDIT", 8, "23Y1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("0aea82a6-b4a2-479b-886b-128d6240ada9"), "GHNP", 11, "20Y1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("0b357b7b-146e-46ec-8f9d-aa130519b13e"), "SM STOCK", 51, "181E2630346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("0b697801-95d2-4297-91e8-5e72154a7f69"), "GHNP", 13, "23X1E2330526", "SORTIE PRODUCTION", "WAFA MONTAGE", 5999 },
                    { new Guid("0b6e2a5e-00db-49ff-9d2e-74d44c3aafc1"), "GHNP", 20, "2412X63088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("0b7e895e-e203-437a-809f-5e875a5024a9"), "SM AUDIT", 39, "23Y1E2330526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("0ba0fe2a-5156-4ea6-93b9-ca5a41aa984f"), "SM STOCK", 96, "1612X630088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("0ba300ec-a612-49f5-a81d-aab310590ab6"), "SM CL", 3, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("0ba67db3-bf90-4244-b1f8-42bc7d43ae85"), "GHNP", 41, "20X1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("0bb8a1c6-00f6-41fb-a6eb-4f513c441e85"), "SM CL", 15, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("0c7a3e17-69c2-4ce1-ae53-dc24219edb9a"), "GHNP", 4, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("0c939ccb-f9d5-46b0-8450-4ed06e91f9b8"), "SM STOCK", 35, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("0ca4e062-c07e-4f08-953f-fcd93a9d5f98"), "GHNP", 13, "22Y1E2319346", "RECEPTION QUALITE", "THOURAYA MONTAGE", 9090 },
                    { new Guid("0d0d45fc-e26e-409f-b326-4a62ea1b4da3"), "GHNP", 24, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("0dddcffc-b1f6-4cbf-a176-c97a133cb5eb"), "GHNP", 16, "23A1E2330526", "RECEPTION QUALITE", "AZZA MONTAGE", 9090 },
                    { new Guid("0e16ac2a-d3c7-4de2-ad17-91ea39a38979"), "GHNP", 31, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("0eb71017-7f3b-4575-be88-43dc9581cf13"), "GHNP", 17, "23Y1E2330526", "SORTIE PRODUCTION", "WAFA MONTAGE", 5999 },
                    { new Guid("1117ef05-6d13-4cdb-9e07-3a15d99048ba"), "SM CL", 60, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("11345204-ca1d-418e-9801-275d89999f6f"), "SM AUDIT", 20, "22Y1E2319526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("115765f1-8a5c-4547-b160-4a280e9b7bdd"), "SM AUDIT", 4, "22Y1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("116afa08-aaaf-422d-a52f-e24859cff5de"), "GHNP", 25, "2614V320458", "SORTIE PRODUCTION", "NAJET  MONTAGE", 5999 },
                    { new Guid("11b95204-c437-40fb-90f9-8d0f7774cab3"), "SM AUDIT", 42, "20Y1E533015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("12660339-275f-4c1e-963c-010cc1221cab"), "GHNP", 22, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("1293e0b8-9228-4ca9-8764-ea965ba45424"), "GHNP", 29, "2412X72088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("12e997fd-b343-460f-8b87-bbbce725abce"), "SM CL", 6, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("1345a364-e324-4c8d-baf0-5e28aa32f367"), "SM STOCK", 34, "23B1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("13515131-5af3-4cde-99f0-b34da3ebb24e"), "GHNP", 2, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("1393f7fe-3d06-48f5-bf89-dcae98c60bc9"), "GHNP", 44, "28Y15C330751", "RECEPTION QUALITE", "BASMA MONTAGE", 9090 },
                    { new Guid("1425d49c-616b-47cf-a314-a2d685bb9500"), "GHNP", 90, "1612X630088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("1457a3b2-8a4b-41fc-b5fc-334d738c3208"), "GHNP", 29, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("148cf0af-c385-42b9-ae7a-cc6e6151bbcb"), "SM CL", 33, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("14e66126-d16f-42fa-a750-9862bd52a047"), "SM STOCK", 16, "2614V320458", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("15b58fd7-b68b-417d-8815-91691c007fd2"), "GHNP", 17, "241E2710526", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("15d1b77f-d70a-4dbe-a585-630f9b8256ae"), "GHNP", 54, "211E5720612", "RECEPTION QUALITE", "WAHIBA MONTAGE", 9090 },
                    { new Guid("15e1dd4b-8fed-4253-85c7-21424b0e3254"), "SG 1", 8, "2614V320458", "MONTAGE GORGE", "HAMRAOUI CHAIMA", 2140 },
                    { new Guid("15f50e48-3cbf-4596-bf72-2f9de44cd54c"), "SM AUDIT", 17, "22Y1E2319346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("15f955e8-e8d0-464e-a321-b50c607e86fb"), "SG 3", 24, "17Y15C319448", "MONTAGE GORGE", "MANSRI RADHIA", 2140 },
                    { new Guid("16332b28-269b-4f96-ac48-7209cded6320"), "GHNP", 42, "28Y15C330751", "RECEPTION QUALITE", "BASMA MONTAGE", 9090 },
                    { new Guid("1739577d-a01d-4bb7-955f-31f4580bef3b"), "GHNP", 13, "23X1E2330526", "RECEPTION QUALITE", "WAFA MONTAGE", 9090 },
                    { new Guid("1776ddd0-3052-4f5b-bee6-2a160eed35c2"), "SM AUDIT", 10, "23A1E2330526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("17b494fc-e493-4b8f-8599-4293f82da71f"), "GHNP", 41, "23X1E2330526", "RECEPTION QUALITE", "WAFA MONTAGE", 9090 },
                    { new Guid("17efdaa4-d900-43f6-b93d-69e56bc76eb6"), "GHNP", 30, "28Y15C330751", "SORTIE PRODUCTION", "BASMA MONTAGE", 5999 },
                    { new Guid("18ad8927-3edc-45b9-b5c7-41a6350cab6c"), "SM AUDIT", 16, "22X1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("1955483f-2ed3-4998-a187-2fa779875f18"), "GHNP", 10, "22X1E2319346", "SORTIE PRODUCTION", "THOURAYA MONTAGE", 5999 },
                    { new Guid("1a515b36-6a6d-4614-a8c0-2204b9371896"), "GHNP", 7, "26Y12X33011", "ENGAGEMENT", "WAFA MONTAGE", 1999 },
                    { new Guid("1a962bb0-33a3-49c6-9ee3-33a23514aa03"), "GHNP", 28, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("1ab63740-4395-436f-aaba-093fb35ffa84"), "GHNP", 1, "26Y12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("1acd0df1-6329-4921-a6dc-658d1602e074"), "SM AUDIT", 10, "23B1E2330526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("1b0b02de-efa9-42f5-a2e9-d99431b1049d"), "GHNP", 10, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("1b709fe4-3f8a-481a-8b65-5e2f3197b36e"), "SM STOCK", 34, "23Y1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("1b8ac4b7-1330-4cf3-a674-5ffba36a0a1a"), "SM CL", 32, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("1b98fc3d-9eb5-4fe5-ba65-ce780642d06e"), "SM STOCK", 11, "23B1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("1bbf4cf8-7962-4f26-972d-68c48e27853c"), "SM AUDIT", 25, "23X1E2330346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("1bd53001-2dfa-49f8-a7d8-7a9b2fea08f8"), "GHNP", 22, "17Y15C319448", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("1c28a621-0126-41b8-9301-a780b892a097"), "SM AUDIT", 2, "22X1E2319346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("1c7dc34d-f5b6-43ef-9733-9112325ae232"), "SM CL", 17, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("1cec048e-2424-4f54-8463-f4bd2eeea5e5"), "GHNP", 40, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("1d83c2d1-7237-4fb5-ade7-c2a6b6ab547e"), "SM CL", 37, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("1dd46c20-819b-4aa4-9041-338f45142575"), "SG 2", 48, "28Y15C330751", "ASSEMBLAGE BASQUE", "EL MAHMOUDI WIDED", 2011 },
                    { new Guid("1e37bb37-f05e-485c-b4b6-c8af3c6dcb99"), "GHNP", 24, "211E5720612", "SORTIE PRODUCTION", "WAHIBA MONTAGE", 5999 },
                    { new Guid("1e61167c-8afb-4110-855e-be1931e22bca"), "SM CL", 6, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("1eee2f77-0e08-43e6-bd13-ab47d86cf69d"), "GHNP", 24, "2412X63088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("1f014eb7-19fe-4fe5-8663-0fd9a04cad13"), "SM STOCK", 25, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("1f26bdcc-b362-40e5-b69c-024becba9fdc"), "GHNP", 59, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("1fdf0209-0f73-433b-9057-9d06d7060f66"), "SM CL", 29, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("200e7f47-f7cb-40ed-972d-05ec1ae2e0b5"), "GHNP", 12, "2614V320458", "SORTIE PRODUCTION", "NAJET  MONTAGE", 5999 },
                    { new Guid("20fa6ef7-d148-48eb-ad41-2670de021bba"), "GHNP", 32, "23B1E2330526", "ENGAGEMENT", "AZZA MONTAGE", 1999 },
                    { new Guid("215d9266-445a-4ddd-9df4-d8d1acb01b91"), "GHNP", 17, "141E271015", "ENGAGEMENT", "MEHERZIA MONTAGE", 1999 },
                    { new Guid("21d51172-7056-47ab-86fb-df7cd953694e"), "GHNP", 33, "26X12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("22152ac1-ed73-472f-b497-fbfcf9828df8"), "GHNP", 46, "181E2630346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("22248ce2-4c4b-4463-8e76-10a8a4615d08"), "SM AUDIT", 18, "23X1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("22d53e9e-05be-4a74-9be1-c19f6b5d6647"), "SG 5", 49, "23B1E2330526", "MONTAGE GORGE", "EL AHWEH JEMIYA", 2140 },
                    { new Guid("2348b3e8-07b1-47ba-817e-f7716d4f3c28"), "GHNP", 31, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("237d3296-30c6-4304-8a8f-45d1d0643e8a"), "SM STOCK", 5, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("2396498d-0b88-4464-beaa-a050e55efd8e"), "SM AUDIT", 95, "141E271015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("23992d04-1e07-4d75-a722-bea3ec46c86c"), "SM STOCK", 36, "23X1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("24041909-13db-4aeb-9f24-7f625caf4861"), "SM CL", 16, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("241bdfda-7f53-4681-8aab-98cadfc83f57"), "GHNP", 15, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("24744347-34ae-47ed-86e2-08b6f9f2ee04"), "SM CL", 52, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("24903b2a-cb9d-4734-947c-c890fbfde11f"), "SM CL", 4, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("24afefa5-4c6d-472c-83e7-597b5451aa6d"), "SM CL", 20, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("24ead4b1-a171-401e-b7ff-74c8ebd7ff4e"), "SM CL", 12, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("2546fdb4-20ad-444c-90ff-bd736bf0f9a1"), "GHNP", 51, "181E2710346", "ENGAGEMENT", "MEHERZIA MONTAGE", 1999 },
                    { new Guid("25741c17-3c9f-465f-bec6-28dc47755efd"), "GHNP", 41, "28X15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("2604c293-18f6-4370-977c-76814426eabd"), "GHNP", 57, "2612X320709", "ENGAGEMENT", "NAJET  MONTAGE", 1999 },
                    { new Guid("2606bef8-7158-44a2-8352-8225ae7fbd70"), "SM AUDIT", 4, "20Y1E533015", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("26d70c80-5d14-4f57-914d-14f7eb014764"), "SM CL", 25, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("272d9da1-f134-4c31-81d2-b0f0be9a2a98"), "SM AUDIT", 7, "17Y15C319448", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("27c8e766-2610-4cbb-be65-b3d26b30798b"), "SM CL", 47, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("28c5311a-ef4b-49e4-8011-1b83d56892b5"), "SG 1", 1, "2614V320458", "MONTAGE GORGE", "ARBI FATMA", 2140 },
                    { new Guid("290fb1bf-d0ca-4e87-b4cc-bd261f3e9eb5"), "GHNP", 39, "23A1E2330526", "RECEPTION QUALITE", "AZZA MONTAGE", 9090 },
                    { new Guid("2974e4ca-cfa6-4018-a22b-80c2d31a39f0"), "SM AUDIT", 15, "2412X72088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("29dbd665-d94f-47a1-b3fc-9652cfa39364"), "SM STOCK", 2, "181E2630346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("2aa5495e-337a-4c15-a8fa-1491ce0ca45d"), "SM STOCK", 49, "23Y1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("2b68dd67-adba-44ed-8501-111843603fc3"), "SM CL", 1, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("2bd53952-ae92-452e-806a-33a4223d6c33"), "GHNP", 55, "211E5720612", "RECEPTION QUALITE", "WAHIBA MONTAGE", 9090 },
                    { new Guid("2c2fe7bb-1a1c-4a03-9571-2fe9f44372d3"), "SM AUDIT", 39, "23A1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("2c393f91-967b-4738-b5af-a0830a98fc04"), "SM AUDIT", 31, "2412X63088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("2cee7103-256d-4d94-973b-46123c813c7d"), "SM AUDIT", 63, "141E271015", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("2d01125d-99d8-462f-9ac2-e7945b5ef267"), "GHNP", 40, "28Y15C330751", "RECEPTION QUALITE", "BASMA MONTAGE", 9090 },
                    { new Guid("2d149875-c101-4dd9-b827-6dc7cba4fe74"), "GHNP", 67, "141E271015", "ENGAGEMENT", "MEHERZIA MONTAGE", 1999 },
                    { new Guid("2d882eb6-9969-4977-93d7-f2883bae9c75"), "GHNP", 8, "2412X63088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("2dc34542-413a-4616-8d5b-4f3562c87c39"), "GHNP", 23, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("2e0b902a-acd5-4111-8210-ece01a482e29"), "SG 7", 43, "23X1E2330526", "MONTAGE GORGE", "LAHZEMI MOUNIRA", 2140 },
                    { new Guid("2ebe8d90-4997-4125-b7fb-60412b7c782b"), "SM AUDIT", 1, "20Y1E533015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("30056126-ef13-4e9f-9f24-00f879a07b2e"), "GHNP", 63, "141E271015", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("300d796f-58b6-4687-ba8c-b88a3dba01b1"), "GHNP", 46, "181E2630346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("30113f94-680e-4c98-8fa7-51dcbc17ea21"), "GHNP", 6, "211E5720612", "RECEPTION QUALITE", "WAHIBA MONTAGE", 9090 },
                    { new Guid("30998bf8-b342-41c8-ba27-b73607c8e032"), "SM CL", 8, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("30cf247f-8ad1-4325-ba65-0bf2a35620ea"), "SM CL", 15, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("310551a6-33e8-4bd0-adff-9bb927635e44"), "SM CL", 27, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("3143fbc6-9f43-4f93-a473-981d74bc5756"), "GHNP", 22, "22Y1E2319346", "SORTIE PRODUCTION", "THOURAYA MONTAGE", 5999 },
                    { new Guid("314ade28-e2b4-461c-a5e6-faea172e5626"), "GHNP", 16, "22Y1E2319346", "RECEPTION QUALITE", "THOURAYA MONTAGE", 9090 },
                    { new Guid("315d5921-46a6-490a-9644-f69ac5dcedf1"), "GHNP", 42, "2412X72088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("317d1cc3-45f0-4453-8c9f-316684f83ae5"), "SM STOCK", 51, "21X1E2347346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("32a79ded-a332-4393-8a32-44c1b76fd9da"), "SM AUDIT", 49, "23Y1E2330526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("32d06277-4e80-44b0-9fe1-eef404d5dd02"), "SM STOCK", 40, "23X1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("32d21ece-a4bc-4c21-b296-b2d62bc3f842"), "GHNP", 30, "26Y12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("32ee1f90-2664-4eb2-b6e5-c53183206b73"), "SG 7", 32, "23X1E2330526", "MONTAGE GORGE", "LAHZEMI MOUNIRA", 2140 },
                    { new Guid("330eece3-08a8-4fcc-9ca2-5a805146a8e4"), "GHNP", 54, "2612X320709", "ENGAGEMENT", "NAJET  MONTAGE", 1999 },
                    { new Guid("33b81849-af17-4973-bcdb-6a09091ee512"), "SM CL", 17, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("33dc12cc-e93b-42b6-9085-f0c6eb4fa0a9"), "SM AUDIT", 3, "181E2710346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("33e05b83-e60f-4a26-88d7-df8217e7b622"), "SM CL", 55, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("347c1b3a-81b8-4a5d-8cee-5542eca52c22"), "GHNP", 30, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("34a5002e-0d95-4322-8376-dd146f0ba151"), "GHNP", 35, "20Y1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("34e512b3-0088-47f8-a115-6cede9cb040a"), "GHNP", 15, "26Y12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("35486dc7-0658-41ac-89dd-6e63b30577ce"), "GHNP", 63, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("35e31350-8683-4edb-bcc4-cf7a7a7c022f"), "SM CL", 26, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("364e5d43-75d9-4979-9eab-172ca8888814"), "GHNP", 19, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("36c2b6c5-99e8-4424-917c-a0f464a6db22"), "GHNP", 40, "1612X630088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("37a4b8f5-f394-4e3e-a1f7-bd211b7cef91"), "GHNP", 64, "211E5720612", "SORTIE PRODUCTION", "WAHIBA MONTAGE", 5999 },
                    { new Guid("3873fcde-fb27-41b3-846f-957c03e62618"), "SM CL", 2, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("38d8921b-bd95-4924-a047-98380c7e0d44"), "SM AUDIT", 22, "22A1E2319526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("3956a7f6-fdbb-4595-bc42-bfe9cfe018ee"), "GHNP", 4, "20X1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("3961d8ab-2c46-499c-ac83-353df9db6149"), "SM AUDIT", 38, "23Y1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("39daa2c0-8770-493a-9b29-4f3fa5118d88"), "SM AUDIT", 22, "181E2710346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("39e150cf-0218-4e56-b219-4950ed615dce"), "SM CL", 31, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("3a1cdc3b-ed9b-4ec7-8cd6-64d50beccc66"), "GHNP", 9, "23B1E2330526", "SORTIE PRODUCTION", "AZZA MONTAGE", 5999 },
                    { new Guid("3a35f5a2-4255-41a2-96ac-13e53ac3c72b"), "SM AUDIT", 14, "201C451015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("3ae79e71-9643-422a-85cf-884906cc07b8"), "SM STOCK", 38, "23Y1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("3bb4d9a8-3403-4c89-aef1-7070106054f7"), "GHNP", 34, "28Y15C330751", "SORTIE PRODUCTION", "BASMA MONTAGE", 5999 },
                    { new Guid("3bd703af-acd7-4afc-957e-2f3c65d6d89d"), "GHNP", 12, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("3c2efef4-124a-4dfa-a2c5-70b83e5bf870"), "GHNP", 32, "2612X320709", "ENGAGEMENT", "NAJET  MONTAGE", 1999 },
                    { new Guid("3c516b64-37df-4807-a906-8d4eb361ca59"), "GHNP", 14, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("3d84301e-889a-4b34-a8ff-325cac187fde"), "SM AUDIT", 23, "22Y1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("3e051a83-3b6c-4708-92d4-3db6de8ee602"), "GHNP", 4, "20Y1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("3f84fee9-19c9-4271-93a3-a232d3814aaa"), "SM CL", 36, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("3fa5cc12-1fe5-4336-b8e2-35912354ba2e"), "GHNP", 31, "26Y12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("3faee655-e2d9-4834-b0f3-c63744ccf327"), "SG 6", 10, "22X1E2319346", "MONTAGE GORGE", "SESSI SALOUA", 2140 },
                    { new Guid("3feed6b9-7674-4b58-bad4-7a5a07db0101"), "SM AUDIT", 62, "181E2710346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("407c0b0b-495f-465b-b5be-82bbf4c664b6"), "GHNP", 37, "28Y15C330751", "RECEPTION QUALITE", "BASMA MONTAGE", 9090 },
                    { new Guid("40c9f32d-560f-4d03-b756-c3630f0923b2"), "GHNP", 48, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("411708de-383a-47ca-8611-b44dc1a0c09c"), "GHNP", 20, "28X15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("4153bd38-9d2d-4db7-8a37-6a03b5f14e37"), "SM AUDIT", 36, "20Y1E533015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("417b52c9-5976-43ef-be24-48915104969b"), "SM AUDIT", 58, "181E2710346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("4306074d-c21c-4073-8519-5f7a1934680c"), "GHNP", 27, "23B1E2330526", "RECEPTION QUALITE", "AZZA MONTAGE", 9090 },
                    { new Guid("430a0039-de7b-4b23-83d6-76ac7a50c4a7"), "GHNP", 17, "23Y1E2330526", "RECEPTION QUALITE", "WAFA MONTAGE", 9090 },
                    { new Guid("438b9a87-db4f-46aa-88ee-7f28aeee0a1e"), "GHNP", 63, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("44af257c-b97d-4f35-9012-b60d2ea0ad39"), "SM STOCK", 4, "22Y1E2319346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("44c605b5-d456-4997-9efe-705f48a34e68"), "SM STOCK", 31, "181E2710346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("44fc924c-f6c1-4c54-b15f-55234dd0ed71"), "SM STOCK", 31, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("45334085-245b-446c-bca3-e050929627a1"), "SG 2", 33, "28Y15C330751", "ASSEMBLAGE BASQUE", "EL MAHMOUDI WIDED", 2011 },
                    { new Guid("456868d2-fde5-4e4d-8101-e1a558e3f497"), "GHNP", 9, "23B1E2330526", "RECEPTION QUALITE", "AZZA MONTAGE", 9090 },
                    { new Guid("45840865-7668-4d07-9e05-cd5c5c76bea6"), "SM AUDIT", 10, "2412X63088", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("45a7ec5a-fb11-464a-b165-4693e2fae30d"), "SM CL", 3, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("45d66f13-5680-4e0f-bb92-7ba772de944d"), "SG 5", 5, "23B1E2330526", "MONTAGE GORGE", "EL AHWEH JEMIYA", 2140 },
                    { new Guid("46df45b6-755d-4dfa-aa3e-0a4d8c1b93b2"), "GHNP", 7, "2412X72088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("47569888-ab81-4fa0-bd6e-cb8514e5908b"), "GHNP", 1, "2614V320458", "RECEPTION QUALITE", "NAJET  MONTAGE", 9090 },
                    { new Guid("47b20e63-eba2-46b6-9111-3a97e3297041"), "SM STOCK", 18, "23X1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("47c1e1c5-fa33-41e0-8f90-7f49e5ae1c28"), "GHNP", 48, "28Y15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("47cc83ae-befa-4be9-bc65-5a34cca2a1f3"), "SM CL", 35, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("47f7dd63-e9c1-4978-8866-2451c2d7d844"), "GHNP", 42, "2412X72088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("48481a33-273f-4f33-af59-3982e34bc2b3"), "SM STOCK", 29, "2614V320458", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("48f5ead3-77d4-44f4-8cb9-203ffd8ae006"), "GHNP", 35, "20Y1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("4932dcd8-80c0-47ff-867e-fbccadc933e6"), "GHNP", 6, "211E5720612", "SORTIE PRODUCTION", "WAHIBA MONTAGE", 5999 },
                    { new Guid("4935dbb1-0836-4c2d-8013-8572529e9191"), "GHNP", 4, "20Y1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("4a2e6215-5b89-4769-98ba-ae9fa41abae1"), "SM STOCK", 14, "181E2710346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("4a7900d9-8e1c-4f5f-b3c9-8d03dbcbca04"), "SG 6", 13, "22Y1E2319346", "MONTAGE GORGE", "SESSI SALOUA", 2140 },
                    { new Guid("4a9bd55b-48a5-4f86-97b9-8f0aed4689ca"), "SM AUDIT", 22, "23X1E2330346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("4bef58ed-f009-4f32-8f91-c7cdfb84c013"), "SM STOCK", 20, "23X1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("4c038df6-4eb0-4078-ae40-9510db2393a0"), "GHNP", 25, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("4c0a91cf-8595-45d4-a1be-251547e10a27"), "GHNP", 47, "241E2710526", "ENGAGEMENT", "MEHERZIA MONTAGE", 1999 },
                    { new Guid("4c3f75ef-d583-432d-bb31-092d360827df"), "GHNP", 19, "26X14V316458", "ENGAGEMENT", "AZZA MONTAGE", 1999 },
                    { new Guid("4c5057b5-220d-4b67-b35d-4814462f759e"), "GHNP", 21, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("4c932885-29a0-4599-93fe-b693f2069065"), "SM AUDIT", 19, "22X1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("4d34665d-5a37-43eb-b6ab-8ffd51dc5d5a"), "GHNP", 12, "2614V320458", "RECEPTION QUALITE", "NAJET  MONTAGE", 9090 },
                    { new Guid("4d5a807e-383a-4cc4-a71e-18672eab00a0"), "SM CL", 50, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("4d6cb64e-8a68-46a8-9217-8164f90cb379"), "GHNP", 15, "2412X72088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("4e070f9f-ec2a-430d-9837-c61e43cc05bd"), "SM CL", 5, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("4e103fae-bbad-4a50-adcb-579fe4ae860f"), "GHNP", 6, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("4e1b5538-4359-46e0-81de-7224b0ba7251"), "SM CL", 22, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("4e2148ef-49d7-4717-8d3c-ce81aa5a36eb"), "GHNP", 25, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("4e3c6c62-407a-49a3-9b2c-8269faf52d7d"), "GHNP", 29, "2412X72088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("4ed513d5-086d-4e4c-be3c-57b4e81aa5df"), "SM AUDIT", 12, "211E5720612", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("4efe76ab-3aab-443d-b7bb-12f43cef1cc7"), "GHNP", 90, "1612X630088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("4fb25191-b134-44ac-a284-3dadb4fa4f28"), "GHNP", 15, "2412X72088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("5054ebbb-a1f7-43b9-920a-de7110a26c5d"), "SM AUDIT", 64, "211E5720612", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("506cd1bf-5897-4e63-850e-d035e6ada6d3"), "SM STOCK", 13, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("50a4ae8c-589e-4c84-aed4-cd10320c854c"), "SM CL", 34, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("50f70dd4-4d8f-4836-ab27-7aac4b5bf34d"), "SM STOCK", 30, "1612X70088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("50faa526-4f7d-41a2-bb69-be8a6c2f147a"), "SM AUDIT", 11, "23X1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("50fed549-ac48-437f-aa1b-65e8d67dd401"), "SM CL", 9, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("513db942-d873-4f8e-85ba-67b9fd2ab8a0"), "SG 3", 28, "17Y15C319448", "MONTAGE GORGE", "MANSRI RADHIA", 2140 },
                    { new Guid("517a2a3b-1132-44ec-bc22-561967ef41a6"), "SM CL", 9, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("51c01393-f2d6-4db8-8965-8f94bd62656c"), "GHNP", 63, "141E271015", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("51db36c0-328e-4861-a258-664834c80b3d"), "GHNP", 55, "211E5720612", "SORTIE PRODUCTION", "WAHIBA MONTAGE", 5999 },
                    { new Guid("522f020d-045f-43ac-9c82-224464800614"), "SM CL", 51, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("5277b8f4-9d7a-49f4-8bd1-d4084c244525"), "SM CL", 11, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("53607432-d5a8-41c3-ad09-0bd9f7dec9f5"), "SM AUDIT", 8, "17Y15C319448", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("53e32b51-ce8a-43fe-b0d7-ac9f2b3a221d"), "GHNP", 34, "17Y15C319448", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("542fe04f-a5fa-49a8-8af4-7b7faade72bc"), "SM STOCK", 5, "22A1E2319526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("54b46b49-7f5f-4e9b-aa1c-5c33b81f9b31"), "GHNP", 12, "1715C720448", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("551f5d7f-f56d-46eb-8072-c562fcef300b"), "SM CL", 13, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("554ff681-2ae3-4511-be8b-1bb1826c1bd1"), "SM AUDIT", 9, "181E2710346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("55b80844-4e64-45ce-8431-5c30da53d0fa"), "GHNP", 36, "28Y15C330751", "RECEPTION QUALITE", "BASMA MONTAGE", 9090 },
                    { new Guid("55d4fd3e-0d07-42b3-8917-f1bc1844e8ba"), "GHNP", 22, "22Y1E2319346", "RECEPTION QUALITE", "THOURAYA MONTAGE", 9090 },
                    { new Guid("55fc124d-f22c-4d6b-9db0-0c4b431dc71e"), "SM STOCK", 24, "23A1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("56fb4b46-3f10-4e15-a882-d013c737ffe9"), "SM STOCK", 29, "241E2710526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("572ac72d-1e40-45f1-8cd4-f370830bc87f"), "SM CL", 2, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("576e5b9a-1574-4f39-a8ed-4b88ed03b2bd"), "GHNP", 44, "2412X72088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("57ae1008-325d-44b3-bb6e-87d9786f95d1"), "SM AUDIT", 41, "23B1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("582aafcf-4173-4459-a84a-28cd86075417"), "SM AUDIT", 23, "22A1E2319526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("58c19aea-daac-4765-bae7-1984ecacb9f5"), "GHNP", 28, "181E2630346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("593e928f-c969-4f85-ac0f-07145f1e941b"), "GHNP", 41, "23X1E2330526", "SORTIE PRODUCTION", "WAFA MONTAGE", 5999 },
                    { new Guid("593edf56-2b2a-4c52-97b8-56bffb7eccdb"), "SM CL", 2, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("59f76a4c-2d5b-42a1-95c3-162b212897bb"), "SG 6", 1, "22X1E2319346", "MONTAGE GORGE", "JLASSI SAIDA", 2140 },
                    { new Guid("59fe153e-8202-4bf6-ba4c-88dc6cc07255"), "SM AUDIT", 28, "22Y1E2319346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("5a2f0dbc-d4c8-4053-a6ec-647d8b71bbe4"), "GHNP", 50, "28Y15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("5a30ffcd-5517-4064-b773-c01a9c88aa2d"), "GHNP", 26, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("5a38fd4b-e41d-4345-ba50-8291eef6cc6f"), "SM CL", 20, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("5a4a9aac-a0e8-4bbd-bf9b-ff795d269c60"), "SM STOCK", 9, "22X1E2319346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("5a59a341-4c82-4a52-9350-4168f491b112"), "SG 3", 11, "22Y1E2319346", "MONTAGE GORGE", "BELLILI YAMINA", 2140 },
                    { new Guid("5a72c0d7-a0db-4bd8-973b-41f49531f3ca"), "SG 7", 34, "23X1E2330526", "MONTAGE GORGE", "M'HIRSSI INES", 2140 },
                    { new Guid("5a8331f1-029a-485f-9a35-4b79a0cae1b7"), "SM AUDIT", 35, "21X1E2319526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("5ae24a93-5068-44a6-bd67-233ec0d8d8c8"), "SM STOCK", 7, "17Y15C319448", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("5af0301d-f3cd-4f3e-acc5-6f6378681062"), "GHNP", 53, "211E5720612", "SORTIE PRODUCTION", "WAHIBA MONTAGE", 5999 },
                    { new Guid("5b2758bf-2619-4005-a072-f80dbd18eb78"), "SM STOCK", 34, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("5b4b8add-5a96-41db-af4a-663981595736"), "SM STOCK", 14, "23X1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("5b9ea4f1-ef55-444c-b993-b98ef60740fa"), "SM CL", 56, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("5bc27bfb-e978-43fd-a1dd-0c15cf4c1590"), "GHNP", 4, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("5be4f03b-c74a-43d5-b556-e9462ce5df5a"), "SM CL", 28, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("5c6afb04-5b4e-4950-a445-661530e78f2e"), "GHNP", 8, "2412X63088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("5ca86d7f-9a72-4e05-983e-e7e46dbc5f9d"), "SM STOCK", 10, "22Y1E2319346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("5cb585aa-6bba-465c-8d35-7145c05cfa09"), "SM STOCK", 27, "23A1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("5cc1f2f0-7d81-4420-99d5-eaeb3ce1b010"), "SG 1", 31, "2614V320458", "MONTAGE GORGE", "ARBI FATMA", 2140 },
                    { new Guid("5d8aab60-2384-4efc-b6e3-b6c06a85e2a3"), "GHNP", 36, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("5e58203f-8a3c-421b-b54b-94e912f7c0b1"), "SM STOCK", 8, "23Y1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("5eaa3bde-ae50-4e4f-a078-fdf53a47952a"), "GHNP", 16, "28Y15C330751", "RECEPTION QUALITE", "BASMA MONTAGE", 9090 },
                    { new Guid("5fbd82ed-692d-4867-b855-5eea83fdb59e"), "GHNP", 75, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("6074dc2e-0da4-4aaf-bc3e-009010c0e539"), "SM CL", 16, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("60f94810-5ff2-4003-b3ee-802fa4b4ea5c"), "GHNP", 14, "26Y14V316458", "ENGAGEMENT", "AZZA MONTAGE", 1999 },
                    { new Guid("617f909e-fa1d-428f-8ece-988fae409829"), "GHNP", 41, "1612X630088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("618d3276-35d3-462a-9e90-cc5d4ae10b65"), "GHNP", 16, "23X1E2330526", "RECEPTION QUALITE", "WAFA MONTAGE", 9090 },
                    { new Guid("61b7670d-b5d7-4edf-ba5e-aff58017ab5a"), "GHNP", 10, "22X1E2319346", "RECEPTION QUALITE", "THOURAYA MONTAGE", 9090 },
                    { new Guid("62301fd9-4814-4c34-bcd8-e1edded8b136"), "SM CL", 57, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("6299a9c6-dae3-462f-b717-930f56c5d268"), "GHNP", 26, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("62b906c0-23d0-4676-9167-52d9bbbc02bf"), "SG 7", 31, "23X1E2330526", "MONTAGE GORGE", "LAHZEMI MOUNIRA", 2140 },
                    { new Guid("62cee0c1-749c-4197-85d9-ec99855678fc"), "GHNP", 37, "28Y15C330751", "SORTIE PRODUCTION", "BASMA MONTAGE", 5999 },
                    { new Guid("62d6d79c-4b4c-488e-83c0-3108f864e82a"), "SM AUDIT", 31, "23A1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("635e06a6-40e6-4bb5-8009-d2198ce25b4f"), "SM STOCK", 12, "211E5720612", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("6374bd20-47c4-49d8-9f4d-54efa8450a80"), "GHNP", 28, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("638edda3-1b19-4a4e-b45e-012dcffcd11c"), "SG 3", 24, "22Y1E2319346", "MONTAGE GORGE", "BELLILI YAMINA", 2140 },
                    { new Guid("648b9c4e-6341-43a5-b50a-5d79a94565f8"), "GHNP", 33, "26Y12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("64a80d5b-125e-44ab-94f5-f9b2becaabfb"), "GHNP", 5, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("64b46b0f-8970-425e-b15f-aa9ce2e77bf7"), "SM AUDIT", 27, "17X15C319448", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("64f2c3d9-9924-4117-94eb-3e83d546080e"), "GHNP", 24, "211E5720612", "RECEPTION QUALITE", "WAHIBA MONTAGE", 9090 },
                    { new Guid("64fce2f7-a25d-4117-a782-6cd36ce4d984"), "SG 4", 49, "20Y1E533015", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 },
                    { new Guid("65b1f66d-e4f5-4c0b-a66d-77c46a20f5f8"), "SM CL", 12, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("65ddfaa0-bc7b-4896-8988-1c2755e4d6a5"), "SM CL", 8, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("65f400fe-c537-415e-90d2-bf5544d2ef4c"), "GHNP", 28, "211E5720612", "RECEPTION QUALITE", "WAHIBA MONTAGE", 9090 },
                    { new Guid("661107bd-800f-4e77-a96f-6f97523f5090"), "SG 4", 32, "21X1E5330612", "MONTAGE GORGE", "CHTITA SONIA", 2140 },
                    { new Guid("6663d97f-aec1-4788-ba8e-91200a6477f6"), "SM AUDIT", 22, "2614V320458", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("667d2d29-8b01-48b1-8fb1-d8516ef6f698"), "SG 4", 13, "20X1E533015", "MONTAGE GORGE", "AOUADI LATIFA", 2140 },
                    { new Guid("67bacc0a-abba-4290-b369-d36ee0d15894"), "GHNP", 18, "2612X320709", "ENGAGEMENT", "NAJET  MONTAGE", 1999 },
                    { new Guid("67ece294-f0e9-4a05-afbe-ec7d613646df"), "GHNP", 41, "1612X630088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("681ef21c-0d43-47d2-9703-977665f9dd62"), "SG 6", 20, "22X1E2319346", "MONTAGE GORGE", "SESSI SALOUA", 2140 },
                    { new Guid("6abec267-1b82-4ab0-a4a9-2a0842fea66e"), "SG 4", 19, "21Y1E5330612", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 },
                    { new Guid("6aef2f3d-acba-4ee1-9c75-b8b9f5593209"), "SM STOCK", 32, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("6b083c37-fcf6-4d35-a751-a4d8d906a898"), "SM AUDIT", 35, "22A1E2319526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("6b34a42a-2c7c-4519-90a1-f19c200956ab"), "GHNP", 61, "211E5720612", "SORTIE PRODUCTION", "WAHIBA MONTAGE", 5999 },
                    { new Guid("6b6a2928-91e1-47f7-90cf-1a44c99707b1"), "SM STOCK", 9, "21X1E2319526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("6bad5928-065e-49a2-bfd4-fba118f92949"), "GHNP", 31, "1715C720448", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("6ca3872f-8741-48e3-a48c-00eada9a550e"), "SM STOCK", 62, "181E2710346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("6cacb150-409c-4996-9041-fd251fe69d5a"), "SM STOCK", 20, "21X1E2347346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("6cfbe3f0-53e0-49d8-a692-12dd9754aa82"), "SM CL", 13, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("6d18e0f7-2f71-4a80-8254-4482bd676ca0"), "GHNP", 8, "23B1E2330526", "RECEPTION QUALITE", "AZZA MONTAGE", 9090 },
                    { new Guid("6d60d709-69b1-4f3c-ad41-1d078beb43e1"), "GHNP", 31, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("6da7c349-7f57-4803-83e1-7800c7845dc3"), "SM CL", 45, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("6de78b62-38ba-476f-9e0a-d22bcc0d2d9f"), "SM CL", 8, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("6f1d589e-20f1-42b1-86d2-4261f6268fa9"), "SM STOCK", 33, "24Y12X33088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("6fa47b9a-d913-46c2-89c5-08ca1fbb3eea"), "GHNP", 27, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("6fc0acaf-6b9b-4e91-8a25-7639b88441af"), "GHNP", 8, "22Y1E2319346", "SORTIE PRODUCTION", "THOURAYA MONTAGE", 5999 },
                    { new Guid("6fcbf8f8-b082-4369-9e7e-fd81a2fe2ad8"), "GHNP", 12, "17X15C319448", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("70192f12-7301-45d2-8c9a-00c6e0703d17"), "SM CL", 26, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("70259f6f-4127-47d3-b058-1a7cdae64463"), "SM CL", 11, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("70264e43-16e8-4322-9b8d-f8cf27abcd36"), "SG 4", 12, "21Y1E5330612", "MONTAGE GORGE", "AOUADI LATIFA", 2140 },
                    { new Guid("70370132-afe8-4987-ab27-50d37b1a8f19"), "SG 3", 19, "17Y15C319448", "MONTAGE GORGE", "MANSRI RADHIA", 2140 },
                    { new Guid("71d2e4a5-067a-447d-9657-813809a79168"), "GHNP", 25, "2614V320458", "RECEPTION QUALITE", "NAJET  MONTAGE", 9090 },
                    { new Guid("71f42837-5623-4192-bb43-56611a8da74a"), "GHNP", 34, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("725ff577-aff2-4eff-bf43-51581fdf19a6"), "GHNP", 17, "22X1E2319346", "RECEPTION QUALITE", "THOURAYA MONTAGE", 9090 },
                    { new Guid("729383c6-5d99-4543-a265-50cc8ff8e3cf"), "SM CL", 54, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("72c5e127-2ed0-49c1-afdc-d7340113cb58"), "GHNP", 18, "1715C720448", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("72ed08ae-3804-49f9-b5ae-23c8fc8f9061"), "SM CL", 4, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("7303caf6-7206-4385-b8c2-c9b33358405a"), "SM STOCK", 10, "23B1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("733e60d5-57cd-4ee6-a976-5375698c904c"), "GHNP", 20, "26X1C2330661", "ENGAGEMENT", "WAFA MONTAGE", 1999 },
                    { new Guid("73c074bb-082a-4c3b-8f37-fb09df6f2690"), "SM CL", 27, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("741f3d4b-e859-4d4f-b321-f97ef724f842"), "SM CL", 12, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("742ef860-1e24-455d-93e0-387111c71832"), "GHNP", 42, "23B1E2330526", "RECEPTION QUALITE", "AZZA MONTAGE", 9090 },
                    { new Guid("744ad188-ec63-4cbe-b2aa-8b34895f15c8"), "GHNP", 14, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("744b7473-4df1-40f8-b4bd-739191910b7e"), "GHNP", 58, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("74b040cb-179b-4edc-a5f1-022c03f9cccd"), "SM CL", 17, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("758cf997-2c81-4629-9489-5a2c56af1006"), "SM AUDIT", 42, "23B1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("758d0f5d-bdf1-4ffa-8b59-26b2d51c576f"), "GHNP", 17, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("76d7c97c-e63a-49ab-9c42-3eade7d179ac"), "GHNP", 36, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("777f619e-be6e-4046-82f4-2bb88ca0d86c"), "SG 5", 48, "23B1E2330526", "MONTAGE GORGE", "EL AHWEH JEMIYA", 2140 },
                    { new Guid("77e6ef35-f82b-4e6f-a079-c8f8f6512583"), "SM STOCK", 31, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("781cbedd-6ea7-45cf-a7a7-7e761b337a1d"), "SM AUDIT", 10, "22Y1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("7a65dd42-e3ae-4b60-a680-31c632d3d253"), "SG 6", 3, "22Y1E2319346", "MONTAGE GORGE", "SESSI SALOUA", 2140 },
                    { new Guid("7b14fa7e-48c8-463e-b80d-f5424e4819bf"), "SG 7", 47, "23X1E2330526", "MONTAGE GORGE", "M'HIRSSI INES", 2140 },
                    { new Guid("7b93cfd6-6b1e-432d-ac51-09eee295ec8c"), "SM PACK", 16, "23A1E2330526", "CONTROLE CLIENT", "BEN RABEH NADIA", 9099 },
                    { new Guid("7c1d4042-4f06-4806-84f6-05df5a0268a3"), "SM AUDIT", 34, "211E5720612", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("7d04ca7f-cc54-4632-bbdb-5400912839b8"), "GHNP", 10, "21X1E5330612", "ENGAGEMENT", "CHEDIA MONTAGE", 1999 },
                    { new Guid("7d536631-f3f9-4aea-9bc5-638eab2ad0ac"), "SM AUDIT", 17, "23Y1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("7e017e1c-9746-4694-89a0-37d350eff3b2"), "SM CL", 33, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("7e10daa4-511f-46eb-9248-d3ea9cd4d06f"), "GHNP", 31, "23A1E2330526", "RECEPTION QUALITE", "AZZA MONTAGE", 9090 },
                    { new Guid("7f2f2be3-71e4-420f-a77c-d276c157a2bd"), "SM AUDIT", 8, "23B1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("80193e49-591f-47c2-b278-3faa744312b6"), "SM AUDIT", 30, "1612X70088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("81cb3ddf-efeb-4c86-b360-f4668915a1d9"), "SM AUDIT", 11, "23B1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("81d4adb5-8a9a-4c80-a1f9-27b2a190fa86"), "GHNP", 25, "22X1E233015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("81ed9f2d-1a2d-4bd7-ac88-4f71dbc893a3"), "GHNP", 28, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("836adca5-c1bc-4ae8-abc2-3776cf450df4"), "SM CL", 46, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("8375b389-5ee0-4563-8b29-7aba8f94c9f6"), "SG 4", 48, "21X1E5330612", "MONTAGE GORGE", "CHTITA SONIA", 2140 },
                    { new Guid("83834dff-2162-44dc-94e1-48b861ec0573"), "SM AUDIT", 4, "1612X70088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("83fd20c5-7a83-454a-a762-4416335b13cf"), "GHNP", 4, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("84ebce32-4e20-4170-9aa7-c26f00304a9d"), "SM AUDIT", 19, "23X1E2330346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("84fe08b0-9343-4478-ae12-aa54eb5a14ad"), "SM STOCK", 26, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("852c6934-72a6-4e65-9932-bd103ae73bb5"), "GHNP", 3, "21X1E5330612", "ENGAGEMENT", "CHEDIA MONTAGE", 1999 },
                    { new Guid("859638f1-8164-4eaf-8a7f-b632c7ec8910"), "SM AUDIT", 2, "22Y1E2319346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("85b22e17-4ffb-4100-a846-3234982193e7"), "GHNP", 3, "20X1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("86088c9d-6741-47ee-adaa-de39db6ac951"), "GHNP", 17, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("865eadb2-d4b9-44f8-b382-535e518846d9"), "SM AUDIT", 18, "141E271015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("8727f60c-ba72-4862-a799-344846760010"), "SM CL", 31, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("878abeb4-d05d-452e-8ca1-96236ca973f2"), "SM AUDIT", 41, "20X1E533015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("87be3bba-dafc-4d15-a139-7e994fa8be51"), "GHNP", 34, "28Y15C330751", "RECEPTION QUALITE", "BASMA MONTAGE", 9090 },
                    { new Guid("87cb7d96-f957-42d8-8295-1b20fcb83712"), "SG 3", 7, "22Y1E2319346", "MONTAGE GORGE", "BELLILI YAMINA", 2140 },
                    { new Guid("87f4d71f-1162-44f2-a2c8-f1e20d108f7e"), "GHNP", 44, "28Y15C330751", "SORTIE PRODUCTION", "BASMA MONTAGE", 5999 },
                    { new Guid("8812a7e7-1fbb-429d-b701-aa9e3f2a7c62"), "GHNP", 53, "211E5720612", "RECEPTION QUALITE", "WAHIBA MONTAGE", 9090 },
                    { new Guid("8816dd6f-7e04-4aa0-8986-b8a300494e9a"), "GHNP", 19, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("886df866-ce34-414f-ae3d-13efde88b18b"), "SM AUDIT", 13, "17Y15C319448", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("88b84f36-5641-44bf-baf6-0167a86504a6"), "SG 4", 37, "21X1E5330612", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 },
                    { new Guid("88d36c39-7302-4b0c-a35c-ef022a840ccf"), "GHNP", 40, "241E2710526", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("891b11da-341e-43d8-9b75-69012d372fad"), "GHNP", 15, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("8954905a-ad05-4294-bd21-03c6ccdeacc8"), "SM STOCK", 22, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("89a4d7b1-1502-409f-8132-3bd120ddfeff"), "GHNP", 10, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("89b73f85-c719-4d36-8643-0a585c0e271e"), "SM AUDIT", 51, "181E2630346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("89f418f0-0710-40b7-a944-69ef4393f055"), "GHNP", 28, "241E2710526", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("8a8effe6-9ba9-4b65-94ce-9554e0f3cd4b"), "GHNP", 36, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("8aa9cf13-f2a9-4daf-ae47-e27658c400de"), "SM AUDIT", 28, "23A1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("8af31ca9-0646-4310-9061-23ddbb904880"), "SM CL", 29, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("8af44e07-226f-4cd5-b275-6c08a1cff17e"), "SM STOCK", 14, "201C451015", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("8b0f8bfc-cc36-4822-bda1-9b54da94d2ec"), "GHNP", 10, "2614V320458", "SORTIE PRODUCTION", "NAJET  MONTAGE", 5999 },
                    { new Guid("8b515a93-dccf-4150-b07c-43f0ec885627"), "SM AUDIT", 4, "22A1E2319526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("8b926742-91ee-40e7-83ba-96a22329118f"), "GHNP", 14, "21X1E5330612", "ENGAGEMENT", "CHEDIA MONTAGE", 1999 },
                    { new Guid("8bc94aa4-faff-4e4a-beb3-c67a66693c72"), "SM CL", 20, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("8cab192d-ffa7-40db-981b-1b07158c2d2b"), "GHNP", 24, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("8cb15a9e-e4e2-4591-a6ca-12b60c72f8f9"), "SM STOCK", 20, "22Y1E2319346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("8dbe7be6-a9f0-4e1b-b0b7-c41abdf4de45"), "GHNP", 2, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("8dd7cceb-e460-4ec8-82b0-fcafc6692e19"), "SM AUDIT", 55, "211E5720612", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("8e1f66c8-ff85-4f63-a4f5-475f959af086"), "SM CL", 14, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("8e44cfaf-73fc-449c-986f-607e7bc539ed"), "SM STOCK", 35, "23Y1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("8e807b11-c10e-4cc3-9f25-734982e88b22"), "GHNP", 50, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("8f67b692-abb9-4207-88fd-06ee8a87dea8"), "GHNP", 19, "28X15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("8fd91145-7b79-4888-a599-ac2a66f10988"), "SG 5", 19, "23B1E2330526", "MONTAGE GORGE", "EL AHWEH JEMIYA", 2140 },
                    { new Guid("902a498f-6f27-4600-b802-926abdaa2e5a"), "GHNP", 14, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("907b961a-5311-4e99-83b1-e855a5e6485f"), "GHNP", 7, "2412X72088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("90b4f23f-0d86-4668-9916-a3c0e0e33001"), "GHNP", 4, "28Y15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("90c3533d-932a-46fa-a1d6-4155ab22b8e5"), "SM AUDIT", 34, "23Y1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("90ffd982-8941-457b-bc97-8819f5054661"), "GHNP", 27, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("910d0f7b-028c-4de6-80c8-0c0b3f84425e"), "GHNP", 13, "26X14V316458", "ENGAGEMENT", "AZZA MONTAGE", 1999 },
                    { new Guid("91d226e5-a30c-4d3c-a713-433edc8d5328"), "SM CL", 49, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("91f32a3c-f70b-4341-a8ef-7c6913aa9c8b"), "GHNP", 30, "1612X70088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("923a44c5-a28c-4ee1-9dff-cdaf023c72a8"), "SM AUDIT", 14, "23X1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("929a59b8-655b-4246-b11e-179b55b62bd2"), "SM STOCK", 3, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("92fdd871-280e-4822-bb66-8084699fd22b"), "GHNP", 39, "23A1E2330526", "SORTIE PRODUCTION", "AZZA MONTAGE", 5999 },
                    { new Guid("930d9072-3553-4390-a62f-42ce6ee07242"), "SM AUDIT", 14, "181E2710346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("932b76c2-1295-4c4b-85c9-13e0213f8411"), "SM STOCK", 37, "181E2630346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("9360d940-2344-49b1-a1fc-3b69e33cee10"), "GHNP", 96, "1612X630088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("9373b4b3-1442-42fe-a9bd-3457c36472eb"), "SM STOCK", 6, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("93951891-bd41-426f-8c50-794ced102dfc"), "SM STOCK", 19, "22X1E2319346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("93a185b6-6458-459e-9fce-d36838881566"), "SM CL", 23, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("93df63f0-30ed-4783-91f1-151d566ab287"), "GHNP", 25, "23Y1E2330526", "RECEPTION QUALITE", "WAFA MONTAGE", 9090 },
                    { new Guid("93ebabef-3a05-473d-b107-c60383bc5f91"), "GHNP", 8, "23B1E2330526", "SORTIE PRODUCTION", "AZZA MONTAGE", 5999 },
                    { new Guid("93f44d3a-8a68-46bf-85b7-01bce5546e03"), "GHNP", 3, "22X1E2319346", "SORTIE PRODUCTION", "THOURAYA MONTAGE", 5999 },
                    { new Guid("9433203d-aa65-4df2-b77d-395cbfba8b4a"), "SM CL", 5, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("943e480f-1378-4426-a5c1-718857331507"), "GHNP", 34, "23B1E2330526", "SORTIE PRODUCTION", "AZZA MONTAGE", 5999 },
                    { new Guid("9478fa3b-f48e-4253-b280-92d18a0e3a1d"), "GHNP", 1, "20Y1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("94fb1228-1692-410a-a960-fc8b76620b7c"), "GHNP", 15, "26X14V316458", "ENGAGEMENT", "AZZA MONTAGE", 1999 },
                    { new Guid("9531a146-9645-4a70-a7f1-6b86067f48d9"), "SM CL", 10, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("95f0b31e-d1a4-4354-bb0a-feba77f8e81d"), "SM AUDIT", 5, "2412X63088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("962ef718-eeed-4a60-8a23-39c9b15186c2"), "SM CL", 32, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("97a4758c-86b3-42ae-8285-d3d1d52dc3ad"), "SM CL", 14, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("9830df08-cb75-4254-a699-d950be508f3b"), "SM STOCK", 38, "23A1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("98417737-de4e-4c45-b219-90eaa24810d0"), "SM CL", 38, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("98645ecb-3641-41ab-9edb-10d8e292ab20"), "SM STOCK", 20, "22Y1E2319526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("989b408f-80ac-4de2-913c-2469263088d6"), "SM AUDIT", 68, "211E5720612", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("99042df8-5fe2-4207-9bf4-41b364c5a61e"), "SM AUDIT", 24, "23X1E2330346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("9909eca3-4754-4a03-9821-0eadf3b7f374"), "SM CL", 42, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("991a23b1-ba05-4ef8-bdde-1f985957379f"), "GHNP", 25, "22X1E233015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("9941463b-a5e7-49c1-824f-2d92b3c1e58d"), "GHNP", 31, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("998eed3c-cee7-49f1-86e2-c9bd9b197510"), "SM AUDIT", 35, "23Y1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("9a394428-486f-4689-8129-87d9c0c96c65"), "SM CL", 5, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("9a3f413a-2b3e-4e24-85d0-ea30366f13eb"), "SM AUDIT", 40, "20Y1E533015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("9af39010-a4de-45a0-bf39-02f0c9f9c22f"), "GHNP", 15, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("9b9ad8ba-48db-4d76-bae6-b3d6a83e178d"), "GHNP", 5, "21X1E5330612", "ENGAGEMENT", "CHEDIA MONTAGE", 1999 },
                    { new Guid("9c15dab1-9753-45c5-9d7f-910bc6d6732a"), "GHNP", 30, "28Y15C330751", "RECEPTION QUALITE", "BASMA MONTAGE", 9090 },
                    { new Guid("9ce1786a-3538-4bbd-9c82-406633724eb2"), "GHNP", 30, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("9dc2be2f-7850-4112-8093-8169eaba89a6"), "SM CL", 30, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("9de3edac-594a-4845-8358-24460f131ac8"), "SM STOCK", 21, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("9e5bb692-3465-4e2a-b525-15b22ff2a958"), "SM STOCK", 17, "23Y1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("9e7b1aa1-4c71-48ae-a5c7-42326cad19d0"), "SM AUDIT", 31, "23X1E2330346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("9e7fcfa2-c082-4299-baf1-5d8bce8d5214"), "GHNP", 21, "28X15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("9e81240e-26af-4b52-b854-4a5a93b63fa8"), "SM CL", 7, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("9e986ccb-6a84-4129-9c8f-43c2f60a0671"), "GHNP", 25, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("9f4d7702-1237-4b76-ba49-3c58d1bcc00a"), "GHNP", 31, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("9fea5347-11da-4d92-b8d4-9a5de72a8261"), "SG 1", 25, "2612X320709", "MONTAGE GORGE", "HAMRAOUI CHAIMA", 2140 },
                    { new Guid("a015f31a-14dd-4ce6-a96a-c996be157b7c"), "SM CL", 9, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("a0237375-bc31-4886-9dc7-76a6b7538527"), "SM CL", 15, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("a10c7124-9b03-40c0-944b-bae824d265d9"), "GHNP", 4, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("a144ad85-4baf-489f-9e30-6ec48e54f874"), "GHNP", 18, "20X1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("a15ff077-1e1f-46b9-9398-12ce417d972b"), "GHNP", 47, "211E5720612", "RECEPTION QUALITE", "WAHIBA MONTAGE", 9090 },
                    { new Guid("a227791e-a1bf-435e-9735-0dad4c3b7199"), "SM AUDIT", 16, "22Y1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("a3410891-a955-4cff-be7e-766f0b2bd4bf"), "SM AUDIT", 14, "22Y1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("a3b71746-28e5-4aa5-8a07-16a9fa1d4b24"), "GHNP", 1, "2614V320458", "SORTIE PRODUCTION", "NAJET  MONTAGE", 5999 },
                    { new Guid("a3defaf5-a2e6-4403-95cf-98c565c61dae"), "SM COL", 6, "4912S720407", "ENGAGEMENT", "COLLECTION  SIMOTEX", 1999 },
                    { new Guid("a4491851-fd94-4356-a7ff-b1d29928718a"), "SM AUDIT", 40, "22Y1E233015", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("a4775a0f-f742-449c-acb3-8a58d1254721"), "SG 7", 27, "23B1E2330526", "MONTAGE GORGE", "M'HIRSSI INES", 2140 },
                    { new Guid("a50cf390-f10b-4969-bb3b-b6536e2b5e63"), "SM STOCK", 23, "22A1E2319526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("a58a8756-671c-47cb-a61d-18529eb40bb0"), "GHNP", 25, "23Y1E2330526", "SORTIE PRODUCTION", "WAFA MONTAGE", 5999 },
                    { new Guid("a5a197d1-103f-4a15-981f-e23c5ea3f814"), "GHNP", 2, "26Y12X33011", "ENGAGEMENT", "WAFA MONTAGE", 1999 },
                    { new Guid("a5e6d507-fcc0-4159-b858-61fb1546c7b2"), "SG 1", 27, "2614V320458", "MONTAGE GORGE", "ARBI FATMA", 2140 },
                    { new Guid("a5e7414c-9997-43f4-897e-e19ae7dae082"), "SM AUDIT", 32, "2614V320458", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("a5f2ecc9-1dfa-43ed-aef0-44cc20586b06"), "SG 4", 26, "21Y1E5330612", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 },
                    { new Guid("a64f98db-59f5-4e0c-9793-30287b26fac5"), "SM STOCK", 22, "181E2710346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("a737c9c9-90f4-4f3e-919a-830108c61e62"), "GHNP", 3, "22X1E2319346", "RECEPTION QUALITE", "THOURAYA MONTAGE", 9090 },
                    { new Guid("a7c0a4ca-4b1a-468a-afe2-8c64d713c79c"), "GHNP", 18, "20X1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("a7e7edb8-46e2-4517-a8fd-18a3e4b1d891"), "GHNP", 10, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("a8415937-ece8-4f0a-8c26-29fb872f5a88"), "SM CL", 43, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("a8bad686-befc-4787-9494-36da7dc6371c"), "SM STOCK", 2, "22X1E2319346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("a953ea2c-b03e-4eab-8ffc-11a265230289"), "SM STOCK", 17, "22Y1E2319346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("a97f2a48-6e9b-4ca6-98be-656b65b4c770"), "SM STOCK", 24, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("a9ffe05c-4dcd-4b6b-a055-397fac5ac512"), "SM STOCK", 18, "22X1E2319346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("aa8c6040-1c9a-4d87-8d47-3c3d73387cf4"), "SM AUDIT", 22, "22Y1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("aaddf621-c96c-42f5-8a39-91f1d20f5c42"), "SM AUDIT", 27, "2412X63088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("ab2c7c39-50d6-4fa0-9a57-9c8501a80d14"), "SM AUDIT", 20, "22Y1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("ab7377ea-2a62-4cad-a0b1-13afbd982376"), "SM AUDIT", 36, "2412X63088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("ac36eb99-93c2-4684-a366-3ff7fa3edfae"), "SM CL", 23, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("ac71c2b6-c5ae-49c8-857a-98aaf64b9460"), "GHNP", 4, "1612X70088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("ac7264f6-ef39-4dcf-bc91-980df3428801"), "GHNP", 47, "211E5720612", "SORTIE PRODUCTION", "WAHIBA MONTAGE", 5999 },
                    { new Guid("ad163a21-4b3c-485a-9fca-169949b9e0ff"), "SG 3", 23, "17X15C319448", "MONTAGE GORGE", "MANSRI RADHIA", 2140 },
                    { new Guid("ad79b3c4-fa7b-48a3-8b2e-f29ed5d0cc80"), "GHNP", 19, "22Y1E2319346", "RECEPTION QUALITE", "THOURAYA MONTAGE", 9090 },
                    { new Guid("ad83c121-e433-489b-88c8-e12830e88834"), "GHNP", 1, "28Y15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("adf1e4f3-332c-447c-ad2b-48f0442cecb2"), "SM AUDIT", 6, "22Y1E2319346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("ae19ef45-4adc-4a95-9e54-018299f43cef"), "SG 4", 16, "20X1E533015", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 },
                    { new Guid("aeb34440-fdc6-4f54-887e-40d78e55c9b3"), "GHNP", 67, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("afc3d5c6-74c9-4729-8adb-e9ac89d1ef1f"), "GHNP", 7, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("b07d6e24-a8aa-42b3-9edc-b0464657f35e"), "SM AUDIT", 33, "23X1E2330346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("b07fd633-c3c9-4679-94a2-1fd1009397c7"), "SM AUDIT", 34, "23B1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("b0c55b46-d068-4343-bbf2-9d9e2e9181b0"), "GHNP", 27, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("b0fe2192-15f7-4e75-a0f0-755871b29278"), "GHNP", 42, "23B1E2330526", "SORTIE PRODUCTION", "AZZA MONTAGE", 5999 },
                    { new Guid("b1150071-2a63-4aac-8b16-597aa95b4196"), "SM AUDIT", 32, "23X1E2330346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("b11c5d6c-45cc-4b4f-b469-dab671d89c47"), "SG 4", 3, "20X1E533015", "MONTAGE GORGE", "AOUADI LATIFA", 2140 },
                    { new Guid("b11d32ab-2e81-44e8-915f-a91552d04a08"), "GHNP", 13, "2712X63011", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("b127fb7e-06b9-4561-886b-b79ff30a0148"), "SG 1", 25, "2614V320458", "MONTAGE GORGE", "ARBI FATMA", 2140 },
                    { new Guid("b13d747a-bd3b-48e1-8390-32fe1a8400c5"), "SM AUDIT", 25, "22Y1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("b13d92eb-dc73-44fd-8546-9641cd9fb6a8"), "GHNP", 14, "23X1E2330526", "SORTIE PRODUCTION", "WAFA MONTAGE", 5999 },
                    { new Guid("b14bc245-7403-44c1-b2ad-0cc82b05534c"), "SM STOCK", 21, "2614V320458", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("b1f10c4c-8c7a-4215-a2c3-976aba305804"), "SM AUDIT", 9, "23X1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("b1f80251-fe54-46b7-9f5b-fec2f9f4aefd"), "GHNP", 42, "28Y15C330751", "SORTIE PRODUCTION", "BASMA MONTAGE", 5999 },
                    { new Guid("b21de55d-3594-4915-b111-ebe65a9b2115"), "GHNP", 24, "2412X63088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("b28246a6-860e-4c13-8a05-b7d985fbc875"), "SG 3", 12, "22Y1E2319346", "MONTAGE GORGE", "BELLILI YAMINA", 2140 },
                    { new Guid("b2da2fdf-53c3-492b-a463-a7c11067409f"), "SM AUDIT", 37, "181E2710346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("b31a4286-3b4a-4460-9767-ae2660f9053d"), "SM CL", 39, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("b34e75a0-ab8b-4657-bb9d-7eb697478175"), "SM AUDIT", 38, "23A1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("b36ac4a6-1136-4348-91fc-7607a9d81bcb"), "GHNP", 13, "26Y14V316458", "ENGAGEMENT", "AZZA MONTAGE", 1999 },
                    { new Guid("b431f893-3ed5-4e7b-8b05-4d061047f78b"), "GHNP", 33, "28Y15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("b4893ba9-c52d-45fe-a633-24578d174bf1"), "GHNP", 16, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("b4f3ab11-6537-4056-b17b-4cb566664463"), "SM STOCK", 18, "1612X70088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("b5367a20-d3bb-4732-bcae-6ccf1a6ee54c"), "SG 1", 12, "2614V320458", "MONTAGE GORGE", "ARBI FATMA", 2140 },
                    { new Guid("b5937aa2-240f-475c-bb22-35b2059b56a9"), "GHNP", 16, "26X14V316458", "ENGAGEMENT", "AZZA MONTAGE", 1999 },
                    { new Guid("b5eb31fa-c378-48b2-aa7a-96a9ca136a76"), "SG 5", 23, "23B1E2330526", "MONTAGE GORGE", "EL HOMRI AMAL", 2140 },
                    { new Guid("b5f5a81d-9848-4f57-acc7-86046384933d"), "GHNP", 8, "22Y1E2319346", "RECEPTION QUALITE", "THOURAYA MONTAGE", 9090 },
                    { new Guid("b6561d80-9bc0-4eef-b0b4-eb09fba8b526"), "GHNP", 39, "26Y12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("b6601dcb-e0d9-4e91-b15d-8a89807ace63"), "SG 6", 30, "22Y1E2319346", "MONTAGE GORGE", "SESSI SALOUA", 2140 },
                    { new Guid("b6bb1ec2-abf8-4cba-8efa-f76bdf4b48f7"), "SM STOCK", 1, "23Y1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("b6c9d344-8d79-431a-9a4b-097865d735b2"), "SM AUDIT", 18, "22X1E2319346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("b754ab70-7081-4a6e-81c0-fecdc71a5833"), "GHNP", 32, "28Y15C330751", "SORTIE PRODUCTION", "BASMA MONTAGE", 5999 },
                    { new Guid("b78b58ba-748b-404d-80c1-14552e7e533d"), "SM CL", 21, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("b798a1bd-c50f-4ff6-9148-e295f653b88e"), "SG 7", 42, "23X1E2330526", "MONTAGE GORGE", "M'HIRSSI INES", 2140 },
                    { new Guid("b7ad083f-e342-4b23-9c73-30e4b823f3ff"), "GHNP", 54, "211E5720612", "SORTIE PRODUCTION", "WAHIBA MONTAGE", 5999 },
                    { new Guid("b7e14dfb-b110-473f-b391-b7fb06cd5390"), "SM CL", 19, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("b7e2d993-de4c-4a95-ace0-22b05139f908"), "GHNP", 3, "20X1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("b7ee9396-68e5-4c58-bbae-8b8c36f0fba3"), "SM STOCK", 95, "141E271015", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("b831c118-199c-425e-b000-a4edd0d157f4"), "SM STOCK", 18, "141E271015", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("b8ad3e2c-bec5-4988-8676-fcecf0facc59"), "SM STOCK", 10, "23A1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("b9ec49d7-d89a-4337-a562-dfeb354ac323"), "SG 3", 33, "17Y15C319448", "MONTAGE GORGE", "MANSRI RADHIA", 2140 },
                    { new Guid("ba45d181-d519-46ff-b1d0-6f3ae0f357d4"), "SM AUDIT", 35, "23X1E2330346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("ba89a894-cc74-4bec-beb6-ea69af62487a"), "GHNP", 32, "241E2710526", "ENGAGEMENT", "MEHERZIA MONTAGE", 1999 },
                    { new Guid("bad57cd6-21cf-42c5-bd91-b7a575edcd86"), "GHNP", 10, "17X15C319448", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("bbd5e4eb-16e5-4548-82ac-8439c472a575"), "GHNP", 3, "26Y12X33011", "ENGAGEMENT", "WAFA MONTAGE", 1999 },
                    { new Guid("bc3958a0-7cf1-4471-a3f3-edefca86fc12"), "GHNP", 1, "26Y12X33011", "ENGAGEMENT", "WAFA MONTAGE", 1999 },
                    { new Guid("bd2f0b84-28ef-4a6c-ac7d-808374a79b38"), "GHNP", 26, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("be1be7c5-e721-494f-9fab-cf1e3c014acf"), "SM STOCK", 4, "22A1E2319526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("be753488-4386-44e4-9a68-9e6515f0b99b"), "SG 7", 25, "23X1E2330526", "MONTAGE GORGE", "LAHZEMI MOUNIRA", 2140 },
                    { new Guid("beaae9cf-432c-44fd-ad7a-9b53c40c6b38"), "SM STOCK", 31, "23A1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("beda76a4-72b4-414a-99dd-8c5f50c26f5a"), "SM CL", 41, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("bfab1211-f779-421a-bc61-522b87ae7d58"), "SM CL", 1, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("bfc28620-754b-4055-b246-b96e0b316a7a"), "SG 1", 4, "2614V320458", "MONTAGE GORGE", "ARBI FATMA", 2140 },
                    { new Guid("bff09c73-4b53-4e12-8651-d0f58384825c"), "SM STOCK", 36, "2412X63088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("bffcf940-760b-49bf-9af9-c3cbb06a9417"), "GHNP", 3, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("c009cf36-e8d1-441d-bc45-76981f551839"), "SG 2", 1, "28Y15C330751", "ASSEMBLAGE BASQUE", "EL MAHMOUDI WIDED", 2011 },
                    { new Guid("c05c9687-d119-4e7e-bbfc-3b1bdf699904"), "GHNP", 16, "23X1E2330526", "SORTIE PRODUCTION", "WAFA MONTAGE", 5999 },
                    { new Guid("c085682c-ca0a-4332-a469-389eb45e5ba9"), "GHNP", 32, "26X12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("c08b34f9-0e75-4f7f-a70f-cf3ece744962"), "SM CL", 26, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("c0a1737e-4505-4627-88ca-d4eaccb6f4d8"), "GHNP", 18, "1612X70088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("c11d48d9-7fce-4ac0-87b6-0502e9589d6f"), "SM STOCK", 35, "22A1E2319526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("c2157815-8a5b-4b0e-bd39-2d578fc144af"), "GHNP", 29, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("c2e4d03f-4849-4c1f-adf7-d1fbf9287a42"), "SM STOCK", 74, "181E2630346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("c301cfa3-d750-4536-b70c-d4989b68fa85"), "SG 4", 1, "20X1E533015", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 },
                    { new Guid("c33a759f-1fc6-416d-ae33-d43be8bfab10"), "SG 5", 21, "23B1E2330526", "MONTAGE GORGE", "EL AHWEH JEMIYA", 2140 },
                    { new Guid("c4bd0585-053d-4aba-90d0-6ac41b87d3eb"), "SG 5", 44, "23B1E2330526", "MONTAGE GORGE", "EL HOMRI AMAL", 2140 },
                    { new Guid("c55c005b-51f1-4ba1-a525-7db4bf5fe8bb"), "GHNP", 40, "241E2710526", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("c6130bb2-e24d-4457-8311-8ec4d2f88a00"), "SG 4", 49, "21Y1E5330612", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 },
                    { new Guid("c625bcf8-707b-49d0-8de7-b558cc137a14"), "GHNP", 18, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("c64d9fb4-7a06-4509-b298-1131ff94e571"), "GHNP", 3, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("c6b030db-1d8d-4a18-b222-1512ee17641a"), "SM CL", 1, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("c6b90045-2925-41c1-b83e-85e3629a9d74"), "GHNP", 17, "2612X320709", "ENGAGEMENT", "NAJET  MONTAGE", 1999 },
                    { new Guid("c6f47cf0-d597-4faf-8535-ea50e6cd6eab"), "SM AUDIT", 30, "1512X700088", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("c70eb6da-f2eb-4858-93cb-0fbe9619daaa"), "SM STOCK", 2, "17Y15C319448", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("c7351363-c1bf-4542-b2cd-6d910cca3f9c"), "SM CL", 61, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("c7bb0b50-d871-45f6-acb2-f6aca4675b6b"), "SM STOCK", 4, "20Y1E533015", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("c858d5ec-f6c7-49c1-b4db-500ea19af62e"), "SM AUDIT", 31, "241E2710526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("c8aedd6b-d887-4d60-8764-2bc4cfd06a9d"), "SM STOCK", 22, "22A1E2319526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("c8c82048-50c0-4d8a-a55e-fc52ac7ae8dd"), "GHNP", 4, "2614V720458", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("c8da203d-3708-4464-8be2-b35f28ad0d3e"), "SG 2", 50, "28Y15C330751", "ASSEMBLAGE BASQUE", "AYARI AMANI", 2011 },
                    { new Guid("c8e68ad7-4737-422e-846d-318a6de89f97"), "SM STOCK", 9, "23X1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("c8edd741-c68d-4ca2-9bed-2144c7f0e04a"), "SM CL", 16, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("c92b51dc-9464-44da-a78e-68fb9768f1da"), "GHNP", 55, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("c98dbaf1-b751-4eb6-9ea8-783ff9f89832"), "GHNP", 5, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("c99a3f98-8eb8-4739-af59-2328ebe43421"), "GHNP", 20, "2412X63088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("ca6396d1-5ead-4714-8d2a-a0548370cca0"), "GHNP", 16, "23A1E2330526", "SORTIE PRODUCTION", "AZZA MONTAGE", 5999 },
                    { new Guid("ca6ee632-7146-494f-84e5-43d47409ace1"), "SM CL", 40, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("ca7f4ae5-50d8-4705-a432-a61b1757a852"), "GHNP", 5, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("cb17bd14-736c-45f8-87a7-e6f1edbc36f8"), "SM STOCK", 40, "2412X72088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("cb1fab70-856f-49d0-815a-6e29a3ccaff4"), "SM STOCK", 13, "17Y15C319448", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("cb88625c-d50f-4df9-a5c9-64aa6b0aa6a0"), "GHNP", 13, "22Y1E2319346", "SORTIE PRODUCTION", "THOURAYA MONTAGE", 5999 },
                    { new Guid("cc225523-8f6d-4095-8a13-5739aab88e31"), "GHNP", 17, "22X1E2319346", "SORTIE PRODUCTION", "THOURAYA MONTAGE", 5999 },
                    { new Guid("cc32de3b-71ee-4625-a520-54fd95ad78ca"), "GHNP", 26, "26X12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("cc64d76f-f8e6-415d-bf47-e1e4f73143a3"), "GHNP", 19, "22Y1E2319346", "SORTIE PRODUCTION", "THOURAYA MONTAGE", 5999 },
                    { new Guid("cc76ca6e-88d1-468a-a3f2-2782fd5005d6"), "SM STOCK", 7, "201C451015", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("cd47f807-e02b-40fc-b71f-0b680895e7b8"), "GHNP", 36, "28Y15C330751", "SORTIE PRODUCTION", "BASMA MONTAGE", 5999 },
                    { new Guid("cf70545d-b043-4bf4-aaec-6e5af701ab79"), "SM CL", 23, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("cffcff6e-fd2b-400f-95d5-f4b96bdd136f"), "GHNP", 44, "1612X630088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("d091a2b8-de9c-44b3-89a7-7765f8ec79e3"), "GHNP", 1, "20Y1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("d0f35b40-bf71-4b3d-b0f2-5a9978e097f0"), "GHNP", 59, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("d0fe46e2-356d-4b98-b2ea-fe3ca45c7998"), "GHNP", 6, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("d1077e97-29bb-47e3-a7e1-e6ae6b4eaf53"), "SM STOCK", 33, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("d1de97db-fc5d-48bb-ad51-55733ad298d7"), "GHNP", 10, "2614V320458", "RECEPTION QUALITE", "NAJET  MONTAGE", 9090 },
                    { new Guid("d2b61daa-add7-4451-a443-46417ba2a105"), "SM CL", 19, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("d2c13bd9-e5a4-4832-b4b3-94b2c8ae8c90"), "SM CL", 24, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("d35b01ec-8bdc-4471-afa7-7c6f232ed6cc"), "SM AUDIT", 7, "22X1E2319346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("d37a96d5-4932-4527-a821-f441c30d72fd"), "GHNP", 67, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("d3afb1ad-8b3e-4d28-ae59-5476780865e7"), "GHNP", 36, "23X1E2330526", "RECEPTION QUALITE", "WAFA MONTAGE", 9090 },
                    { new Guid("d4fc0d34-0c36-4c38-8dbf-2856add1d04e"), "SM STOCK", 19, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("d59eb88e-d994-459c-9725-19150adbac88"), "GHNP", 13, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("d5c18989-1ca0-4bad-92b8-629e8518d76c"), "GHNP", 28, "241E2710526", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("d5c49000-89bb-43d6-91b0-1af4e92eea32"), "SG 6", 29, "22Y1E2319346", "MONTAGE GORGE", "SESSI SALOUA", 2140 },
                    { new Guid("d6139191-1510-4a04-b62c-f1433587c76b"), "SM AUDIT", 13, "2412X63088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("d62cf05a-389d-41b8-9980-92dbc7185186"), "GHNP", 9, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("d63213dd-c2a0-4d9c-a03e-1f141d323250"), "GHNP", 64, "211E5720612", "RECEPTION QUALITE", "WAHIBA MONTAGE", 9090 },
                    { new Guid("d6989eeb-9966-4351-82cc-558694b52641"), "SG 1", 10, "2614V320458", "MONTAGE GORGE", "ARBI FATMA", 2140 },
                    { new Guid("d6baf084-aae8-4150-a0af-6bcada18d40a"), "GHNP", 40, "28Y15C330751", "SORTIE PRODUCTION", "BASMA MONTAGE", 5999 },
                    { new Guid("d6e69a1f-5f9d-4425-9310-18150ce3168a"), "GHNP", 38, "2412X63088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("d7d9ff7b-eced-42ba-8e94-ebb80ac559c5"), "GHNP", 40, "1612X630088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("d7e0086c-2a7a-4989-9cc4-c3f625fbb9d0"), "GHNP", 28, "211E5720612", "SORTIE PRODUCTION", "WAHIBA MONTAGE", 5999 },
                    { new Guid("d825fd8a-5104-494a-88ba-4cc9ce3a32da"), "SM CL", 24, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("d84d23bb-1910-4bef-add4-d3f3ae95df52"), "SM STOCK", 38, "181E2710346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("d8954c41-278d-44c1-bd7f-645dbbc92c22"), "SM STOCK", 8, "181E2710346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("d948bd64-40b6-40fc-afcc-5c0a552e5885"), "SM CL", 22, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("d99058f7-32f4-4235-8075-f581a50ee9d4"), "SM STOCK", 39, "23Y1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("da764337-f5f7-455c-bdd9-eac98d36993c"), "SM CL", 59, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("da7c60c8-5402-4ec8-98b6-603180b8effb"), "GHNP", 7, "181E2710346", "ENGAGEMENT", "MEHERZIA MONTAGE", 1999 },
                    { new Guid("db7f3571-dd1b-4056-95e5-0fc527db507a"), "SM AUDIT", 5, "22A1E2319526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("dca17b18-877f-4ec6-a8e4-e63f8fbca3fd"), "GHNP", 60, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("dcecf432-ad89-4dc5-bea7-94fc8d73c8d4"), "GHNP", 37, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("dd01d501-c5bf-4653-9241-9a647f2031d6"), "GHNP", 11, "20Y1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("dd3e0dc1-6a73-4db2-940b-b919fdfd45e8"), "SM AUDIT", 31, "181E2710346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("ddc02b96-2a17-4185-a841-235a6230b633"), "GHNP", 17, "241E2710526", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("df41a5c5-5d00-4fde-ac70-f0c82cb709aa"), "SM CL", 7, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("df5ecbbb-2150-478e-b001-89a9f79f6a7a"), "SM AUDIT", 30, "181E2710346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("df713fc7-6919-4df7-b709-a352dfd770d3"), "SG 2", 12, "28Y15C330751", "ASSEMBLAGE BASQUE", "AYARI AMANI", 2011 },
                    { new Guid("dfeb0ea2-1978-450d-8ed5-b187c16a9168"), "GHNP", 49, "28Y15C330751", "ENGAGEMENT", "BASMA MONTAGE", 1999 },
                    { new Guid("e03469e4-3ebd-48b3-84ba-94b4a5b1b43a"), "GHNP", 44, "2412X72088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("e03932ad-7486-4479-95e1-41d0a9b34695"), "SG 4", 48, "20X1E533015", "MONTAGE GORGE", "AOUADI LATIFA", 2140 },
                    { new Guid("e0ac521e-d7d0-456c-a891-9737fd385ee5"), "GHNP", 14, "26Y12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("e0c3c384-d60a-43ed-941f-e829e4235109"), "GHNP", 49, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("e20ec594-0c35-4d09-a0ac-d601011797c1"), "SM AUDIT", 32, "20Y1E533015", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("e2570c24-fa88-4d96-aae3-9f38e530d22b"), "SM AUDIT", 41, "23X1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("e2873de0-fd7e-435b-b277-2b8f8818bf53"), "GHNP", 1, "21X1E5330612", "ENGAGEMENT", "CHEDIA MONTAGE", 1999 },
                    { new Guid("e2bbe69b-f713-43a0-88e3-44568fecd628"), "GHNP", 33, "24Y12X33088", "Sortie Qualité", "QUALITÉ SIMOTEX", 9100 },
                    { new Guid("e2bf6388-6ae1-48e4-9ed2-fb8d9de809f1"), "GHNP", 9, "2412X72088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("e3730439-30ce-4c64-950b-f4e8be0089cc"), "GHNP", 9, "2412X72088", "RECEPTION QUALITE", "WAFA SL MONTAGE", 9090 },
                    { new Guid("e42944af-7da7-44d3-aa15-597edfa5d481"), "SM CL", 25, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("e4d0aa54-86c9-4ca0-81c0-7e1ffedc185b"), "SM AUDIT", 40, "1612X630088", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("e55a6d49-7751-4719-b40f-5e08905d0442"), "SM STOCK", 42, "23B1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("e5690331-c243-489b-bde7-11acda3c4059"), "GHNP", 41, "20X1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("e5a021ff-147e-4917-9247-05c06b154291"), "SM CL", 19, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("e66d10e3-5684-408e-9300-d29091ddf960"), "GHNP", 68, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("e69a6943-d5cf-40ba-b289-5d29a611b871"), "GHNP", 5, "26Y1C2319661", "ENGAGEMENT", "THOURAYA MONTAGE", 1999 },
                    { new Guid("e6c165b9-8abb-4628-8e10-61f872f49ed0"), "GHNP", 17, "26X14V316458", "ENGAGEMENT", "AZZA MONTAGE", 1999 },
                    { new Guid("e842b436-bc15-4814-af5b-0e8e28f1112c"), "SM CL", 18, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("e8cc8ec8-0f06-46ca-8883-e5f250a904b4"), "GHNP", 52, "2612X320709", "ENGAGEMENT", "NAJET  MONTAGE", 1999 },
                    { new Guid("e8db1f84-8e13-4f4c-a8db-1e128abbdefa"), "SM AUDIT", 38, "2412X63088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("e9598152-d243-4792-88e6-42f52a60af6d"), "GHNP", 59, "2612X320709", "ENGAGEMENT", "NAJET  MONTAGE", 1999 },
                    { new Guid("e97a31e3-f6d0-410a-9455-70ac5537b059"), "SM CL", 13, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("e9c34db8-df2e-45e7-b41c-81e0246cbc40"), "SM AUDIT", 26, "181E2710346", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("ead55b56-fa1c-477e-ad39-607f1fdea261"), "SM CL", 48, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("eaee337c-2734-4f7d-bbdd-4d6aa5b8479c"), "SM CL", 7, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("eb697a19-cce4-4eca-a827-77b4a2ca8abe"), "SM CL", 21, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("eb746ce3-edb6-4d7f-81c2-7f64b29a207b"), "SM AUDIT", 24, "23A1E2330526", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("ec2a63e3-d3b7-4308-8fb5-9ced326118bd"), "SM CL", 18, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("ec69b397-9ab9-4884-8359-619a2dd7544f"), "GHNP", 15, "241E2710526", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("ecf8f51c-f550-4274-b508-9dbc1f99c44d"), "SM CL", 14, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("ed06fd41-7935-49f9-9eb7-f112782d14d7"), "SM STOCK", 4, "1612X70088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("edc30fc2-5a9e-4317-ae4e-bb33fb3d9e8c"), "GHNP", 30, "21X1E5330612", "ENGAGEMENT", "CHEDIA MONTAGE", 1999 },
                    { new Guid("eeac9923-f8bb-4d84-a17f-00c44fa2dd02"), "SM CL", 18, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("ef4153cb-1d49-44ad-b63d-033e7fb2eb51"), "SM AUDIT", 34, "181E2710346", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("efa5e022-a6da-4960-8940-3c0dbeb3aac2"), "GHNP", 7, "2412X72088", "SORTIE PRODUCTION", "WAFA SL MONTAGE", 5999 },
                    { new Guid("efe5bd23-e636-4a68-a401-0c162e63cb22"), "SM CL", 3, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("eff377be-77d9-49a3-9830-a661728b1d37"), "GHNP", 25, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("f00787fe-05f8-4a27-8383-36cfbb8102d4"), "SM CL", 10, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("f023040f-5daf-4c1c-9460-2e6ef1e9ddae"), "GHNP", 16, "28Y15C330751", "SORTIE PRODUCTION", "BASMA MONTAGE", 5999 },
                    { new Guid("f03aaef1-efde-47ce-adaa-24c7d3bdd9c9"), "GHNP", 23, "17Y15C319448", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("f03db3b9-299b-4fc6-b792-22d5a72c51f1"), "SM STOCK", 37, "181E2710346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("f066d3a2-4aab-4364-a17f-ecd1900f4137"), "GHNP", 28, "181E2630346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("f06c00bb-17a1-4bc2-b003-0de2bad27fc9"), "GHNP", 15, "241E2710526", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("f113562a-a761-4577-8b46-314c975efadd"), "SM CL", 58, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("f13a8ef7-e0cf-4fa8-9dc3-588bc41298e7"), "SM STOCK", 34, "181E2710346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("f1902eb2-f6bc-4040-a6b2-09323416beba"), "GHNP", 14, "17X15C319448", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("f19194f7-ba00-4163-b86a-301e74004a78"), "SM STOCK", 41, "23B1E2330526", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("f19bd39b-c57d-47c7-8da1-3ea3a04f9af2"), "SM CL", 24, "291E2720526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("f2f90fd1-a361-4c9f-8f31-712ebd4ed9c1"), "GHNP", 27, "23B1E2330526", "SORTIE PRODUCTION", "AZZA MONTAGE", 5999 },
                    { new Guid("f3a3d2be-a25c-403d-9e52-20989bf02e00"), "SM CL", 4, "291E2710526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("f4700b7e-ba34-4fc1-b8dd-8f69c2b5a8d4"), "SM STOCK", 29, "23X1E2330346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("f4dc622c-ca5d-4797-aa12-f1b952e0a2d8"), "SM AUDIT", 21, "2412X63088", "CONTROLE CLIENT", "MANAI HANEN", 9099 },
                    { new Guid("f5238cc4-d6ee-4be9-b462-0a192864826d"), "SM AUDIT", 36, "23X1E2330526", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("f626eab5-69d6-49c7-8679-28a1d82d5353"), "SM STOCK", 27, "17X15C319448", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("f6a24c32-a44a-4836-8b84-bb60cd4d853a"), "SG 7", 46, "23X1E2330526", "MONTAGE GORGE", "LAHZEMI MOUNIRA", 2140 },
                    { new Guid("f6bc79c5-7c8c-4554-b4e5-3910afda0b1a"), "SG 2", 4, "28Y15C330751", "ASSEMBLAGE BASQUE", "AYARI AMANI", 2011 },
                    { new Guid("f6e1a608-8f5f-4e19-8bd6-cdecfa2ea5bc"), "GHNP", 18, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("f6ec7901-8b14-474d-96d4-5fe5a9af2a3e"), "SM STOCK", 44, "1612X630088", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("f72b4756-fdd0-4c3a-ad1b-5baaa290f6bc"), "SM AUDIT", 7, "2412X72088", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("f74049b3-c3b5-483b-bfd9-df399822e498"), "GHNP", 18, "26X14V316458", "ENGAGEMENT", "AZZA MONTAGE", 1999 },
                    { new Guid("f7afc06b-4f7e-4467-942b-946a2df75375"), "GHNP", 28, "20Y1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("f88ee010-4cb4-43ca-afd7-dbfa4e4db626"), "GHNP", 14, "181E2710346", "SORTIE PRODUCTION", "MEHERZIA MONTAGE", 5999 },
                    { new Guid("f8a7bdda-ab48-4701-a62e-480c8a1d19bf"), "GHNP", 32, "28Y15C330751", "RECEPTION QUALITE", "BASMA MONTAGE", 9090 },
                    { new Guid("f8e9d9c4-2346-4ca5-a3b9-50a529152988"), "SM CL", 53, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("f9081638-6eee-4ff9-991e-0f42a8e93ada"), "SM CL", 6, "291E2770526", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("f92183fd-2bfe-459c-af39-10820159087d"), "SM AUDIT", 2, "17Y15C319448", "CONTROLE CLIENT", "BEN BELGACEM  SANA", 9099 },
                    { new Guid("faa42b23-611a-42d9-8067-903ec09572ee"), "SG 5", 57, "23B1E2330526", "MONTAGE GORGE", "EL AHWEH JEMIYA", 2140 },
                    { new Guid("fbf0471a-20d1-4163-980c-906f975081e2"), "SM CL", 28, "29X15C347751", "COUPE LECTRA", "COUPE LECTRA SIMOTEX", 900 },
                    { new Guid("fc520475-8786-45df-b043-b199bb5ad1c6"), "SM STOCK", 23, "22Y1E2319346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("fcc4183e-55c9-42a4-a8ff-69f4c1761811"), "SM STOCK", 26, "21X1E2347346", "ENTREE STOCK TUNIS", "SIMOTEX ENTREE STOCK", 9000 },
                    { new Guid("fd88d988-559e-49e4-adc7-e19b34d60a90"), "GHNP", 7, "1715C720448", "ENGAGEMENT", "WAFA SL MONTAGE", 1999 },
                    { new Guid("fdfac8db-bd17-42a8-89e5-64bf705e5fe0"), "GHNP", 5, "26Y12X33011", "ENGAGEMENT", "WAFA MONTAGE", 1999 },
                    { new Guid("fe5ea0e7-91d7-4597-8037-7fba909d8fb0"), "GHNP", 23, "20X1E533015", "RECEPTION QUALITE", "CHEDIA MONTAGE", 9090 },
                    { new Guid("fe65469a-1e88-4608-a73c-09dd6216cddb"), "GHNP", 30, "26X12Z316314", "ENGAGEMENT", "AMEL MONTAGE", 1999 },
                    { new Guid("fe668775-b45d-4806-b540-e9ae17ee3593"), "GHNP", 23, "20X1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("febc13c4-8cfd-4036-ac96-9b8d1e7c205a"), "GHNP", 61, "211E5720612", "RECEPTION QUALITE", "WAHIBA MONTAGE", 9090 },
                    { new Guid("febfc68e-9fbc-4d42-ac32-db7e7b61374c"), "GHNP", 14, "23X1E2330526", "RECEPTION QUALITE", "WAFA MONTAGE", 9090 },
                    { new Guid("ff0c8c01-e250-4cf9-bf79-dc7b5b2c22cd"), "GHNP", 4, "20X1E533015", "SORTIE PRODUCTION", "CHEDIA MONTAGE", 5999 },
                    { new Guid("ff5656bf-5144-4499-84f2-8f338ca391d5"), "GHNP", 31, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("ff750eb0-2adc-4368-9503-1964d6bea2d8"), "GHNP", 9, "181E2710346", "RECEPTION QUALITE", "MEHERZIA MONTAGE", 9090 },
                    { new Guid("ff8765db-66d2-4008-9e2e-01da7d2969ce"), "GHNP", 43, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("ff8ff391-04d8-41b2-af40-1a1604c4d17c"), "SG 3", 16, "17Y15C319448", "MONTAGE GORGE", "MANSRI RADHIA", 2140 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("00194635-a943-4683-849b-2cca087ecdce"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0034524d-d3cf-4c3f-9fe0-547c395a3ea9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("00a69d2e-3b6e-4705-a85e-3bdcd80cf115"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("00f3e4fd-4ecf-42c7-af9e-8183115d0134"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("013e0244-7c7d-483f-a2f3-e7c8215a12fc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0144ec8f-f2fb-4755-99c7-13e8a2362fa0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("016edaca-e87e-463f-8fb4-94bdd549a8f3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("026619fe-1560-46df-be01-571d19081b6c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("02a16567-fc63-4740-ae09-2bb3b1d1b689"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("03035563-0e9c-480d-9a04-1ccd08df5d47"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("031bdbce-32d7-499d-99ce-4953db4f90c3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("036be02e-8063-4124-8d9a-2cd60b8a884e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("039ebc4b-74af-4d57-b835-46d9d58d019f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("03ba292e-1faf-4e54-abe2-c24ed62686b9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0430fe44-03f4-4a25-b0a2-c7c7b80a3263"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("050cf0b6-a9b7-4d5f-a1e8-d236ded51eb9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("053068c2-f078-4b48-b8ef-36cdc7922a48"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("055c8fdb-1961-4ab7-a517-78f3f7628aeb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("05d1c595-1cfa-4594-b739-d6a7a988bd26"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("05e39e1b-95a8-4952-b2c3-666af3ca54b9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("06157af9-80a8-4832-ae36-ceaead63f04a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("06371176-54ec-4423-be07-8137aab79bed"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0678a092-3d56-48e9-afb6-55b790cf2615"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("06805421-7218-45e4-8da9-9f79b0a5f26f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0718af5f-bad7-4acc-9731-61f3e103fa72"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0767ddc7-0d79-4290-b300-be302aeca10d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("07d5b2cc-c746-4492-90f1-b62ce271c636"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("080a1707-4813-4f16-9766-46d8840b61dc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0853383a-8f5e-4936-bc8b-b58023e22d59"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("096aedad-f4c6-4156-ba79-e17768348fc3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("09b18dab-8983-4f8d-9e73-30c1f95160df"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("09e18ecc-5387-49e4-a5ef-4c8a023be0c9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0aa4a53e-4f37-4c07-87e6-901bb344250b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0ab40c47-c62f-4a44-9f1e-a246c2f915db"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0ad6eb6f-c212-4d25-8e1b-d66cd392573d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0aea82a6-b4a2-479b-886b-128d6240ada9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0b357b7b-146e-46ec-8f9d-aa130519b13e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0b697801-95d2-4297-91e8-5e72154a7f69"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0b6e2a5e-00db-49ff-9d2e-74d44c3aafc1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0b7e895e-e203-437a-809f-5e875a5024a9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0ba0fe2a-5156-4ea6-93b9-ca5a41aa984f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0ba300ec-a612-49f5-a81d-aab310590ab6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0ba67db3-bf90-4244-b1f8-42bc7d43ae85"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0bb8a1c6-00f6-41fb-a6eb-4f513c441e85"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0c7a3e17-69c2-4ce1-ae53-dc24219edb9a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0c939ccb-f9d5-46b0-8450-4ed06e91f9b8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0ca4e062-c07e-4f08-953f-fcd93a9d5f98"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0d0d45fc-e26e-409f-b326-4a62ea1b4da3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0dddcffc-b1f6-4cbf-a176-c97a133cb5eb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0e16ac2a-d3c7-4de2-ad17-91ea39a38979"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("0eb71017-7f3b-4575-be88-43dc9581cf13"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1117ef05-6d13-4cdb-9e07-3a15d99048ba"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("11345204-ca1d-418e-9801-275d89999f6f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("115765f1-8a5c-4547-b160-4a280e9b7bdd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("116afa08-aaaf-422d-a52f-e24859cff5de"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("11b95204-c437-40fb-90f9-8d0f7774cab3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("12660339-275f-4c1e-963c-010cc1221cab"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1293e0b8-9228-4ca9-8764-ea965ba45424"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("12e997fd-b343-460f-8b87-bbbce725abce"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1345a364-e324-4c8d-baf0-5e28aa32f367"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("13515131-5af3-4cde-99f0-b34da3ebb24e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1393f7fe-3d06-48f5-bf89-dcae98c60bc9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1425d49c-616b-47cf-a314-a2d685bb9500"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1457a3b2-8a4b-41fc-b5fc-334d738c3208"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("148cf0af-c385-42b9-ae7a-cc6e6151bbcb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("14e66126-d16f-42fa-a750-9862bd52a047"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("15b58fd7-b68b-417d-8815-91691c007fd2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("15d1b77f-d70a-4dbe-a585-630f9b8256ae"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("15e1dd4b-8fed-4253-85c7-21424b0e3254"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("15f50e48-3cbf-4596-bf72-2f9de44cd54c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("15f955e8-e8d0-464e-a321-b50c607e86fb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("16332b28-269b-4f96-ac48-7209cded6320"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1739577d-a01d-4bb7-955f-31f4580bef3b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1776ddd0-3052-4f5b-bee6-2a160eed35c2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("17b494fc-e493-4b8f-8599-4293f82da71f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("17efdaa4-d900-43f6-b93d-69e56bc76eb6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("18ad8927-3edc-45b9-b5c7-41a6350cab6c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1955483f-2ed3-4998-a187-2fa779875f18"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1a515b36-6a6d-4614-a8c0-2204b9371896"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1a962bb0-33a3-49c6-9ee3-33a23514aa03"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1ab63740-4395-436f-aaba-093fb35ffa84"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1acd0df1-6329-4921-a6dc-658d1602e074"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1b0b02de-efa9-42f5-a2e9-d99431b1049d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1b709fe4-3f8a-481a-8b65-5e2f3197b36e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1b8ac4b7-1330-4cf3-a674-5ffba36a0a1a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1b98fc3d-9eb5-4fe5-ba65-ce780642d06e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1bbf4cf8-7962-4f26-972d-68c48e27853c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1bd53001-2dfa-49f8-a7d8-7a9b2fea08f8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1c28a621-0126-41b8-9301-a780b892a097"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1c7dc34d-f5b6-43ef-9733-9112325ae232"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1cec048e-2424-4f54-8463-f4bd2eeea5e5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1d83c2d1-7237-4fb5-ade7-c2a6b6ab547e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1dd46c20-819b-4aa4-9041-338f45142575"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1e37bb37-f05e-485c-b4b6-c8af3c6dcb99"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1e61167c-8afb-4110-855e-be1931e22bca"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1eee2f77-0e08-43e6-bd13-ab47d86cf69d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1f014eb7-19fe-4fe5-8663-0fd9a04cad13"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1f26bdcc-b362-40e5-b69c-024becba9fdc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("1fdf0209-0f73-433b-9057-9d06d7060f66"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("200e7f47-f7cb-40ed-972d-05ec1ae2e0b5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("20fa6ef7-d148-48eb-ad41-2670de021bba"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("215d9266-445a-4ddd-9df4-d8d1acb01b91"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("21d51172-7056-47ab-86fb-df7cd953694e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("22152ac1-ed73-472f-b497-fbfcf9828df8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("22248ce2-4c4b-4463-8e76-10a8a4615d08"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("22d53e9e-05be-4a74-9be1-c19f6b5d6647"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2348b3e8-07b1-47ba-817e-f7716d4f3c28"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("237d3296-30c6-4304-8a8f-45d1d0643e8a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2396498d-0b88-4464-beaa-a050e55efd8e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("23992d04-1e07-4d75-a722-bea3ec46c86c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("24041909-13db-4aeb-9f24-7f625caf4861"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("241bdfda-7f53-4681-8aab-98cadfc83f57"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("24744347-34ae-47ed-86e2-08b6f9f2ee04"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("24903b2a-cb9d-4734-947c-c890fbfde11f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("24afefa5-4c6d-472c-83e7-597b5451aa6d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("24ead4b1-a171-401e-b7ff-74c8ebd7ff4e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2546fdb4-20ad-444c-90ff-bd736bf0f9a1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("25741c17-3c9f-465f-bec6-28dc47755efd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2604c293-18f6-4370-977c-76814426eabd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2606bef8-7158-44a2-8352-8225ae7fbd70"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("26d70c80-5d14-4f57-914d-14f7eb014764"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("272d9da1-f134-4c31-81d2-b0f0be9a2a98"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("27c8e766-2610-4cbb-be65-b3d26b30798b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("28c5311a-ef4b-49e4-8011-1b83d56892b5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("290fb1bf-d0ca-4e87-b4cc-bd261f3e9eb5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2974e4ca-cfa6-4018-a22b-80c2d31a39f0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("29dbd665-d94f-47a1-b3fc-9652cfa39364"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2aa5495e-337a-4c15-a8fa-1491ce0ca45d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2b68dd67-adba-44ed-8501-111843603fc3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2bd53952-ae92-452e-806a-33a4223d6c33"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2c2fe7bb-1a1c-4a03-9571-2fe9f44372d3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2c393f91-967b-4738-b5af-a0830a98fc04"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2cee7103-256d-4d94-973b-46123c813c7d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2d01125d-99d8-462f-9ac2-e7945b5ef267"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2d149875-c101-4dd9-b827-6dc7cba4fe74"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2d882eb6-9969-4977-93d7-f2883bae9c75"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2dc34542-413a-4616-8d5b-4f3562c87c39"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2e0b902a-acd5-4111-8210-ece01a482e29"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("2ebe8d90-4997-4125-b7fb-60412b7c782b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("30056126-ef13-4e9f-9f24-00f879a07b2e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("300d796f-58b6-4687-ba8c-b88a3dba01b1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("30113f94-680e-4c98-8fa7-51dcbc17ea21"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("30998bf8-b342-41c8-ba27-b73607c8e032"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("30cf247f-8ad1-4325-ba65-0bf2a35620ea"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("310551a6-33e8-4bd0-adff-9bb927635e44"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3143fbc6-9f43-4f93-a473-981d74bc5756"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("314ade28-e2b4-461c-a5e6-faea172e5626"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("315d5921-46a6-490a-9644-f69ac5dcedf1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("317d1cc3-45f0-4453-8c9f-316684f83ae5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("32a79ded-a332-4393-8a32-44c1b76fd9da"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("32d06277-4e80-44b0-9fe1-eef404d5dd02"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("32d21ece-a4bc-4c21-b296-b2d62bc3f842"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("32ee1f90-2664-4eb2-b6e5-c53183206b73"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("330eece3-08a8-4fcc-9ca2-5a805146a8e4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("33b81849-af17-4973-bcdb-6a09091ee512"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("33dc12cc-e93b-42b6-9085-f0c6eb4fa0a9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("33e05b83-e60f-4a26-88d7-df8217e7b622"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("347c1b3a-81b8-4a5d-8cee-5542eca52c22"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("34a5002e-0d95-4322-8376-dd146f0ba151"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("34e512b3-0088-47f8-a115-6cede9cb040a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("35486dc7-0658-41ac-89dd-6e63b30577ce"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("35e31350-8683-4edb-bcc4-cf7a7a7c022f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("364e5d43-75d9-4979-9eab-172ca8888814"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("36c2b6c5-99e8-4424-917c-a0f464a6db22"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("37a4b8f5-f394-4e3e-a1f7-bd211b7cef91"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3873fcde-fb27-41b3-846f-957c03e62618"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("38d8921b-bd95-4924-a047-98380c7e0d44"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3956a7f6-fdbb-4595-bc42-bfe9cfe018ee"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3961d8ab-2c46-499c-ac83-353df9db6149"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("39daa2c0-8770-493a-9b29-4f3fa5118d88"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("39e150cf-0218-4e56-b219-4950ed615dce"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3a1cdc3b-ed9b-4ec7-8cd6-64d50beccc66"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3a35f5a2-4255-41a2-96ac-13e53ac3c72b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3ae79e71-9643-422a-85cf-884906cc07b8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3bb4d9a8-3403-4c89-aef1-7070106054f7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3bd703af-acd7-4afc-957e-2f3c65d6d89d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3c2efef4-124a-4dfa-a2c5-70b83e5bf870"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3c516b64-37df-4807-a906-8d4eb361ca59"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3d84301e-889a-4b34-a8ff-325cac187fde"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3e051a83-3b6c-4708-92d4-3db6de8ee602"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3f84fee9-19c9-4271-93a3-a232d3814aaa"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3fa5cc12-1fe5-4336-b8e2-35912354ba2e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3faee655-e2d9-4834-b0f3-c63744ccf327"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("3feed6b9-7674-4b58-bad4-7a5a07db0101"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("407c0b0b-495f-465b-b5be-82bbf4c664b6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("40c9f32d-560f-4d03-b756-c3630f0923b2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("411708de-383a-47ca-8611-b44dc1a0c09c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4153bd38-9d2d-4db7-8a37-6a03b5f14e37"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("417b52c9-5976-43ef-be24-48915104969b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4306074d-c21c-4073-8519-5f7a1934680c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("430a0039-de7b-4b23-83d6-76ac7a50c4a7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("438b9a87-db4f-46aa-88ee-7f28aeee0a1e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("44af257c-b97d-4f35-9012-b60d2ea0ad39"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("44c605b5-d456-4997-9efe-705f48a34e68"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("44fc924c-f6c1-4c54-b15f-55234dd0ed71"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("45334085-245b-446c-bca3-e050929627a1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("456868d2-fde5-4e4d-8101-e1a558e3f497"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("45840865-7668-4d07-9e05-cd5c5c76bea6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("45a7ec5a-fb11-464a-b165-4693e2fae30d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("45d66f13-5680-4e0f-bb92-7ba772de944d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("46df45b6-755d-4dfa-aa3e-0a4d8c1b93b2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("47569888-ab81-4fa0-bd6e-cb8514e5908b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("47b20e63-eba2-46b6-9111-3a97e3297041"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("47c1e1c5-fa33-41e0-8f90-7f49e5ae1c28"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("47cc83ae-befa-4be9-bc65-5a34cca2a1f3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("47f7dd63-e9c1-4978-8866-2451c2d7d844"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("48481a33-273f-4f33-af59-3982e34bc2b3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("48f5ead3-77d4-44f4-8cb9-203ffd8ae006"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4932dcd8-80c0-47ff-867e-fbccadc933e6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4935dbb1-0836-4c2d-8013-8572529e9191"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4a2e6215-5b89-4769-98ba-ae9fa41abae1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4a7900d9-8e1c-4f5f-b3c9-8d03dbcbca04"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4a9bd55b-48a5-4f86-97b9-8f0aed4689ca"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4bef58ed-f009-4f32-8f91-c7cdfb84c013"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4c038df6-4eb0-4078-ae40-9510db2393a0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4c0a91cf-8595-45d4-a1be-251547e10a27"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4c3f75ef-d583-432d-bb31-092d360827df"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4c5057b5-220d-4b67-b35d-4814462f759e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4c932885-29a0-4599-93fe-b693f2069065"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4d34665d-5a37-43eb-b6ab-8ffd51dc5d5a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4d5a807e-383a-4cc4-a71e-18672eab00a0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4d6cb64e-8a68-46a8-9217-8164f90cb379"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4e070f9f-ec2a-430d-9837-c61e43cc05bd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4e103fae-bbad-4a50-adcb-579fe4ae860f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4e1b5538-4359-46e0-81de-7224b0ba7251"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4e2148ef-49d7-4717-8d3c-ce81aa5a36eb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4e3c6c62-407a-49a3-9b2c-8269faf52d7d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4ed513d5-086d-4e4c-be3c-57b4e81aa5df"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4efe76ab-3aab-443d-b7bb-12f43cef1cc7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("4fb25191-b134-44ac-a284-3dadb4fa4f28"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5054ebbb-a1f7-43b9-920a-de7110a26c5d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("506cd1bf-5897-4e63-850e-d035e6ada6d3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("50a4ae8c-589e-4c84-aed4-cd10320c854c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("50f70dd4-4d8f-4836-ab27-7aac4b5bf34d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("50faa526-4f7d-41a2-bb69-be8a6c2f147a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("50fed549-ac48-437f-aa1b-65e8d67dd401"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("513db942-d873-4f8e-85ba-67b9fd2ab8a0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("517a2a3b-1132-44ec-bc22-561967ef41a6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("51c01393-f2d6-4db8-8965-8f94bd62656c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("51db36c0-328e-4861-a258-664834c80b3d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("522f020d-045f-43ac-9c82-224464800614"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5277b8f4-9d7a-49f4-8bd1-d4084c244525"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("53607432-d5a8-41c3-ad09-0bd9f7dec9f5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("53e32b51-ce8a-43fe-b0d7-ac9f2b3a221d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("542fe04f-a5fa-49a8-8af4-7b7faade72bc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("54b46b49-7f5f-4e9b-aa1c-5c33b81f9b31"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("551f5d7f-f56d-46eb-8072-c562fcef300b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("554ff681-2ae3-4511-be8b-1bb1826c1bd1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("55b80844-4e64-45ce-8431-5c30da53d0fa"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("55d4fd3e-0d07-42b3-8917-f1bc1844e8ba"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("55fc124d-f22c-4d6b-9db0-0c4b431dc71e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("56fb4b46-3f10-4e15-a882-d013c737ffe9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("572ac72d-1e40-45f1-8cd4-f370830bc87f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("576e5b9a-1574-4f39-a8ed-4b88ed03b2bd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("57ae1008-325d-44b3-bb6e-87d9786f95d1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("582aafcf-4173-4459-a84a-28cd86075417"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("58c19aea-daac-4765-bae7-1984ecacb9f5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("593e928f-c969-4f85-ac0f-07145f1e941b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("593edf56-2b2a-4c52-97b8-56bffb7eccdb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("59f76a4c-2d5b-42a1-95c3-162b212897bb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("59fe153e-8202-4bf6-ba4c-88dc6cc07255"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5a2f0dbc-d4c8-4053-a6ec-647d8b71bbe4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5a30ffcd-5517-4064-b773-c01a9c88aa2d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5a38fd4b-e41d-4345-ba50-8291eef6cc6f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5a4a9aac-a0e8-4bbd-bf9b-ff795d269c60"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5a59a341-4c82-4a52-9350-4168f491b112"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5a72c0d7-a0db-4bd8-973b-41f49531f3ca"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5a8331f1-029a-485f-9a35-4b79a0cae1b7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5ae24a93-5068-44a6-bd67-233ec0d8d8c8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5af0301d-f3cd-4f3e-acc5-6f6378681062"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5b2758bf-2619-4005-a072-f80dbd18eb78"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5b4b8add-5a96-41db-af4a-663981595736"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5b9ea4f1-ef55-444c-b993-b98ef60740fa"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5bc27bfb-e978-43fd-a1dd-0c15cf4c1590"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5be4f03b-c74a-43d5-b556-e9462ce5df5a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5c6afb04-5b4e-4950-a445-661530e78f2e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5ca86d7f-9a72-4e05-983e-e7e46dbc5f9d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5cb585aa-6bba-465c-8d35-7145c05cfa09"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5cc1f2f0-7d81-4420-99d5-eaeb3ce1b010"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5d8aab60-2384-4efc-b6e3-b6c06a85e2a3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5e58203f-8a3c-421b-b54b-94e912f7c0b1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5eaa3bde-ae50-4e4f-a078-fdf53a47952a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("5fbd82ed-692d-4867-b855-5eea83fdb59e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6074dc2e-0da4-4aaf-bc3e-009010c0e539"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("60f94810-5ff2-4003-b3ee-802fa4b4ea5c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("617f909e-fa1d-428f-8ece-988fae409829"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("618d3276-35d3-462a-9e90-cc5d4ae10b65"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("61b7670d-b5d7-4edf-ba5e-aff58017ab5a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("62301fd9-4814-4c34-bcd8-e1edded8b136"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6299a9c6-dae3-462f-b717-930f56c5d268"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("62b906c0-23d0-4676-9167-52d9bbbc02bf"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("62cee0c1-749c-4197-85d9-ec99855678fc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("62d6d79c-4b4c-488e-83c0-3108f864e82a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("635e06a6-40e6-4bb5-8009-d2198ce25b4f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6374bd20-47c4-49d8-9f4d-54efa8450a80"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("638edda3-1b19-4a4e-b45e-012dcffcd11c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("648b9c4e-6341-43a5-b50a-5d79a94565f8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("64a80d5b-125e-44ab-94f5-f9b2becaabfb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("64b46b0f-8970-425e-b15f-aa9ce2e77bf7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("64f2c3d9-9924-4117-94eb-3e83d546080e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("64fce2f7-a25d-4117-a782-6cd36ce4d984"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("65b1f66d-e4f5-4c0b-a66d-77c46a20f5f8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("65ddfaa0-bc7b-4896-8988-1c2755e4d6a5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("65f400fe-c537-415e-90d2-bf5544d2ef4c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("661107bd-800f-4e77-a96f-6f97523f5090"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6663d97f-aec1-4788-ba8e-91200a6477f6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("667d2d29-8b01-48b1-8fb1-d8516ef6f698"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("67bacc0a-abba-4290-b369-d36ee0d15894"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("67ece294-f0e9-4a05-afbe-ec7d613646df"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("681ef21c-0d43-47d2-9703-977665f9dd62"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6abec267-1b82-4ab0-a4a9-2a0842fea66e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6aef2f3d-acba-4ee1-9c75-b8b9f5593209"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6b083c37-fcf6-4d35-a751-a4d8d906a898"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6b34a42a-2c7c-4519-90a1-f19c200956ab"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6b6a2928-91e1-47f7-90cf-1a44c99707b1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6bad5928-065e-49a2-bfd4-fba118f92949"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6ca3872f-8741-48e3-a48c-00eada9a550e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6cacb150-409c-4996-9041-fd251fe69d5a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6cfbe3f0-53e0-49d8-a692-12dd9754aa82"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6d18e0f7-2f71-4a80-8254-4482bd676ca0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6d60d709-69b1-4f3c-ad41-1d078beb43e1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6da7c349-7f57-4803-83e1-7800c7845dc3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6de78b62-38ba-476f-9e0a-d22bcc0d2d9f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6f1d589e-20f1-42b1-86d2-4261f6268fa9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6fa47b9a-d913-46c2-89c5-08ca1fbb3eea"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6fc0acaf-6b9b-4e91-8a25-7639b88441af"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("6fcbf8f8-b082-4369-9e7e-fd81a2fe2ad8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("70192f12-7301-45d2-8c9a-00c6e0703d17"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("70259f6f-4127-47d3-b058-1a7cdae64463"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("70264e43-16e8-4322-9b8d-f8cf27abcd36"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("70370132-afe8-4987-ab27-50d37b1a8f19"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("71d2e4a5-067a-447d-9657-813809a79168"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("71f42837-5623-4192-bb43-56611a8da74a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("725ff577-aff2-4eff-bf43-51581fdf19a6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("729383c6-5d99-4543-a265-50cc8ff8e3cf"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("72c5e127-2ed0-49c1-afdc-d7340113cb58"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("72ed08ae-3804-49f9-b5ae-23c8fc8f9061"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7303caf6-7206-4385-b8c2-c9b33358405a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("733e60d5-57cd-4ee6-a976-5375698c904c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("73c074bb-082a-4c3b-8f37-fb09df6f2690"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("741f3d4b-e859-4d4f-b321-f97ef724f842"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("742ef860-1e24-455d-93e0-387111c71832"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("744ad188-ec63-4cbe-b2aa-8b34895f15c8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("744b7473-4df1-40f8-b4bd-739191910b7e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("74b040cb-179b-4edc-a5f1-022c03f9cccd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("758cf997-2c81-4629-9489-5a2c56af1006"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("758d0f5d-bdf1-4ffa-8b59-26b2d51c576f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("76d7c97c-e63a-49ab-9c42-3eade7d179ac"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("777f619e-be6e-4046-82f4-2bb88ca0d86c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("77e6ef35-f82b-4e6f-a079-c8f8f6512583"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("781cbedd-6ea7-45cf-a7a7-7e761b337a1d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7a65dd42-e3ae-4b60-a680-31c632d3d253"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7b14fa7e-48c8-463e-b80d-f5424e4819bf"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7b93cfd6-6b1e-432d-ac51-09eee295ec8c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7c1d4042-4f06-4806-84f6-05df5a0268a3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7d04ca7f-cc54-4632-bbdb-5400912839b8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7d536631-f3f9-4aea-9bc5-638eab2ad0ac"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7e017e1c-9746-4694-89a0-37d350eff3b2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7e10daa4-511f-46eb-9248-d3ea9cd4d06f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("7f2f2be3-71e4-420f-a77c-d276c157a2bd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("80193e49-591f-47c2-b278-3faa744312b6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("81cb3ddf-efeb-4c86-b360-f4668915a1d9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("81d4adb5-8a9a-4c80-a1f9-27b2a190fa86"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("81ed9f2d-1a2d-4bd7-ac88-4f71dbc893a3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("836adca5-c1bc-4ae8-abc2-3776cf450df4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8375b389-5ee0-4563-8b29-7aba8f94c9f6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("83834dff-2162-44dc-94e1-48b861ec0573"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("83fd20c5-7a83-454a-a762-4416335b13cf"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("84ebce32-4e20-4170-9aa7-c26f00304a9d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("84fe08b0-9343-4478-ae12-aa54eb5a14ad"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("852c6934-72a6-4e65-9932-bd103ae73bb5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("859638f1-8164-4eaf-8a7f-b632c7ec8910"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("85b22e17-4ffb-4100-a846-3234982193e7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("86088c9d-6741-47ee-adaa-de39db6ac951"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("865eadb2-d4b9-44f8-b382-535e518846d9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8727f60c-ba72-4862-a799-344846760010"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("878abeb4-d05d-452e-8ca1-96236ca973f2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("87be3bba-dafc-4d15-a139-7e994fa8be51"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("87cb7d96-f957-42d8-8295-1b20fcb83712"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("87f4d71f-1162-44f2-a2c8-f1e20d108f7e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8812a7e7-1fbb-429d-b701-aa9e3f2a7c62"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8816dd6f-7e04-4aa0-8986-b8a300494e9a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("886df866-ce34-414f-ae3d-13efde88b18b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("88b84f36-5641-44bf-baf6-0167a86504a6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("88d36c39-7302-4b0c-a35c-ef022a840ccf"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("891b11da-341e-43d8-9b75-69012d372fad"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8954905a-ad05-4294-bd21-03c6ccdeacc8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("89a4d7b1-1502-409f-8132-3bd120ddfeff"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("89b73f85-c719-4d36-8643-0a585c0e271e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("89f418f0-0710-40b7-a944-69ef4393f055"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8a8effe6-9ba9-4b65-94ce-9554e0f3cd4b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8aa9cf13-f2a9-4daf-ae47-e27658c400de"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8af31ca9-0646-4310-9061-23ddbb904880"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8af44e07-226f-4cd5-b275-6c08a1cff17e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8b0f8bfc-cc36-4822-bda1-9b54da94d2ec"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8b515a93-dccf-4150-b07c-43f0ec885627"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8b926742-91ee-40e7-83ba-96a22329118f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8bc94aa4-faff-4e4a-beb3-c67a66693c72"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8cab192d-ffa7-40db-981b-1b07158c2d2b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8cb15a9e-e4e2-4591-a6ca-12b60c72f8f9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8dbe7be6-a9f0-4e1b-b0b7-c41abdf4de45"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8dd7cceb-e460-4ec8-82b0-fcafc6692e19"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8e1f66c8-ff85-4f63-a4f5-475f959af086"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8e44cfaf-73fc-449c-986f-607e7bc539ed"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8e807b11-c10e-4cc3-9f25-734982e88b22"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8f67b692-abb9-4207-88fd-06ee8a87dea8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("8fd91145-7b79-4888-a599-ac2a66f10988"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("902a498f-6f27-4600-b802-926abdaa2e5a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("907b961a-5311-4e99-83b1-e855a5e6485f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("90b4f23f-0d86-4668-9916-a3c0e0e33001"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("90c3533d-932a-46fa-a1d6-4155ab22b8e5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("90ffd982-8941-457b-bc97-8819f5054661"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("910d0f7b-028c-4de6-80c8-0c0b3f84425e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("91d226e5-a30c-4d3c-a713-433edc8d5328"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("91f32a3c-f70b-4341-a8ef-7c6913aa9c8b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("923a44c5-a28c-4ee1-9dff-cdaf023c72a8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("929a59b8-655b-4246-b11e-179b55b62bd2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("92fdd871-280e-4822-bb66-8084699fd22b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("930d9072-3553-4390-a62f-42ce6ee07242"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("932b76c2-1295-4c4b-85c9-13e0213f8411"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9360d940-2344-49b1-a1fc-3b69e33cee10"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9373b4b3-1442-42fe-a9bd-3457c36472eb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("93951891-bd41-426f-8c50-794ced102dfc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("93a185b6-6458-459e-9fce-d36838881566"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("93df63f0-30ed-4783-91f1-151d566ab287"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("93ebabef-3a05-473d-b107-c60383bc5f91"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("93f44d3a-8a68-46bf-85b7-01bce5546e03"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9433203d-aa65-4df2-b77d-395cbfba8b4a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("943e480f-1378-4426-a5c1-718857331507"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9478fa3b-f48e-4253-b280-92d18a0e3a1d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("94fb1228-1692-410a-a960-fc8b76620b7c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9531a146-9645-4a70-a7f1-6b86067f48d9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("95f0b31e-d1a4-4354-bb0a-feba77f8e81d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("962ef718-eeed-4a60-8a23-39c9b15186c2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("97a4758c-86b3-42ae-8285-d3d1d52dc3ad"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9830df08-cb75-4254-a699-d950be508f3b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("98417737-de4e-4c45-b219-90eaa24810d0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("98645ecb-3641-41ab-9edb-10d8e292ab20"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("989b408f-80ac-4de2-913c-2469263088d6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("99042df8-5fe2-4207-9bf4-41b364c5a61e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9909eca3-4754-4a03-9821-0eadf3b7f374"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("991a23b1-ba05-4ef8-bdde-1f985957379f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9941463b-a5e7-49c1-824f-2d92b3c1e58d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("998eed3c-cee7-49f1-86e2-c9bd9b197510"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9a394428-486f-4689-8129-87d9c0c96c65"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9a3f413a-2b3e-4e24-85d0-ea30366f13eb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9af39010-a4de-45a0-bf39-02f0c9f9c22f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9b9ad8ba-48db-4d76-bae6-b3d6a83e178d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9c15dab1-9753-45c5-9d7f-910bc6d6732a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9ce1786a-3538-4bbd-9c82-406633724eb2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9dc2be2f-7850-4112-8093-8169eaba89a6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9de3edac-594a-4845-8358-24460f131ac8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9e5bb692-3465-4e2a-b525-15b22ff2a958"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9e7b1aa1-4c71-48ae-a5c7-42326cad19d0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9e7fcfa2-c082-4299-baf1-5d8bce8d5214"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9e81240e-26af-4b52-b854-4a5a93b63fa8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9e986ccb-6a84-4129-9c8f-43c2f60a0671"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9f4d7702-1237-4b76-ba49-3c58d1bcc00a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("9fea5347-11da-4d92-b8d4-9a5de72a8261"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a015f31a-14dd-4ce6-a96a-c996be157b7c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a0237375-bc31-4886-9dc7-76a6b7538527"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a10c7124-9b03-40c0-944b-bae824d265d9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a144ad85-4baf-489f-9e30-6ec48e54f874"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a15ff077-1e1f-46b9-9398-12ce417d972b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a227791e-a1bf-435e-9735-0dad4c3b7199"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a3410891-a955-4cff-be7e-766f0b2bd4bf"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a3b71746-28e5-4aa5-8a07-16a9fa1d4b24"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a3defaf5-a2e6-4403-95cf-98c565c61dae"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a4491851-fd94-4356-a7ff-b1d29928718a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a4775a0f-f742-449c-acb3-8a58d1254721"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a50cf390-f10b-4969-bb3b-b6536e2b5e63"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a58a8756-671c-47cb-a61d-18529eb40bb0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a5a197d1-103f-4a15-981f-e23c5ea3f814"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a5e6d507-fcc0-4159-b858-61fb1546c7b2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a5e7414c-9997-43f4-897e-e19ae7dae082"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a5f2ecc9-1dfa-43ed-aef0-44cc20586b06"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a64f98db-59f5-4e0c-9793-30287b26fac5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a737c9c9-90f4-4f3e-919a-830108c61e62"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a7c0a4ca-4b1a-468a-afe2-8c64d713c79c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a7e7edb8-46e2-4517-a8fd-18a3e4b1d891"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a8415937-ece8-4f0a-8c26-29fb872f5a88"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a8bad686-befc-4787-9494-36da7dc6371c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a953ea2c-b03e-4eab-8ffc-11a265230289"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a97f2a48-6e9b-4ca6-98be-656b65b4c770"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("a9ffe05c-4dcd-4b6b-a055-397fac5ac512"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("aa8c6040-1c9a-4d87-8d47-3c3d73387cf4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("aaddf621-c96c-42f5-8a39-91f1d20f5c42"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ab2c7c39-50d6-4fa0-9a57-9c8501a80d14"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ab7377ea-2a62-4cad-a0b1-13afbd982376"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ac36eb99-93c2-4684-a366-3ff7fa3edfae"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ac71c2b6-c5ae-49c8-857a-98aaf64b9460"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ac7264f6-ef39-4dcf-bc91-980df3428801"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ad163a21-4b3c-485a-9fca-169949b9e0ff"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ad79b3c4-fa7b-48a3-8b2e-f29ed5d0cc80"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ad83c121-e433-489b-88c8-e12830e88834"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("adf1e4f3-332c-447c-ad2b-48f0442cecb2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ae19ef45-4adc-4a95-9e54-018299f43cef"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("aeb34440-fdc6-4f54-887e-40d78e55c9b3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("afc3d5c6-74c9-4729-8adb-e9ac89d1ef1f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b07d6e24-a8aa-42b3-9edc-b0464657f35e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b07fd633-c3c9-4679-94a2-1fd1009397c7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b0c55b46-d068-4343-bbf2-9d9e2e9181b0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b0fe2192-15f7-4e75-a0f0-755871b29278"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b1150071-2a63-4aac-8b16-597aa95b4196"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b11c5d6c-45cc-4b4f-b469-dab671d89c47"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b11d32ab-2e81-44e8-915f-a91552d04a08"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b127fb7e-06b9-4561-886b-b79ff30a0148"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b13d747a-bd3b-48e1-8390-32fe1a8400c5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b13d92eb-dc73-44fd-8546-9641cd9fb6a8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b14bc245-7403-44c1-b2ad-0cc82b05534c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b1f10c4c-8c7a-4215-a2c3-976aba305804"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b1f80251-fe54-46b7-9f5b-fec2f9f4aefd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b21de55d-3594-4915-b111-ebe65a9b2115"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b28246a6-860e-4c13-8a05-b7d985fbc875"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b2da2fdf-53c3-492b-a463-a7c11067409f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b31a4286-3b4a-4460-9767-ae2660f9053d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b34e75a0-ab8b-4657-bb9d-7eb697478175"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b36ac4a6-1136-4348-91fc-7607a9d81bcb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b431f893-3ed5-4e7b-8b05-4d061047f78b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b4893ba9-c52d-45fe-a633-24578d174bf1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b4f3ab11-6537-4056-b17b-4cb566664463"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b5367a20-d3bb-4732-bcae-6ccf1a6ee54c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b5937aa2-240f-475c-bb22-35b2059b56a9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b5eb31fa-c378-48b2-aa7a-96a9ca136a76"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b5f5a81d-9848-4f57-acc7-86046384933d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b6561d80-9bc0-4eef-b0b4-eb09fba8b526"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b6601dcb-e0d9-4e91-b15d-8a89807ace63"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b6bb1ec2-abf8-4cba-8efa-f76bdf4b48f7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b6c9d344-8d79-431a-9a4b-097865d735b2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b754ab70-7081-4a6e-81c0-fecdc71a5833"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b78b58ba-748b-404d-80c1-14552e7e533d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b798a1bd-c50f-4ff6-9148-e295f653b88e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b7ad083f-e342-4b23-9c73-30e4b823f3ff"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b7e14dfb-b110-473f-b391-b7fb06cd5390"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b7e2d993-de4c-4a95-ace0-22b05139f908"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b7ee9396-68e5-4c58-bbae-8b8c36f0fba3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b831c118-199c-425e-b000-a4edd0d157f4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b8ad3e2c-bec5-4988-8676-fcecf0facc59"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("b9ec49d7-d89a-4337-a562-dfeb354ac323"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ba45d181-d519-46ff-b1d0-6f3ae0f357d4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ba89a894-cc74-4bec-beb6-ea69af62487a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("bad57cd6-21cf-42c5-bd91-b7a575edcd86"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("bbd5e4eb-16e5-4548-82ac-8439c472a575"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("bc3958a0-7cf1-4471-a3f3-edefca86fc12"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("bd2f0b84-28ef-4a6c-ac7d-808374a79b38"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("be1be7c5-e721-494f-9fab-cf1e3c014acf"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("be753488-4386-44e4-9a68-9e6515f0b99b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("beaae9cf-432c-44fd-ad7a-9b53c40c6b38"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("beda76a4-72b4-414a-99dd-8c5f50c26f5a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("bfab1211-f779-421a-bc61-522b87ae7d58"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("bfc28620-754b-4055-b246-b96e0b316a7a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("bff09c73-4b53-4e12-8651-d0f58384825c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("bffcf940-760b-49bf-9af9-c3cbb06a9417"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c009cf36-e8d1-441d-bc45-76981f551839"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c05c9687-d119-4e7e-bbfc-3b1bdf699904"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c085682c-ca0a-4332-a469-389eb45e5ba9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c08b34f9-0e75-4f7f-a70f-cf3ece744962"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c0a1737e-4505-4627-88ca-d4eaccb6f4d8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c11d48d9-7fce-4ac0-87b6-0502e9589d6f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c2157815-8a5b-4b0e-bd39-2d578fc144af"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c2e4d03f-4849-4c1f-adf7-d1fbf9287a42"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c301cfa3-d750-4536-b70c-d4989b68fa85"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c33a759f-1fc6-416d-ae33-d43be8bfab10"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c4bd0585-053d-4aba-90d0-6ac41b87d3eb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c55c005b-51f1-4ba1-a525-7db4bf5fe8bb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c6130bb2-e24d-4457-8311-8ec4d2f88a00"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c625bcf8-707b-49d0-8de7-b558cc137a14"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c64d9fb4-7a06-4509-b298-1131ff94e571"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c6b030db-1d8d-4a18-b222-1512ee17641a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c6b90045-2925-41c1-b83e-85e3629a9d74"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c6f47cf0-d597-4faf-8535-ea50e6cd6eab"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c70eb6da-f2eb-4858-93cb-0fbe9619daaa"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c7351363-c1bf-4542-b2cd-6d910cca3f9c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c7bb0b50-d871-45f6-acb2-f6aca4675b6b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c858d5ec-f6c7-49c1-b4db-500ea19af62e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c8aedd6b-d887-4d60-8764-2bc4cfd06a9d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c8c82048-50c0-4d8a-a55e-fc52ac7ae8dd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c8da203d-3708-4464-8be2-b35f28ad0d3e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c8e68ad7-4737-422e-846d-318a6de89f97"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c8edd741-c68d-4ca2-9bed-2144c7f0e04a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c92b51dc-9464-44da-a78e-68fb9768f1da"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c98dbaf1-b751-4eb6-9ea8-783ff9f89832"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("c99a3f98-8eb8-4739-af59-2328ebe43421"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ca6396d1-5ead-4714-8d2a-a0548370cca0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ca6ee632-7146-494f-84e5-43d47409ace1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ca7f4ae5-50d8-4705-a432-a61b1757a852"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cb17bd14-736c-45f8-87a7-e6f1edbc36f8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cb1fab70-856f-49d0-815a-6e29a3ccaff4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cb88625c-d50f-4df9-a5c9-64aa6b0aa6a0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cc225523-8f6d-4095-8a13-5739aab88e31"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cc32de3b-71ee-4625-a520-54fd95ad78ca"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cc64d76f-f8e6-415d-bf47-e1e4f73143a3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cc76ca6e-88d1-468a-a3f2-2782fd5005d6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cd47f807-e02b-40fc-b71f-0b680895e7b8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cf70545d-b043-4bf4-aaec-6e5af701ab79"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("cffcff6e-fd2b-400f-95d5-f4b96bdd136f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d091a2b8-de9c-44b3-89a7-7765f8ec79e3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d0f35b40-bf71-4b3d-b0f2-5a9978e097f0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d0fe46e2-356d-4b98-b2ea-fe3ca45c7998"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d1077e97-29bb-47e3-a7e1-e6ae6b4eaf53"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d1de97db-fc5d-48bb-ad51-55733ad298d7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d2b61daa-add7-4451-a443-46417ba2a105"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d2c13bd9-e5a4-4832-b4b3-94b2c8ae8c90"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d35b01ec-8bdc-4471-afa7-7c6f232ed6cc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d37a96d5-4932-4527-a821-f441c30d72fd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d3afb1ad-8b3e-4d28-ae59-5476780865e7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d4fc0d34-0c36-4c38-8dbf-2856add1d04e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d59eb88e-d994-459c-9725-19150adbac88"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d5c18989-1ca0-4bad-92b8-629e8518d76c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d5c49000-89bb-43d6-91b0-1af4e92eea32"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d6139191-1510-4a04-b62c-f1433587c76b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d62cf05a-389d-41b8-9980-92dbc7185186"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d63213dd-c2a0-4d9c-a03e-1f141d323250"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d6989eeb-9966-4351-82cc-558694b52641"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d6baf084-aae8-4150-a0af-6bcada18d40a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d6e69a1f-5f9d-4425-9310-18150ce3168a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d7d9ff7b-eced-42ba-8e94-ebb80ac559c5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d7e0086c-2a7a-4989-9cc4-c3f625fbb9d0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d825fd8a-5104-494a-88ba-4cc9ce3a32da"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d84d23bb-1910-4bef-add4-d3f3ae95df52"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d8954c41-278d-44c1-bd7f-645dbbc92c22"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d948bd64-40b6-40fc-afcc-5c0a552e5885"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("d99058f7-32f4-4235-8075-f581a50ee9d4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("da764337-f5f7-455c-bdd9-eac98d36993c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("da7c60c8-5402-4ec8-98b6-603180b8effb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("db7f3571-dd1b-4056-95e5-0fc527db507a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("dca17b18-877f-4ec6-a8e4-e63f8fbca3fd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("dcecf432-ad89-4dc5-bea7-94fc8d73c8d4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("dd01d501-c5bf-4653-9241-9a647f2031d6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("dd3e0dc1-6a73-4db2-940b-b919fdfd45e8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ddc02b96-2a17-4185-a841-235a6230b633"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("df41a5c5-5d00-4fde-ac70-f0c82cb709aa"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("df5ecbbb-2150-478e-b001-89a9f79f6a7a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("df713fc7-6919-4df7-b709-a352dfd770d3"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("dfeb0ea2-1978-450d-8ed5-b187c16a9168"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e03469e4-3ebd-48b3-84ba-94b4a5b1b43a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e03932ad-7486-4479-95e1-41d0a9b34695"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e0ac521e-d7d0-456c-a891-9737fd385ee5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e0c3c384-d60a-43ed-941f-e829e4235109"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e20ec594-0c35-4d09-a0ac-d601011797c1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e2570c24-fa88-4d96-aae3-9f38e530d22b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e2873de0-fd7e-435b-b277-2b8f8818bf53"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e2bbe69b-f713-43a0-88e3-44568fecd628"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e2bf6388-6ae1-48e4-9ed2-fb8d9de809f1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e3730439-30ce-4c64-950b-f4e8be0089cc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e42944af-7da7-44d3-aa15-597edfa5d481"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e4d0aa54-86c9-4ca0-81c0-7e1ffedc185b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e55a6d49-7751-4719-b40f-5e08905d0442"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e5690331-c243-489b-bde7-11acda3c4059"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e5a021ff-147e-4917-9247-05c06b154291"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e66d10e3-5684-408e-9300-d29091ddf960"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e69a6943-d5cf-40ba-b289-5d29a611b871"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e6c165b9-8abb-4628-8e10-61f872f49ed0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e842b436-bc15-4814-af5b-0e8e28f1112c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e8cc8ec8-0f06-46ca-8883-e5f250a904b4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e8db1f84-8e13-4f4c-a8db-1e128abbdefa"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e9598152-d243-4792-88e6-42f52a60af6d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e97a31e3-f6d0-410a-9455-70ac5537b059"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("e9c34db8-df2e-45e7-b41c-81e0246cbc40"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ead55b56-fa1c-477e-ad39-607f1fdea261"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("eaee337c-2734-4f7d-bbdd-4d6aa5b8479c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("eb697a19-cce4-4eca-a827-77b4a2ca8abe"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("eb746ce3-edb6-4d7f-81c2-7f64b29a207b"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ec2a63e3-d3b7-4308-8fb5-9ced326118bd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ec69b397-9ab9-4884-8359-619a2dd7544f"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ecf8f51c-f550-4274-b508-9dbc1f99c44d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ed06fd41-7935-49f9-9eb7-f112782d14d7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("edc30fc2-5a9e-4317-ae4e-bb33fb3d9e8c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("eeac9923-f8bb-4d84-a17f-00c44fa2dd02"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ef4153cb-1d49-44ad-b63d-033e7fb2eb51"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("efa5e022-a6da-4960-8940-3c0dbeb3aac2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("efe5bd23-e636-4a68-a401-0c162e63cb22"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("eff377be-77d9-49a3-9830-a661728b1d37"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f00787fe-05f8-4a27-8383-36cfbb8102d4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f023040f-5daf-4c1c-9460-2e6ef1e9ddae"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f03aaef1-efde-47ce-adaa-24c7d3bdd9c9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f03db3b9-299b-4fc6-b792-22d5a72c51f1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f066d3a2-4aab-4364-a17f-ecd1900f4137"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f06c00bb-17a1-4bc2-b003-0de2bad27fc9"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f113562a-a761-4577-8b46-314c975efadd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f13a8ef7-e0cf-4fa8-9dc3-588bc41298e7"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f1902eb2-f6bc-4040-a6b2-09323416beba"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f19194f7-ba00-4163-b86a-301e74004a78"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f19bd39b-c57d-47c7-8da1-3ea3a04f9af2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f2f90fd1-a361-4c9f-8f31-712ebd4ed9c1"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f3a3d2be-a25c-403d-9e52-20989bf02e00"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f4700b7e-ba34-4fc1-b8dd-8f69c2b5a8d4"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f4dc622c-ca5d-4797-aa12-f1b952e0a2d8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f5238cc4-d6ee-4be9-b462-0a192864826d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f626eab5-69d6-49c7-8679-28a1d82d5353"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f6a24c32-a44a-4836-8b84-bb60cd4d853a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f6bc79c5-7c8c-4554-b4e5-3910afda0b1a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f6e1a608-8f5f-4e19-8bd6-cdecfa2ea5bc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f6ec7901-8b14-474d-96d4-5fe5a9af2a3e"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f72b4756-fdd0-4c3a-ad1b-5baaa290f6bc"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f74049b3-c3b5-483b-bfd9-df399822e498"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f7afc06b-4f7e-4467-942b-946a2df75375"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f88ee010-4cb4-43ca-afd7-dbfa4e4db626"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f8a7bdda-ab48-4701-a62e-480c8a1d19bf"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f8e9d9c4-2346-4ca5-a3b9-50a529152988"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f9081638-6eee-4ff9-991e-0f42a8e93ada"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("f92183fd-2bfe-459c-af39-10820159087d"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("faa42b23-611a-42d9-8067-903ec09572ee"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("fbf0471a-20d1-4163-980c-906f975081e2"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("fc520475-8786-45df-b043-b199bb5ad1c6"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("fcc4183e-55c9-42a4-a8ff-69f4c1761811"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("fd88d988-559e-49e4-adc7-e19b34d60a90"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("fdfac8db-bd17-42a8-89e5-64bf705e5fe0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("fe5ea0e7-91d7-4597-8037-7fba909d8fb0"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("fe65469a-1e88-4608-a73c-09dd6216cddb"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("fe668775-b45d-4806-b540-e9ae17ee3593"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("febc13c4-8cfd-4036-ac96-9b8d1e7c205a"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("febfc68e-9fbc-4d42-ac32-db7e7b61374c"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ff0c8c01-e250-4cf9-bf79-dc7b5b2c22cd"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ff5656bf-5144-4499-84f2-8f338ca391d5"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ff750eb0-2adc-4368-9503-1964d6bea2d8"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ff8765db-66d2-4008-9e2e-01da7d2969ce"));

            migrationBuilder.DeleteData(
                table: "Reclamations",
                keyColumn: "Id",
                keyValue: new Guid("ff8ff391-04d8-41b2-af40-1a1604c4d17c"));

            migrationBuilder.InsertData(
                table: "Defauts",
                columns: new[] { "Id", "Defauls", "Opn_Id", "TRet_Id" },
                values: new object[] { new Guid("cb663965-79bc-416d-887c-bb179b217e26"), "Echappée de couture autre que glaçage : ", 1058, 47 });

            migrationBuilder.InsertData(
                table: "Reclamations",
                columns: new[] { "Id", "Chaine", "Num_Paquet", "OF", "Operation", "Operatrice", "Opn_Id" },
                values: new object[,]
                {
                    { new Guid("78610462-3bab-4cf2-83ff-489f31e80671"), "GHNP", 28, "17Y15C319448", "RECEPTION QUALITE", "AMEL MONTAGE", 9090 },
                    { new Guid("86aa310e-a6df-46db-9fe6-27a35d86e95c"), "GHNP", 28, "17Y15C319448", "SORTIE PRODUCTION", "AMEL MONTAGE", 5999 },
                    { new Guid("aeed1f2d-03e6-4232-be6d-3c3c0fe0eafe"), "GHNP", 75, "211E5720612", "ENGAGEMENT", "WAHIBA MONTAGE", 1999 },
                    { new Guid("b28c00bb-811c-41da-8e07-db16a6ec1626"), "SG 4", 26, "21Y1E5330612", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 },
                    { new Guid("c671b314-47f9-4e4f-aeac-a46d35c9cf4d"), "SG 4", 19, "21Y1E5330612", "MONTAGE GORGE", "BOUSLIMI MOUNA", 2140 }
                });
        }
    }
}
