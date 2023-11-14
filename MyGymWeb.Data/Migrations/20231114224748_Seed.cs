using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class Seed : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UseCode = table.Column<bool>(type: "bit", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                name: "Applies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Practis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Motto = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ForApplication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applies_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Practis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Motto = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientFullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TrainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id");
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
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AthleteId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gyms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gyms_AspNetUsers_AthleteId",
                        column: x => x.AthleteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Gyms_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersTrainers",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTrainers", x => new { x.UserId, x.TrainerId });
                    table.ForeignKey(
                        name: "FK_UsersTrainers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersTrainers_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EventTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    GymId = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupEvents_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProductCount = table.Column<int>(type: "int", nullable: false),
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
                name: "UsersProducts",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PromoCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProducts", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_UsersProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Amount", "ConcurrencyStamp", "DiscountPrice", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UseCode", "UserName" },
                values: new object[] { "bdb57211-855c-470a-b0f4-817d9335a26b", 0, 1000m, "0ab57721-bcfb-4ec1-99de-94fa5568ff9d", 0m, "Admin@admin.bg", false, "George", "Bush", false, null, "Admin@admin.bg", "Admin@admin.bg", "AQAAAAEAACcQAAAAEHzl4e2kUS4qGxdM9tZK2boXT+WQeN5Lorb+gbwK/hXNxZySeAuhD37IDd5PaN+LwQ==", null, false, "e44f379f-7024-4ba5-9fe9-43ba39d0f4f7", false, false, "Admin@admin.bg" });

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
                columns: new[] { "Id", "AthleteId", "Description", "ImageUrl", "Name", "TrainerId", "Type" },
                values: new object[,]
                {
                    { 1, null, "Jack's boxing gym is a full service fitness facility offering top notch boxing instruction from the best of the best. We are a Pittsburgh Northside family run business that provides family safe boxing fitness, weight training, and circuit training options for men, women, and children of all capabilities. If you want an effective workout that targets all muscle groups, you've come to the right place. GET READY TO WORK. ", "https://i.pinimg.com/originals/30/5a/49/305a49dcb1bfd8267be3f05818a64543.jpg", "Boxing Champions Center", null, "BigBoxGym" },
                    { 2, null, "This Gym is most popular and most exclusive  private 1 on 1 and group boxing training facility! All of our classes are taught by world-class coaches in a fun and friendly environment. Hybrid offers both Boxing and Muay Thai Kickboxing semi-private classes which focus on proper boxing technique, kicking technique, shadow boxing drills, 1-on-1 mitt work, bag work, and High Intensity Interval Training so you can get amazing results in the fastest time possible. We cap all classes at 6 participants for a more personal group training experience. Burn over 500 calories per class.", "https://images.squarespace-cdn.com/content/v1/57e1819b2e69cf0a7552a014/1678287369599-TV986RNEWX85AM1XA2EV/Colosseum+Boxing004.jpg?format=1000w", "Knockdown Warriors", null, "BigBoxGym" },
                    { 4, null, "The Pilates method, with its proven beneficial effect on the body, is preferred as a training activity among a large number of ladies. The exercises are performed smoothly, with maximum control in each movement to avoid injuries and achieve the desired results. With regular exercise, you can improve your posture, even your gait. It is a unique system of exercises for stretching and strength, strengthening and toning muscles. No exercise is an end in itself, all the muscles of the body are activated. You will strengthen your muscles and shape your body so that it looks even more graceful, tight and beautiful. Pain in the neck and back is especially affected.By following the exact instructions, at the end of the workout you will feel your body toned and pleasantly relaxed.", "https://fitathletic.com/wp-content/uploads/2014/07/fit_athletic_blog_reformer-pilates-1.jpg", "Harmony Center", null, "PilatesGym" },
                    { 5, null, "You are about to pass through the many dimensions of your own Self. This journey will take you through a transformation of consciousness, across a vital bridge connecting spirit and matter, Heaven and Earth, mind and body. And as you transform yourself, you transform the world.We are committed to providing you with the tools to support you on your journey to a full spectrum yoga experience.We will be glad to meet you!", "https://previews.123rf.com/images/popunderlight/popunderlight1801/popunderlight180100251/92852319-portrait-of-attractive-asian-girl-doing-yoga-exercise-in-gym.jpg", "Immortal Yoga", null, "YogaGym" },
                    { 6, null, "A mellow paced body conditioning technique that combines breathing, stretching and strengthening to achieve and maintain optimal posture. Allow your body to move freely and efficiently by strengthening your deep abdominal and core stabilisers while relaxing tense neck and shoulder muscles. This class may include bands, circles and or balls.", "https://cdn.pixabay.com/photo/2018/04/05/17/21/kettlebell-3293475_1280.jpg", "Tranquil Studio", null, "YogaGym" },
                    { 9, null, "This is not just gyms, nor ordinary spa. This is the unique lifestyle club in our country – places where, together with our club members, we realize our common vision of a meaningful life. What is it? To achieve change, health, personal balance and satisfaction through sport in a convenient and accessible way, saving time and effort, but without compromising the rhythm of the big city. Dynamically and purposefully, not with compulsion or with annoyance, but jointly, with fun and at with own pace. Each one of the clubs has a unique interior design, prepared by Pro Design Interiors.", "https://www.borntough.com/cdn/shop/articles/Bodybuilding_at_age_30.jpg?v=1639596956&width=1800", "Muscle Monkeys", null, "ClassicGym" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "GymId", "ImageUrl", "IsActive", "Mark", "Name", "Price", "ProductCount" },
                values: new object[,]
                {
                    { 1, "Introducing our sleek and stylish protein shaker bottle - the perfect companion for your workouts and active lifestyle!, Crafted with a perfect size.", null, "https://cdn.shopify.com/s/files/1/0572/7397/4993/products/ShakerBanner_1_1080x.jpg?v=1676866459", true, "WolvesFitness", "Wolves Fitness Shaker Bottle", 30m, 0 },
                    { 2, "The UFE 2in1 Protein Shaker is a premium shaker that is BPA, BPS and BPF free. The Shaker has a 700ml capacity and comes complete dual mixing.", null, "https://files.ekmcdn.com/alphasports86/images/urban-fitness-2in1-protein-shaker-700ml--2023-p.jpg?v=6FB99E0C-5E66-4D39-B4E2-7384D9AB6276", true, "Urban Fitness", "Urban Fitness 2in1 Protein Shaker", 27m, 0 },
                    { 3, "ElephantSkin gloves are designed for (hobby) athletes who do not want to compromise on hygiene during their training.More training, less cleaning - that's the concept behind ElephantSkin's sustainable fitness glove.", null, "https://cdn.shopify.com/s/files/1/0585/3016/9008/products/elephantskin-fitness-handschuhe-titelbild.png?v=1644683288", true, "ElephantSkin Fitness", "The Fitness Gloves", 17m, 0 },
                    { 4, "Keep your hard-earned muscles fed, whether youre at home or at the gym. Stay fit & consistent with your protein supplementation & stay strong around the clock, in the gym or at home. Pro series whey has a scientific combination of whey isolate (fast) for immediate absorption and whey concentrate (slow digesting) to give feed your muscles for longer time a protein drink thats richer & tastier than any whey protein in india", null, "https://gonobs.com/cdn/shop/files/raging-whey-listing-creative-1.png?v=1696973140", true, "Goodlife", "Pro Nutrition and Fitness", 50m, 0 },
                    { 5, "Products with electrical plugs are designed for use in the US. Outlets and voltage differ internationally and this product may require an adapter or converter for use in your destination. Please check compatibility before purchasing.", null, "https://fitness1.bg/products/u/levrone-wellness-series-l-carnitine-125000-1-l-1786f0c.jpg", true, "Goodlife", "L-Carnitine", 14m, 0 },
                    { 6, "At Fitness Superstore, we have the most rigorous remanufacturing process in the industry. All machines are disassembled, sand blasted, and repainted. Parts, belts, bearings, and batteries are replaced on every machine. All other parts that are worn more that 25% are replaced. We guarantee (Covered by our Warranty) your machine to be in “like new” working and “close to new” cosmetic condition. Click Play on the video below for through details.", null, "https://www.fitnesssuperstore.com/v/vspfiles/templates/fitness-resp/images/homepage/product-slider/precor-ellipticals.jpg", true, "Force USA G20.", "New & Refurbished Gym & Fitness Equipment For Sale", 150m, 0 },
                    { 7, "The French Fitness FSR100 Commercial Functional Smith Rack System features an innovative structure that combines arm and leg stations for strengthening different muscle groups and executing comprehensive workouts, limiting the need to switch between gym equipment. The FSR100 is a complete training system made with a heavy-duty steel frame reinforced with a durable powder-coated finish. Utilizes sturdy aircraft cable with a tensile strength of 2,000lb that's guaranteed to withstand intense long-lasting use. Standard weight horns let you organize weights on the machine for easy accessibility. Engage in intense weightlifting or strength training right in the comfort of your home with the French Fitness FSR100 Commercial Functional Smith Rack System.", null, "https://cdn3.volusion.com/aqyor.dadrn/v/vspfiles/photos/FF-FSR100-2.jpg?v-cache=1682102760", true, "Force USA G20.", "Smith Machine", 880m, 0 },
                    { 8, "This multi-station workhorse provides health club quality strength training for up to three people simultaneously (with optional GKR9). The G9 series of gyms features a multi-function Press Arm Station for bench press, incline press, shoulder press and chest supported mid row exercises. The Perfect Pec Station with fully adjustable range of motion allows users to achieve deeper muscle penetration for faster, more defined results. The Leg Press/ Calf Press Station operates on its own separate weight stack, with a 2 to 1 weight ratio, giving the G9 Gyms the awesome capacity of a 420 lb leg press. Add the optional Vertical Knee Raise / Dip Station (GKR9) and up to three people can workout simultaneously on the G9S.", null, "https://cdn3.volusion.com/aqyor.dadrn/v/vspfiles/photos/bsldG9S-2.jpg?v-cache=1669221040", true, "American Musle", "Body-Solid G9S Selectorized", 880m, 0 },
                    { 9, "The French Fitness FL70 Freeweight Leverage Gym System is a multifunctional training device that can be used by three people at the same time. The FL70 guarantees a complete heavy-duty workout without the need for a spotter. Perform high pulls, kicks, biceps/triceps, standing calves, press training and a lot more on this versatile leverage free weight gym.", null, "https://cdn11.bigcommerce.com/s-47lrg8qzg0/images/stencil/500x659/products/16275/375950/ff-x10__80072.1698736148.jpg?c=1", true, "Olympic Weight", "French Fitness FL70 Freeweight", 1999m, 0 },
                    { 10, "Equipped with the Venum Gel Shock system, these Venum Body fitness gloves offer effective protection and shock absorption, so that you are comfortable during all phases of training.", null, "https://cdn.webshopapp.com/shops/16221/files/401178608/930x1240x3/venum-venum-aero-body-fitness-gloves-black-pink.jpg", true, "Venum", "Venum Aero Body Fitness Gloves Black Pink", 34.95m, 0 },
                    { 11, "These multi-purpose resistance bands are light and very easily transportable. These are muscle building accessories that, depending on the use and the resistance chosen, will help develop your strength, flexibility or mobility.", null, "https://cdn.webshopapp.com/shops/16221/files/360675752/930x1240x3/venum-venum-challenger-resistance-band-purple-22-3.jpg", true, "Venum", "Venum Challenger Resistance Band Purple", 34.60m, 0 },
                    { 12, "Isolating and recruiting every muscle within your core, the Venu Challenger abdominal wheel is a strength accessory used to build endurance, simple but incredibly effective.", null, "https://cdn.webshopapp.com/shops/16221/files/348996905/930x1240x3/venum-venum-challenger-abs-wheel-yellow-black-venu.jpg", true, "Venum", "Challenger ABS Wheel", 19.99m, 0 },
                    { 13, "Bad Boy has been involved in the sport since the early nineties and is one of the original supporters of mixed martial arts and Jiu Jitsu tournaments.", null, "https://cdn.webshopapp.com/shops/16221/files/422027250/466x544x1/image.jpg", true, "Bad Boy", "Bad Boy MMA Fightshorts Capo 2 White", 19.99m, 0 },
                    { 14, "Booster Boxing Gloves Pro Shield 3 Green.  Booster Boxing Gloves Pro Shield are a Top quality 100% handmade in Thailand genuine leather professional sparring and training gloves by Booster Fightgear.   Multi-layered high and low density foam core ensures the best protection for the knuckles and maximizes impact dispersion for ultimate fighter protection on the wrist.  Booster Pro Shield are made with a full +/- 8cm wide Velcro closure to ensure proper wrist support. Extra padded palm for increased support and added defensive protection   The interior lining is made to dry quickly to help rid the gloves of moisture and perspiration   Booster Pro Range Boxing Gloves are double stitched for extra durability with perfectly positioned attached thumb .  These gloves meet international standards and offer incredible results.  Specification’s Booster Boxing Gloves Pro Shield :  • Booster Kickboxing Gloves are Handmade in Thailand. • Attached thumb for extra safety. Booster Fight Gear Europe. • Durable Long Lasting Velcro closure. • 100% A-grade Cowhide Thai leather.", null, "https://cdn.webshopapp.com/shops/16221/files/395465361/466x544x1/image.jpg", true, "Booster", "Booster Boxing Gloves Pro Shield 3 Green", 129.00m, 0 },
                    { 15, "Venum Rafter Sweatshirt Dark Heather Grey.  The Venum Rafter sweatshirt is an ultra comfortable fleece crewneck.  The 3D printing on the chest gives an original relief to this sweatshirt, which can be worn with jeans as well as with the Venum Rafter jogging pants.  The design marks a notable graphic evolution compared to previous collections.  Specification's Venum Rafter Sweatshirt :  • 55% Cotton / 45% Polyester • Fleece lining • Jacquard bands • Embroidered Venum logo • 3D printing • Straight cut • Machine wash at 30 °: do not iron or tumble dry", null, "https://cdn.webshopapp.com/shops/16221/files/421682446/930x1240x3/venum-venum-rafter-sweatshirt-dark-heather-grey.jpg", true, "Venum", "Rafter Sweatshirt Dark Heather Grey", 49.95m, 0 },
                    { 16, "Hayabusa Kanpeki T3 LX Hybrid Sparring Gloves 7oz Italian Leather.  The Next Generation Of Kanpeki: The Hayabusa T3 LX 7oz MMA Gloves. Luxurious full-grain Italian leather.  Hayabusa Kanpeki T3 LX MMA Hybrids Sparring Gloves combine the best of both worlds.  For Fitness:  Maximize your high intensity interval training by going from the punching bag to the skipping rope, to crunches with a medicine ball and back to the bag.  For MMA:  The padding you need for heavy bag work with the flexibility of an open palm glove. This glove allows you to go from striking to grappling with ease while staying in place the whole time.  PERFECT FIT AND FEEL  The multi-directional Dual-X closure is unmatched when it comes to hand and wrist stabilization for the best protection and injury prevention possible.  INDUSTRY-LEADING WRIST SUPPORT  The best closure system ever created. Hayabusa’s patented wrist support technology helps eliminate hand strain to ensure the best in protection and safety.  CONSISTENT PERFORMANCE AND DURABILITY, PUNCH AFTER PUNCH  Hayabusa gloves are built to last. The attention to detail and craftsmanship guarantees a glove as resilient as the athletes who use it.", null, "https://cdn.webshopapp.com/shops/16221/files/323824938/930x1240x3/hayabusa-hayabusa-kanpeki-t3-lx-hybrid-sparring-gl.jpg", true, "Hayabusa", "Hayabusa Kanpeki T3 LX Hybrid Sparring Gloves 7oz ", 142.99m, 0 },
                    { 17, "Venum Koi Rashguard Long Sleeves Black Blue.  Expert Tip: Venum Rashguards have very tight Fit. If you want to be more comfortable, we advise you to take minimal one size more than you take for a classic compression top.  With its one-of-a-kind attention to detail, the Venum Koi Rashguard brings an exclusive quality design like no other.  Made with a blend of spandex and elastane, the Venum Koi Rashguard perfectly fits every curve of your body, which minimizes your opponents’ grasps during grappling as well as protecting you against cuts and other skin abrasions.  The distinctive Koi design is sublimated into the fabric and the seams have been specifically strengthened for longer lasting vibrant durability.  Day after day, fight after fight, dominate your opponent with the Venum Koi Rashguard.  Specification's Venum Koi Rash Guard :  • Composition: 35% Cotton 65% Polyester • Care instructions: Do not bleach, do not iron, do not tumble dry, machine wash at 30°C • Sport: MMA, Grappling, BJJ • Collar shape: Round neck • Pattern / Color: Printed • Extras: Quick drying • Additional information: Reinforced seams, Silicone elastic bands at the bottom, Protects from chafing and burning • Properties: Breathable, quick drying", null, "https://cdn.webshopapp.com/shops/16221/files/433053093/930x1240x3/venum-venum-koi-rashguard-long-sleeves-black-blue.jpg", true, "Venum", "Venum Koi Rashguard Long Sleeves Black Blue", 59.95m, 0 },
                    { 18, "Venum Elite Boxing Gloves Microfiber White Silver.\r\n\r\nThe triple density foam balances the shock, improving you as a fighter without the stress on your arms during impacts.\r\n\r\nAssembled and hand-sewn in Thailand, these boxing gloves have been designed for regular and intensive use.\r\n\r\nThe unique design and brand new colors are fit for all the fighters, no matter their level.\r\n\r\nThe reinforced seams and mesh panels combined with their ergonomic shape will bring you a comfortable fit and feel as if you are truly one with the glove.\r\n\r\nSpecification's Venum Elite Boxing Gloves :\r\n\r\n• Fully handmade in Thailand\r\n• Premium semi leather construction\r\n• Specific mesh panel placed under the fist for great thermal regulation\r\n• Triple density foam\r\n• Reinforced palm for a maximum absorption\r\n• 100% full attached thumb for a better injury prevention\r\n• Strengthened seams for a long-lasting quality\r\n• Large Velcro enclosure\r\n• Long cuffs improving wrist protection", null, "https://cdn.webshopapp.com/shops/16221/files/433528738/930x1240x3/venum-venum-elite-boxing-gloves-microfiber-white-s.jpg", true, "Venum", "Venum Elite Boxing Gloves Microfiber White Silver", 89.95m, 0 },
                    { 19, "The PTS Lite, or Venum Power Training System Lite is a lite version of the original PTS.\r\n\r\nIt is a modular exercise system that will allow you to develop your endurance as well as your strength and your durability.\r\n\r\nEasily transportable and attachable almost anywhere, the Venum PTS Lite adapts to athletes of all levels: the variety and intensity of the exercises is adjustable to your goals, your level and your favorite discipline.\r\n\r\nInstalling the Power Training System is quick and easy, in the gym as well as at home training.", null, "https://cdn.webshopapp.com/shops/16221/files/350147425/466x544x1/image.jpg", true, "Venum", "Venum Power Training System Lite - PTS Lite", 99.99m, 0 },
                    { 20, "The Punch Round \"No-Fear\" kickboxing shin guards combine a good fit, high quality with good durability. They are made from a high-quality artificial leather. With a 3-layer shock-absorbing foam for optimum protection.\r\n\r\nThe attachment is made of 2 sturdy velcro closure for a good and lasting fit during training and sparring.", null, "https://cdn.webshopapp.com/shops/16221/files/327053024/375x500x2/punchr-punch-round-kids-nofear-kickboxing-shin-gua.jpg", true, "Punch Round", "Punch Round Kids NoFear Kickboxing Shin Guards Black White", 34.90m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Motto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("00bf85e6-178f-49b3-a5e9-74b26b848bb4"), "https://i.pinimg.com/originals/a0/07/34/a00734047b571a8573c6a83f03c6a1fe.jpg", "Wladimir Klitschko is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as athletic footwork and mobility, unusual for boxers of his size.", true, "My Hammer will destroy you!", "Wladimir Klitschko", null, "Above 20 years!", 190m, "BoxingTrainer", null },
                    { new Guid("0c874878-6c14-4c2f-9229-d46c4b93d1e9"), "https://www.greatestphysiques.com/wp-content/uploads/2018/04/Anna-Victoria.01.jpg", "Anna Victoria is a personal transformation coach and fitness star from the United States of America. Although she's now famous for her healthy and fit figure, Anna's early life looked completely different. She grew up being unaware of the importance of a healthy diet and regular exercise.", true, "Train Even Harder!", "Anna Victoria", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("3b685787-02f6-4b2e-9459-62a17982ef9e"), "https://img.freepik.com/free-photo/young-adult-doing-indoor-sport-gym_23-2149205542.jpg?w=2000", "Brad Schoenfeld considered one of greatest trainers of all time is a respected trainer, author and professor of exercise science who specialises in the science of bodybuilding and nutritionso he's often referred to as the gym trainer for men. He has spent over 30 years researching in the area of human performance, exercise physiology and muscle hypertrophy, and his work has been featured in major publications such as Men’s Health. He is also the author of numerous best-selling books on strength training and sports nutrition. His legacy lives on with his ongoing commitment to helping people achieve their fitness goals through his knowledge and experience from training thousands of athletes around the world.", true, "Im The Best!", "Brad Schoenfeld", null, "Above 20 years.", 190m, "ClassicTrainer", null },
                    { new Guid("4cf499e9-dbd6-42ba-8e53-cb328a3f88db"), "https://pagesix.com/wp-content/uploads/sites/3/2022/08/Russell-Hornsby-Mike-Tyson_99-1.jpg?quality=75&strip=all&w=413", "Michael Gerard Tyson is an American former professional boxer who competed from 1985 to 2005. Nicknamed 'Iron Mike' and 'Kid Dynamite' in his early career, and later known as 'The Baddest Man on the Planet',Tyson is regarded as one of the greatest heavyweight boxers of all time.[6] He reigned as the undisputed world heavyweight champion from.Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title. He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round.Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", true, "Give me all the weed in the world.", "Mike Tyson", null, "Above 30 years.", 200m, "BoxingTrainer", null },
                    { new Guid("50b5a7e2-eef3-42fe-a5f6-093314b82966"), "https://www.the-sun.com/wp-content/uploads/sites/6/2023/03/karina-elle-lisenbee-fitness-model-801547146.jpg", "Karina Elle Lisenbee is an American Instagram Pilates model, gym instructor and former cross-country runner. She was a cheerleader and cross-country runner during her high school years. At the age of 16, she was spotted by a photographer in a mall, after which she started modeling. She then began to participate in bikini competitions, often winning them. Soon after that, she launched her Instagram account where she started posting her intense gym workouts, which are enough to put the fittest among us to shame. Known for her plyometrics, hack squats and deadlifts, Karina went on to win the ‘World Fitness Federation Pro Bikini Championship’. The famous fitness model has also graced the pages of magazines like ‘Racked’, ‘Hers’, ‘Self’ and ‘Shape’. Additionally, not only does she have brand endorsement deals with major brands like ‘Gymshark’ and ‘Nike’, but she also has her own line of merchandise called ‘Gym Bae’. Needless to say, she is one of the most followed fitness models and instructors on the popular photo-sharing app, Instagram.", true, "If u need a trainer, call me!", "Karina Elle", null, "Above 8 years.", 110m, "PilatesTrainer", null },
                    { new Guid("53cad477-d4a2-4ccf-8887-50599edfeada"), "https://firstclasspt.se/____impro/1/onewebmedia/Bigstock/professionella%20manliga%20skola%20sport%20coach%20ger%20tumme.jpg?etag=%22a97572-59303a63%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=321%2B481&extract=28%2B37%2B280%2B421&quality=85", "Matt trains a roster of celebrity clients, is a published author and has his own brand of fitness clothing. But despite this borderline celebrity trainer status, he remains grounded. He knows that working with regular people and helping them to achieve the results they’re looking for is what gets referrals, and word of mouth business. After 23 years of experience in the fitness industry, Matt knows something about being able to relate to others and considers interpersonal skills to be one of the most important assets an aspiring trainer can possess.", true, "I can teach u to fly!", "Matt Roberts", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("69d0d38e-f12c-4c2d-8b6b-1a8fdb75bb39"), "https://storage.googleapis.com/pai-images/803e7f4cfb964082a057d3db348f18b2.jpeg", "Anllela Sagra is a Colombian fitness model, trainer, bodybuilder, and social media personality. Blessed with inherent beauty and strict work ethics, she has emerged as one of the most influential figures in her industry in the recent years. Initially, her aspiration was to become a regular model and fashion designer. She even earned a degree in fashion design from the University of Colombia. However, she decided to become a fitness model after meeting a fitness enthusiast in the gym. The concept of female bodybuilders is still quite novel in her home country as muscles on women are not considered attractive in Colombia. Despite this, Sagra started undergoing weight training and began to put on muscles on her slim frame. Soon enough, she was attending fitness competitions and garnering fans from all over the world on social media. She has over 10 million followers on Instagram and more than one million followers on Facebook. On Twitter and YouTube, the social media platforms on which she is rarely active these days, she has 22.5 thousand followers and 265 thousand subscribers respectively. She has her own app listed on both Apple App Store and Google Play.", true, "The world is mine!", "Anllela Sagra", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("833535ae-59f3-47af-9390-b1aedc80ee1e"), "https://nathealth-assets.s3-eu-west-1.amazonaws.com/articles/Rachel_Brathen.jpg", "Yoga social media star and author Rachel Brathen is well-known for her openness and authenticity. She tells Stacey Carter why she wanted to write her book and how she navigates sharing her life with the world", true, "Let yoga be your life!", "Rachel Braten", null, "Above 8 years.", 100m, "YogaTrainer", null },
                    { new Guid("a3c50f8b-f16a-4bc3-97ff-7ad9f8b2cf9f"), "https://ronniecoleman.net/cdn/shop/products/ronnie-coleman-signature-series-light-weight-baby-tee-apparel-accessories-shirt-29983544049777_1024x1024.jpg?v=1655495689", "Ronald Dean Coleman  is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning,dominant body-parts and extremely heavy workouts,making him the strongest", true, "I pump 200 for chest!", "Ronnie Coleman", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("c1d71d81-0920-4f92-996d-c1dd9df6241c"), "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60", "Dwayne Douglas Johnson, also known by his ring name the Rock, is an American actor, film producer, and retired professional wrestler. Widely regarded as one of the greatest professional wrestlers of all time,he was integral to the development and success of the World Wrestling Federation (WWF, now WWE) during the Attitude Era, an industry boom period in the late 1990s and early 2000s. Johnson wrestled for the WWF for eight years prior to pursuing an acting career. His films have grossed over $3.5 billion in North America and over $10.5 billion worldwide, making him one of the world's highest-grossing and highest-paid actors.", true, "Just Bring It!", "Dwayne Johnson", null, "Above 8 years.", 200m, "ClassicTrainer", null },
                    { new Guid("c2cabb17-3c8e-4532-bc18-1a0f53eb559e"), "https://e0.pxfuel.com/wallpapers/609/537/desktop-wallpaper-chris-bumstead.jpg", "Christopher Adam Bumstead, known by his fans as CBum, is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.Bumstead maintains a large online presence with content focusing on his lifestyle and bodybuilding.", true, "More Weight.", "Chris Bumstead", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("d4740918-2f83-4807-a51a-1e53d8adb458"), "https://www.hfe.co.uk/wp-content/uploads/2018/12/Shaun-Stafford-Headshot1-copy-2-703x1024.jpg", "With a Masters degree in strength and conditioning from Oxford University, Shaun left university and went into a bodybuilding career. He followed that with a semi-professional rugby career and more recently focused on personal training. He supports a number of clients, notably those in a rugby arena from his performance gym and has a huge presence of social media. But despite this level of influence, he encourages aspiring trainers to focus their energy into what’s important to them. He reminds them that an online following isn’t necessary to have a profoundly important impact on someone’s life and to double down on those things that you’re good at and that make you happy.", true, "Train Harder!", "Shaun Stafford", null, "Above 8 years.", 110m, "YogaTrainer", null }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Motto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("e0ba061b-78ff-4e90-90b4-aa95ee0e4462"), "https://xcal.com/wp-content/uploads/2023/02/Rachel.webp", "Exercise professional and sports nutrition specialist, Louise, has published a number of books which have become Sunday Times bestsellers. This isn’t a common achievement, and is evidence of the relatable and compassionate way that Louise discusses the relationship between nourishing your body with food and staying “lean for life”. Since starting her company in 2007, Louise has helped close to 20,000 individuals - a phenomenal number! Louise has taught her methods to a team of coaches so that she’s able to impact even more people each year. Louise is an advocate of connecting goals with values. Both from the perspective of a client connecting with their goal, and also from the perspective of a business owner. Operating from a place of vision means that you’re able to genuinely help people in a way which is meaningful and valuable to them.", true, "Be yourself!", "Louise Parker", null, "Above 12 years.", 130m, "ClassicTrainer", null },
                    { new Guid("e78f0704-5678-4f59-92d5-fe46c2a91129"), "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l1200.webp", "Arnold Alois Schwarzenegger is an Austrian and American actor, businessman, filmmaker, politician, and retired professional bodybuilder best known for his roles in high-profile action movies. He served as the 38th governor of California from 2003 to 2011 and was among Time magazine's 100 most influential people in the world in 2004 and 2007.", true, "I'll be back!", "Arnold Schvarzenegger", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("f01fe197-70de-40b9-882f-e663aa59e2dd"), "https://www.fitnessindiashow.com/wp-content/uploads/2018/11/Screen-Shot-2018-11-06-at-3.58.11-PM.png", "Michelle Lewin is a Venezuelan fitness coach, model, and YouTube star.She became famous because of her hourglass figure that she flaunts whenever she models.Michelle Lewin began her modeling career on a very small scale. She first discovered it by a photographer and it began her journey as a model.As a model, it is common that they take care of their body and Michelle is no exception. She takes care of her body and keeps in shape by going to the gym.", true, "My baby is better than your!", "Michelle Lewin", null, "Above 15 years.", 150m, "ClassicTrainer", null }
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
                name: "IX_Applies_UserId",
                table: "Applies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TrainerId",
                table: "Appointments",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

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
                name: "IX_Gyms_AthleteId",
                table: "Gyms",
                column: "AthleteId");

            migrationBuilder.CreateIndex(
                name: "IX_Gyms_TrainerId",
                table: "Gyms",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GymId",
                table: "Products",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_UserId",
                table: "Trainers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersProducts_ProductId",
                table: "UsersProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersTrainers_TrainerId",
                table: "UsersTrainers",
                column: "TrainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applies");

            migrationBuilder.DropTable(
                name: "Appointments");

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
                name: "UsersProducts");

            migrationBuilder.DropTable(
                name: "UsersTrainers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "GroupTrainerNames");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Gyms");

            migrationBuilder.DropTable(
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
