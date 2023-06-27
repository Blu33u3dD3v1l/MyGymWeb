using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGymProject.Data.Models;

namespace MyGymProject.Data.Configuration
{
    internal class BoxingTrainerConfiguration : IEntityTypeConfiguration<BoxingTrainer>
    {
        public void Configure(EntityTypeBuilder<BoxingTrainer> builder)
        {
            builder.HasData(CreateBoxingTrainers());
        }
        private List<BoxingTrainer> CreateBoxingTrainers()
        {
            var trainers = new List<BoxingTrainer>()
          {
            new BoxingTrainer()
            {
                Id = 1,
                Name = "Mike Tyson",
                ImageUrl = "https://www.si.com/.image/t_share/MTY4MTk2NjgxODE2NjE0ODEz/1988-mike-tyson-nlc_05245jpg.jpg",
                Info = "Michael Gerard Tyson is an American former professional boxer whos Nicknam is Iron Mike and Kid Dynamite in his early career, and later known as The Baddest Man on the Planet,Tyson is considered to be one of the greatest heavyweight boxers of all time.He reigned as the undisputed world heavyweight champion. Tyson won his first 19 professional fights by knockout, 12 of them in the first round. Claiming his first belt at 20 years, four months, and 22 days old, Tyson holds the record as the youngest boxer ever to win a heavyweight title.He was the first heavyweight boxer to simultaneously hold the WBA, WBC and IBF titles, as well as the only heavyweight to unify them in succession. The following year, Tyson became the lineal champion when he knocked out Michael Spinks in 91 seconds of the first round. Tyson was knocked out by underdog Buster Douglas in one of the biggest upsets in boxing history.",
                Practis = "Above 20 Years!",
                Moto = "Lets smash some Heads!",
                PricePerHour = 200,

            },
             new BoxingTrainer()
             {
                 Id = 2,
                 Name = "Muhammad Ali",
                 ImageUrl = "https://cdn.britannica.com/86/192386-050-D7F3126D/Muhammad-Ali-American.jpg",
                 Info = "Muhammad Ali born Cassius Marcellus Clay Jr. was an American professional boxer and activist. Nicknamed The Greatest, he is regarded as one of the most significant sports figures of the 20th century and is often regarded as the greatest heavyweight boxer of all time.",
                 Practis = "Practis Above 10 Years",
                 Moto = "Don't be afraid of failure.",
                 PricePerHour = 160,
             },
             new BoxingTrainer()
             {
                 Id = 3,
                 Name = "Evander Holyfield",
                 ImageUrl = "https://media.gettyimages.com/id/702973/photo/bodybuilder-jay-cutler-poses-during-the-arnold-classic-2002-february-23-2002-in-columbus-oh.jpg?s=612x612&w=gi&k=20&c=P2UjdlRcstD8CETCQYByU_2yqjx3KWnJ4xInKXIt3T0=",
                 Info = "Evander Holyfield is an American former professional boxer. He reigned as the undisputed champion at cruiserweight in the late 1980s and at heavyweight, and is the only boxer in history to win the undisputed championship in two weight classes in the three belt era. Nicknamed the Real Deal, Holyfield is the only four-time world heavyweight champion, having held the unified WBA, WBC, and IBF titles.",
                 Practis = "Practis Above 20 Years",
                 Moto = "If something stands between you and your success, move it.",
                 PricePerHour = 180,
             },
             new BoxingTrainer()
             {
                 Id = 4,
                 Name = "Anthony Joshua",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2b/Anthony_Joshua_2017.png",
                 Info = "Anthony Oluwafemi Olaseni Joshua OBE (born 15 October 1989) is a British professional boxer. He is a two-time former unified world heavyweight champion, having held the WBA (Super), IBF, WBO, and IBO titles twice between 2016 and 2021. At regional level, he held the British and Commonwealth heavyweight titles from 2015 to 2016.",
                 Practis = "Practis Above 10 Years",
                 Moto = "You must not only have competitiveness but ability, regardless of the circumstance you face, to never quit.",
                 PricePerHour = 150,
             },
              new BoxingTrainer()
              {
                  Id = 5,
                  Name = "Wladimir Klitschko",
                  ImageUrl = "https://img.championat.com/s/735x490/news/big/v/s/45-letnij-vladimir-klichko-pokazal-vpechatlyayuschuyu-fizicheskuyu-formu-foto_1621247259885661893.jpg",
                  Info = "Wladimir Klitschko (born 25 March 1976) is a Ukrainian former professional boxer who competed from 1996 to 2017. He held the world heavyweight championship twice, including the unified WBA (Super), IBF, WBO, IBO, and Ring magazine titles. A strategic and intelligent boxer, Klitschko is considered to be one of the best heavyweight champions of all time.He was known for his exceptional knockout power, using a strong jab, straight right hand and left hook, quick hand speed, as well as great footwork and mobility, unusual for boxers of his size",
                  Practis = "Above 20 Years",
                  Moto = "Just Do It.",
                  PricePerHour = 200,
              },
              new BoxingTrainer()
              {
                  Id = 6,
                  Name = "Hanna Gabriels",
                  ImageUrl = "https://latinbox2011.files.wordpress.com/2018/12/img_5540.jpg",
                  Info = "Hanna Gabriels Valle (born 14 January 1983) is a Costa Rican professional boxer. She has held world championships in four weight classes, having held the WBA female light middleweight title since 2016; the WBA female light heavyweight and WBC female heavyweight titles since April 2021;[nb 1] the WBO welterweight title in 2009; and the WBO light middleweight title twice between 2010 and 2018. As of September 2020, she is ranked as the world's third best active light middleweight by The Ring and BoxRec",
                  Practis = "Practis Above 7 Years",
                  Moto = "Go For It",
                  PricePerHour = 100,
              }
            };

            return trainers;
        } 

    }
}
