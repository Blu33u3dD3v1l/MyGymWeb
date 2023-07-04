using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 2, null, "This Gym is most popular and most exclusive  private 1 on 1 and group boxing training facility! All of our classes are taught by world-class coaches in a fun and friendly environment. Hybrid offers both Boxing and Muay Thai Kickboxing semi-private classes which focus on proper boxing technique, kicking technique, shadow boxing drills, 1-on-1 mitt work, bag work, and High Intensity Interval Training so you can get amazing results in the fastest time possible. We cap all classes at 6 participants for a more personal group training experience. Burn over 500 calories per class.", "https://e0.pxfuel.com/wallpapers/668/410/desktop-wallpaper-boxing-for-resolution-boxing-boxeo.jpg", "BoxingGym", null, "BigBoxGym" },
                    { 3, null, "This is not just gyms, nor ordinary spa. This is the unique lifestyle club in our country – places where, together with our club members, we realize our common vision of a meaningful life. What is it? To achieve change, health, personal balance and satisfaction through sport in a convenient and accessible way, saving time and effort, but without compromising the rhythm of the big city. Dynamically and purposefully, not with compulsion or with annoyance, but jointly, with fun and at with own pace. Each one of the clubs has a unique interior design, prepared by Pro Design Interiors.", "https://rare-gallery.com/uploads/posts/585296-adult-barbell.jpg", "BodyBuilding", null, "ClassicGym" },
                    { 4, null, "The Pilates method, with its proven beneficial effect on the body, is preferred as a training activity among a large number of ladies. The exercises are performed smoothly, with maximum control in each movement to avoid injuries and achieve the desired results. With regular exercise, you can improve your posture, even your gait. It is a unique system of exercises for stretching and strength, strengthening and toning muscles. No exercise is an end in itself, all the muscles of the body are activated. You will strengthen your muscles and shape your body so that it looks even more graceful, tight and beautiful. Pain in the neck and back is especially affected.By following the exact instructions, at the end of the workout you will feel your body toned and pleasantly relaxed.", "https://fitathletic.com/wp-content/uploads/2014/07/fit_athletic_blog_reformer-pilates-1.jpg", "PilatesGym", null, "PilatesGym" },
                    { 5, null, "You are about to pass through the many dimensions of your own Self. This journey will take you through a transformation of consciousness, across a vital bridge connecting spirit and matter, Heaven and Earth, mind and body. And as you transform yourself, you transform the world.We are committed to providing you with the tools to support you on your journey to a full spectrum yoga experience.We will be glad to meet you!", "https://previews.123rf.com/images/popunderlight/popunderlight1801/popunderlight180100251/92852319-portrait-of-attractive-asian-girl-doing-yoga-exercise-in-gym.jpg", "YogaGym", null, "YogaGym" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupTrainerNames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GroupTrainerNames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GroupTrainerNames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gyms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
