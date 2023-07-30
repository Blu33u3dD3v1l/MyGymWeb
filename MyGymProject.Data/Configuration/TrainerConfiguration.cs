using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data.Models;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel;


namespace MyGymWeb.Data.Configuration
{
    internal class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder
              .HasData(CreateTypes());


        }

        private List<Trainer> CreateTypes()
        {
            var types = new List<Trainer>()
            {
                new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Arnold Schvarzenegger",
                  ImageUrl = "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l1200.webp",
                  Info = "Arnold Alois Schwarzenegger is an Austrian and American actor, businessman, filmmaker, politician, and retired professional bodybuilder best known for his roles in high-profile action movies. He served as the 38th governor of California from 2003 to 2011 and was among Time magazine's 100 most influential people in the world in 2004 and 2007.",
                  Moto = "I'll be back!",
                  Practis = "Above 30 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 200,

              },
                new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Chris Bumstead",
                  ImageUrl = "https://e0.pxfuel.com/wallpapers/609/537/desktop-wallpaper-chris-bumstead.jpg",
                  Info = "Christopher Adam Bumstead, known by his fans as CBum, is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.Bumstead maintains a large online presence with content focusing on his lifestyle and bodybuilding.",
                  Moto = "More Weight.",
                  Practis = "Above 15 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 150,

              },
                new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Mike Tyson",
                  ImageUrl = "https://pagesix.com/wp-content/uploads/sites/3/2022/08/Russell-Hornsby-Mike-Tyson_99-1.jpg?quality=75&strip=all&w=413",
                  Info = "Michael Gerard Tyson is an American former professional boxer who competed from 1985 to 2005. Nicknamed 'Iron Mike' and 'Kid Dynamite' in his early career, and later known as 'The Baddest Man on the Planet',Tyson is regarded as one of the greatest heavyweight boxers of all time.[6] He reigned as the undisputed world heavyweight champion from.Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title. He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round.Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.",
                  Moto = "Give me all the weed in the world.",
                  Practis = "Above 30 years.",
                  Type = "BoxingTrainer",
                  PricePerHour = 200,
              },
                 new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Ronnie Coleman",
                  ImageUrl = "https://ronniecoleman.net/cdn/shop/products/ronnie-coleman-signature-series-light-weight-baby-tee-apparel-accessories-shirt-29983544049777_1024x1024.jpg?v=1655495689",
                  Info = "Ronald Dean Coleman  is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning,dominant body-parts and extremely heavy workouts,making him the strongest",
                  Moto = "I pump 200 for chest!",
                  Practis = "Above 30 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 200,
              },
                  new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Michelle Lewin",
                  ImageUrl = "https://www.fitnessindiashow.com/wp-content/uploads/2018/11/Screen-Shot-2018-11-06-at-3.58.11-PM.png",
                  Info = "Michelle Lewin is a Venezuelan fitness coach, model, and YouTube star.She became famous because of her hourglass figure that she flaunts whenever she models.Michelle Lewin began her modeling career on a very small scale. She first discovered it by a photographer and it began her journey as a model.As a model, it is common that they take care of their body and Michelle is no exception. She takes care of her body and keeps in shape by going to the gym.",
                  Moto = "My baby is better than your!",
                  Practis = "Above 15 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 150,
              },
                   new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Wladimir Klitschko",
                  ImageUrl = "https://i.pinimg.com/originals/a0/07/34/a00734047b571a8573c6a83f03c6a1fe.jpg",
                  Info = "Wladimir Klitschko is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as athletic footwork and mobility, unusual for boxers of his size.",
                  Moto = "My Hammer will destroy you!",
                  Practis = "Above 20 years!",
                  Type = "BoxingTrainer",
                  PricePerHour = 190,
              },
                   new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Brad Schoenfeld",
                  ImageUrl = "https://img.freepik.com/free-photo/young-adult-doing-indoor-sport-gym_23-2149205542.jpg?w=2000",
                  Info = "Brad Schoenfeld considered one of greatest trainers of all time is a respected trainer, author and professor of exercise science who specialises in the science of bodybuilding and nutritionso he's often referred to as the gym trainer for men. He has spent over 30 years researching in the area of human performance, exercise physiology and muscle hypertrophy, and his work has been featured in major publications such as Men’s Health. He is also the author of numerous best-selling books on strength training and sports nutrition. His legacy lives on with his ongoing commitment to helping people achieve their fitness goals through his knowledge and experience from training thousands of athletes around the world.",
                    Moto = "Im The Best!",
                  Practis = "Above 20 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 190,
              },
                   new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Matt Roberts",
                  ImageUrl = "https://firstclasspt.se/____impro/1/onewebmedia/Bigstock/professionella%20manliga%20skola%20sport%20coach%20ger%20tumme.jpg?etag=%22a97572-59303a63%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=321%2B481&extract=28%2B37%2B280%2B421&quality=85",
                  Info = "Matt trains a roster of celebrity clients, is a published author and has his own brand of fitness clothing. But despite this borderline celebrity trainer status, he remains grounded. He knows that working with regular people and helping them to achieve the results they’re looking for is what gets referrals, and word of mouth business. After 23 years of experience in the fitness industry, Matt knows something about being able to relate to others and considers interpersonal skills to be one of the most important assets an aspiring trainer can possess.",
                   Moto = "I can teach u to fly!",
                  Practis = "Above 15 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 150,
              },
                    new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Louise Parker",
                  ImageUrl = "https://xcal.com/wp-content/uploads/2023/02/Rachel.webp",
                  Info = "Exercise professional and sports nutrition specialist, Louise, has published a number of books which have become Sunday Times bestsellers. This isn’t a common achievement, and is evidence of the relatable and compassionate way that Louise discusses the relationship between nourishing your body with food and staying “lean for life”. Since starting her company in 2007, Louise has helped close to 20,000 individuals - a phenomenal number! Louise has taught her methods to a team of coaches so that she’s able to impact even more people each year. Louise is an advocate of connecting goals with values. Both from the perspective of a client connecting with their goal, and also from the perspective of a business owner. Operating from a place of vision means that you’re able to genuinely help people in a way which is meaningful and valuable to them.",
                   Moto = "Be yourself!",
                  Practis = "Above 12 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 130,
              },
                    new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Rachel Braten",
                  ImageUrl = "https://nathealth-assets.s3-eu-west-1.amazonaws.com/articles/Rachel_Brathen.jpg",
                  Info = "Yoga social media star and author Rachel Brathen is well-known for her openness and authenticity. She tells Stacey Carter why she wanted to write her book and how she navigates sharing her life with the world",
                    Moto = "Let yoga be your life!",
                  Practis = "Above 8 years.",
                  Type = "YogaTrainer",
                  PricePerHour = 100,
              },
                    new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Shaun Stafford",
                  ImageUrl = "https://www.hfe.co.uk/wp-content/uploads/2018/12/Shaun-Stafford-Headshot1-copy-2-703x1024.jpg",
                  Info = "With a Masters degree in strength and conditioning from Oxford University, Shaun left university and went into a bodybuilding career. He followed that with a semi-professional rugby career and more recently focused on personal training. He supports a number of clients, notably those in a rugby arena from his performance gym and has a huge presence of social media. But despite this level of influence, he encourages aspiring trainers to focus their energy into what’s important to them. He reminds them that an online following isn’t necessary to have a profoundly important impact on someone’s life and to double down on those things that you’re good at and that make you happy.",
                    Moto = "Train Harder!",
                  Practis = "Above 8 years.",
                  Type = "YogaTrainer",
                  PricePerHour = 110,
              },
                      new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Anna Victoria",
                  ImageUrl = "https://www.greatestphysiques.com/wp-content/uploads/2018/04/Anna-Victoria.01.jpg",
                  Info = "Anna Victoria is a personal transformation coach and fitness star from the United States of America. Although she's now famous for her healthy and fit figure, Anna's early life looked completely different. She grew up being unaware of the importance of a healthy diet and regular exercise.",
                    Moto = "Train Even Harder!",
                  Practis = "Above 8 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 110,
              },
                       new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Anllela Sagra",
                  ImageUrl = "https://storage.googleapis.com/pai-images/803e7f4cfb964082a057d3db348f18b2.jpeg",
                  Info = "Anllela Sagra is a Colombian fitness model, trainer, bodybuilder, and social media personality. Blessed with inherent beauty and strict work ethics, she has emerged as one of the most influential figures in her industry in the recent years. Initially, her aspiration was to become a regular model and fashion designer. She even earned a degree in fashion design from the University of Colombia. However, she decided to become a fitness model after meeting a fitness enthusiast in the gym. The concept of female bodybuilders is still quite novel in her home country as muscles on women are not considered attractive in Colombia. Despite this, Sagra started undergoing weight training and began to put on muscles on her slim frame. Soon enough, she was attending fitness competitions and garnering fans from all over the world on social media. She has over 10 million followers on Instagram and more than one million followers on Facebook. On Twitter and YouTube, the social media platforms on which she is rarely active these days, she has 22.5 thousand followers and 265 thousand subscribers respectively. She has her own app listed on both Apple App Store and Google Play.",
                    Moto = "The world is mine!",
                  Practis = "Above 8 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 110,
              },
                         new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Karina Elle",
                  ImageUrl = "https://www.the-sun.com/wp-content/uploads/sites/6/2023/03/karina-elle-lisenbee-fitness-model-801547146.jpg",
                  Info = "Karina Elle Lisenbee is an American Instagram Pilates model, gym instructor and former cross-country runner. She was a cheerleader and cross-country runner during her high school years. At the age of 16, she was spotted by a photographer in a mall, after which she started modeling. She then began to participate in bikini competitions, often winning them. Soon after that, she launched her Instagram account where she started posting her intense gym workouts, which are enough to put the fittest among us to shame. Known for her plyometrics, hack squats and deadlifts, Karina went on to win the ‘World Fitness Federation Pro Bikini Championship’. The famous fitness model has also graced the pages of magazines like ‘Racked’, ‘Hers’, ‘Self’ and ‘Shape’. Additionally, not only does she have brand endorsement deals with major brands like ‘Gymshark’ and ‘Nike’, but she also has her own line of merchandise called ‘Gym Bae’. Needless to say, she is one of the most followed fitness models and instructors on the popular photo-sharing app, Instagram.",
                    Moto = "In u need a trainer, call me!",
                  Practis = "Above 8 years.",
                  Type = "PilatesTrainer",
                  PricePerHour = 110,
              },
                          new Trainer()
              {
                  Id = Guid.NewGuid(),
                  Name = "Dwayne Johnson",
                  ImageUrl = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2015%2F06%2Fdwayne-johnson-1-2000.jpg&q=60",
                  Info = "Dwayne Douglas Johnson, also known by his ring name the Rock, is an American actor, film producer, and retired professional wrestler. Widely regarded as one of the greatest professional wrestlers of all time,he was integral to the development and success of the World Wrestling Federation (WWF, now WWE) during the Attitude Era, an industry boom period in the late 1990s and early 2000s. Johnson wrestled for the WWF for eight years prior to pursuing an acting career. His films have grossed over $3.5 billion in North America and over $10.5 billion worldwide, making him one of the world's highest-grossing and highest-paid actors.",
                    Moto = "Just Bring It!",
                  Practis = "Above 8 years.",
                  Type = "ClassicTrainer",
                  PricePerHour = 200,
              },
            };

            return types;
        }

    }
}
