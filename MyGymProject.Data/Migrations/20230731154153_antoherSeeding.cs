using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class antoherSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0c24f29-7f41-4fed-b0e8-cb7b1f4b2acb");

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("31e99531-45ae-47b6-8cb9-47fd77906def"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("414351a0-8248-4113-8253-1faa9da4d0da"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("522c417e-256b-4912-8c7c-737a09343fbf"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("60a4d1cb-48d2-4c23-b857-941129076d64"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("6c3bd660-8594-43b1-8e80-699a9aabadea"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("75ec1fc1-e6c5-4e25-ba8a-2e64d498437b"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("75ecd435-82ac-4d5d-a342-a89a7c56d85b"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("8e8964e8-39ba-451c-aa60-07768f524883"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("98c315d9-2bcc-4e46-ba65-515aea87a5d4"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("9b337e9f-2ffb-45fd-8406-208b8d2ecedf"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("a86b5e48-3208-44f4-86f9-bdf03b2937d9"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("db343277-51c9-45ad-99e1-e0329c481408"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ea8d20ec-9e7b-49e1-9372-82e4d11fb7da"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ebafa41d-5d22-498a-9264-a4047f519d29"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("fea04275-dfbf-4a97-923c-0864ea5a4f44"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Amount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bdb57211-855c-470a-b0f4-817d9335a26b", 0, 1000m, "2a5c2145-34be-4a9f-9cb3-4eacb3c46a7d", "Admin@admin.bg", false, "George", "Bush", false, null, "Admin@admin.bg", "Admin@admin.bg", "AQAAAAEAACcQAAAAEIu8l0aiqjAsbbIXjwZNDgVeanK/7rM8oi+CvxtNmJgf3wbPayygrkyHiZ7lPvSgeA==", null, false, "af6b7e59-d4fc-469f-ad33-fd859951275f", false, "Admin@admin.bg" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Moto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c0029eb-b7ef-4241-b967-4806a3f5eda4"), "https://www.the-sun.com/wp-content/uploads/sites/6/2023/03/karina-elle-lisenbee-fitness-model-801547146.jpg", "Karina Elle Lisenbee is an American Instagram Pilates model, gym instructor and former cross-country runner. She was a cheerleader and cross-country runner during her high school years. At the age of 16, she was spotted by a photographer in a mall, after which she started modeling. She then began to participate in bikini competitions, often winning them. Soon after that, she launched her Instagram account where she started posting her intense gym workouts, which are enough to put the fittest among us to shame. Known for her plyometrics, hack squats and deadlifts, Karina went on to win the ‘World Fitness Federation Pro Bikini Championship’. The famous fitness model has also graced the pages of magazines like ‘Racked’, ‘Hers’, ‘Self’ and ‘Shape’. Additionally, not only does she have brand endorsement deals with major brands like ‘Gymshark’ and ‘Nike’, but she also has her own line of merchandise called ‘Gym Bae’. Needless to say, she is one of the most followed fitness models and instructors on the popular photo-sharing app, Instagram.", true, "In u need a trainer, call me!", "Karina Elle", null, "Above 8 years.", 110m, "PilatesTrainer", null },
                    { new Guid("3a3ccd78-ff24-46fe-a014-ea1e1c3edb22"), "https://storage.googleapis.com/pai-images/803e7f4cfb964082a057d3db348f18b2.jpeg", "Anllela Sagra is a Colombian fitness model, trainer, bodybuilder, and social media personality. Blessed with inherent beauty and strict work ethics, she has emerged as one of the most influential figures in her industry in the recent years. Initially, her aspiration was to become a regular model and fashion designer. She even earned a degree in fashion design from the University of Colombia. However, she decided to become a fitness model after meeting a fitness enthusiast in the gym. The concept of female bodybuilders is still quite novel in her home country as muscles on women are not considered attractive in Colombia. Despite this, Sagra started undergoing weight training and began to put on muscles on her slim frame. Soon enough, she was attending fitness competitions and garnering fans from all over the world on social media. She has over 10 million followers on Instagram and more than one million followers on Facebook. On Twitter and YouTube, the social media platforms on which she is rarely active these days, she has 22.5 thousand followers and 265 thousand subscribers respectively. She has her own app listed on both Apple App Store and Google Play.", true, "The world is mine!", "Anllela Sagra", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("4da5aff1-a01f-4a84-acae-aefba03f9714"), "https://i.pinimg.com/originals/a0/07/34/a00734047b571a8573c6a83f03c6a1fe.jpg", "Wladimir Klitschko is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as athletic footwork and mobility, unusual for boxers of his size.", true, "My Hammer will destroy you!", "Wladimir Klitschko", null, "Above 20 years!", 190m, "BoxingTrainer", null },
                    { new Guid("762d1dd7-ea89-42c3-b9eb-326bf1ed2f77"), "https://www.hfe.co.uk/wp-content/uploads/2018/12/Shaun-Stafford-Headshot1-copy-2-703x1024.jpg", "With a Masters degree in strength and conditioning from Oxford University, Shaun left university and went into a bodybuilding career. He followed that with a semi-professional rugby career and more recently focused on personal training. He supports a number of clients, notably those in a rugby arena from his performance gym and has a huge presence of social media. But despite this level of influence, he encourages aspiring trainers to focus their energy into what’s important to them. He reminds them that an online following isn’t necessary to have a profoundly important impact on someone’s life and to double down on those things that you’re good at and that make you happy.", true, "Train Harder!", "Shaun Stafford", null, "Above 8 years.", 110m, "YogaTrainer", null },
                    { new Guid("9ef3222c-38e6-4efa-98c3-d8f7e050b1bc"), "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60", "Dwayne Douglas Johnson, also known by his ring name the Rock, is an American actor, film producer, and retired professional wrestler. Widely regarded as one of the greatest professional wrestlers of all time,he was integral to the development and success of the World Wrestling Federation (WWF, now WWE) during the Attitude Era, an industry boom period in the late 1990s and early 2000s. Johnson wrestled for the WWF for eight years prior to pursuing an acting career. His films have grossed over $3.5 billion in North America and over $10.5 billion worldwide, making him one of the world's highest-grossing and highest-paid actors.", true, "Just Bring It!", "Dwayne Johnson", null, "Above 8 years.", 200m, "ClassicTrainer", null },
                    { new Guid("b3b954a4-45d8-44a5-b4a1-fe7e71854090"), "https://www.greatestphysiques.com/wp-content/uploads/2018/04/Anna-Victoria.01.jpg", "Anna Victoria is a personal transformation coach and fitness star from the United States of America. Although she's now famous for her healthy and fit figure, Anna's early life looked completely different. She grew up being unaware of the importance of a healthy diet and regular exercise.", true, "Train Even Harder!", "Anna Victoria", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("b85a082c-5146-47ca-bf67-85aa85c9ae14"), "https://xcal.com/wp-content/uploads/2023/02/Rachel.webp", "Exercise professional and sports nutrition specialist, Louise, has published a number of books which have become Sunday Times bestsellers. This isn’t a common achievement, and is evidence of the relatable and compassionate way that Louise discusses the relationship between nourishing your body with food and staying “lean for life”. Since starting her company in 2007, Louise has helped close to 20,000 individuals - a phenomenal number! Louise has taught her methods to a team of coaches so that she’s able to impact even more people each year. Louise is an advocate of connecting goals with values. Both from the perspective of a client connecting with their goal, and also from the perspective of a business owner. Operating from a place of vision means that you’re able to genuinely help people in a way which is meaningful and valuable to them.", true, "Be yourself!", "Louise Parker", null, "Above 12 years.", 130m, "ClassicTrainer", null },
                    { new Guid("b915db81-4905-444c-9c3b-be76f22caf43"), "https://ronniecoleman.net/cdn/shop/products/ronnie-coleman-signature-series-light-weight-baby-tee-apparel-accessories-shirt-29983544049777_1024x1024.jpg?v=1655495689", "Ronald Dean Coleman  is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning,dominant body-parts and extremely heavy workouts,making him the strongest", true, "I pump 200 for chest!", "Ronnie Coleman", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("d1a9a4b2-b2a4-4619-81b3-74b7a799c444"), "https://pagesix.com/wp-content/uploads/sites/3/2022/08/Russell-Hornsby-Mike-Tyson_99-1.jpg?quality=75&strip=all&w=413", "Michael Gerard Tyson is an American former professional boxer who competed from 1985 to 2005. Nicknamed 'Iron Mike' and 'Kid Dynamite' in his early career, and later known as 'The Baddest Man on the Planet',Tyson is regarded as one of the greatest heavyweight boxers of all time.[6] He reigned as the undisputed world heavyweight champion from.Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title. He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round.Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", true, "Give me all the weed in the world.", "Mike Tyson", null, "Above 30 years.", 200m, "BoxingTrainer", null },
                    { new Guid("d416c28b-ad5e-4b6e-ba2b-97946181a340"), "https://e0.pxfuel.com/wallpapers/609/537/desktop-wallpaper-chris-bumstead.jpg", "Christopher Adam Bumstead, known by his fans as CBum, is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.Bumstead maintains a large online presence with content focusing on his lifestyle and bodybuilding.", true, "More Weight.", "Chris Bumstead", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("d5717a35-b7c1-4214-8941-aa0fe20a5753"), "https://www.fitnessindiashow.com/wp-content/uploads/2018/11/Screen-Shot-2018-11-06-at-3.58.11-PM.png", "Michelle Lewin is a Venezuelan fitness coach, model, and YouTube star.She became famous because of her hourglass figure that she flaunts whenever she models.Michelle Lewin began her modeling career on a very small scale. She first discovered it by a photographer and it began her journey as a model.As a model, it is common that they take care of their body and Michelle is no exception. She takes care of her body and keeps in shape by going to the gym.", true, "My baby is better than your!", "Michelle Lewin", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("dbd1130e-7174-4697-ba2f-937bbafc10e7"), "https://img.freepik.com/free-photo/young-adult-doing-indoor-sport-gym_23-2149205542.jpg?w=2000", "Brad Schoenfeld considered one of greatest trainers of all time is a respected trainer, author and professor of exercise science who specialises in the science of bodybuilding and nutritionso he's often referred to as the gym trainer for men. He has spent over 30 years researching in the area of human performance, exercise physiology and muscle hypertrophy, and his work has been featured in major publications such as Men’s Health. He is also the author of numerous best-selling books on strength training and sports nutrition. His legacy lives on with his ongoing commitment to helping people achieve their fitness goals through his knowledge and experience from training thousands of athletes around the world.", true, "Im The Best!", "Brad Schoenfeld", null, "Above 20 years.", 190m, "ClassicTrainer", null },
                    { new Guid("e4ee8eba-0eaa-4ee8-a61d-e53e3746bfc4"), "https://nathealth-assets.s3-eu-west-1.amazonaws.com/articles/Rachel_Brathen.jpg", "Yoga social media star and author Rachel Brathen is well-known for her openness and authenticity. She tells Stacey Carter why she wanted to write her book and how she navigates sharing her life with the world", true, "Let yoga be your life!", "Rachel Braten", null, "Above 8 years.", 100m, "YogaTrainer", null },
                    { new Guid("f3a0b08f-1232-4c39-b1c3-9a7b27e5e490"), "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l1200.webp", "Arnold Alois Schwarzenegger is an Austrian and American actor, businessman, filmmaker, politician, and retired professional bodybuilder best known for his roles in high-profile action movies. He served as the 38th governor of California from 2003 to 2011 and was among Time magazine's 100 most influential people in the world in 2004 and 2007.", true, "I'll be back!", "Arnold Schvarzenegger", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("f49f7697-fa33-49ed-aed5-2f4f5a081861"), "https://firstclasspt.se/____impro/1/onewebmedia/Bigstock/professionella%20manliga%20skola%20sport%20coach%20ger%20tumme.jpg?etag=%22a97572-59303a63%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=321%2B481&extract=28%2B37%2B280%2B421&quality=85", "Matt trains a roster of celebrity clients, is a published author and has his own brand of fitness clothing. But despite this borderline celebrity trainer status, he remains grounded. He knows that working with regular people and helping them to achieve the results they’re looking for is what gets referrals, and word of mouth business. After 23 years of experience in the fitness industry, Matt knows something about being able to relate to others and considers interpersonal skills to be one of the most important assets an aspiring trainer can possess.", true, "I can teach u to fly!", "Matt Roberts", null, "Above 15 years.", 150m, "ClassicTrainer", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdb57211-855c-470a-b0f4-817d9335a26b");

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("1c0029eb-b7ef-4241-b967-4806a3f5eda4"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("3a3ccd78-ff24-46fe-a014-ea1e1c3edb22"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("4da5aff1-a01f-4a84-acae-aefba03f9714"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("762d1dd7-ea89-42c3-b9eb-326bf1ed2f77"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("9ef3222c-38e6-4efa-98c3-d8f7e050b1bc"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("b3b954a4-45d8-44a5-b4a1-fe7e71854090"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("b85a082c-5146-47ca-bf67-85aa85c9ae14"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("b915db81-4905-444c-9c3b-be76f22caf43"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d1a9a4b2-b2a4-4619-81b3-74b7a799c444"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d416c28b-ad5e-4b6e-ba2b-97946181a340"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d5717a35-b7c1-4214-8941-aa0fe20a5753"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("dbd1130e-7174-4697-ba2f-937bbafc10e7"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("e4ee8eba-0eaa-4ee8-a61d-e53e3746bfc4"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f3a0b08f-1232-4c39-b1c3-9a7b27e5e490"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f49f7697-fa33-49ed-aed5-2f4f5a081861"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Amount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b0c24f29-7f41-4fed-b0e8-cb7b1f4b2acb", 0, 1000m, "1e360f8c-b046-43aa-ba71-b2838fe0c43e", "Admin@admin.bg", false, null, null, false, null, null, null, null, null, false, "4a7a7d22-c56d-44ab-a774-a6d8338585d1", false, "Admin@admin.bg" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Moto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("31e99531-45ae-47b6-8cb9-47fd77906def"), "https://www.the-sun.com/wp-content/uploads/sites/6/2023/03/karina-elle-lisenbee-fitness-model-801547146.jpg", "Karina Elle Lisenbee is an American Instagram Pilates model, gym instructor and former cross-country runner. She was a cheerleader and cross-country runner during her high school years. At the age of 16, she was spotted by a photographer in a mall, after which she started modeling. She then began to participate in bikini competitions, often winning them. Soon after that, she launched her Instagram account where she started posting her intense gym workouts, which are enough to put the fittest among us to shame. Known for her plyometrics, hack squats and deadlifts, Karina went on to win the ‘World Fitness Federation Pro Bikini Championship’. The famous fitness model has also graced the pages of magazines like ‘Racked’, ‘Hers’, ‘Self’ and ‘Shape’. Additionally, not only does she have brand endorsement deals with major brands like ‘Gymshark’ and ‘Nike’, but she also has her own line of merchandise called ‘Gym Bae’. Needless to say, she is one of the most followed fitness models and instructors on the popular photo-sharing app, Instagram.", true, "In u need a trainer, call me!", "Karina Elle", null, "Above 8 years.", 110m, "PilatesTrainer", null },
                    { new Guid("414351a0-8248-4113-8253-1faa9da4d0da"), "https://storage.googleapis.com/pai-images/803e7f4cfb964082a057d3db348f18b2.jpeg", "Anllela Sagra is a Colombian fitness model, trainer, bodybuilder, and social media personality. Blessed with inherent beauty and strict work ethics, she has emerged as one of the most influential figures in her industry in the recent years. Initially, her aspiration was to become a regular model and fashion designer. She even earned a degree in fashion design from the University of Colombia. However, she decided to become a fitness model after meeting a fitness enthusiast in the gym. The concept of female bodybuilders is still quite novel in her home country as muscles on women are not considered attractive in Colombia. Despite this, Sagra started undergoing weight training and began to put on muscles on her slim frame. Soon enough, she was attending fitness competitions and garnering fans from all over the world on social media. She has over 10 million followers on Instagram and more than one million followers on Facebook. On Twitter and YouTube, the social media platforms on which she is rarely active these days, she has 22.5 thousand followers and 265 thousand subscribers respectively. She has her own app listed on both Apple App Store and Google Play.", true, "The world is mine!", "Anllela Sagra", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("522c417e-256b-4912-8c7c-737a09343fbf"), "https://nathealth-assets.s3-eu-west-1.amazonaws.com/articles/Rachel_Brathen.jpg", "Yoga social media star and author Rachel Brathen is well-known for her openness and authenticity. She tells Stacey Carter why she wanted to write her book and how she navigates sharing her life with the world", true, "Let yoga be your life!", "Rachel Braten", null, "Above 8 years.", 100m, "YogaTrainer", null },
                    { new Guid("60a4d1cb-48d2-4c23-b857-941129076d64"), "https://www.hfe.co.uk/wp-content/uploads/2018/12/Shaun-Stafford-Headshot1-copy-2-703x1024.jpg", "With a Masters degree in strength and conditioning from Oxford University, Shaun left university and went into a bodybuilding career. He followed that with a semi-professional rugby career and more recently focused on personal training. He supports a number of clients, notably those in a rugby arena from his performance gym and has a huge presence of social media. But despite this level of influence, he encourages aspiring trainers to focus their energy into what’s important to them. He reminds them that an online following isn’t necessary to have a profoundly important impact on someone’s life and to double down on those things that you’re good at and that make you happy.", true, "Train Harder!", "Shaun Stafford", null, "Above 8 years.", 110m, "YogaTrainer", null },
                    { new Guid("6c3bd660-8594-43b1-8e80-699a9aabadea"), "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60", "Dwayne Douglas Johnson, also known by his ring name the Rock, is an American actor, film producer, and retired professional wrestler. Widely regarded as one of the greatest professional wrestlers of all time,he was integral to the development and success of the World Wrestling Federation (WWF, now WWE) during the Attitude Era, an industry boom period in the late 1990s and early 2000s. Johnson wrestled for the WWF for eight years prior to pursuing an acting career. His films have grossed over $3.5 billion in North America and over $10.5 billion worldwide, making him one of the world's highest-grossing and highest-paid actors.", true, "Just Bring It!", "Dwayne Johnson", null, "Above 8 years.", 200m, "ClassicTrainer", null },
                    { new Guid("75ec1fc1-e6c5-4e25-ba8a-2e64d498437b"), "https://firstclasspt.se/____impro/1/onewebmedia/Bigstock/professionella%20manliga%20skola%20sport%20coach%20ger%20tumme.jpg?etag=%22a97572-59303a63%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=321%2B481&extract=28%2B37%2B280%2B421&quality=85", "Matt trains a roster of celebrity clients, is a published author and has his own brand of fitness clothing. But despite this borderline celebrity trainer status, he remains grounded. He knows that working with regular people and helping them to achieve the results they’re looking for is what gets referrals, and word of mouth business. After 23 years of experience in the fitness industry, Matt knows something about being able to relate to others and considers interpersonal skills to be one of the most important assets an aspiring trainer can possess.", true, "I can teach u to fly!", "Matt Roberts", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("75ecd435-82ac-4d5d-a342-a89a7c56d85b"), "https://ronniecoleman.net/cdn/shop/products/ronnie-coleman-signature-series-light-weight-baby-tee-apparel-accessories-shirt-29983544049777_1024x1024.jpg?v=1655495689", "Ronald Dean Coleman  is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning,dominant body-parts and extremely heavy workouts,making him the strongest", true, "I pump 200 for chest!", "Ronnie Coleman", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("8e8964e8-39ba-451c-aa60-07768f524883"), "https://pagesix.com/wp-content/uploads/sites/3/2022/08/Russell-Hornsby-Mike-Tyson_99-1.jpg?quality=75&strip=all&w=413", "Michael Gerard Tyson is an American former professional boxer who competed from 1985 to 2005. Nicknamed 'Iron Mike' and 'Kid Dynamite' in his early career, and later known as 'The Baddest Man on the Planet',Tyson is regarded as one of the greatest heavyweight boxers of all time.[6] He reigned as the undisputed world heavyweight champion from.Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title. He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round.Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", true, "Give me all the weed in the world.", "Mike Tyson", null, "Above 30 years.", 200m, "BoxingTrainer", null },
                    { new Guid("98c315d9-2bcc-4e46-ba65-515aea87a5d4"), "https://i.pinimg.com/originals/a0/07/34/a00734047b571a8573c6a83f03c6a1fe.jpg", "Wladimir Klitschko is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as athletic footwork and mobility, unusual for boxers of his size.", true, "My Hammer will destroy you!", "Wladimir Klitschko", null, "Above 20 years!", 190m, "BoxingTrainer", null },
                    { new Guid("9b337e9f-2ffb-45fd-8406-208b8d2ecedf"), "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l1200.webp", "Arnold Alois Schwarzenegger is an Austrian and American actor, businessman, filmmaker, politician, and retired professional bodybuilder best known for his roles in high-profile action movies. He served as the 38th governor of California from 2003 to 2011 and was among Time magazine's 100 most influential people in the world in 2004 and 2007.", true, "I'll be back!", "Arnold Schvarzenegger", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("a86b5e48-3208-44f4-86f9-bdf03b2937d9"), "https://xcal.com/wp-content/uploads/2023/02/Rachel.webp", "Exercise professional and sports nutrition specialist, Louise, has published a number of books which have become Sunday Times bestsellers. This isn’t a common achievement, and is evidence of the relatable and compassionate way that Louise discusses the relationship between nourishing your body with food and staying “lean for life”. Since starting her company in 2007, Louise has helped close to 20,000 individuals - a phenomenal number! Louise has taught her methods to a team of coaches so that she’s able to impact even more people each year. Louise is an advocate of connecting goals with values. Both from the perspective of a client connecting with their goal, and also from the perspective of a business owner. Operating from a place of vision means that you’re able to genuinely help people in a way which is meaningful and valuable to them.", true, "Be yourself!", "Louise Parker", null, "Above 12 years.", 130m, "ClassicTrainer", null },
                    { new Guid("db343277-51c9-45ad-99e1-e0329c481408"), "https://e0.pxfuel.com/wallpapers/609/537/desktop-wallpaper-chris-bumstead.jpg", "Christopher Adam Bumstead, known by his fans as CBum, is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.Bumstead maintains a large online presence with content focusing on his lifestyle and bodybuilding.", true, "More Weight.", "Chris Bumstead", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("ea8d20ec-9e7b-49e1-9372-82e4d11fb7da"), "https://www.greatestphysiques.com/wp-content/uploads/2018/04/Anna-Victoria.01.jpg", "Anna Victoria is a personal transformation coach and fitness star from the United States of America. Although she's now famous for her healthy and fit figure, Anna's early life looked completely different. She grew up being unaware of the importance of a healthy diet and regular exercise.", true, "Train Even Harder!", "Anna Victoria", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("ebafa41d-5d22-498a-9264-a4047f519d29"), "https://www.fitnessindiashow.com/wp-content/uploads/2018/11/Screen-Shot-2018-11-06-at-3.58.11-PM.png", "Michelle Lewin is a Venezuelan fitness coach, model, and YouTube star.She became famous because of her hourglass figure that she flaunts whenever she models.Michelle Lewin began her modeling career on a very small scale. She first discovered it by a photographer and it began her journey as a model.As a model, it is common that they take care of their body and Michelle is no exception. She takes care of her body and keeps in shape by going to the gym.", true, "My baby is better than your!", "Michelle Lewin", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("fea04275-dfbf-4a97-923c-0864ea5a4f44"), "https://img.freepik.com/free-photo/young-adult-doing-indoor-sport-gym_23-2149205542.jpg?w=2000", "Brad Schoenfeld considered one of greatest trainers of all time is a respected trainer, author and professor of exercise science who specialises in the science of bodybuilding and nutritionso he's often referred to as the gym trainer for men. He has spent over 30 years researching in the area of human performance, exercise physiology and muscle hypertrophy, and his work has been featured in major publications such as Men’s Health. He is also the author of numerous best-selling books on strength training and sports nutrition. His legacy lives on with his ongoing commitment to helping people achieve their fitness goals through his knowledge and experience from training thousands of athletes around the world.", true, "Im The Best!", "Brad Schoenfeld", null, "Above 20 years.", 190m, "ClassicTrainer", null }
                });
        }
    }
}
