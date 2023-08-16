using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGymWeb.Data.Models;

namespace MyGymWeb.Data.Configuration
{
  
    internal class GymConfiguration : IEntityTypeConfiguration<Gym>
    {

        public void Configure(EntityTypeBuilder<Gym> builder)
        {
            builder.HasData(CreateGym());
        }
        private  List<Gym> CreateGym()
        {
          var gyms = new List<Gym>()
          {
                new Gym()
            {
                 Id = 1,
                 Name = "Boxing Champions Center",
                 ImageUrl = "https://i.pinimg.com/originals/30/5a/49/305a49dcb1bfd8267be3f05818a64543.jpg",
                 Description = "Jack's boxing gym is a full service fitness facility offering top notch boxing instruction from the best of the best. We are a Pittsburgh Northside family run business that provides family safe boxing fitness, weight training, and circuit training options for men, women, and children of all capabilities. If you want an effective workout that targets all muscle groups, you've come to the right place. GET READY TO WORK. ",
                Type = "BigBoxGym"
            },
            new Gym()
            {
                Id = 2,
                Name = "Knockdown Warriors",
                ImageUrl = "https://images.squarespace-cdn.com/content/v1/57e1819b2e69cf0a7552a014/1678287369599-TV986RNEWX85AM1XA2EV/Colosseum+Boxing004.jpg?format=1000w",
                Description = "This Gym is most popular and most exclusive  private 1 on 1 and group boxing training facility! All of our classes are taught by world-class coaches in a fun and friendly environment. Hybrid offers both Boxing and Muay Thai Kickboxing semi-private classes which focus on proper boxing technique, kicking technique, shadow boxing drills, 1-on-1 mitt work, bag work, and High Intensity Interval Training so you can get amazing results in the fastest time possible. We cap all classes at 6 participants for a more personal group training experience. Burn over 500 calories per class.",
                Type = "BigBoxGym"
            },
            new Gym()
            {
                 Id = 9,
                 Name = "Muscle Monkeys",
                 ImageUrl = "https://www.borntough.com/cdn/shop/articles/Bodybuilding_at_age_30.jpg?v=1639596956&width=1800",
                 Description = "This is not just gyms, nor ordinary spa. This is the unique lifestyle club in our country – places where, together with our club members, we realize our common vision of a meaningful life. What is it? To achieve change, health, personal balance and satisfaction through sport in a convenient and accessible way, saving time and effort, but without compromising the rhythm of the big city. Dynamically and purposefully, not with compulsion or with annoyance, but jointly, with fun and at with own pace. Each one of the clubs has a unique interior design, prepared by Pro Design Interiors.",
                 Type = "ClassicGym"
            },
            new Gym()
            {
                 Id = 4,
                 Name = "Harmony Center",
                 ImageUrl = "https://fitathletic.com/wp-content/uploads/2014/07/fit_athletic_blog_reformer-pilates-1.jpg",
                 Description = "The Pilates method, with its proven beneficial effect on the body, is preferred as a training activity among a large number of ladies. The exercises are performed smoothly, with maximum control in each movement to avoid injuries and achieve the desired results. With regular exercise, you can improve your posture, even your gait. It is a unique system of exercises for stretching and strength, strengthening and toning muscles. No exercise is an end in itself, all the muscles of the body are activated. You will strengthen your muscles and shape your body so that it looks even more graceful, tight and beautiful. Pain in the neck and back is especially affected.By following the exact instructions, at the end of the workout you will feel your body toned and pleasantly relaxed.",
                 Type = "PilatesGym"
            },
            new Gym()
            {
                 Id = 5,
                 Name = "Immortal Yoga",
                 ImageUrl = "https://previews.123rf.com/images/popunderlight/popunderlight1801/popunderlight180100251/92852319-portrait-of-attractive-asian-girl-doing-yoga-exercise-in-gym.jpg",
                 Description = "You are about to pass through the many dimensions of your own Self. This journey will take you through a transformation of consciousness, across a vital bridge connecting spirit and matter, Heaven and Earth, mind and body. And as you transform yourself, you transform the world.We are committed to providing you with the tools to support you on your journey to a full spectrum yoga experience.We will be glad to meet you!",
                Type = "YogaGym"
            },
            new Gym()
            {
                 Id = 6,
                 Name = "Tranquil Studio",
                 ImageUrl = "https://cdn.pixabay.com/photo/2018/04/05/17/21/kettlebell-3293475_1280.jpg",
                 Description = "A mellow paced body conditioning technique that combines breathing, stretching and strengthening to achieve and maintain optimal posture. Allow your body to move freely and efficiently by strengthening your deep abdominal and core stabilisers while relaxing tense neck and shoulder muscles. This class may include bands, circles and or balls.",
                Type = "YogaGym"
            },

          };

            return gyms;
        }

    }
}
