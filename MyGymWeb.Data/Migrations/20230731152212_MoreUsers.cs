using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class MoreUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("1889487e-b8ae-4078-a963-7e2cf5385719"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("2fbca519-42e9-446a-b13c-f5ad8f5da267"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("4dcf6508-0918-4d2a-a6df-1f6f459964f4"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("6259249b-9c56-42b5-af8a-854200e1024e"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("62b9c6eb-90ae-4951-bed0-5e421ce6d96d"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("66cb9902-3093-49ce-af33-3559520cf6f7"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("861c4af3-071b-47f8-8ae3-d14c864b73bc"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("8706dda0-a887-4e3e-9f47-8d66dc13675f"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("8e048d7d-b6a0-45ed-b7a5-fbac58df3a95"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("bf51c30d-77c3-41b5-8fcc-332fcfa5c26a"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("c50582ae-91cf-4b18-9e24-829774a6d250"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d8fda898-9d2e-427e-a483-80860b824298"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("e4c4a86e-b80d-48c9-afb5-117717a284b6"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ee789c81-bdb9-4dd6-8515-bf3b98ccd819"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f0f64bda-8ffc-4595-8c09-6ccff83a4114"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01cce10d-a658-4337-9c85-e052c70edb80", "ed3f57da-46d3-4e22-b980-52782d20ef14" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Moto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("42946901-da98-409f-806c-a7bc3579b93a"), "https://xcal.com/wp-content/uploads/2023/02/Rachel.webp", "Exercise professional and sports nutrition specialist, Louise, has published a number of books which have become Sunday Times bestsellers. This isn’t a common achievement, and is evidence of the relatable and compassionate way that Louise discusses the relationship between nourishing your body with food and staying “lean for life”. Since starting her company in 2007, Louise has helped close to 20,000 individuals - a phenomenal number! Louise has taught her methods to a team of coaches so that she’s able to impact even more people each year. Louise is an advocate of connecting goals with values. Both from the perspective of a client connecting with their goal, and also from the perspective of a business owner. Operating from a place of vision means that you’re able to genuinely help people in a way which is meaningful and valuable to them.", true, "Be yourself!", "Louise Parker", null, "Above 12 years.", 130m, "ClassicTrainer", null },
                    { new Guid("5ede22b1-3445-4e90-a56c-d30276511e0c"), "https://ronniecoleman.net/cdn/shop/products/ronnie-coleman-signature-series-light-weight-baby-tee-apparel-accessories-shirt-29983544049777_1024x1024.jpg?v=1655495689", "Ronald Dean Coleman  is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning,dominant body-parts and extremely heavy workouts,making him the strongest", true, "I pump 200 for chest!", "Ronnie Coleman", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("75f9cb9b-0476-46ea-829c-1907be939dfa"), "https://nathealth-assets.s3-eu-west-1.amazonaws.com/articles/Rachel_Brathen.jpg", "Yoga social media star and author Rachel Brathen is well-known for her openness and authenticity. She tells Stacey Carter why she wanted to write her book and how she navigates sharing her life with the world", true, "Let yoga be your life!", "Rachel Braten", null, "Above 8 years.", 100m, "YogaTrainer", null },
                    { new Guid("955dbdfb-4701-41a3-879e-ec8de5e3a595"), "https://www.fitnessindiashow.com/wp-content/uploads/2018/11/Screen-Shot-2018-11-06-at-3.58.11-PM.png", "Michelle Lewin is a Venezuelan fitness coach, model, and YouTube star.She became famous because of her hourglass figure that she flaunts whenever she models.Michelle Lewin began her modeling career on a very small scale. She first discovered it by a photographer and it began her journey as a model.As a model, it is common that they take care of their body and Michelle is no exception. She takes care of her body and keeps in shape by going to the gym.", true, "My baby is better than your!", "Michelle Lewin", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("9da12f55-1a90-4d11-b0ab-2b548512327f"), "https://firstclasspt.se/____impro/1/onewebmedia/Bigstock/professionella%20manliga%20skola%20sport%20coach%20ger%20tumme.jpg?etag=%22a97572-59303a63%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=321%2B481&extract=28%2B37%2B280%2B421&quality=85", "Matt trains a roster of celebrity clients, is a published author and has his own brand of fitness clothing. But despite this borderline celebrity trainer status, he remains grounded. He knows that working with regular people and helping them to achieve the results they’re looking for is what gets referrals, and word of mouth business. After 23 years of experience in the fitness industry, Matt knows something about being able to relate to others and considers interpersonal skills to be one of the most important assets an aspiring trainer can possess.", true, "I can teach u to fly!", "Matt Roberts", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("9ff39dc8-7b05-42a4-8465-6c67b268e2ef"), "https://e0.pxfuel.com/wallpapers/609/537/desktop-wallpaper-chris-bumstead.jpg", "Christopher Adam Bumstead, known by his fans as CBum, is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.Bumstead maintains a large online presence with content focusing on his lifestyle and bodybuilding.", true, "More Weight.", "Chris Bumstead", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("a8f5a821-c794-477d-a01f-15ad89c74209"), "https://storage.googleapis.com/pai-images/803e7f4cfb964082a057d3db348f18b2.jpeg", "Anllela Sagra is a Colombian fitness model, trainer, bodybuilder, and social media personality. Blessed with inherent beauty and strict work ethics, she has emerged as one of the most influential figures in her industry in the recent years. Initially, her aspiration was to become a regular model and fashion designer. She even earned a degree in fashion design from the University of Colombia. However, she decided to become a fitness model after meeting a fitness enthusiast in the gym. The concept of female bodybuilders is still quite novel in her home country as muscles on women are not considered attractive in Colombia. Despite this, Sagra started undergoing weight training and began to put on muscles on her slim frame. Soon enough, she was attending fitness competitions and garnering fans from all over the world on social media. She has over 10 million followers on Instagram and more than one million followers on Facebook. On Twitter and YouTube, the social media platforms on which she is rarely active these days, she has 22.5 thousand followers and 265 thousand subscribers respectively. She has her own app listed on both Apple App Store and Google Play.", true, "The world is mine!", "Anllela Sagra", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("bb865e75-3b77-422d-b6c3-17a3b5521a4e"), "https://i.pinimg.com/originals/a0/07/34/a00734047b571a8573c6a83f03c6a1fe.jpg", "Wladimir Klitschko is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as athletic footwork and mobility, unusual for boxers of his size.", true, "My Hammer will destroy you!", "Wladimir Klitschko", null, "Above 20 years!", 190m, "BoxingTrainer", null },
                    { new Guid("be39b32f-0578-426f-9881-5c2767b8018f"), "https://www.the-sun.com/wp-content/uploads/sites/6/2023/03/karina-elle-lisenbee-fitness-model-801547146.jpg", "Karina Elle Lisenbee is an American Instagram Pilates model, gym instructor and former cross-country runner. She was a cheerleader and cross-country runner during her high school years. At the age of 16, she was spotted by a photographer in a mall, after which she started modeling. She then began to participate in bikini competitions, often winning them. Soon after that, she launched her Instagram account where she started posting her intense gym workouts, which are enough to put the fittest among us to shame. Known for her plyometrics, hack squats and deadlifts, Karina went on to win the ‘World Fitness Federation Pro Bikini Championship’. The famous fitness model has also graced the pages of magazines like ‘Racked’, ‘Hers’, ‘Self’ and ‘Shape’. Additionally, not only does she have brand endorsement deals with major brands like ‘Gymshark’ and ‘Nike’, but she also has her own line of merchandise called ‘Gym Bae’. Needless to say, she is one of the most followed fitness models and instructors on the popular photo-sharing app, Instagram.", true, "In u need a trainer, call me!", "Karina Elle", null, "Above 8 years.", 110m, "PilatesTrainer", null },
                    { new Guid("c9d9ee16-7c63-46b4-afe3-3612949497fa"), "https://www.greatestphysiques.com/wp-content/uploads/2018/04/Anna-Victoria.01.jpg", "Anna Victoria is a personal transformation coach and fitness star from the United States of America. Although she's now famous for her healthy and fit figure, Anna's early life looked completely different. She grew up being unaware of the importance of a healthy diet and regular exercise.", true, "Train Even Harder!", "Anna Victoria", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("cff5fe0e-cf3e-49da-9029-e92471f6d671"), "https://img.freepik.com/free-photo/young-adult-doing-indoor-sport-gym_23-2149205542.jpg?w=2000", "Brad Schoenfeld considered one of greatest trainers of all time is a respected trainer, author and professor of exercise science who specialises in the science of bodybuilding and nutritionso he's often referred to as the gym trainer for men. He has spent over 30 years researching in the area of human performance, exercise physiology and muscle hypertrophy, and his work has been featured in major publications such as Men’s Health. He is also the author of numerous best-selling books on strength training and sports nutrition. His legacy lives on with his ongoing commitment to helping people achieve their fitness goals through his knowledge and experience from training thousands of athletes around the world.", true, "Im The Best!", "Brad Schoenfeld", null, "Above 20 years.", 190m, "ClassicTrainer", null },
                    { new Guid("d139d582-3b31-43e9-9d41-42ca74fb9cb1"), "https://pagesix.com/wp-content/uploads/sites/3/2022/08/Russell-Hornsby-Mike-Tyson_99-1.jpg?quality=75&strip=all&w=413", "Michael Gerard Tyson is an American former professional boxer who competed from 1985 to 2005. Nicknamed 'Iron Mike' and 'Kid Dynamite' in his early career, and later known as 'The Baddest Man on the Planet',Tyson is regarded as one of the greatest heavyweight boxers of all time.[6] He reigned as the undisputed world heavyweight champion from.Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title. He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round.Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", true, "Give me all the weed in the world.", "Mike Tyson", null, "Above 30 years.", 200m, "BoxingTrainer", null },
                    { new Guid("dcf535db-cc3a-42fb-afb6-dc8516d05e67"), "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60", "Dwayne Douglas Johnson, also known by his ring name the Rock, is an American actor, film producer, and retired professional wrestler. Widely regarded as one of the greatest professional wrestlers of all time,he was integral to the development and success of the World Wrestling Federation (WWF, now WWE) during the Attitude Era, an industry boom period in the late 1990s and early 2000s. Johnson wrestled for the WWF for eight years prior to pursuing an acting career. His films have grossed over $3.5 billion in North America and over $10.5 billion worldwide, making him one of the world's highest-grossing and highest-paid actors.", true, "Just Bring It!", "Dwayne Johnson", null, "Above 8 years.", 200m, "ClassicTrainer", null },
                    { new Guid("f5b53cd7-e0bc-45b6-912d-2911da05bba3"), "https://www.hfe.co.uk/wp-content/uploads/2018/12/Shaun-Stafford-Headshot1-copy-2-703x1024.jpg", "With a Masters degree in strength and conditioning from Oxford University, Shaun left university and went into a bodybuilding career. He followed that with a semi-professional rugby career and more recently focused on personal training. He supports a number of clients, notably those in a rugby arena from his performance gym and has a huge presence of social media. But despite this level of influence, he encourages aspiring trainers to focus their energy into what’s important to them. He reminds them that an online following isn’t necessary to have a profoundly important impact on someone’s life and to double down on those things that you’re good at and that make you happy.", true, "Train Harder!", "Shaun Stafford", null, "Above 8 years.", 110m, "YogaTrainer", null },
                    { new Guid("f7de49fb-e7c8-4bcd-8559-afcd54af3b38"), "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l1200.webp", "Arnold Alois Schwarzenegger is an Austrian and American actor, businessman, filmmaker, politician, and retired professional bodybuilder best known for his roles in high-profile action movies. He served as the 38th governor of California from 2003 to 2011 and was among Time magazine's 100 most influential people in the world in 2004 and 2007.", true, "I'll be back!", "Arnold Schvarzenegger", null, "Above 30 years.", 200m, "ClassicTrainer", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("42946901-da98-409f-806c-a7bc3579b93a"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("5ede22b1-3445-4e90-a56c-d30276511e0c"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("75f9cb9b-0476-46ea-829c-1907be939dfa"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("955dbdfb-4701-41a3-879e-ec8de5e3a595"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("9da12f55-1a90-4d11-b0ab-2b548512327f"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("9ff39dc8-7b05-42a4-8465-6c67b268e2ef"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("a8f5a821-c794-477d-a01f-15ad89c74209"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("bb865e75-3b77-422d-b6c3-17a3b5521a4e"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("be39b32f-0578-426f-9881-5c2767b8018f"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("c9d9ee16-7c63-46b4-afe3-3612949497fa"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("cff5fe0e-cf3e-49da-9029-e92471f6d671"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d139d582-3b31-43e9-9d41-42ca74fb9cb1"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("dcf535db-cc3a-42fb-afb6-dc8516d05e67"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f5b53cd7-e0bc-45b6-912d-2911da05bba3"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f7de49fb-e7c8-4bcd-8559-afcd54af3b38"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "630c34b2-161f-43a2-bf94-aa15ca06777d", "ad663278-e08c-49bb-8ba0-4ac42a5fb13f" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Moto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("1889487e-b8ae-4078-a963-7e2cf5385719"), "https://img.freepik.com/free-photo/young-adult-doing-indoor-sport-gym_23-2149205542.jpg?w=2000", "Brad Schoenfeld considered one of greatest trainers of all time is a respected trainer, author and professor of exercise science who specialises in the science of bodybuilding and nutritionso he's often referred to as the gym trainer for men. He has spent over 30 years researching in the area of human performance, exercise physiology and muscle hypertrophy, and his work has been featured in major publications such as Men’s Health. He is also the author of numerous best-selling books on strength training and sports nutrition. His legacy lives on with his ongoing commitment to helping people achieve their fitness goals through his knowledge and experience from training thousands of athletes around the world.", true, "Im The Best!", "Brad Schoenfeld", null, "Above 20 years.", 190m, "ClassicTrainer", null },
                    { new Guid("2fbca519-42e9-446a-b13c-f5ad8f5da267"), "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l1200.webp", "Arnold Alois Schwarzenegger is an Austrian and American actor, businessman, filmmaker, politician, and retired professional bodybuilder best known for his roles in high-profile action movies. He served as the 38th governor of California from 2003 to 2011 and was among Time magazine's 100 most influential people in the world in 2004 and 2007.", true, "I'll be back!", "Arnold Schvarzenegger", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("4dcf6508-0918-4d2a-a6df-1f6f459964f4"), "https://www.hfe.co.uk/wp-content/uploads/2018/12/Shaun-Stafford-Headshot1-copy-2-703x1024.jpg", "With a Masters degree in strength and conditioning from Oxford University, Shaun left university and went into a bodybuilding career. He followed that with a semi-professional rugby career and more recently focused on personal training. He supports a number of clients, notably those in a rugby arena from his performance gym and has a huge presence of social media. But despite this level of influence, he encourages aspiring trainers to focus their energy into what’s important to them. He reminds them that an online following isn’t necessary to have a profoundly important impact on someone’s life and to double down on those things that you’re good at and that make you happy.", true, "Train Harder!", "Shaun Stafford", null, "Above 8 years.", 110m, "YogaTrainer", null },
                    { new Guid("6259249b-9c56-42b5-af8a-854200e1024e"), "https://www.fitnessindiashow.com/wp-content/uploads/2018/11/Screen-Shot-2018-11-06-at-3.58.11-PM.png", "Michelle Lewin is a Venezuelan fitness coach, model, and YouTube star.She became famous because of her hourglass figure that she flaunts whenever she models.Michelle Lewin began her modeling career on a very small scale. She first discovered it by a photographer and it began her journey as a model.As a model, it is common that they take care of their body and Michelle is no exception. She takes care of her body and keeps in shape by going to the gym.", true, "My baby is better than your!", "Michelle Lewin", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("62b9c6eb-90ae-4951-bed0-5e421ce6d96d"), "https://i.pinimg.com/originals/a0/07/34/a00734047b571a8573c6a83f03c6a1fe.jpg", "Wladimir Klitschko is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as athletic footwork and mobility, unusual for boxers of his size.", true, "My Hammer will destroy you!", "Wladimir Klitschko", null, "Above 20 years!", 190m, "BoxingTrainer", null },
                    { new Guid("66cb9902-3093-49ce-af33-3559520cf6f7"), "https://storage.googleapis.com/pai-images/803e7f4cfb964082a057d3db348f18b2.jpeg", "Anllela Sagra is a Colombian fitness model, trainer, bodybuilder, and social media personality. Blessed with inherent beauty and strict work ethics, she has emerged as one of the most influential figures in her industry in the recent years. Initially, her aspiration was to become a regular model and fashion designer. She even earned a degree in fashion design from the University of Colombia. However, she decided to become a fitness model after meeting a fitness enthusiast in the gym. The concept of female bodybuilders is still quite novel in her home country as muscles on women are not considered attractive in Colombia. Despite this, Sagra started undergoing weight training and began to put on muscles on her slim frame. Soon enough, she was attending fitness competitions and garnering fans from all over the world on social media. She has over 10 million followers on Instagram and more than one million followers on Facebook. On Twitter and YouTube, the social media platforms on which she is rarely active these days, she has 22.5 thousand followers and 265 thousand subscribers respectively. She has her own app listed on both Apple App Store and Google Play.", true, "The world is mine!", "Anllela Sagra", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("861c4af3-071b-47f8-8ae3-d14c864b73bc"), "https://firstclasspt.se/____impro/1/onewebmedia/Bigstock/professionella%20manliga%20skola%20sport%20coach%20ger%20tumme.jpg?etag=%22a97572-59303a63%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=321%2B481&extract=28%2B37%2B280%2B421&quality=85", "Matt trains a roster of celebrity clients, is a published author and has his own brand of fitness clothing. But despite this borderline celebrity trainer status, he remains grounded. He knows that working with regular people and helping them to achieve the results they’re looking for is what gets referrals, and word of mouth business. After 23 years of experience in the fitness industry, Matt knows something about being able to relate to others and considers interpersonal skills to be one of the most important assets an aspiring trainer can possess.", true, "I can teach u to fly!", "Matt Roberts", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("8706dda0-a887-4e3e-9f47-8d66dc13675f"), "https://xcal.com/wp-content/uploads/2023/02/Rachel.webp", "Exercise professional and sports nutrition specialist, Louise, has published a number of books which have become Sunday Times bestsellers. This isn’t a common achievement, and is evidence of the relatable and compassionate way that Louise discusses the relationship between nourishing your body with food and staying “lean for life”. Since starting her company in 2007, Louise has helped close to 20,000 individuals - a phenomenal number! Louise has taught her methods to a team of coaches so that she’s able to impact even more people each year. Louise is an advocate of connecting goals with values. Both from the perspective of a client connecting with their goal, and also from the perspective of a business owner. Operating from a place of vision means that you’re able to genuinely help people in a way which is meaningful and valuable to them.", true, "Be yourself!", "Louise Parker", null, "Above 12 years.", 130m, "ClassicTrainer", null },
                    { new Guid("8e048d7d-b6a0-45ed-b7a5-fbac58df3a95"), "https://ronniecoleman.net/cdn/shop/products/ronnie-coleman-signature-series-light-weight-baby-tee-apparel-accessories-shirt-29983544049777_1024x1024.jpg?v=1655495689", "Ronald Dean Coleman  is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning,dominant body-parts and extremely heavy workouts,making him the strongest", true, "I pump 200 for chest!", "Ronnie Coleman", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("bf51c30d-77c3-41b5-8fcc-332fcfa5c26a"), "https://pagesix.com/wp-content/uploads/sites/3/2022/08/Russell-Hornsby-Mike-Tyson_99-1.jpg?quality=75&strip=all&w=413", "Michael Gerard Tyson is an American former professional boxer who competed from 1985 to 2005. Nicknamed 'Iron Mike' and 'Kid Dynamite' in his early career, and later known as 'The Baddest Man on the Planet',Tyson is regarded as one of the greatest heavyweight boxers of all time.[6] He reigned as the undisputed world heavyweight champion from.Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title. He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round.Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", true, "Give me all the weed in the world.", "Mike Tyson", null, "Above 30 years.", 200m, "BoxingTrainer", null },
                    { new Guid("c50582ae-91cf-4b18-9e24-829774a6d250"), "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60", "Dwayne Douglas Johnson, also known by his ring name the Rock, is an American actor, film producer, and retired professional wrestler. Widely regarded as one of the greatest professional wrestlers of all time,he was integral to the development and success of the World Wrestling Federation (WWF, now WWE) during the Attitude Era, an industry boom period in the late 1990s and early 2000s. Johnson wrestled for the WWF for eight years prior to pursuing an acting career. His films have grossed over $3.5 billion in North America and over $10.5 billion worldwide, making him one of the world's highest-grossing and highest-paid actors.", true, "Just Bring It!", "Dwayne Johnson", null, "Above 8 years.", 200m, "ClassicTrainer", null },
                    { new Guid("d8fda898-9d2e-427e-a483-80860b824298"), "https://www.greatestphysiques.com/wp-content/uploads/2018/04/Anna-Victoria.01.jpg", "Anna Victoria is a personal transformation coach and fitness star from the United States of America. Although she's now famous for her healthy and fit figure, Anna's early life looked completely different. She grew up being unaware of the importance of a healthy diet and regular exercise.", true, "Train Even Harder!", "Anna Victoria", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("e4c4a86e-b80d-48c9-afb5-117717a284b6"), "https://e0.pxfuel.com/wallpapers/609/537/desktop-wallpaper-chris-bumstead.jpg", "Christopher Adam Bumstead, known by his fans as CBum, is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.Bumstead maintains a large online presence with content focusing on his lifestyle and bodybuilding.", true, "More Weight.", "Chris Bumstead", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("ee789c81-bdb9-4dd6-8515-bf3b98ccd819"), "https://www.the-sun.com/wp-content/uploads/sites/6/2023/03/karina-elle-lisenbee-fitness-model-801547146.jpg", "Karina Elle Lisenbee is an American Instagram Pilates model, gym instructor and former cross-country runner. She was a cheerleader and cross-country runner during her high school years. At the age of 16, she was spotted by a photographer in a mall, after which she started modeling. She then began to participate in bikini competitions, often winning them. Soon after that, she launched her Instagram account where she started posting her intense gym workouts, which are enough to put the fittest among us to shame. Known for her plyometrics, hack squats and deadlifts, Karina went on to win the ‘World Fitness Federation Pro Bikini Championship’. The famous fitness model has also graced the pages of magazines like ‘Racked’, ‘Hers’, ‘Self’ and ‘Shape’. Additionally, not only does she have brand endorsement deals with major brands like ‘Gymshark’ and ‘Nike’, but she also has her own line of merchandise called ‘Gym Bae’. Needless to say, she is one of the most followed fitness models and instructors on the popular photo-sharing app, Instagram.", true, "In u need a trainer, call me!", "Karina Elle", null, "Above 8 years.", 110m, "PilatesTrainer", null },
                    { new Guid("f0f64bda-8ffc-4595-8c09-6ccff83a4114"), "https://nathealth-assets.s3-eu-west-1.amazonaws.com/articles/Rachel_Brathen.jpg", "Yoga social media star and author Rachel Brathen is well-known for her openness and authenticity. She tells Stacey Carter why she wanted to write her book and how she navigates sharing her life with the world", true, "Let yoga be your life!", "Rachel Braten", null, "Above 8 years.", 100m, "YogaTrainer", null }
                });
        }
    }
}
