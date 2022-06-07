using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieLand_DataAccess.Migrations
{
    public partial class S06A_MovieLand_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Poster", "ReleaseYear", "Runtime", "Title" },
                values: new object[,]
                {
                    { 1, "SY23IX2QWdXCiX2YkIerTweUcd.jpg", 1993, 141, "L'affaire Pélican" },
                    { 30, "e2sct49Yw8EJsBWT3gdmAOpEY9Y.jpg", 2014, 114, "Entre les tombes" },
                    { 31, "AfKm745YiKJ14yp4UfA4jowBIPi.jpg", 2015, 105, "Focus" },
                    { 32, "wjVn1Qng8B3ySvfJr4ovuehI141.jpg", 2015, 137, "Dangereux 7" },
                    { 33, "w7Q9BAqpbPHSeo6ZDYRpFGpGUxn.jpg", 2016, 129, "Insaisissable 2" },
                    { 34, "cqvNVmn25vCmBcbwSfR1KlSOBBH.jpg", 2016, 124, "Jason Bourne" },
                    { 35, "bCqD2c1nJJY6q65VGBfMItgVvGx.jpg", 2016, 122, "Inferno" },
                    { 36, "aqwQPVosPSjfXRF6bO9Wg48ylAR.jpg", 2017, 90, "iBoy" },
                    { 37, "77Z0g5fc1qWJ7SfHyeiHsMkYx5O.jpg", 2017, 133, "Spider-man : Les retrouvailles" },
                    { 38, "2oc9wS0PjiBVCnAvYqmenCQdRLO.jpg", 2017, 118, "Mon meilleur ennemi" },
                    { 39, "y1zgYmxkQDvi9Tev74PYbmer2Mv.jpg", 2017, 119, "Jumanji : Bienvenue dans la jungle" },
                    { 40, "vVusHIRlyyFVS42XnqZso2wGKr.jpg", 2018, 112, "Venom" },
                    { 29, "pn0bw4DDYVarCLBbWRg1DWUkZPX.jpg", 2014, 97, "Predestination" },
                    { 41, "bSMSO9xupd4R4vwTPqigHn2quLN.jpg", 2019, 97, "Meurtre et mystère" },
                    { 43, "kgajCPm5pdH2Sa3CTCyHuUmQvgT.jpg", 2019, 137, "Rapides et dangereux présentent: Hobbs et Shaw" },
                    { 44, "hiHsAVw2M6j3JHUOPoqAR7X55iB.jpg", 2019, 128, "Terminator : Sombre destin" },
                    { 45, "vwuNoe7sCWxZw7Feo3iIhym5rKM.jpg", 2020, 99, "Sonic le hérisson" },
                    { 46, "fePczipv6ZzDO2uoww4vTAu2Sq3.jpg", 2020, 110, "Spenser : la justice à tout prix" },
                    { 47, "fNXKcqfD252Kk52AJb6arCYCDlS.jpg", 2020, 101, "L'Art du crime" },
                    { 48, "4xiq5NpooMCBFjQhGQjx8LqmhTy.jpg", 2020, 93, "Scooby!" },
                    { 49, "pSGO3h6Cyqgv1bDbkjzxUlU8jsW.jpg", 2020, 125, "The Old Guard" },
                    { 50, "k342BTraGregKSIVrrH7AGqoKna.jpg", 2020, 103, "La nuit où on a sauvé Maman" },
                    { 51, "zDtraIGPVhmSnPZQ34fmyvWT5tz.jpg", 2020, 123, "Enola Holmes" },
                    { 52, "gS1C3cIXJXHZbW00PtWy1bSdorH.jpg", 2021, 102, "La femme à la fenêtre" },
                    { 53, "dFMu4ZfJf0tfgJkR0x3sRpeG0Rj.jpg", 2021, 117, "La femme de mon meilleur ennemi" },
                    { 42, "zrNKUa5SBUwue39coJArNdDgQJM.jpg", 2019, 129, "Spider-Man : Loin des siens" },
                    { 54, "iPTZGFmPs7HsXHYxiuxGolihjOH.jpg", 2021, 127, "L'armée des voleurs" },
                    { 28, "Nkgaj3X0W2jHQ1TzHEgWFpN3kJ.jpg", 2014, 107, "Sans arrêt" },
                    { 26, "mskYkcgAMCOKncFMfTWAHL5sUTo.jpg", 2013, 115, "Insaisissable" },
                    { 2, "pNz1NREgddPdlzytlR8mW4B26fW.jpg", 2002, 121, "Spider-Man" },
                    { 3, "32bzh3HnRZdE8oM9pwfmGJUYnvl.jpg", 2002, 89, "Scooby-Doo" },
                    { 4, "e2oWzbhxfqAlJ83ea38D64VD1RR.jpg", 2005, 128, "L'interprète" },
                    { 5, "wzIO3ytxeSNt1wRpXLIdkNbGoDm.jpg", 2005, 120, "M. et Mme Smith" },
                    { 6, "hjWcpt9GI9v9NSkex58GUZhlS25.jpg", 2005, 129, "The Legend of Zorro" },
                    { 7, "q6wt3HwGwRnzKbpgwNTeIZgHKkH.jpg", 2006, 149, "Le code Da Vinci" },
                    { 8, "x7zBSbzWyJB1VB10BAMMWTOWe45.jpg", 2007, 93, "Prémonition" },
                    { 9, "svCEllDaXbt3eNlbf4HZLA5kKjJ.jpg", 2007, 113, "Fracture" },
                    { 10, "4SBTOPWMM3My5nDIlpNHt6dg78d.jpg", 2007, 139, "Spider-Man 3" },
                    { 11, "7zEWoMDAgvgHlv1D11vF3Br3ZTd.jpg", 2008, 113, "L'Incroyable Hulk" },
                    { 12, "lLbElXAzCNxaCaHGBDvLv7KM9QM.jpg", 2008, 118, "L'Oeil du mal" },
                    { 27, "cB46TSg3kGjq2eVy5kVUhlpUa1H.jpg", 2013, 143, "L'homme d'acier" },
                    { 13, "uvd0fOK5dZsZDMICflMxotedsmC.jpg", 2009, 121, "Prédictions" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Poster", "ReleaseYear", "Runtime", "Title" },
                values: new object[,]
                {
                    { 15, "zS0B5iu68dyBNXUoSpZmIaxh2ua.jpg", 2009, 138, "Anges & Démons" },
                    { 16, "OuABrWGUHbIAmaE0wkmNMvy1A7.jpg", 2011, 113, "Hors de moi" },
                    { 17, "786fsgu3U7P9icbllwpd6yfOIiD.jpg", 2011, 105, "Sans limites" },
                    { 18, "7MMrRbyOts9v1YHYoc7LSrz8XnQ.jpg", 2011, 123, "Green Lantern" },
                    { 19, "bRMdfPlHNbnpifEUIOEajxl8BcX.jpg", 2011, 101, "Johnny English renaît" },
                    { 20, "kbeSPWIRkWZYQgLCyPqxjj4G0kx.jpg", 2011, 129, "Sherlock Holmes: Le jeu des ombres" },
                    { 21, "i0jXQFuSsKLDNxWH7mV0BijugtY.jpg", 2011, 95, "Ghost Rider: Esprit de vengeance" },
                    { 22, "gsIkMf1VErbF0xtrgXEZXqLgsBG.jpg", 2012, 137, "L'extraordinaire Spider-Man" },
                    { 23, "sqKvTMHHbkH5ak4jPIPHCTQqb6W.jpg", 2012, 121, "Total Recall: Mémoires programmées" },
                    { 24, "hagmYjjQBR5I73YFsYMXMY2Uoj3.jpg", 2013, 109, "Emprise sur la ville" },
                    { 25, "n3pCxunmHrK6AWpLaAThgYiguWK.jpg", 2013, 118, "Parker" },
                    { 14, "cAFfhia4joDvGK2zvL6lOue6Xlx.jpg", 2009, 127, "State of Play" },
                    { 55, "5OCzQvJ0ePPx66OPGVC6ga9bUUQ.jpg", 2022, 106, "Adam à travers le temps" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 55);
        }
    }
}
