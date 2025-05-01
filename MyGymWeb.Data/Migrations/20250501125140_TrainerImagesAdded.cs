using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyGymWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class TrainerImagesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("06cb4840-6506-413d-95b2-474364a1f371"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("10782d15-b390-4be4-a0ae-e73b4b020e18"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("1ad2ca87-01c8-485d-a5e3-4118c5e2fa53"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("53569872-3c7a-4216-81e4-c86d3d0723c8"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("5dd4a1eb-99e5-4ba8-a8cc-4084fa215fa7"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("6268ee23-3538-4239-90bd-c53d181e0ba6"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("78602ed8-d406-4fda-b8c7-6f018f96c1ea"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("870dad61-30f9-474e-a8f1-e822f5a3daf3"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("9ae3fac1-935a-429c-9774-861339db4e30"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("a6ff8612-042f-498a-8775-f7fbb96520ba"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ae7b7186-b50e-4e49-9594-fda0250cf528"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("b20cd77c-d6e3-41b7-a790-2c7fea6e14d6"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("cce4ed16-f15f-486d-9a00-65b53a509391"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ed112441-b8a4-44bc-a5f9-c99c3d2ce44f"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("fb4cd0a7-16cd-429f-9a51-a531d81dc209"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ff55833c-377d-457f-a8e3-381b67825ac0"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdb57211-855c-470a-b0f4-817d9335a26b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec2c84f-2490-4e63-a5a3-eca36e1ef76e", "AQAAAAIAAYagAAAAEFw9EX30SoqLG7g8InSJgM8LLs31yEZyMrN2S/hKkmP9/ZfdSDvCSXaA4Ei5f3ZZ4w==", "57961529-e425-4836-a1bc-25aa40dc2b71" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Motto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("10778215-7107-4740-b9fe-edecf6d3f048"), "https://img.freepik.com/free-photo/young-adult-doing-indoor-sport-gym_23-2149205542.jpg?semt=ais_hybrid&w=740", "Brad Schoenfeld considered one of greatest trainers of all time is a respected trainer, author and professor of exercise science who specialises in the science of bodybuilding and nutritionso he's often referred to as the gym trainer for men. He has spent over 30 years researching in the area of human performance, exercise physiology and muscle hypertrophy, and his work has been featured in major publications such as Men’s Health. He is also the author of numerous best-selling books on strength training and sports nutrition. His legacy lives on with his ongoing commitment to helping people achieve their fitness goals through his knowledge and experience from training thousands of athletes around the world.", true, "Im The Best!", "Brad Schoenfeld", null, "Above 20 years.", 190m, "ClassicTrainer", null },
                    { new Guid("269c054b-7d05-43b2-a187-519215876bd9"), "https://www.the-sun.com/wp-content/uploads/sites/6/2023/03/karina-elle-lisenbee-fitness-model-801547146.jpg", "Karina Elle Lisenbee is an American Instagram Pilates model, gym instructor and former cross-country runner. She was a cheerleader and cross-country runner during her high school years. At the age of 16, she was spotted by a photographer in a mall, after which she started modeling. She then began to participate in bikini competitions, often winning them. Soon after that, she launched her Instagram account where she started posting her intense gym workouts, which are enough to put the fittest among us to shame. Known for her plyometrics, hack squats and deadlifts, Karina went on to win the ‘World Fitness Federation Pro Bikini Championship’. The famous fitness model has also graced the pages of magazines like ‘Racked’, ‘Hers’, ‘Self’ and ‘Shape’. Additionally, not only does she have brand endorsement deals with major brands like ‘Gymshark’ and ‘Nike’, but she also has her own line of merchandise called ‘Gym Bae’. Needless to say, she is one of the most followed fitness models and instructors on the popular photo-sharing app, Instagram.", true, "If u need a trainer, call me!", "Karina Elle", null, "Above 8 years.", 110m, "PilatesTrainer", null },
                    { new Guid("384ce103-5239-4ef9-baa2-4cad280cd88a"), "https://www.greatestphysiques.com/wp-content/uploads/2018/04/Anna-Victoria.01.jpg", "Anna Victoria is a personal transformation coach and fitness star from the United States of America. Although she's now famous for her healthy and fit figure, Anna's early life looked completely different. She grew up being unaware of the importance of a healthy diet and regular exercise.", true, "Train Even Harder!", "Anna Victoria", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("435532d5-e763-4ffe-91d8-9b0fd6410362"), "https://photogallery.indiatimes.com/photo/68319469.cms", "Anllela Sagra is a Colombian fitness model, trainer, bodybuilder, and social media personality. Blessed with inherent beauty and strict work ethics, she has emerged as one of the most influential figures in her industry in the recent years. Initially, her aspiration was to become a regular model and fashion designer. She even earned a degree in fashion design from the University of Colombia. However, she decided to become a fitness model after meeting a fitness enthusiast in the gym. The concept of female bodybuilders is still quite novel in her home country as muscles on women are not considered attractive in Colombia. Despite this, Sagra started undergoing weight training and began to put on muscles on her slim frame. Soon enough, she was attending fitness competitions and garnering fans from all over the world on social media. She has over 10 million followers on Instagram and more than one million followers on Facebook. On Twitter and YouTube, the social media platforms on which she is rarely active these days, she has 22.5 thousand followers and 265 thousand subscribers respectively. She has her own app listed on both Apple App Store and Google Play.", true, "The world is mine!", "Anllela Sagra", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("614482e0-1937-418f-a9d5-8b8316ac2146"), "https://www.fitnessindiashow.com/wp-content/uploads/2018/11/Screen-Shot-2018-11-06-at-3.58.11-PM.png", "Michelle Lewin is a Venezuelan fitness coach, model, and YouTube star.She became famous because of her hourglass figure that she flaunts whenever she models.Michelle Lewin began her modeling career on a very small scale. She first discovered it by a photographer and it began her journey as a model.As a model, it is common that they take care of their body and Michelle is no exception. She takes care of her body and keeps in shape by going to the gym.", true, "My baby is better than your!", "Michelle Lewin", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("62d4f673-b1bb-4c26-ae02-b7620aea4f22"), "https://i.guim.co.uk/img/media/29e2354853c6e5f190ae1f6be56d959bd467ae75/874_0_2865_3580/master/2865.jpg?width=1140&dpr=2&s=none&crop=none", "Oleksandr Oleksandrovych Usyk is a Ukrainian professional boxer. He has held the unified heavyweight championship since 2021, and the Ring magazine title since 2022. He held the undisputed championship in two weight classes—cruiserweight and heavyweight—and is the third male boxer in history (after Terence Crawford and Naoya Inoue) to become a two-weight undisputed champion in the 'four-belt era'.", true, "Train in silence, strike with thunder!", "Oleksandr Usyk", null, "Above 8 years.", 200m, "BoxingTrainer", null },
                    { new Guid("6342b89d-ae92-46b0-927b-283a08e3ff09"), "https://xcal.com/wp-content/uploads/2023/02/Rachel.webp", "Exercise professional and sports nutrition specialist, Louise, has published a number of books which have become Sunday Times bestsellers. This isn’t a common achievement, and is evidence of the relatable and compassionate way that Louise discusses the relationship between nourishing your body with food and staying “lean for life”. Since starting her company in 2007, Louise has helped close to 20,000 individuals - a phenomenal number! Louise has taught her methods to a team of coaches so that she’s able to impact even more people each year. Louise is an advocate of connecting goals with values. Both from the perspective of a client connecting with their goal, and also from the perspective of a business owner. Operating from a place of vision means that you’re able to genuinely help people in a way which is meaningful and valuable to them.", true, "Be yourself!", "Louise Parker", null, "Above 12 years.", 130m, "ClassicTrainer", null },
                    { new Guid("7a1ac214-c6c1-4fd2-8348-d41013d7b020"), "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2015_14/475911/today-rachel-brathen-yoga-150330-13-tease.jpg", "Yoga social media star and author Rachel Brathen is well-known for her openness and authenticity. She tells Stacey Carter why she wanted to write her book and how she navigates sharing her life with the world", true, "Let yoga be your life!", "Rachel Braten", null, "Above 8 years.", 100m, "YogaTrainer", null },
                    { new Guid("7f795ec9-87b2-4bb0-91af-6c81574c4a53"), "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l1200.webp", "Arnold Alois Schwarzenegger is an Austrian and American actor, businessman, filmmaker, politician, and retired professional bodybuilder best known for his roles in high-profile action movies. He served as the 38th governor of California from 2003 to 2011 and was among Time magazine's 100 most influential people in the world in 2004 and 2007.", true, "I'll be back!", "Arnold Schvarzenegger", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("912bdc6b-5eae-4516-920b-9a0f5c43d79e"), "https://firstclasspt.se/____impro/1/onewebmedia/Bigstock/professionella%20manliga%20skola%20sport%20coach%20ger%20tumme.jpg?etag=%22a97572-59303a63%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=321%2B481&extract=28%2B37%2B280%2B421&quality=85", "Matt trains a roster of celebrity clients, is a published author and has his own brand of fitness clothing. But despite this borderline celebrity trainer status, he remains grounded. He knows that working with regular people and helping them to achieve the results they’re looking for is what gets referrals, and word of mouth business. After 23 years of experience in the fitness industry, Matt knows something about being able to relate to others and considers interpersonal skills to be one of the most important assets an aspiring trainer can possess.", true, "I can teach u to fly!", "Matt Roberts", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("95ab552a-b2b8-48c7-9d65-11e7bb0ee436"), "https://www.hfe.co.uk/wp-content/uploads/2018/12/Shaun-Stafford-Headshot1-copy-2-703x1024.jpg", "With a Masters degree in strength and conditioning from Oxford University, Shaun left university and went into a bodybuilding career. He followed that with a semi-professional rugby career and more recently focused on personal training. He supports a number of clients, notably those in a rugby arena from his performance gym and has a huge presence of social media. But despite this level of influence, he encourages aspiring trainers to focus their energy into what’s important to them. He reminds them that an online following isn’t necessary to have a profoundly important impact on someone’s life and to double down on those things that you’re good at and that make you happy.", true, "Train Harder!", "Shaun Stafford", null, "Above 8 years.", 110m, "YogaTrainer", null },
                    { new Guid("bb14ba88-c309-41e2-a0da-48abaefff9b4"), "https://cdn.prod.website-files.com/6367f8198bef742a30d18cba/63af0dd732bfdbd85f40eb89_Chris-Bumstead-10.jpeg", "Christopher Adam Bumstead, known by his fans as CBum, is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.Bumstead maintains a large online presence with content focusing on his lifestyle and bodybuilding.", true, "More Weight.", "Chris Bumstead", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("bb971567-54fc-4c3f-9f6a-2973e21c3217"), "https://i.pinimg.com/originals/a0/07/34/a00734047b571a8573c6a83f03c6a1fe.jpg", "Wladimir Klitschko is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as athletic footwork and mobility, unusual for boxers of his size.", true, "My Hammer will destroy you!", "Wladimir Klitschko", null, "Above 20 years!", 190m, "BoxingTrainer", null },
                    { new Guid("e30cbf53-ec84-4250-9eb0-26e84374c377"), "https://ronniecoleman.net/cdn/shop/products/ronnie-coleman-signature-series-light-weight-baby-tee-apparel-accessories-shirt-29983544049777_1024x1024.jpg?v=1655495689", "Ronald Dean Coleman  is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning,dominant body-parts and extremely heavy workouts,making him the strongest", true, "I pump 200 for chest!", "Ronnie Coleman", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("e4a493ff-b63e-4ab2-859a-8407d7db7a37"), "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60", "Dwayne Douglas Johnson, also known by his ring name the Rock, is an American actor, film producer, and retired professional wrestler. Widely regarded as one of the greatest professional wrestlers of all time,he was integral to the development and success of the World Wrestling Federation (WWF, now WWE) during the Attitude Era, an industry boom period in the late 1990s and early 2000s. Johnson wrestled for the WWF for eight years prior to pursuing an acting career. His films have grossed over $3.5 billion in North America and over $10.5 billion worldwide, making him one of the world's highest-grossing and highest-paid actors.", true, "Just Bring It!", "Dwayne Johnson", null, "Above 8 years.", 200m, "ClassicTrainer", null },
                    { new Guid("f98c3113-73a4-4524-9a59-0332005880e4"), "https://pagesix.com/wp-content/uploads/sites/3/2022/08/Russell-Hornsby-Mike-Tyson_99-1.jpg?quality=75&strip=all&w=413", "Michael Gerard Tyson is an American former professional boxer who competed from 1985 to 2005. Nicknamed 'Iron Mike' and 'Kid Dynamite' in his early career, and later known as 'The Baddest Man on the Planet',Tyson is regarded as one of the greatest heavyweight boxers of all time.[6] He reigned as the undisputed world heavyweight champion from.Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title. He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round.Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", true, "Give me all the weed in the world.", "Mike Tyson", null, "Above 30 years.", 200m, "BoxingTrainer", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("10778215-7107-4740-b9fe-edecf6d3f048"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("269c054b-7d05-43b2-a187-519215876bd9"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("384ce103-5239-4ef9-baa2-4cad280cd88a"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("435532d5-e763-4ffe-91d8-9b0fd6410362"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("614482e0-1937-418f-a9d5-8b8316ac2146"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("62d4f673-b1bb-4c26-ae02-b7620aea4f22"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("6342b89d-ae92-46b0-927b-283a08e3ff09"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("7a1ac214-c6c1-4fd2-8348-d41013d7b020"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("7f795ec9-87b2-4bb0-91af-6c81574c4a53"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("912bdc6b-5eae-4516-920b-9a0f5c43d79e"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("95ab552a-b2b8-48c7-9d65-11e7bb0ee436"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("bb14ba88-c309-41e2-a0da-48abaefff9b4"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("bb971567-54fc-4c3f-9f6a-2973e21c3217"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("e30cbf53-ec84-4250-9eb0-26e84374c377"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("e4a493ff-b63e-4ab2-859a-8407d7db7a37"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f98c3113-73a4-4524-9a59-0332005880e4"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdb57211-855c-470a-b0f4-817d9335a26b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a90db67-9d74-4bba-bdc3-5f207737a96a", "AQAAAAIAAYagAAAAEBfkFNUmw6upiIMFtHgXCA5Yv93TPyfSKkWQMKCpnGRHPQDRNHtSrWPXxIWCSSPWEw==", "e378630a-714b-4f28-8537-20970c50e03d" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Motto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("06cb4840-6506-413d-95b2-474364a1f371"), "https://pagesix.com/wp-content/uploads/sites/3/2022/08/Russell-Hornsby-Mike-Tyson_99-1.jpg?quality=75&strip=all&w=413", "Michael Gerard Tyson is an American former professional boxer who competed from 1985 to 2005. Nicknamed 'Iron Mike' and 'Kid Dynamite' in his early career, and later known as 'The Baddest Man on the Planet',Tyson is regarded as one of the greatest heavyweight boxers of all time.[6] He reigned as the undisputed world heavyweight champion from.Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title. He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round.Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", true, "Give me all the weed in the world.", "Mike Tyson", null, "Above 30 years.", 200m, "BoxingTrainer", null },
                    { new Guid("10782d15-b390-4be4-a0ae-e73b4b020e18"), "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l1200.webp", "Arnold Alois Schwarzenegger is an Austrian and American actor, businessman, filmmaker, politician, and retired professional bodybuilder best known for his roles in high-profile action movies. He served as the 38th governor of California from 2003 to 2011 and was among Time magazine's 100 most influential people in the world in 2004 and 2007.", true, "I'll be back!", "Arnold Schvarzenegger", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("1ad2ca87-01c8-485d-a5e3-4118c5e2fa53"), "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60", "Oleksandr Oleksandrovych Usyk is a Ukrainian professional boxer. He has held the unified heavyweight championship since 2021, and the Ring magazine title since 2022. He held the undisputed championship in two weight classes—cruiserweight and heavyweight—and is the third male boxer in history (after Terence Crawford and Naoya Inoue) to become a two-weight undisputed champion in the 'four-belt era'.", true, "Train in silence, strike with thunder!", "Oleksandr Usyk", null, "Above 8 years.", 200m, "BoxingTrainer", null },
                    { new Guid("53569872-3c7a-4216-81e4-c86d3d0723c8"), "https://i.pinimg.com/originals/a0/07/34/a00734047b571a8573c6a83f03c6a1fe.jpg", "Wladimir Klitschko is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as athletic footwork and mobility, unusual for boxers of his size.", true, "My Hammer will destroy you!", "Wladimir Klitschko", null, "Above 20 years!", 190m, "BoxingTrainer", null },
                    { new Guid("5dd4a1eb-99e5-4ba8-a8cc-4084fa215fa7"), "https://img.freepik.com/free-photo/young-adult-doing-indoor-sport-gym_23-2149205542.jpg?semt=ais_hybrid&w=740", "Brad Schoenfeld considered one of greatest trainers of all time is a respected trainer, author and professor of exercise science who specialises in the science of bodybuilding and nutritionso he's often referred to as the gym trainer for men. He has spent over 30 years researching in the area of human performance, exercise physiology and muscle hypertrophy, and his work has been featured in major publications such as Men’s Health. He is also the author of numerous best-selling books on strength training and sports nutrition. His legacy lives on with his ongoing commitment to helping people achieve their fitness goals through his knowledge and experience from training thousands of athletes around the world.", true, "Im The Best!", "Brad Schoenfeld", null, "Above 20 years.", 190m, "ClassicTrainer", null },
                    { new Guid("6268ee23-3538-4239-90bd-c53d181e0ba6"), "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2015_14/475911/today-rachel-brathen-yoga-150330-13-tease.jpg", "Yoga social media star and author Rachel Brathen is well-known for her openness and authenticity. She tells Stacey Carter why she wanted to write her book and how she navigates sharing her life with the world", true, "Let yoga be your life!", "Rachel Braten", null, "Above 8 years.", 100m, "YogaTrainer", null },
                    { new Guid("78602ed8-d406-4fda-b8c7-6f018f96c1ea"), "https://photogallery.indiatimes.com/photo/68319469.cms", "Anllela Sagra is a Colombian fitness model, trainer, bodybuilder, and social media personality. Blessed with inherent beauty and strict work ethics, she has emerged as one of the most influential figures in her industry in the recent years. Initially, her aspiration was to become a regular model and fashion designer. She even earned a degree in fashion design from the University of Colombia. However, she decided to become a fitness model after meeting a fitness enthusiast in the gym. The concept of female bodybuilders is still quite novel in her home country as muscles on women are not considered attractive in Colombia. Despite this, Sagra started undergoing weight training and began to put on muscles on her slim frame. Soon enough, she was attending fitness competitions and garnering fans from all over the world on social media. She has over 10 million followers on Instagram and more than one million followers on Facebook. On Twitter and YouTube, the social media platforms on which she is rarely active these days, she has 22.5 thousand followers and 265 thousand subscribers respectively. She has her own app listed on both Apple App Store and Google Play.", true, "The world is mine!", "Anllela Sagra", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("870dad61-30f9-474e-a8f1-e822f5a3daf3"), "https://www.hfe.co.uk/wp-content/uploads/2018/12/Shaun-Stafford-Headshot1-copy-2-703x1024.jpg", "With a Masters degree in strength and conditioning from Oxford University, Shaun left university and went into a bodybuilding career. He followed that with a semi-professional rugby career and more recently focused on personal training. He supports a number of clients, notably those in a rugby arena from his performance gym and has a huge presence of social media. But despite this level of influence, he encourages aspiring trainers to focus their energy into what’s important to them. He reminds them that an online following isn’t necessary to have a profoundly important impact on someone’s life and to double down on those things that you’re good at and that make you happy.", true, "Train Harder!", "Shaun Stafford", null, "Above 8 years.", 110m, "YogaTrainer", null },
                    { new Guid("9ae3fac1-935a-429c-9774-861339db4e30"), "https://www.fitnessindiashow.com/wp-content/uploads/2018/11/Screen-Shot-2018-11-06-at-3.58.11-PM.png", "Michelle Lewin is a Venezuelan fitness coach, model, and YouTube star.She became famous because of her hourglass figure that she flaunts whenever she models.Michelle Lewin began her modeling career on a very small scale. She first discovered it by a photographer and it began her journey as a model.As a model, it is common that they take care of their body and Michelle is no exception. She takes care of her body and keeps in shape by going to the gym.", true, "My baby is better than your!", "Michelle Lewin", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("a6ff8612-042f-498a-8775-f7fbb96520ba"), "https://cdn.prod.website-files.com/6367f8198bef742a30d18cba/63af0dd732bfdbd85f40eb89_Chris-Bumstead-10.jpeg", "Christopher Adam Bumstead, known by his fans as CBum, is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.Bumstead maintains a large online presence with content focusing on his lifestyle and bodybuilding.", true, "More Weight.", "Chris Bumstead", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("ae7b7186-b50e-4e49-9594-fda0250cf528"), "https://xcal.com/wp-content/uploads/2023/02/Rachel.webp", "Exercise professional and sports nutrition specialist, Louise, has published a number of books which have become Sunday Times bestsellers. This isn’t a common achievement, and is evidence of the relatable and compassionate way that Louise discusses the relationship between nourishing your body with food and staying “lean for life”. Since starting her company in 2007, Louise has helped close to 20,000 individuals - a phenomenal number! Louise has taught her methods to a team of coaches so that she’s able to impact even more people each year. Louise is an advocate of connecting goals with values. Both from the perspective of a client connecting with their goal, and also from the perspective of a business owner. Operating from a place of vision means that you’re able to genuinely help people in a way which is meaningful and valuable to them.", true, "Be yourself!", "Louise Parker", null, "Above 12 years.", 130m, "ClassicTrainer", null },
                    { new Guid("b20cd77c-d6e3-41b7-a790-2c7fea6e14d6"), "https://www.the-sun.com/wp-content/uploads/sites/6/2023/03/karina-elle-lisenbee-fitness-model-801547146.jpg", "Karina Elle Lisenbee is an American Instagram Pilates model, gym instructor and former cross-country runner. She was a cheerleader and cross-country runner during her high school years. At the age of 16, she was spotted by a photographer in a mall, after which she started modeling. She then began to participate in bikini competitions, often winning them. Soon after that, she launched her Instagram account where she started posting her intense gym workouts, which are enough to put the fittest among us to shame. Known for her plyometrics, hack squats and deadlifts, Karina went on to win the ‘World Fitness Federation Pro Bikini Championship’. The famous fitness model has also graced the pages of magazines like ‘Racked’, ‘Hers’, ‘Self’ and ‘Shape’. Additionally, not only does she have brand endorsement deals with major brands like ‘Gymshark’ and ‘Nike’, but she also has her own line of merchandise called ‘Gym Bae’. Needless to say, she is one of the most followed fitness models and instructors on the popular photo-sharing app, Instagram.", true, "If u need a trainer, call me!", "Karina Elle", null, "Above 8 years.", 110m, "PilatesTrainer", null },
                    { new Guid("cce4ed16-f15f-486d-9a00-65b53a509391"), "https://ronniecoleman.net/cdn/shop/products/ronnie-coleman-signature-series-light-weight-baby-tee-apparel-accessories-shirt-29983544049777_1024x1024.jpg?v=1655495689", "Ronald Dean Coleman  is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning,dominant body-parts and extremely heavy workouts,making him the strongest", true, "I pump 200 for chest!", "Ronnie Coleman", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("ed112441-b8a4-44bc-a5f9-c99c3d2ce44f"), "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60", "Dwayne Douglas Johnson, also known by his ring name the Rock, is an American actor, film producer, and retired professional wrestler. Widely regarded as one of the greatest professional wrestlers of all time,he was integral to the development and success of the World Wrestling Federation (WWF, now WWE) during the Attitude Era, an industry boom period in the late 1990s and early 2000s. Johnson wrestled for the WWF for eight years prior to pursuing an acting career. His films have grossed over $3.5 billion in North America and over $10.5 billion worldwide, making him one of the world's highest-grossing and highest-paid actors.", true, "Just Bring It!", "Dwayne Johnson", null, "Above 8 years.", 200m, "ClassicTrainer", null },
                    { new Guid("fb4cd0a7-16cd-429f-9a51-a531d81dc209"), "https://www.greatestphysiques.com/wp-content/uploads/2018/04/Anna-Victoria.01.jpg", "Anna Victoria is a personal transformation coach and fitness star from the United States of America. Although she's now famous for her healthy and fit figure, Anna's early life looked completely different. She grew up being unaware of the importance of a healthy diet and regular exercise.", true, "Train Even Harder!", "Anna Victoria", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("ff55833c-377d-457f-a8e3-381b67825ac0"), "https://firstclasspt.se/____impro/1/onewebmedia/Bigstock/professionella%20manliga%20skola%20sport%20coach%20ger%20tumme.jpg?etag=%22a97572-59303a63%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=321%2B481&extract=28%2B37%2B280%2B421&quality=85", "Matt trains a roster of celebrity clients, is a published author and has his own brand of fitness clothing. But despite this borderline celebrity trainer status, he remains grounded. He knows that working with regular people and helping them to achieve the results they’re looking for is what gets referrals, and word of mouth business. After 23 years of experience in the fitness industry, Matt knows something about being able to relate to others and considers interpersonal skills to be one of the most important assets an aspiring trainer can possess.", true, "I can teach u to fly!", "Matt Roberts", null, "Above 15 years.", 150m, "ClassicTrainer", null }
                });
        }
    }
}
