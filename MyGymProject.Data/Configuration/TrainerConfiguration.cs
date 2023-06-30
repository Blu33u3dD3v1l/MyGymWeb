using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGymWeb.Data.Models;

namespace MyGymWeb.Data.Configuration
{
    internal class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {

            builder.HasData(CreateTrainers());
          
        }
        private List<Trainer> CreateTrainers()
        {
            var trainers = new List<Trainer>()
          {
            new Trainer()
            {
                Id = 1,
                Name = "Arnold Schwarzenegger",
                ImageUrl = "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l960.webp",
                Info = "Arnold Schwarzenegger is known as the Styrian Oak, or Austrian Oak, in the bodybuilding world, where he dwarfed his competition. He won his first amateur Mr. Universe title 20 years old. After moving to California he compete bigger events in the United States, he won three more Mr. Universe titles and then the professional Mr. Olympia title six years in a row before retiring.",
                Practis = "Practis Above 20 Years",
                Type = "CLassicTrainer",
                Moto = "You dream.",
                PricePerHour = 200,

            },
             new Trainer()
             {
                 Id = 2,
                 Name = "Chris Bumstead",
                 ImageUrl = "https://e0.pxfuel.com/wallpapers/609/537/desktop-wallpaper-chris-bumstead.jpg",
                 Info = "Christopher Adam Bumstead is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.",
                 Practis = "Practis Above 10 Years",
                 Type = "CLassicTrainer",
                 Moto = "Don't be afraid of failure.",
                 PricePerHour = 160,
             },
             new Trainer()
             {
                 Id = 3,
                 Name = "Jay Cutler",
                 ImageUrl = "https://media.gettyimages.com/id/702973/photo/bodybuilder-jay-cutler-poses-during-the-arnold-classic-2002-february-23-2002-in-columbus-oh.jpg?s=612x612&w=gi&k=20&c=P2UjdlRcstD8CETCQYByU_2yqjx3KWnJ4xInKXIt3T0=",
                 Info = "Jason Isaac Cutler is an American retired professional bodybuilder.An IFBB pro, Cutler is a four-time Mr. Olympia winner and a six-time runner-up, the most in history.",
                 Practis = "Practis Above 20 Years",
                 Type = "CLassicTrainer",
                 Moto = "If something stands between you and your success, move it.",
                 PricePerHour = 180,
             },
             new Trainer()
             {
                 Id = 4,
                 Name = "Dorian Yates",
                 ImageUrl = "https://generationiron.com/wp-content/uploads/2022/01/CED5711A-1DAC-45E1-BB83-5462E5A04652.jpeg",
                 Info = "Dorian Andrew Mientjez Yates is an English retired professional bodybuilder. He won the Mr. Olympia title six consecutive times and has the fifth-highest number of Mr. Olympia wins in history, ranking behind Ronnie Coleman",
                 Practis = "Practis Above 20 Years",
                 Type = "CLassicTrainer",
                 Moto = "You must not only have competitiveness but ability, regardless of the circumstance you face, to never quit.",
                 PricePerHour = 170,
             },
              new Trainer()
              {
                  Id = 5,
                  Name = "Ronnie Coleman",
                  ImageUrl = "https://yt3.googleusercontent.com/d8GULtiQ88hMBsHr-4P2p4_30wj-QjaZaR_f97WZxDc3EP_vm5wfx-xSazlSEWhilab0Pq7HgA=s900-c-k-c0x00ffffff-no-rj",
                  Info = "Ronald \"Ronnie\" Dean Coleman is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning, dominant body-parts and extremely heavy workouts, making him the strongest bodybuilder of all time.",
                  Practis = "Practis Above 20 Years",
                  Type = "CLassicTrainer",
                  Moto = "Just Do It.",
                  PricePerHour = 200,
              },
              new Trainer()
              {
                  Id = 6,
                  Name = "Melina Keltaniemi ",
                  ImageUrl = "https://musclehealthmag.com/wp-content/uploads/2019/05/melina5-819x1024.jpg",
                  Info = "A young female bodybuilder at only 22 years old, Melina Keltaniemi is just beginning her career, but she’s off to a flying start!This ripped female bodybuilder came 2nd place in the 2018 Nordic Elite Pro, 3rd place at IFBB Elite Pro Russia, and was 2018's IFBB Elite Pro World Champion. Her drive to become the most successful female bodybuilder is clear, and her mindset matches that of a champion competitor.",
                  Practis = "Practis Above 2 Years",
                  Type = "CLassicTrainer",
                  Moto = "Go For It",
                  PricePerHour = 100,
              },
              new Trainer()
              {
                  Id = 7,
                Name = "Mike Tyson",
                ImageUrl = "https://www.si.com/.image/t_share/MTY4MTk2NjgxODE2NjE0ODEz/1988-mike-tyson-nlc_05245jpg.jpg",
                Info = "Michael Gerard Tyson is an American former professional boxer whos Nicknam is Iron Mike and Kid Dynamite in his early career, and later known as The Baddest Man on the Planet,Tyson is considered to be one of the greatest heavyweight boxers of all time.He reigned as the undisputed world heavyweight champion. Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title.He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round. Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.",
                Practis = "Above 20 Years!",
                Type = "BoxingTrainer",
                Moto = "Lets smash some Heads!",
                PricePerHour = 200,
              },
               new Trainer()
              {
                 Id = 8,
                 Name = "Muhammad Ali",
                 ImageUrl = "https://cdn.britannica.com/86/192386-050-D7F3126D/Muhammad-Ali-American.jpg",
                 Info = "Muhammad Ali born Cassius Marcellus Clay Jr. was an American professional boxer and activist. Nicknamed The Greatest, he is regarded as one of the most significant sports figures of the 20th century and is often regarded as the greatest heavyweight boxer of all time.",
                 Practis = "Practis Above 10 Years",
                 Type = "BoxingTrainer",
                 Moto = "Don't be afraid of failure.",                    
                 PricePerHour = 160,
              },
                new Trainer()
              {
                     Id = 9,
                 Name = "Evander Holyfield",
                 ImageUrl = "https://media.gettyimages.com/id/702973/photo/bodybuilder-jay-cutler-poses-during-the-arnold-classic-2002-february-23-2002-in-columbus-oh.jpg?s=612x612&w=gi&k=20&c=P2UjdlRcstD8CETCQYByU_2yqjx3KWnJ4xInKXIt3T0=",
                 Info = "Evander Holyfield is an American former professional boxer. He reigned as the undisputed champion at cruiserweight in the late 1980s and at heavyweight, and is the only boxer in history to win the undisputed championship in two weight classes in the three belt era. Nicknamed the Real Deal, Holyfield is the only four-time world heavyweight champion, having held the unified WBA, WBC, and IBF titles.",
                 Practis = "Practis Above 20 Years",
                 Type = "BoxingTrainer",
                 Moto = "If something stands between you and your success, move it.",
                 PricePerHour = 180,
              },
                new Trainer()
              {
                 Id = 10,
                 Name = "Anthony Joshua",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2b/Anthony_Joshua_2017.png",
                 Info = "Anthony Oluwafemi Olaseni Joshua OBE (born 15 October 1989) is a British professional boxer. He is a two-time former unified world heavyweight champion, having held the WBA (Super), IBF, WBO, and IBO titles twice between 2016 and 2021. At regional level, he held the British and Commonwealth heavyweight titles from 2015 to 2016.",
                 Practis = "Practis Above 10 Years",
                 Type = "BoxingTrainer",
                 Moto = "You must not only have competitiveness but ability, regardless of the circumstance you face, to never quit.",
                 PricePerHour = 150,
              },
                new Trainer()
              {
                  Id = 11,
                  Name = "Wladimir Klitschko",
                  ImageUrl = "https://img.championat.com/s/735x490/news/big/v/s/45-letnij-vladimir-klichko-pokazal-vpechatlyayuschuyu-fizicheskuyu-formu-foto_1621247259885661893.jpg",
                  Info = "Wladimir Klitschko (born 25 March 1976) is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as great footwork and mobility, unusual for boxers of his size",
                  Practis = "Above 20 Years",
                  Type = "BoxingTrainer",
                  Moto = "Just Do It.",
                  PricePerHour = 200,
              },
                new Trainer()
              {
                  Id = 12,
                  Name = "Hanna Gabriels",
                  ImageUrl = "https://latinbox2011.files.wordpress.com/2018/12/img_5540.jpg",
                  Info = "Hanna Gabriels Valle (born 14 January 1983) is a Costa Rican professional boxer. She has held world championships in four weight classes, having held the WBA female light middleweight title since 2016; the WBA female light heavyweight and WBC female heavyweight titles since April 2021;[nb 1] the WBO welterweight title in 2009; and the WBO light middleweight title twice between 2010 and 2018. As of September 2020, she is ranked as the world's third best active light middleweight by The Ring and BoxRec",
                  Practis = "Practis Above 7 Years",    
                  Type = "BoxingTrainer",
                  Moto = "Go For It",
                  PricePerHour = 100,
              },
                new Trainer()
              {
                  Id = 13,
                  Name = "Kristin McGee",
                  ImageUrl = "https://fitnessgalore.net/wp-content/uploads/2013/12/kristenmcgeetodaynew-1050x1575.jpg",
                  Info = "Kristin McGee is an American fitness instructor and yogi who launched Peloton Interactive yoga classes.She is a mom of three boys and a fitness influencer who advocates for the benefits of movement.",
                  Practis = "Practis Above 7 Years",
                  Type = "YogaTrainer",                 
                  Moto = "Go For It",
                  PricePerHour = 100,
              },
                new Trainer()
              {
                  Id = 14,
                  Name = "Indra Devi",
                  ImageUrl = "https://res.cloudinary.com/fleetnation/image/private/c_fit,w_1120/fl_no_overflow,g_south,l_text:style_gothic2:%C2%A9%20Imagerisium,o_20,y_10/fl_no_overflow,g_center,l_watermark4,o_25,y_50/v1471521586/qub6twmyw0o4b2gjdxyf.jpg",
                  Info = "Eugenie Peterson, known as Indra Devi, is a pioneering teacher of yoga as exercise, and an early disciple of the father of modern yoga.She went to India in her twenties, becoming a film star there and acquiring the stage name Indra Devi. She was the first woman to study under the yoga guru Krishnamacharya at the Mysore Palace, alongside B.K.S Iyengar and K. Pattabhi Jois who went on to become yoga gurus. Moving to China, she taught the first yoga classes in that country at Madame Chiang Kai-shek's house.",
                  Practis = "Practis Above 7 Years",
                  Type = "YogaTrainer",
                  Moto = "Dream",
                  PricePerHour = 100,
              },
                new Trainer()
              {
                  Id = 15,
                  Name = "Bett Larkin",
                  ImageUrl = "https://i0.wp.com/ideamensch.com/wp-content/uploads/2021/02/brett-larkin-e1613526716771.jpg",
                  Info = "Brett Larkin is a Youtube Star, Pilates and Yoga instructor who rose to fame for her at-home, beginner-friendly vinyasa flow and meditation courses she posts to her YouTube channel, where she has amassed a following of 500,000 subscribers. The focus of her channel is to make yoga more accessible to everyone. She also offers a yoga instructor training online course. Born on July 24, , Brett Larkin hails from , United States. As in 2023, Brett Larkin's age is N/A. Check below for more deets about Brett Larkin. This page will put a light upon the Brett Larkin bio, wiki, age, birthday, family details, affairs, controversies, caste, height, weight, rumors, lesser-known facts, and more",
                  Practis = "Practis Above 5 Years",
                  Type = "PilatesTrainer",
                  Moto = "Dream",
                  PricePerHour = 100,
              },
            };

            return trainers;
        }
    }
    
}
