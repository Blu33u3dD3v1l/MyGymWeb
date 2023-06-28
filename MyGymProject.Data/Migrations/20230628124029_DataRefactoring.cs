using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class DataRefactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_All_BoxingTrainers_BoxingTrainerId",
                table: "All");

            migrationBuilder.DropForeignKey(
                name: "FK_All_ClassicTrainers_ClassicTrainerId",
                table: "All");

            migrationBuilder.DropTable(
                name: "BoxingTrainers");

            migrationBuilder.DropTable(
                name: "ClassicTrainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_All",
                table: "All");

            migrationBuilder.DropIndex(
                name: "IX_All_BoxingTrainerId",
                table: "All");

            migrationBuilder.DropColumn(
                name: "BoxingTrainerId",
                table: "All");

            migrationBuilder.RenameColumn(
                name: "ClassicTrainerId",
                table: "All",
                newName: "TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_All_ClassicTrainerId",
                table: "All",
                newName: "IX_All_TrainerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_All",
                table: "All",
                columns: new[] { "GymId", "TrainerId", "ProductId" });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Practis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Moto = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    GymId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainers_Gyms_GymId",
                        column: x => x.GymId,
                        principalTable: "Gyms",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "GymId", "ImageUrl", "Info", "Moto", "Name", "Practis", "PricePerHour" },
                values: new object[,]
                {
                    { 1, null, "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l960.webp", "Arnold Schwarzenegger is known as the Styrian Oak, or Austrian Oak, in the bodybuilding world, where he dwarfed his competition. He won his first amateur Mr. Universe title 20 years old. After moving to California he compete bigger events in the United States, he won three more Mr. Universe titles and then the professional Mr. Olympia title six years in a row before retiring.", "You dream.", "Arnold Schwarzenegger", "Practis Above 20 Years", 200m },
                    { 2, null, "https://www.muscleandfitness.com/wp-content/uploads/2019/10/Chris-Bumstead-Shirtless-Hands-On-Hip.jpg?quality=86&strip=all", "Christopher Adam Bumstead is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.", "Don't be afraid of failure.", "Chris Bumstead", "Practis Above 10 Years", 160m },
                    { 3, null, "https://media.gettyimages.com/id/702973/photo/bodybuilder-jay-cutler-poses-during-the-arnold-classic-2002-february-23-2002-in-columbus-oh.jpg?s=612x612&w=gi&k=20&c=P2UjdlRcstD8CETCQYByU_2yqjx3KWnJ4xInKXIt3T0=", "Jason Isaac Cutler is an American retired professional bodybuilder.An IFBB pro, Cutler is a four-time Mr. Olympia winner and a six-time runner-up, the most in history.", "If something stands between you and your success, move it.", "Jay Cutler", "Practis Above 20 Years", 180m },
                    { 4, null, "https://generationiron.com/wp-content/uploads/2022/01/CED5711A-1DAC-45E1-BB83-5462E5A04652.jpeg", "Dorian Andrew Mientjez Yates is an English retired professional bodybuilder. He won the Mr. Olympia title six consecutive times and has the fifth-highest number of Mr. Olympia wins in history, ranking behind Ronnie Coleman", "You must not only have competitiveness but ability, regardless of the circumstance you face, to never quit.", "Dorian Yates", "Practis Above 20 Years", 170m },
                    { 5, null, "https://yt3.googleusercontent.com/d8GULtiQ88hMBsHr-4P2p4_30wj-QjaZaR_f97WZxDc3EP_vm5wfx-xSazlSEWhilab0Pq7HgA=s900-c-k-c0x00ffffff-no-rj", "Ronald \"Ronnie\" Dean Coleman is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning, dominant body-parts and extremely heavy workouts, making him the strongest bodybuilder of all time.", "Just Do It.", "Ronnie Coleman", "Practis Above 20 Years", 200m },
                    { 6, null, "https://musclehealthmag.com/wp-content/uploads/2019/05/melina5-819x1024.jpg", "A young female bodybuilder at only 22 years old, Melina Keltaniemi is just beginning her career, but she’s off to a flying start!This ripped female bodybuilder came 2nd place in the 2018 Nordic Elite Pro, 3rd place at IFBB Elite Pro Russia, and was 2018's IFBB Elite Pro World Champion. Her drive to become the most successful female bodybuilder is clear, and her mindset matches that of a champion competitor.", "Go For It", "Melina Keltaniemi ", "Practis Above 2 Years", 100m },
                    { 7, null, "https://www.si.com/.image/t_share/MTY4MTk2NjgxODE2NjE0ODEz/1988-mike-tyson-nlc_05245jpg.jpg", "Michael Gerard Tyson is an American former professional boxer whos Nicknam is Iron Mike and Kid Dynamite in his early career, and later known as The Baddest Man on the Planet,Tyson is considered to be one of the greatest heavyweight boxers of all time.He reigned as the undisputed world heavyweight champion. Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title.He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round. Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", "Lets smash some Heads!", "Mike Tyson", "Above 20 Years!", 200m },
                    { 8, null, "https://cdn.britannica.com/86/192386-050-D7F3126D/Muhammad-Ali-American.jpg", "Muhammad Ali born Cassius Marcellus Clay Jr. was an American professional boxer and activist. Nicknamed The Greatest, he is regarded as one of the most significant sports figures of the 20th century and is often regarded as the greatest heavyweight boxer of all time.", "Don't be afraid of failure.", "Muhammad Ali", "Practis Above 10 Years", 160m },
                    { 9, null, "https://media.gettyimages.com/id/702973/photo/bodybuilder-jay-cutler-poses-during-the-arnold-classic-2002-february-23-2002-in-columbus-oh.jpg?s=612x612&w=gi&k=20&c=P2UjdlRcstD8CETCQYByU_2yqjx3KWnJ4xInKXIt3T0=", "Evander Holyfield is an American former professional boxer. He reigned as the undisputed champion at cruiserweight in the late 1980s and at heavyweight, and is the only boxer in history to win the undisputed championship in two weight classes in the three belt era. Nicknamed the Real Deal, Holyfield is the only four-time world heavyweight champion, having held the unified WBA, WBC, and IBF titles.", "If something stands between you and your success, move it.", "Evander Holyfield", "Practis Above 20 Years", 180m },
                    { 10, null, "https://upload.wikimedia.org/wikipedia/commons/2/2b/Anthony_Joshua_2017.png", "Anthony Oluwafemi Olaseni Joshua OBE (born 15 October 1989) is a British professional boxer. He is a two-time former unified world heavyweight champion, having held the WBA (Super), IBF, WBO, and IBO titles twice between 2016 and 2021. At regional level, he held the British and Commonwealth heavyweight titles from 2015 to 2016.", "You must not only have competitiveness but ability, regardless of the circumstance you face, to never quit.", "Anthony Joshua", "Practis Above 10 Years", 150m },
                    { 11, null, "https://img.championat.com/s/735x490/news/big/v/s/45-letnij-vladimir-klichko-pokazal-vpechatlyayuschuyu-fizicheskuyu-formu-foto_1621247259885661893.jpg", "Wladimir Klitschko (born 25 March 1976) is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as great footwork and mobility, unusual for boxers of his size", "Just Do It.", "Wladimir Klitschko", "Above 20 Years", 200m },
                    { 12, null, "https://latinbox2011.files.wordpress.com/2018/12/img_5540.jpg", "Hanna Gabriels Valle (born 14 January 1983) is a Costa Rican professional boxer. She has held world championships in four weight classes, having held the WBA female light middleweight title since 2016; the WBA female light heavyweight and WBC female heavyweight titles since April 2021;[nb 1] the WBO welterweight title in 2009; and the WBO light middleweight title twice between 2010 and 2018. As of September 2020, she is ranked as the world's third best active light middleweight by The Ring and BoxRec", "Go For It", "Hanna Gabriels", "Practis Above 7 Years", 100m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_GymId",
                table: "Trainers",
                column: "GymId");

            migrationBuilder.AddForeignKey(
                name: "FK_All_Trainers_TrainerId",
                table: "All",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_All_Trainers_TrainerId",
                table: "All");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_All",
                table: "All");

            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "All",
                newName: "ClassicTrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_All_TrainerId",
                table: "All",
                newName: "IX_All_ClassicTrainerId");

            migrationBuilder.AddColumn<int>(
                name: "BoxingTrainerId",
                table: "All",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_All",
                table: "All",
                columns: new[] { "GymId", "BoxingTrainerId", "ClassicTrainerId", "ProductId" });

            migrationBuilder.CreateTable(
                name: "BoxingTrainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Moto = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Practis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxingTrainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoxingTrainers_Gyms_GymId",
                        column: x => x.GymId,
                        principalTable: "Gyms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClassicTrainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Moto = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Practis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassicTrainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassicTrainers_Gyms_GymId",
                        column: x => x.GymId,
                        principalTable: "Gyms",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BoxingTrainers",
                columns: new[] { "Id", "GymId", "ImageUrl", "Info", "Moto", "Name", "Practis", "PricePerHour" },
                values: new object[,]
                {
                    { 1, null, "https://www.si.com/.image/t_share/MTY4MTk2NjgxODE2NjE0ODEz/1988-mike-tyson-nlc_05245jpg.jpg", "Michael Gerard Tyson is an American former professional boxer whos Nicknam is Iron Mike and Kid Dynamite in his early career, and later known as The Baddest Man on the Planet,Tyson is considered to be one of the greatest heavyweight boxers of all time.He reigned as the undisputed world heavyweight champion. Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title.He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round. Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", "Lets smash some Heads!", "Mike Tyson", "Above 20 Years!", 200m },
                    { 2, null, "https://cdn.britannica.com/86/192386-050-D7F3126D/Muhammad-Ali-American.jpg", "Muhammad Ali born Cassius Marcellus Clay Jr. was an American professional boxer and activist. Nicknamed The Greatest, he is regarded as one of the most significant sports figures of the 20th century and is often regarded as the greatest heavyweight boxer of all time.", "Don't be afraid of failure.", "Muhammad Ali", "Practis Above 10 Years", 160m },
                    { 3, null, "https://media.gettyimages.com/id/702973/photo/bodybuilder-jay-cutler-poses-during-the-arnold-classic-2002-february-23-2002-in-columbus-oh.jpg?s=612x612&w=gi&k=20&c=P2UjdlRcstD8CETCQYByU_2yqjx3KWnJ4xInKXIt3T0=", "Evander Holyfield is an American former professional boxer. He reigned as the undisputed champion at cruiserweight in the late 1980s and at heavyweight, and is the only boxer in history to win the undisputed championship in two weight classes in the three belt era. Nicknamed the Real Deal, Holyfield is the only four-time world heavyweight champion, having held the unified WBA, WBC, and IBF titles.", "If something stands between you and your success, move it.", "Evander Holyfield", "Practis Above 20 Years", 180m },
                    { 4, null, "https://upload.wikimedia.org/wikipedia/commons/2/2b/Anthony_Joshua_2017.png", "Anthony Oluwafemi Olaseni Joshua OBE (born 15 October 1989) is a British professional boxer. He is a two-time former unified world heavyweight champion, having held the WBA (Super), IBF, WBO, and IBO titles twice between 2016 and 2021. At regional level, he held the British and Commonwealth heavyweight titles from 2015 to 2016.", "You must not only have competitiveness but ability, regardless of the circumstance you face, to never quit.", "Anthony Joshua", "Practis Above 10 Years", 150m },
                    { 5, null, "https://img.championat.com/s/735x490/news/big/v/s/45-letnij-vladimir-klichko-pokazal-vpechatlyayuschuyu-fizicheskuyu-formu-foto_1621247259885661893.jpg", "Wladimir Klitschko (born 25 March 1976) is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as great footwork and mobility, unusual for boxers of his size", "Just Do It.", "Wladimir Klitschko", "Above 20 Years", 200m },
                    { 6, null, "https://latinbox2011.files.wordpress.com/2018/12/img_5540.jpg", "Hanna Gabriels Valle (born 14 January 1983) is a Costa Rican professional boxer. She has held world championships in four weight classes, having held the WBA female light middleweight title since 2016; the WBA female light heavyweight and WBC female heavyweight titles since April 2021;[nb 1] the WBO welterweight title in 2009; and the WBO light middleweight title twice between 2010 and 2018. As of September 2020, she is ranked as the world's third best active light middleweight by The Ring and BoxRec", "Go For It", "Hanna Gabriels", "Practis Above 7 Years", 100m }
                });

            migrationBuilder.InsertData(
                table: "ClassicTrainers",
                columns: new[] { "Id", "GymId", "ImageUrl", "Info", "Moto", "Name", "Practis", "PricePerHour" },
                values: new object[,]
                {
                    { 1, null, "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l960.webp", "Arnold Schwarzenegger is known as the Styrian Oak, or Austrian Oak, in the bodybuilding world, where he dwarfed his competition. He won his first amateur Mr. Universe title 20 years old. After moving to California he compete bigger events in the United States, he won three more Mr. Universe titles and then the professional Mr. Olympia title six years in a row before retiring.", "You dream.", "Arnold Schwarzenegger", "Practis Above 20 Years", 200m },
                    { 2, null, "https://www.muscleandfitness.com/wp-content/uploads/2019/10/Chris-Bumstead-Shirtless-Hands-On-Hip.jpg?quality=86&strip=all", "Christopher Adam Bumstead is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.", "Don't be afraid of failure.", "Chris Bumstead", "Practis Above 10 Years", 160m },
                    { 3, null, "https://media.gettyimages.com/id/702973/photo/bodybuilder-jay-cutler-poses-during-the-arnold-classic-2002-february-23-2002-in-columbus-oh.jpg?s=612x612&w=gi&k=20&c=P2UjdlRcstD8CETCQYByU_2yqjx3KWnJ4xInKXIt3T0=", "Jason Isaac Cutler is an American retired professional bodybuilder.An IFBB pro, Cutler is a four-time Mr. Olympia winner and a six-time runner-up, the most in history.", "If something stands between you and your success, move it.", "Jay Cutler", "Practis Above 20 Years", 180m },
                    { 4, null, "https://generationiron.com/wp-content/uploads/2022/01/CED5711A-1DAC-45E1-BB83-5462E5A04652.jpeg", "Dorian Andrew Mientjez Yates is an English retired professional bodybuilder. He won the Mr. Olympia title six consecutive times and has the fifth-highest number of Mr. Olympia wins in history, ranking behind Ronnie Coleman", "You must not only have competitiveness but ability, regardless of the circumstance you face, to never quit.", "Dorian Yates", "Practis Above 20 Years", 170m },
                    { 5, null, "https://yt3.googleusercontent.com/d8GULtiQ88hMBsHr-4P2p4_30wj-QjaZaR_f97WZxDc3EP_vm5wfx-xSazlSEWhilab0Pq7HgA=s900-c-k-c0x00ffffff-no-rj", "Ronald \"Ronnie\" Dean Coleman is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning, dominant body-parts and extremely heavy workouts, making him the strongest bodybuilder of all time.", "Just Do It.", "Ronnie Coleman", "Practis Above 20 Years", 200m },
                    { 6, null, "https://musclehealthmag.com/wp-content/uploads/2019/05/melina5-819x1024.jpg", "A young female bodybuilder at only 22 years old, Melina Keltaniemi is just beginning her career, but she’s off to a flying start!This ripped female bodybuilder came 2nd place in the 2018 Nordic Elite Pro, 3rd place at IFBB Elite Pro Russia, and was 2018's IFBB Elite Pro World Champion. Her drive to become the most successful female bodybuilder is clear, and her mindset matches that of a champion competitor.", "Go For It", "Melina Keltaniemi ", "Practis Above 2 Years", 100m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_All_BoxingTrainerId",
                table: "All",
                column: "BoxingTrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_BoxingTrainers_GymId",
                table: "BoxingTrainers",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassicTrainers_GymId",
                table: "ClassicTrainers",
                column: "GymId");

            migrationBuilder.AddForeignKey(
                name: "FK_All_BoxingTrainers_BoxingTrainerId",
                table: "All",
                column: "BoxingTrainerId",
                principalTable: "BoxingTrainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_All_ClassicTrainers_ClassicTrainerId",
                table: "All",
                column: "ClassicTrainerId",
                principalTable: "ClassicTrainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
