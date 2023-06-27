using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGymProject.Data.Models;

namespace MyGymProject.Data.Configuration
{
    internal class ClassicTrainerConfiguration : IEntityTypeConfiguration<ClassicTrainer>
    {
        public void Configure(EntityTypeBuilder<ClassicTrainer> builder)
        {

            builder.HasData(CreateTrainers());
          
        }
        private List<ClassicTrainer> CreateTrainers()
        {
            var trainers = new List<ClassicTrainer>()
          {
            new ClassicTrainer()
            {
                Id = 1,
                Name = "Arnold Schwarzenegger",
                ImageUrl = "https://i.ebayimg.com/images/g/yDkAAOSw7vtjPegV/s-l960.webp",
                Info = "Arnold Schwarzenegger is known as the Styrian Oak, or Austrian Oak, in the bodybuilding world, where he dwarfed his competition. He won his first amateur Mr. Universe title 20 years old. After moving to California he compete bigger events in the United States, he won three more Mr. Universe titles and then the professional Mr. Olympia title six years in a row before retiring.",
                Practis = "Practis Above 20 Years",
                Moto = "You dream.",
                PricePerHour = 200,

            },
             new ClassicTrainer()
             {
                 Id = 2,
                 Name = "Chris Bumstead",
                 ImageUrl = "https://www.muscleandfitness.com/wp-content/uploads/2019/10/Chris-Bumstead-Shirtless-Hands-On-Hip.jpg?quality=86&strip=all",
                 Info = "Christopher Adam Bumstead is a Canadian IFBB professional bodybuilder. Bumstead is the reigning Mr. Olympia Classic Physique winner, having won the competition in 2019, 2020, 2021 and 2022. He was also the runner-up in 2017 and 2018.",
                 Practis = "Practis Above 10 Years",
                 Moto = "Don't be afraid of failure.",
                 PricePerHour = 160,
             },
             new ClassicTrainer()
             {
                 Id = 3,
                 Name = "Jay Cutler",
                 ImageUrl = "https://media.gettyimages.com/id/702973/photo/bodybuilder-jay-cutler-poses-during-the-arnold-classic-2002-february-23-2002-in-columbus-oh.jpg?s=612x612&w=gi&k=20&c=P2UjdlRcstD8CETCQYByU_2yqjx3KWnJ4xInKXIt3T0=",
                 Info = "Jason Isaac Cutler is an American retired professional bodybuilder.An IFBB pro, Cutler is a four-time Mr. Olympia winner and a six-time runner-up, the most in history.",
                 Practis = "Practis Above 20 Years",
                 Moto = "If something stands between you and your success, move it.",
                 PricePerHour = 180,
             },
             new ClassicTrainer()
             {
                 Id = 4,
                 Name = "Dorian Yates",
                 ImageUrl = "https://generationiron.com/wp-content/uploads/2022/01/CED5711A-1DAC-45E1-BB83-5462E5A04652.jpeg",
                 Info = "Dorian Andrew Mientjez Yates is an English retired professional bodybuilder. He won the Mr. Olympia title six consecutive times and has the fifth-highest number of Mr. Olympia wins in history, ranking behind Ronnie Coleman",
                 Practis = "Practis Above 20 Years",
                 Moto = "You must not only have competitiveness but ability, regardless of the circumstance you face, to never quit.",
                 PricePerHour = 170,
             },
              new ClassicTrainer()
              {
                  Id = 5,
                  Name = "Ronnie Coleman",
                  ImageUrl = "https://yt3.googleusercontent.com/d8GULtiQ88hMBsHr-4P2p4_30wj-QjaZaR_f97WZxDc3EP_vm5wfx-xSazlSEWhilab0Pq7HgA=s900-c-k-c0x00ffffff-no-rj",
                  Info = "Ronald \"Ronnie\" Dean Coleman is an American retired professional bodybuilder. The winner of the Mr. Olympia title for eight consecutive years, he is widely regarded as either the greatest bodybuilder of all time or one of the two greatest along with Arnold Schwarzenegger and as the most dominant bodybuilding physique ever to grace the stage.Winner of 26 IFBB professional titles, he is also renowned for his combination of size and conditioning, dominant body-parts and extremely heavy workouts, making him the strongest bodybuilder of all time.",
                  Practis = "Practis Above 20 Years",
                  Moto = "Just Do It.",
                  PricePerHour = 200,
              },
              new ClassicTrainer()
              {
                  Id = 6,
                  Name = "Melina Keltaniemi ",
                  ImageUrl = "https://musclehealthmag.com/wp-content/uploads/2019/05/melina5-819x1024.jpg",
                  Info = "A young female bodybuilder at only 22 years old, Melina Keltaniemi is just beginning her career, but she’s off to a flying start!This ripped female bodybuilder came 2nd place in the 2018 Nordic Elite Pro, 3rd place at IFBB Elite Pro Russia, and was 2018's IFBB Elite Pro World Champion. Her drive to become the most successful female bodybuilder is clear, and her mindset matches that of a champion competitor.",
                  Practis = "Practis Above 2 Years",
                  Moto = "Go For It",
                  PricePerHour = 100,
              }
            };

            return trainers;
        }
    }
    
}
