using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyGymWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0791dd2c-a0b7-4ac2-9b02-f4d8bcbb37a9", "AQAAAAIAAYagAAAAEHTk2JYYrGHiRSQRGAQ5yore95kh9deiQmKeVMwtmf9V8uidulnbZ0nneIn+h71oFQ==", "7a0cfa75-1e86-4a73-b2d5-bbcfac0525f9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://drberg.in/368-large_default/-shaker-bottle.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://elephantskin.com/wp-content/uploads/2024/05/ElephantSkin_CHAMPION_0002_Ebene-1_1800x1800.png-500x500.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Mark", "Price" },
                values: new object[] { "Whey Gourmet Edition 2kg Life Pro is a supplement based on whey concentrate, which has exceptional nutritional values and is part of the Gourmet line of flavours. Life Pro's Gourmet line is characterised by a variety of very successful, exclusive and delicious flavours. Life Pro Whey Gourmet Edition 2kg is designed to help you meet your daily protein requirements, maintain a healthy lifestyle and enjoy every shake. It has a protein concentration of between 72% and 77% in its composition (depending on the flavour selected). In addition, you can now enjoy your favourite Gourmet flavour in 3 different formats: 30g, 900g and 2kg.", "Life Pro", 61m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Mark", "Name" },
                values: new object[] { "Let L-Carnitine support your metabolism and endurance by tapping into your body's fuel reserves - turning your fat into energy. Take advantage of L-Carnitine's lipid-metabolizing power, that helps transport fat out of your system. It's the perfect addition to your diet and fitness program.Boost It Up Get a lean body and stay toned! L-Carnitine helps shuttle fatty acids to your muscles so they can be burnt as energy during exercise. Conquer fatigue by delaying muscle soreness so you can train longer! Amplify your performance! Enhance cellular energy production for max physical output. Suggested use Shake well before opening. Consume 1 serving at any time of the day between meals. On training days, consume 1 serving 30 minutes before exercise. Regular exercise and proper nutrition are essential components for achieving your diet and fitness goals. As individuals vary so may results from using this product.", "https://proteinhouse.mu/cdn/shop/files/nutrex-research-l-carnitine-3000-698006.png?v=1723805951&width=1445", "Nutrex Research", "L-Carnitine 3000" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREDhyUn0XH7qNDvKI21WGxL3SZ7d5ftwtsB_M3lTGhGI15hej4aYNE4Is046eHI6DrtL0&usqp=CAU");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.johnsonfitness.com.au/cdn/shop/products/MX22_MAGNUMMG-PL62-03smithmachine_MatteBlk_hero_lores.jpg?v=1665704942");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://www.ironcompany.com/media/catalog/product/cache/0497f845716ff9ff5fb3d560ec6f3888/b/o/body_solid_g9s_2_stack_gym_for_home_or_light_commercial_spaces.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://f.nooncdn.com/p/pzsku/ZA596E824F4FF23EB0D32Z/45/_/1737458392/ae70680d-5d9c-426c-9cde-24382d53f0ca.jpg?width=240");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Mark", "Name" },
                values: new object[] { "Experience superior performance with the Bad Boy Classic Vale Tudo Shorts. Designed to work as hard as you do, these shorts are more than just clothing - they're a second skin, moving seamlessly with your body without any restrictions.Crafted from a stretchy, sweat-wicking fabric, they help improve blood circulation, boosting your muscle performance to new heights. Plus, they keep you dry and comfortable, whether you're in the middle of a fight or an intense workout. With a customized fit thanks to the elastic waistband and inner drawstrings, these shorts stay perfectly in place, so you can focus on what really matters - your performance.", "https://i.ebayimg.com/images/g/8UUAAOSwezxlAxYz/s-l1200.jpg", "Bad Boy", "Bad Boy Classic Mens White Training MMA Fight Shorts BJJ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Composition: 92% polyester, 8% elastane Lightweight fast drying fabric to keep you dry and comfortable Stretchy fibre for exceptional mobility Raglan sleeves design for superior range of motion Flat seams for smooth sensation against your skin", "https://minotaurfightstore.co.uk/wp-content/uploads/2023/03/BADBOY_Tee_BBC00003_Black_1.jpg", "Bad Boy Core Logo T-Shirt Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://kingfightstore.nl/cdn/shop/files/gr3.jpg?v=1742221007&width=630");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Mark", "Name" },
                values: new object[] { "Experience unrestricted movement with this athletic compression top, meticulously crafted from a high-performance spandex blend that offers a second-skin fit, ideal for intense training sessions and competitive events.\r\nStay cool and dry during your toughest workouts; the advanced moisture-wicking technology efficiently draws sweat away from the skin, keeping you comfortable and focused on your performance.\r\nEngineered for durability, this base layer is constructed with reinforced stitching to withstand the rigors of grappling, striking, and high-impact exercises, ensuring long-lasting wear and tear resistance.\r\nDesigned with a streamlined, ergonomic fit, this compression top supports your muscles and enhances blood flow, promoting faster recovery and reduced muscle fatigue after strenuous activity, making it suitable as jiu jitsu shirts.\r\nEnjoy complete freedom of movement during any activity; the four-way stretch fabric allows for a full range of motion, enabling you to execute complex techniques and movements with ease and precision.", "https://img4.dhresource.com/webp/m/0x0/f3/albu/jc/g/21/9c17be60-10cf-4556-9ff7-78ca7c066565.jpg", "Cody", "Spandex Base Layer for Gym, Training & Combat Sports" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://aagsport.com/cdn/shop/products/pKhP5YsPvYT5lvLmL8Shl1Yz-700x700_480x480.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://www.thefightfactory.com.au/cdn/shop/products/cl-sport-longsleeve-rash-guard-cl-sport-tropics-rashguard-long-sleeve-blue-30570066608171_760x.png?v=1721166388%27");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://eu.venum.com/cdn/shop/files/a509146d1d982199d9b22789bb3414a5f84d8073_VENUM_0984_210_1.jpg?v=1744031393");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://www.venum.com/cdn/shop/products/a_252Fc_252F9_252Fd_252Fac9db668ba094dea00e671838375208e3a323fcb_PTS_LIGHT_SD_02.jpg?v=1658483964&width=1946");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Children's shin guards without a protective panel on the instep for kickboxing training. The shin guards are comfortable to wear and, thanks to their fastening with 2 wide Velcro straps, they adapt perfectly to the shape of the leg. The thick foam padding does an excellent job of absorbing impact force, protecting the shins from injury. The material on the inside is skin-friendly and minimises the risk of abrasions. The classic design makes the pads fit in with the rest of your training outfit and equipment.", "https://static2.groundgame.com/hpeciai/4c3e2722b4b5b934246f2e5942b0b6ed/pol_il_Dzieciece-ochraniacze-piszczeli-bez-stopy-Cyborg-Czarne-1649.jpg", "Children's Shin Guards Without Foot Protection Cyborg" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ImageUrl", "Info", "IsActive", "Motto", "Name", "PhoneNumber", "Practis", "PricePerHour", "Type", "UserId" },
                values: new object[,]
                {
                    { new Guid("188d9e5e-fa03-42aa-a96b-7fd5f512daf4"), "https://cdn.prod.website-files.com/6367f8198bef742a30d18cba/63af0dd732bfdbd85f40eb89_Chris-Bumstead-10.jpeg", "Christopher Adam Bumstead, known by his fans as CBum, is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.Bumstead maintains a large online presence with content focusing on his lifestyle and bodybuilding.", true, "More Weight.", "Chris Bumstead", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("22bcd060-a119-4ef6-8a39-785c0569252d"), "https://pagesix.com/wp-content/uploads/sites/3/2022/08/Russell-Hornsby-Mike-Tyson_99-1.jpg?quality=75&strip=all&w=413", "Michael Gerard Tyson is an American former professional boxer who competed from 1985 to 2005. Nicknamed 'Iron Mike' and 'Kid Dynamite' in his early career, and later known as 'The Baddest Man on the Planet',Tyson is regarded as one of the greatest heavyweight boxers of all time.[6] He reigned as the undisputed world heavyweight champion from.Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title. He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round.Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.", true, "Give me all the weed in the world.", "Mike Tyson", null, "Above 30 years.", 200m, "BoxingTrainer", null },
                    { new Guid("2b2180db-0b60-4d72-98d9-9bf00134d788"), "https://img.freepik.com/free-photo/young-adult-doing-indoor-sport-gym_23-2149205542.jpg?semt=ais_hybrid&w=740", "Brad Schoenfeld considered one of greatest trainers of all time is a respected trainer, author and professor of exercise science who specialises in the science of bodybuilding and nutritionso he's often referred to as the gym trainer for men. He has spent over 30 years researching in the area of human performance, exercise physiology and muscle hypertrophy, and his work has been featured in major publications such as Men’s Health. He is also the author of numerous best-selling books on strength training and sports nutrition. His legacy lives on with his ongoing commitment to helping people achieve their fitness goals through his knowledge and experience from training thousands of athletes around the world.", true, "Im The Best!", "Brad Schoenfeld", null, "Above 20 years.", 190m, "ClassicTrainer", null },
                    { new Guid("4efcfbfa-b5f3-4334-8fb7-2921cca00c35"), "https://i.pinimg.com/originals/a0/07/34/a00734047b571a8573c6a83f03c6a1fe.jpg", "Wladimir Klitschko is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as athletic footwork and mobility, unusual for boxers of his size.", true, "My Hammer will destroy you!", "Wladimir Klitschko", null, "Above 20 years!", 190m, "BoxingTrainer", null },
                    { new Guid("88a27837-2c79-4208-85a6-0cc0b963e02f"), "https://www.the-sun.com/wp-content/uploads/sites/6/2023/03/karina-elle-lisenbee-fitness-model-801547146.jpg", "Karina Elle Lisenbee is an American Instagram Pilates model, gym instructor and former cross-country runner. She was a cheerleader and cross-country runner during her high school years. At the age of 16, she was spotted by a photographer in a mall, after which she started modeling. She then began to participate in bikini competitions, often winning them. Soon after that, she launched her Instagram account where she started posting her intense gym workouts, which are enough to put the fittest among us to shame. Known for her plyometrics, hack squats and deadlifts, Karina went on to win the ‘World Fitness Federation Pro Bikini Championship’. The famous fitness model has also graced the pages of magazines like ‘Racked’, ‘Hers’, ‘Self’ and ‘Shape’. Additionally, not only does she have brand endorsement deals with major brands like ‘Gymshark’ and ‘Nike’, but she also has her own line of merchandise called ‘Gym Bae’. Needless to say, she is one of the most followed fitness models and instructors on the popular photo-sharing app, Instagram.", true, "If u need a trainer, call me!", "Karina Elle", null, "Above 8 years.", 110m, "PilatesTrainer", null },
                    { new Guid("9648c7c5-efd4-47ff-b5ae-936d7d35761f"), "https://photogallery.indiatimes.com/photo/68319469.cms", "Anllela Sagra is a Colombian fitness model, trainer, bodybuilder, and social media personality. Blessed with inherent beauty and strict work ethics, she has emerged as one of the most influential figures in her industry in the recent years. Initially, her aspiration was to become a regular model and fashion designer. She even earned a degree in fashion design from the University of Colombia. However, she decided to become a fitness model after meeting a fitness enthusiast in the gym. The concept of female bodybuilders is still quite novel in her home country as muscles on women are not considered attractive in Colombia. Despite this, Sagra started undergoing weight training and began to put on muscles on her slim frame. Soon enough, she was attending fitness competitions and garnering fans from all over the world on social media. She has over 10 million followers on Instagram and more than one million followers on Facebook. On Twitter and YouTube, the social media platforms on which she is rarely active these days, she has 22.5 thousand followers and 265 thousand subscribers respectively. She has her own app listed on both Apple App Store and Google Play.", true, "The world is mine!", "Anllela Sagra", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("a98c629c-4fbd-451d-a720-f1f50086578b"), "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60", "Dwayne Douglas Johnson, also known by his ring name the Rock, is an American actor, film producer, and retired professional wrestler. Widely regarded as one of the greatest professional wrestlers of all time,he was integral to the development and success of the World Wrestling Federation (WWF, now WWE) during the Attitude Era, an industry boom period in the late 1990s and early 2000s. Johnson wrestled for the WWF for eight years prior to pursuing an acting career. His films have grossed over $3.5 billion in North America and over $10.5 billion worldwide, making him one of the world's highest-grossing and highest-paid actors.", true, "Just Bring It!", "Dwayne Johnson", null, "Above 8 years.", 200m, "ClassicTrainer", null },
                    { new Guid("ab5d3213-9428-45ea-a1b8-d8f511f5cf51"), "https://www.fitnessindiashow.com/wp-content/uploads/2018/11/Screen-Shot-2018-11-06-at-3.58.11-PM.png", "Michelle Lewin is a Venezuelan fitness coach, model, and YouTube star.She became famous because of her hourglass figure that she flaunts whenever she models.Michelle Lewin began her modeling career on a very small scale. She first discovered it by a photographer and it began her journey as a model.As a model, it is common that they take care of their body and Michelle is no exception. She takes care of her body and keeps in shape by going to the gym.", true, "My baby is better than your!", "Michelle Lewin", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("b455fe0e-2d70-4609-8c6f-e34bce1c6af0"), "https://www.greatestphysiques.com/wp-content/uploads/2018/04/Anna-Victoria.01.jpg", "Anna Victoria is a personal transformation coach and fitness star from the United States of America. Although she's now famous for her healthy and fit figure, Anna's early life looked completely different. She grew up being unaware of the importance of a healthy diet and regular exercise.", true, "Train Even Harder!", "Anna Victoria", null, "Above 8 years.", 110m, "ClassicTrainer", null },
                    { new Guid("b4da124e-db71-4aae-a0df-7f52c84f1bcb"), "https://i.guim.co.uk/img/media/29e2354853c6e5f190ae1f6be56d959bd467ae75/874_0_2865_3580/master/2865.jpg?width=1140&dpr=2&s=none&crop=none", "Oleksandr Oleksandrovych Usyk is a Ukrainian professional boxer. He has held the unified heavyweight championship since 2021, and the Ring magazine title since 2022. He held the undisputed championship in two weight classes—cruiserweight and heavyweight—and is the third male boxer in history (after Terence Crawford and Naoya Inoue) to become a two-weight undisputed champion in the 'four-belt era'.", true, "Train in silence, strike with thunder!", "Oleksandr Usyk", null, "Above 8 years.", 200m, "BoxingTrainer", null },
                    { new Guid("d174e5be-fb70-4083-b8c3-28b1da18b69b"), "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2015_14/475911/today-rachel-brathen-yoga-150330-13-tease.jpg", "Yoga social media star and author Rachel Brathen is well-known for her openness and authenticity. She tells Stacey Carter why she wanted to write her book and how she navigates sharing her life with the world", true, "Let yoga be your life!", "Rachel Braten", null, "Above 8 years.", 100m, "YogaTrainer", null },
                    { new Guid("d91b8686-f5e7-4d8a-980b-1dc888b0ff45"), "https://firstclasspt.se/____impro/1/onewebmedia/Bigstock/professionella%20manliga%20skola%20sport%20coach%20ger%20tumme.jpg?etag=%22a97572-59303a63%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=321%2B481&extract=28%2B37%2B280%2B421&quality=85", "Matt trains a roster of celebrity clients, is a published author and has his own brand of fitness clothing. But despite this borderline celebrity trainer status, he remains grounded. He knows that working with regular people and helping them to achieve the results they’re looking for is what gets referrals, and word of mouth business. After 23 years of experience in the fitness industry, Matt knows something about being able to relate to others and considers interpersonal skills to be one of the most important assets an aspiring trainer can possess.", true, "I can teach u to fly!", "Matt Roberts", null, "Above 15 years.", 150m, "ClassicTrainer", null },
                    { new Guid("f2d5b2a5-8100-4103-b8ad-1bfa6f9672cb"), "https://www.hfe.co.uk/wp-content/uploads/2018/12/Shaun-Stafford-Headshot1-copy-2-703x1024.jpg", "With a Masters degree in strength and conditioning from Oxford University, Shaun left university and went into a bodybuilding career. He followed that with a semi-professional rugby career and more recently focused on personal training. He supports a number of clients, notably those in a rugby arena from his performance gym and has a huge presence of social media. But despite this level of influence, he encourages aspiring trainers to focus their energy into what’s important to them. He reminds them that an online following isn’t necessary to have a profoundly important impact on someone’s life and to double down on those things that you’re good at and that make you happy.", true, "Train Harder!", "Shaun Stafford", null, "Above 8 years.", 110m, "YogaTrainer", null },
                    { new Guid("f337afd0-75a2-4c37-a601-17a3bb06bba6"), "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l1200.webp", "Arnold Alois Schwarzenegger is an Austrian and American actor, businessman, filmmaker, politician, and retired professional bodybuilder best known for his roles in high-profile action movies. He served as the 38th governor of California from 2003 to 2011 and was among Time magazine's 100 most influential people in the world in 2004 and 2007.", true, "I'll be back!", "Arnold Schvarzenegger", null, "Above 30 years.", 200m, "ClassicTrainer", null },
                    { new Guid("f9a61a63-7ee0-4c06-b82c-6d990f963318"), "https://xcal.com/wp-content/uploads/2023/02/Rachel.webp", "Exercise professional and sports nutrition specialist, Louise, has published a number of books which have become Sunday Times bestsellers. This isn’t a common achievement, and is evidence of the relatable and compassionate way that Louise discusses the relationship between nourishing your body with food and staying “lean for life”. Since starting her company in 2007, Louise has helped close to 20,000 individuals - a phenomenal number! Louise has taught her methods to a team of coaches so that she’s able to impact even more people each year. Louise is an advocate of connecting goals with values. Both from the perspective of a client connecting with their goal, and also from the perspective of a business owner. Operating from a place of vision means that you’re able to genuinely help people in a way which is meaningful and valuable to them.", true, "Be yourself!", "Louise Parker", null, "Above 12 years.", 130m, "ClassicTrainer", null },
                    { new Guid("fa45d067-370a-4b73-a88d-917b012c9bbf"), "https://ronniecoleman.net/cdn/shop/products/ronnie-coleman-signature-series-light-weight-baby-tee-apparel-accessories-shirt-29983544049777_1024x1024.jpg?v=1655495689", "Ronald Dean Coleman  is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning,dominant body-parts and extremely heavy workouts,making him the strongest", true, "I pump 200 for chest!", "Ronnie Coleman", null, "Above 30 years.", 200m, "ClassicTrainer", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("188d9e5e-fa03-42aa-a96b-7fd5f512daf4"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("22bcd060-a119-4ef6-8a39-785c0569252d"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("2b2180db-0b60-4d72-98d9-9bf00134d788"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("4efcfbfa-b5f3-4334-8fb7-2921cca00c35"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("88a27837-2c79-4208-85a6-0cc0b963e02f"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("9648c7c5-efd4-47ff-b5ae-936d7d35761f"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("a98c629c-4fbd-451d-a720-f1f50086578b"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("ab5d3213-9428-45ea-a1b8-d8f511f5cf51"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("b455fe0e-2d70-4609-8c6f-e34bce1c6af0"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("b4da124e-db71-4aae-a0df-7f52c84f1bcb"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d174e5be-fb70-4083-b8c3-28b1da18b69b"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("d91b8686-f5e7-4d8a-980b-1dc888b0ff45"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f2d5b2a5-8100-4103-b8ad-1bfa6f9672cb"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f337afd0-75a2-4c37-a601-17a3bb06bba6"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("f9a61a63-7ee0-4c06-b82c-6d990f963318"));

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: new Guid("fa45d067-370a-4b73-a88d-917b012c9bbf"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdb57211-855c-470a-b0f4-817d9335a26b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec2c84f-2490-4e63-a5a3-eca36e1ef76e", "AQAAAAIAAYagAAAAEFw9EX30SoqLG7g8InSJgM8LLs31yEZyMrN2S/hKkmP9/ZfdSDvCSXaA4Ei5f3ZZ4w==", "57961529-e425-4836-a1bc-25aa40dc2b71" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://files.ekmcdn.com/alphasports86/images/urban-fitness-2in1-protein-shaker-700ml--2023-p.jpg?v=6FB99E0C-5E66-4D39-B4E2-7384D9AB6276");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://cdn.shopify.com/s/files/1/0585/3016/9008/products/elephantskin-fitness-handschuhe-titelbild.png?v=1644683288");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Mark", "Price" },
                values: new object[] { "Keep your hard-earned muscles fed, whether youre at home or at the gym. Stay fit & consistent with your protein supplementation & stay strong around the clock, in the gym or at home. Pro series whey has a scientific combination of whey isolate (fast) for immediate absorption and whey concentrate (slow digesting) to give feed your muscles for longer time a protein drink thats richer & tastier than any whey protein in india", "Goodlife", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Mark", "Name" },
                values: new object[] { "Products with electrical plugs are designed for use in the US. Outlets and voltage differ internationally and this product may require an adapter or converter for use in your destination. Please check compatibility before purchasing.", "https://fitness1.bg/products/u/levrone-wellness-series-l-carnitine-125000-1-l-1786f0c.jpg", "Goodlife", "L-Carnitine" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.fitnesssuperstore.com/v/vspfiles/templates/fitness-resp/images/homepage/product-slider/precor-ellipticals.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://cdn3.volusion.com/aqyor.dadrn/v/vspfiles/photos/FF-FSR100-2.jpg?v-cache=1682102760");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://cdn3.volusion.com/aqyor.dadrn/v/vspfiles/photos/bsldG9S-2.jpg?v-cache=1669221040");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://cdn.webshopapp.com/shops/16221/files/401178608/930x1240x3/venum-venum-aero-body-fitness-gloves-black-pink.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Mark", "Name" },
                values: new object[] { "These multi-purpose resistance bands are light and very easily transportable. These are muscle building accessories that, depending on the use and the resistance chosen, will help develop your strength, flexibility or mobility.", "https://cdn.webshopapp.com/shops/16221/files/360675752/930x1240x3/venum-venum-challenger-resistance-band-purple-22-3.jpg", "Venum", "Venum Challenger Resistance Band Purple" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Bad Boy has been involved in the sport since the early nineties and is one of the original supporters of mixed martial arts and Jiu Jitsu tournaments.", "https://cdn.webshopapp.com/shops/16221/files/422027250/466x544x1/image.jpg", "Bad Boy MMA Fightshorts Capo 2 White" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://cdn.webshopapp.com/shops/16221/files/395465361/466x544x1/image.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Mark", "Name" },
                values: new object[] { "Venum Rafter Sweatshirt Dark Heather Grey.  The Venum Rafter sweatshirt is an ultra comfortable fleece crewneck.  The 3D printing on the chest gives an original relief to this sweatshirt, which can be worn with jeans as well as with the Venum Rafter jogging pants.  The design marks a notable graphic evolution compared to previous collections.  Specification's Venum Rafter Sweatshirt :  • 55% Cotton / 45% Polyester • Fleece lining • Jacquard bands • Embroidered Venum logo • 3D printing • Straight cut • Machine wash at 30 °: do not iron or tumble dry", "https://cdn.webshopapp.com/shops/16221/files/421682446/930x1240x3/venum-venum-rafter-sweatshirt-dark-heather-grey.jpg", "Venum", "Rafter Sweatshirt Dark Heather Grey" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://cdn.webshopapp.com/shops/16221/files/323824938/930x1240x3/hayabusa-hayabusa-kanpeki-t3-lx-hybrid-sparring-gl.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://cdn.webshopapp.com/shops/16221/files/433053093/930x1240x3/venum-venum-koi-rashguard-long-sleeves-black-blue.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://cdn.webshopapp.com/shops/16221/files/433528738/930x1240x3/venum-venum-elite-boxing-gloves-microfiber-white-s.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://cdn.webshopapp.com/shops/16221/files/350147425/466x544x1/image.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "The Punch Round \"No-Fear\" kickboxing shin guards combine a good fit, high quality with good durability. They are made from a high-quality artificial leather. With a 3-layer shock-absorbing foam for optimum protection.\r\n\r\nThe attachment is made of 2 sturdy velcro closure for a good and lasting fit during training and sparring.", "https://cdn.webshopapp.com/shops/16221/files/327053024/375x500x2/punchr-punch-round-kids-nofear-kickboxing-shin-gua.jpg", "Punch Round Kids NoFear Kickboxing Shin Guards Black White" });

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
    }
}
