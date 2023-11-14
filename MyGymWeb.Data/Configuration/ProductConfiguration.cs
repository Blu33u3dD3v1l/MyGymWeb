using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGymWeb.Data.Models;

namespace MyGymWeb.Data.Configuration
{

    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
           .HasData(CreateProduct());
        }

        private List<Product> CreateProduct()
        {
            var product = new List<Product>()
          {
            new Product()
            {
                Id = 1,
                Name = "Wolves Fitness Shaker Bottle",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0572/7397/4993/products/ShakerBanner_1_1080x.jpg?v=1676866459",
                Mark = "WolvesFitness",
                Price = 30,
                Description = "Introducing our sleek and stylish protein shaker bottle - the perfect companion for your workouts and active lifestyle!, Crafted with a perfect size.",

            },
            new Product()
            {
                Id = 2,
                Name = "Urban Fitness 2in1 Protein Shaker",
                ImageUrl = "https://files.ekmcdn.com/alphasports86/images/urban-fitness-2in1-protein-shaker-700ml--2023-p.jpg?v=6FB99E0C-5E66-4D39-B4E2-7384D9AB6276",
                Mark = "Urban Fitness",
                Price = 27,
                Description = "The UFE 2in1 Protein Shaker is a premium shaker that is BPA, BPS and BPF free. The Shaker has a 700ml capacity and comes complete dual mixing.",


            },
             new Product()
             {
                 Id = 3,
                 Name = "The Fitness Gloves",
                 ImageUrl = "https://cdn.shopify.com/s/files/1/0585/3016/9008/products/elephantskin-fitness-handschuhe-titelbild.png?v=1644683288",
                 Mark = "ElephantSkin Fitness",
                 Price = 17,
                 Description = "ElephantSkin gloves are designed for (hobby) athletes who do not want to compromise on hygiene during their training.More training, less cleaning - that's the concept behind ElephantSkin's sustainable fitness glove.",


             },
              new Product()
              {
                  Id = 4,
                  Name = "Pro Nutrition and Fitness",
                  ImageUrl = "https://gonobs.com/cdn/shop/files/raging-whey-listing-creative-1.png?v=1696973140",
                  Mark = "Goodlife",
                  Price = 50,
                  Description = "Keep your hard-earned muscles fed, whether youre at home or at the gym. Stay fit & consistent with your protein supplementation & stay strong around the clock, in the gym or at home. Pro series whey has a scientific combination of whey isolate (fast) for immediate absorption and whey concentrate (slow digesting) to give feed your muscles for longer time a protein drink thats richer & tastier than any whey protein in india",


              },
                new Product()
                {
                    Id = 5,
                    Name = "L-Carnitine",
                    ImageUrl = "https://fitness1.bg/products/u/levrone-wellness-series-l-carnitine-125000-1-l-1786f0c.jpg",
                    Mark = "Goodlife",
                    Price = 14,
                    Description = "Products with electrical plugs are designed for use in the US. Outlets and voltage differ internationally and this product may require an adapter or converter for use in your destination. Please check compatibility before purchasing.",


                },
                 new Product()
                {
                    Id = 6,
                    Name = "New & Refurbished Gym & Fitness Equipment For Sale",
                    ImageUrl = "https://www.fitnesssuperstore.com/v/vspfiles/templates/fitness-resp/images/homepage/product-slider/precor-ellipticals.jpg",
                    Mark = "Force USA G20.",
                    Price = 150,
                    Description = "At Fitness Superstore, we have the most rigorous remanufacturing process in the industry. All machines are disassembled, sand blasted, and repainted. Parts, belts, bearings, and batteries are replaced on every machine. All other parts that are worn more that 25% are replaced. We guarantee (Covered by our Warranty) your machine to be in “like new” working and “close to new” cosmetic condition. Click Play on the video below for through details.",
                },
                   new Product()
                {
                    Id = 7,
                    Name = "Smith Machine",
                    ImageUrl = "https://cdn3.volusion.com/aqyor.dadrn/v/vspfiles/photos/FF-FSR100-2.jpg?v-cache=1682102760",
                    Mark = "Force USA G20.",
                    Price = 880,
                    Description = "The French Fitness FSR100 Commercial Functional Smith Rack System features an innovative structure that combines arm and leg stations for strengthening different muscle groups and executing comprehensive workouts, limiting the need to switch between gym equipment. The FSR100 is a complete training system made with a heavy-duty steel frame reinforced with a durable powder-coated finish. Utilizes sturdy aircraft cable with a tensile strength of 2,000lb that's guaranteed to withstand intense long-lasting use. Standard weight horns let you organize weights on the machine for easy accessibility. Engage in intense weightlifting or strength training right in the comfort of your home with the French Fitness FSR100 Commercial Functional Smith Rack System.",
                   },
                   new Product()
                {
                    Id = 8,
                    Name = "Body-Solid G9S Selectorized",
                    ImageUrl = "https://cdn3.volusion.com/aqyor.dadrn/v/vspfiles/photos/bsldG9S-2.jpg?v-cache=1669221040",
                    Mark = "American Musle",
                    Price = 880,
                    Description = "This multi-station workhorse provides health club quality strength training for up to three people simultaneously (with optional GKR9). The G9 series of gyms features a multi-function Press Arm Station for bench press, incline press, shoulder press and chest supported mid row exercises. The Perfect Pec Station with fully adjustable range of motion allows users to achieve deeper muscle penetration for faster, more defined results. The Leg Press/ Calf Press Station operates on its own separate weight stack, with a 2 to 1 weight ratio, giving the G9 Gyms the awesome capacity of a 420 lb leg press. Add the optional Vertical Knee Raise / Dip Station (GKR9) and up to three people can workout simultaneously on the G9S.",
                },
                   new Product()
                {
                    Id = 9,
                    Name = "French Fitness FL70 Freeweight",
                    ImageUrl = "https://cdn11.bigcommerce.com/s-47lrg8qzg0/images/stencil/500x659/products/16275/375950/ff-x10__80072.1698736148.jpg?c=1",
                    Mark = "Olympic Weight",
                    Price = 1999,
                    Description = "The French Fitness FL70 Freeweight Leverage Gym System is a multifunctional training device that can be used by three people at the same time. The FL70 guarantees a complete heavy-duty workout without the need for a spotter. Perform high pulls, kicks, biceps/triceps, standing calves, press training and a lot more on this versatile leverage free weight gym.",
                },
                   new Product()
                {
                    Id = 10,
                    Name = "Venum Aero Body Fitness Gloves Black Pink",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/401178608/930x1240x3/venum-venum-aero-body-fitness-gloves-black-pink.jpg",
                    Mark = "Venum",
                    Price = 34.95M,
                    Description = "Equipped with the Venum Gel Shock system, these Venum Body fitness gloves offer effective protection and shock absorption, so that you are comfortable during all phases of training.",
                },
                   new Product()
                {
                    Id = 11,
                    Name = "Venum Challenger Resistance Band Purple",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/360675752/930x1240x3/venum-venum-challenger-resistance-band-purple-22-3.jpg",
                    Mark = "Venum",
                    Price = 34.60M,
                    Description = "These multi-purpose resistance bands are light and very easily transportable. These are muscle building accessories that, depending on the use and the resistance chosen, will help develop your strength, flexibility or mobility.",
                },
                   new Product()
                {
                    Id = 12,
                    Name = "Challenger ABS Wheel",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/348996905/930x1240x3/venum-venum-challenger-abs-wheel-yellow-black-venu.jpg",
                    Mark = "Venum",
                    Price = 19.99M,
                    Description = "Isolating and recruiting every muscle within your core, the Venu Challenger abdominal wheel is a strength accessory used to build endurance, simple but incredibly effective.",
                },
                   new Product()
                {
                    Id = 13,
                    Name = "Bad Boy MMA Fightshorts Capo 2 White",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/422027250/466x544x1/image.jpg",
                    Mark = "Bad Boy",
                    Price = 19.99M,
                    Description = "Bad Boy has been involved in the sport since the early nineties and is one of the original supporters of mixed martial arts and Jiu Jitsu tournaments.",
                },
                   new Product()
                {
                    Id = 14,
                    Name = "Booster Boxing Gloves Pro Shield 3 Green",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/395465361/466x544x1/image.jpg",
                    Mark = "Booster",
                    Price = 129.00M,
                    Description = "Booster Boxing Gloves Pro Shield 3 Green.  Booster Boxing Gloves Pro Shield are a Top quality 100% handmade in Thailand genuine leather professional sparring and training gloves by Booster Fightgear.   Multi-layered high and low density foam core ensures the best protection for the knuckles and maximizes impact dispersion for ultimate fighter protection on the wrist.  Booster Pro Shield are made with a full +/- 8cm wide Velcro closure to ensure proper wrist support. Extra padded palm for increased support and added defensive protection   The interior lining is made to dry quickly to help rid the gloves of moisture and perspiration   Booster Pro Range Boxing Gloves are double stitched for extra durability with perfectly positioned attached thumb .  These gloves meet international standards and offer incredible results.  Specification’s Booster Boxing Gloves Pro Shield :  • Booster Kickboxing Gloves are Handmade in Thailand. • Attached thumb for extra safety. Booster Fight Gear Europe. • Durable Long Lasting Velcro closure. • 100% A-grade Cowhide Thai leather.",
                },
                   new Product()
                {
                    Id = 15,
                    Name = "Rafter Sweatshirt Dark Heather Grey",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/421682446/930x1240x3/venum-venum-rafter-sweatshirt-dark-heather-grey.jpg",
                    Mark = "Venum",
                    Price = 49.95M,
                    Description = "Venum Rafter Sweatshirt Dark Heather Grey.  The Venum Rafter sweatshirt is an ultra comfortable fleece crewneck.  The 3D printing on the chest gives an original relief to this sweatshirt, which can be worn with jeans as well as with the Venum Rafter jogging pants.  The design marks a notable graphic evolution compared to previous collections.  Specification's Venum Rafter Sweatshirt :  • 55% Cotton / 45% Polyester • Fleece lining • Jacquard bands • Embroidered Venum logo • 3D printing • Straight cut • Machine wash at 30 °: do not iron or tumble dry",
                },
                   new Product()
                {
                    Id = 16,
                    Name = "Hayabusa Kanpeki T3 LX Hybrid Sparring Gloves 7oz ",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/323824938/930x1240x3/hayabusa-hayabusa-kanpeki-t3-lx-hybrid-sparring-gl.jpg",
                    Mark = "Hayabusa",
                    Price = 142.99M,
                    Description = "Hayabusa Kanpeki T3 LX Hybrid Sparring Gloves 7oz Italian Leather.  The Next Generation Of Kanpeki: The Hayabusa T3 LX 7oz MMA Gloves. Luxurious full-grain Italian leather.  Hayabusa Kanpeki T3 LX MMA Hybrids Sparring Gloves combine the best of both worlds.  For Fitness:  Maximize your high intensity interval training by going from the punching bag to the skipping rope, to crunches with a medicine ball and back to the bag.  For MMA:  The padding you need for heavy bag work with the flexibility of an open palm glove. This glove allows you to go from striking to grappling with ease while staying in place the whole time.  PERFECT FIT AND FEEL  The multi-directional Dual-X closure is unmatched when it comes to hand and wrist stabilization for the best protection and injury prevention possible.  INDUSTRY-LEADING WRIST SUPPORT  The best closure system ever created. Hayabusa’s patented wrist support technology helps eliminate hand strain to ensure the best in protection and safety.  CONSISTENT PERFORMANCE AND DURABILITY, PUNCH AFTER PUNCH  Hayabusa gloves are built to last. The attention to detail and craftsmanship guarantees a glove as resilient as the athletes who use it.",
                },
                   new Product()
                {
                    Id = 17,
                    Name = "Venum Koi Rashguard Long Sleeves Black Blue",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/433053093/930x1240x3/venum-venum-koi-rashguard-long-sleeves-black-blue.jpg",
                    Mark = "Venum",
                    Price = 59.95M,
                    Description = "Venum Koi Rashguard Long Sleeves Black Blue.  Expert Tip: Venum Rashguards have very tight Fit. If you want to be more comfortable, we advise you to take minimal one size more than you take for a classic compression top.  With its one-of-a-kind attention to detail, the Venum Koi Rashguard brings an exclusive quality design like no other.  Made with a blend of spandex and elastane, the Venum Koi Rashguard perfectly fits every curve of your body, which minimizes your opponents’ grasps during grappling as well as protecting you against cuts and other skin abrasions.  The distinctive Koi design is sublimated into the fabric and the seams have been specifically strengthened for longer lasting vibrant durability.  Day after day, fight after fight, dominate your opponent with the Venum Koi Rashguard.  Specification's Venum Koi Rash Guard :  • Composition: 35% Cotton 65% Polyester • Care instructions: Do not bleach, do not iron, do not tumble dry, machine wash at 30°C • Sport: MMA, Grappling, BJJ • Collar shape: Round neck • Pattern / Color: Printed • Extras: Quick drying • Additional information: Reinforced seams, Silicone elastic bands at the bottom, Protects from chafing and burning • Properties: Breathable, quick drying",
                },
                   new Product()
                {
                    Id = 18,
                    Name = "Venum Elite Boxing Gloves Microfiber White Silver",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/433528738/930x1240x3/venum-venum-elite-boxing-gloves-microfiber-white-s.jpg",
                    Mark = "Venum",
                    Price = 89.95M,
                    Description = "Venum Elite Boxing Gloves Microfiber White Silver.\r\n\r\nThe triple density foam balances the shock, improving you as a fighter without the stress on your arms during impacts.\r\n\r\nAssembled and hand-sewn in Thailand, these boxing gloves have been designed for regular and intensive use.\r\n\r\nThe unique design and brand new colors are fit for all the fighters, no matter their level.\r\n\r\nThe reinforced seams and mesh panels combined with their ergonomic shape will bring you a comfortable fit and feel as if you are truly one with the glove.\r\n\r\nSpecification's Venum Elite Boxing Gloves :\r\n\r\n• Fully handmade in Thailand\r\n• Premium semi leather construction\r\n• Specific mesh panel placed under the fist for great thermal regulation\r\n• Triple density foam\r\n• Reinforced palm for a maximum absorption\r\n• 100% full attached thumb for a better injury prevention\r\n• Strengthened seams for a long-lasting quality\r\n• Large Velcro enclosure\r\n• Long cuffs improving wrist protection",
                },
                   new Product()
                {
                    Id = 19,
                    Name = "Venum Power Training System Lite - PTS Lite",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/350147425/466x544x1/image.jpg",
                    Mark = "Venum",
                    Price = 99.99M,
                    Description = "The PTS Lite, or Venum Power Training System Lite is a lite version of the original PTS.\r\n\r\nIt is a modular exercise system that will allow you to develop your endurance as well as your strength and your durability.\r\n\r\nEasily transportable and attachable almost anywhere, the Venum PTS Lite adapts to athletes of all levels: the variety and intensity of the exercises is adjustable to your goals, your level and your favorite discipline.\r\n\r\nInstalling the Power Training System is quick and easy, in the gym as well as at home training.",
                },
                   new Product()
                {
                    Id = 20,
                    Name = "Punch Round Kids NoFear Kickboxing Shin Guards Black White",
                    ImageUrl = "https://cdn.webshopapp.com/shops/16221/files/327053024/375x500x2/punchr-punch-round-kids-nofear-kickboxing-shin-gua.jpg",
                    Mark = "Punch Round",
                    Price = 34.90M,
                    Description = "The Punch Round \"No-Fear\" kickboxing shin guards combine a good fit, high quality with good durability. They are made from a high-quality artificial leather. With a 3-layer shock-absorbing foam for optimum protection.\r\n\r\nThe attachment is made of 2 sturdy velcro closure for a good and lasting fit during training and sparring.",
                }
            };
            return product;
       }
                       
    }
}
