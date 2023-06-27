using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymProject.Data.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupTrainerNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTrainerNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gyms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gyms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoxingTrainers",
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
                    table.PrimaryKey("PK_ClassicTrainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassicTrainers_Gyms_GymId",
                        column: x => x.GymId,
                        principalTable: "Gyms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GymsUsers",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GymId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymsUsers", x => new { x.GymId, x.UserId });
                    table.ForeignKey(
                        name: "FK_GymsUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymsUsers_Gyms_GymId",
                        column: x => x.GymId,
                        principalTable: "Gyms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GymId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Gyms_GymId",
                        column: x => x.GymId,
                        principalTable: "Gyms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EventTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    GymId = table.Column<int>(type: "int", nullable: false),
                    GroupTrainerNamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupEvents_GroupTrainerNames_GroupTrainerNamesId",
                        column: x => x.GroupTrainerNamesId,
                        principalTable: "GroupTrainerNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupEvents_Gyms_GymId",
                        column: x => x.GymId,
                        principalTable: "Gyms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupEvents_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "All",
                columns: table => new
                {
                    GymId = table.Column<int>(type: "int", nullable: false),
                    BoxingTrainerId = table.Column<int>(type: "int", nullable: false),
                    ClassicTrainerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_All", x => new { x.GymId, x.BoxingTrainerId, x.ClassicTrainerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_All_BoxingTrainers_BoxingTrainerId",
                        column: x => x.BoxingTrainerId,
                        principalTable: "BoxingTrainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_All_ClassicTrainers_ClassicTrainerId",
                        column: x => x.ClassicTrainerId,
                        principalTable: "ClassicTrainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_All_Gyms_GymId",
                        column: x => x.GymId,
                        principalTable: "Gyms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_All_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "GroupTrainerNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Desy Perez" },
                    { 2, "John Doe" },
                    { 3, "Kevin Friend" }
                });

            migrationBuilder.InsertData(
                table: "Gyms",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "This Gym is most popular and most exclusive  private 1 on 1 and group boxing training facility! All of our classes are taught by world-class coaches in a fun and friendly environment. Hybrid offers both Boxing and Muay Thai Kickboxing semi-private classes which focus on proper boxing technique, kicking technique, shadow boxing drills, 1-on-1 mitt work, bag work, and High Intensity Interval Training so you can get amazing results in the fastest time possible. We cap all classes at 6 participants for a more personal group training experience. Burn over 500 calories per class.", "https://t4.ftcdn.net/jpg/01/81/13/87/360_F_181138772_ihC3eeSfzQCIUBCZTQC9i6odb8ALOjUw.jpg", "BoxingGym", "BigBoxGym" },
                    { 2, "This is not just gyms, nor ordinary spa. This is the unique lifestyle club in our country – places where, together with our club members, we realize our common vision of a meaningful life. What is it? To achieve change, health, personal balance and satisfaction through sport in a convenient and accessible way, saving time and effort, but without compromising the rhythm of the big city. Dynamically and purposefully, not with compulsion or with annoyance, but jointly, with fun and at with own pace. Each one of the clubs has a unique interior design, prepared by Pro Design Interiors.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQnt7cNQqkpsp8fnIxvd5p_isrMs_NLaioC1-2Z5vn7XQ&s", "BodyBuilding", "ClassicGym" },
                    { 3, "The Pilates method, with its proven beneficial effect on the body, is preferred as a training activity among a large number of ladies. The exercises are performed smoothly, with maximum control in each movement to avoid injuries and achieve the desired results. With regular exercise, you can improve your posture, even your gait. It is a unique system of exercises for stretching and strength, strengthening and toning muscles. No exercise is an end in itself, all the muscles of the body are activated. You will strengthen your muscles and shape your body so that it looks even more graceful, tight and beautiful. Pain in the neck and back is especially affected.By following the exact instructions, at the end of the workout you will feel your body toned and pleasantly relaxed.", "https://fitathletic.com/wp-content/uploads/2014/07/fit_athletic_blog_reformer-pilates-1.jpg", "PilatesGym", "PilatesGym" },
                    { 4, "You are about to pass through the many dimensions of your own Self. This journey will take you through a transformation of consciousness, across a vital bridge connecting spirit and matter, Heaven and Earth, mind and body. And as you transform yourself, you transform the world.We are committed to providing you with the tools to support you on your journey to a full spectrum yoga experience.We will be glad to meet you!", "https://previews.123rf.com/images/popunderlight/popunderlight1801/popunderlight180100251/92852319-portrait-of-attractive-asian-girl-doing-yoga-exercise-in-gym.jpg", "YogaGym", "YogaGym" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "GymId", "ImageUrl", "Mark", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Introducing our sleek and stylish protein shaker bottle - the perfect companion for your workouts and active lifestyle!, Crafted with a perfect size.", null, "https://cdn.shopify.com/s/files/1/0572/7397/4993/products/ShakerBanner_1_1080x.jpg?v=1676866459", "WolvesFitness", "Wolves Fitness Shaker Bottle", 30 },
                    { 2, "The UFE 2in1 Protein Shaker is a premium shaker that is BPA, BPS and BPF free. The Shaker has a 700ml capacity and comes complete dual mixing.", null, "https://files.ekmcdn.com/alphasports86/images/urban-fitness-2in1-protein-shaker-700ml--2023-p.jpg?v=6FB99E0C-5E66-4D39-B4E2-7384D9AB6276", "Urban Fitness", "Urban Fitness 2in1 Protein Shaker", 27 },
                    { 3, "ElephantSkin gloves are designed for (hobby) athletes who do not want to compromise on hygiene during their training.More training, less cleaning - that's the concept behind ElephantSkin's sustainable fitness glove.", null, "https://cdn.shopify.com/s/files/1/0585/3016/9008/products/elephantskin-fitness-handschuhe-titelbild.png?v=1644683288", "ElephantSkin Fitness", "The Fitness Gloves", 17 },
                    { 4, "Keep your hard-earned muscles fed, whether youre at home or at the gym. Stay fit & consistent with your protein supplementation & stay strong around the clock, in the gym or at home. Pro series whey has a scientific combination of whey isolate (fast) for immediate absorption and whey concentrate (slow digesting) to give feed your muscles for longer time a protein drink thats richer & tastier than any whey protein in india", null, "https://cdn.shopify.com/s/files/1/0233/6459/9885/products/51v0EC9aP5L._SL1080.jpg?v=1666270776", "Goodlife", "Pro Nutrition and Fitness", 50 },
                    { 5, "Products with electrical plugs are designed for use in the US. Outlets and voltage differ internationally and this product may require an adapter or converter for use in your destination. Please check compatibility before purchasing.", null, "https://fitness1.bg/products/u/levrone-wellness-series-l-carnitine-125000-1-l-1786f0c.jpg", "Goodlife", "L-Carnitine", 14 }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pilates" },
                    { 2, "Yoga" },
                    { 3, "Classic" },
                    { 4, "Boxing" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_All_BoxingTrainerId",
                table: "All",
                column: "BoxingTrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_All_ClassicTrainerId",
                table: "All",
                column: "ClassicTrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_All_ProductId",
                table: "All",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BoxingTrainers_GymId",
                table: "BoxingTrainers",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassicTrainers_GymId",
                table: "ClassicTrainers",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupEvents_GroupTrainerNamesId",
                table: "GroupEvents",
                column: "GroupTrainerNamesId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupEvents_GymId",
                table: "GroupEvents",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupEvents_TypeId",
                table: "GroupEvents",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GymsUsers_UserId",
                table: "GymsUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GymId",
                table: "Products",
                column: "GymId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "All");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GroupEvents");

            migrationBuilder.DropTable(
                name: "GymsUsers");

            migrationBuilder.DropTable(
                name: "BoxingTrainers");

            migrationBuilder.DropTable(
                name: "ClassicTrainers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "GroupTrainerNames");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Gyms");
        }
    }
}
