using Microsoft.Data.SqlClient;
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
                ImageUrl = "https://drberg.in/368-large_default/-shaker-bottle.jpg",
                Mark = "Urban Fitness",
                Price = 27,
                Description = "The UFE 2in1 Protein Shaker is a premium shaker that is BPA, BPS and BPF free. The Shaker has a 700ml capacity and comes complete dual mixing.",


            },
             new Product()
             {
                 Id = 3,
                 Name = "The Fitness Gloves",
                 ImageUrl = "https://elephantskin.com/wp-content/uploads/2024/05/ElephantSkin_CHAMPION_0002_Ebene-1_1800x1800.png-500x500.webp",
                 Mark = "ElephantSkin Fitness",
                 Price = 17,
                 Description = "ElephantSkin gloves are designed for (hobby) athletes who do not want to compromise on hygiene during their training.More training, less cleaning - that's the concept behind ElephantSkin's sustainable fitness glove.",


             },
              new Product()
              {
                  Id = 4,
                  Name = "Pro Nutrition and Fitness",
                  ImageUrl = "https://gonobs.com/cdn/shop/files/raging-whey-listing-creative-1.png?v=1696973140",
                  Mark = "Life Pro",
                  Price = 61,
                  Description = "Whey Gourmet Edition 2kg Life Pro is a supplement based on whey concentrate, which has exceptional nutritional values and is part of the Gourmet line of flavours. Life Pro's Gourmet line is characterised by a variety of very successful, exclusive and delicious flavours. Life Pro Whey Gourmet Edition 2kg is designed to help you meet your daily protein requirements, maintain a healthy lifestyle and enjoy every shake. It has a protein concentration of between 72% and 77% in its composition (depending on the flavour selected). In addition, you can now enjoy your favourite Gourmet flavour in 3 different formats: 30g, 900g and 2kg.",


              },
                new Product()
                {
                    Id = 5,
                    Name = "L-Carnitine 3000",
                    ImageUrl = "https://proteinhouse.mu/cdn/shop/files/nutrex-research-l-carnitine-3000-698006.png?v=1723805951&width=1445",
                    Mark = "Nutrex Research",
                    Price = 14,
                    Description = "Let L-Carnitine support your metabolism and endurance by tapping into your body's fuel reserves - turning your fat into energy. Take advantage of L-Carnitine's lipid-metabolizing power, that helps transport fat out of your system. It's the perfect addition to your diet and fitness program.Boost It Up Get a lean body and stay toned! L-Carnitine helps shuttle fatty acids to your muscles so they can be burnt as energy during exercise. Conquer fatigue by delaying muscle soreness so you can train longer! Amplify your performance! Enhance cellular energy production for max physical output. Suggested use Shake well before opening. Consume 1 serving at any time of the day between meals. On training days, consume 1 serving 30 minutes before exercise. Regular exercise and proper nutrition are essential components for achieving your diet and fitness goals. As individuals vary so may results from using this product.",


                },
                 new Product()
                {
                    Id = 6,
                    Name = "New & Refurbished Gym & Fitness Equipment For Sale",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREDhyUn0XH7qNDvKI21WGxL3SZ7d5ftwtsB_M3lTGhGI15hej4aYNE4Is046eHI6DrtL0&usqp=CAU",
                    Mark = "Force USA G20.",
                    Price = 150,
                    Description = "At Fitness Superstore, we have the most rigorous remanufacturing process in the industry. All machines are disassembled, sand blasted, and repainted. Parts, belts, bearings, and batteries are replaced on every machine. All other parts that are worn more that 25% are replaced. We guarantee (Covered by our Warranty) your machine to be in “like new” working and “close to new” cosmetic condition. Click Play on the video below for through details.",
                },
                   new Product()
                {
                    Id = 7,
                    Name = "Smith Machine",
                    ImageUrl = "https://www.johnsonfitness.com.au/cdn/shop/products/MX22_MAGNUMMG-PL62-03smithmachine_MatteBlk_hero_lores.jpg?v=1665704942",
                    Mark = "Force USA G20.",
                    Price = 880,
                    Description = "The French Fitness FSR100 Commercial Functional Smith Rack System features an innovative structure that combines arm and leg stations for strengthening different muscle groups and executing comprehensive workouts, limiting the need to switch between gym equipment. The FSR100 is a complete training system made with a heavy-duty steel frame reinforced with a durable powder-coated finish. Utilizes sturdy aircraft cable with a tensile strength of 2,000lb that's guaranteed to withstand intense long-lasting use. Standard weight horns let you organize weights on the machine for easy accessibility. Engage in intense weightlifting or strength training right in the comfort of your home with the French Fitness FSR100 Commercial Functional Smith Rack System.",
                   },
                   new Product()
                {
                    Id = 8,
                    Name = "Body-Solid G9S Selectorized",
                    ImageUrl = "https://www.ironcompany.com/media/catalog/product/cache/0497f845716ff9ff5fb3d560ec6f3888/b/o/body_solid_g9s_2_stack_gym_for_home_or_light_commercial_spaces.png",
                    Mark = "American Musle",
                    Price = 880,
                    Description = "This multi-station workhorse provides health club quality strength training for up to three people simultaneously (with optional GKR9). The G9 series of gyms features a multi-function Press Arm Station for bench press, incline press, shoulder press and chest supported mid row exercises. The Perfect Pec Station with fully adjustable range of motion allows users to achieve deeper muscle penetration for faster, more defined results. The Leg Press/ Calf Press Station operates on its own separate weight stack, with a 2 to 1 weight ratio, giving the G9 Gyms the awesome capacity of a 420 lb leg press. Add the optional Vertical Knee Raise / Dip Station (GKR9) and up to three people can workout simultaneously on the G9S.",
                },
                   new Product()
                {
                    Id = 9,
                    Name = "French Fitness FL70 Freeweight",
                    ImageUrl = "https://cdn11.bigcommerce.com/s-47lrg8qzg0/images/stencil/640w/products/16275/378734/ff-x10__12566.1700116344.jpg?c=1",
                    Mark = "Olympic Weight",
                    Price = 1999,
                    Description = "The French Fitness FL70 Freeweight Leverage Gym System is a multifunctional training device that can be used by three people at the same time. The FL70 guarantees a complete heavy-duty workout without the need for a spotter. Perform high pulls, kicks, biceps/triceps, standing calves, press training and a lot more on this versatile leverage free weight gym.",
                },
                   new Product()
                {
                    Id = 10,
                    Name = "Venum Aero Body Fitness Gloves Black Pink",
                    ImageUrl = "https://f.nooncdn.com/p/pzsku/ZA596E824F4FF23EB0D32Z/45/_/1737458392/ae70680d-5d9c-426c-9cde-24382d53f0ca.jpg?width=240",
                    Mark = "Venum",
                    Price = 34.95M,
                    Description = "Equipped with the Venum Gel Shock system, these Venum Body fitness gloves offer effective protection and shock absorption, so that you are comfortable during all phases of training.",
                },
                   new Product()
                {
                    Id = 11,
                    Name = "Bad Boy Classic Mens White Training MMA Fight Shorts BJJ",
                    ImageUrl = "https://i.ebayimg.com/images/g/8UUAAOSwezxlAxYz/s-l1200.jpg",
                    Mark = "Bad Boy",
                    Price = 34.60M,
                    Description = "Experience superior performance with the Bad Boy Classic Vale Tudo Shorts. Designed to work as hard as you do, these shorts are more than just clothing - they're a second skin, moving seamlessly with your body without any restrictions.Crafted from a stretchy, sweat-wicking fabric, they help improve blood circulation, boosting your muscle performance to new heights. Plus, they keep you dry and comfortable, whether you're in the middle of a fight or an intense workout. With a customized fit thanks to the elastic waistband and inner drawstrings, these shorts stay perfectly in place, so you can focus on what really matters - your performance.",
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
                    Name = "Bad Boy Core Logo T-Shirt Black",
                    ImageUrl = "https://minotaurfightstore.co.uk/wp-content/uploads/2023/03/BADBOY_Tee_BBC00003_Black_1.jpg",
                    Mark = "Bad Boy",
                    Price = 19.99M,
                    Description = "Composition: 92% polyester, 8% elastane Lightweight fast drying fabric to keep you dry and comfortable Stretchy fibre for exceptional mobility Raglan sleeves design for superior range of motion Flat seams for smooth sensation against your skin",
                },
                   new Product()
                {
                    Id = 14,
                    Name = "Booster Boxing Gloves Pro Shield 3 Green",
                    ImageUrl = "https://kingfightstore.nl/cdn/shop/files/gr3.jpg?v=1742221007&width=630",
                    Mark = "Booster",
                    Price = 129.00M,
                    Description = "Booster Boxing Gloves Pro Shield 3 Green.  Booster Boxing Gloves Pro Shield are a Top quality 100% handmade in Thailand genuine leather professional sparring and training gloves by Booster Fightgear.   Multi-layered high and low density foam core ensures the best protection for the knuckles and maximizes impact dispersion for ultimate fighter protection on the wrist.  Booster Pro Shield are made with a full +/- 8cm wide Velcro closure to ensure proper wrist support. Extra padded palm for increased support and added defensive protection   The interior lining is made to dry quickly to help rid the gloves of moisture and perspiration   Booster Pro Range Boxing Gloves are double stitched for extra durability with perfectly positioned attached thumb .  These gloves meet international standards and offer incredible results.  Specification’s Booster Boxing Gloves Pro Shield :  • Booster Kickboxing Gloves are Handmade in Thailand. • Attached thumb for extra safety. Booster Fight Gear Europe. • Durable Long Lasting Velcro closure. • 100% A-grade Cowhide Thai leather.",
                },
                   new Product()
                {
                    Id = 15,
                    Name = "Spandex Base Layer for Gym, Training & Combat Sports",
                    ImageUrl = "https://img4.dhresource.com/webp/m/0x0/f3/albu/jc/g/21/9c17be60-10cf-4556-9ff7-78ca7c066565.jpg",
                    Mark = "Cody",
                    Price = 49.95M,
                    Description = "Experience unrestricted movement with this athletic compression top, meticulously crafted from a high-performance spandex blend that offers a second-skin fit, ideal for intense training sessions and competitive events.\r\nStay cool and dry during your toughest workouts; the advanced moisture-wicking technology efficiently draws sweat away from the skin, keeping you comfortable and focused on your performance.\r\nEngineered for durability, this base layer is constructed with reinforced stitching to withstand the rigors of grappling, striking, and high-impact exercises, ensuring long-lasting wear and tear resistance.\r\nDesigned with a streamlined, ergonomic fit, this compression top supports your muscles and enhances blood flow, promoting faster recovery and reduced muscle fatigue after strenuous activity, making it suitable as jiu jitsu shirts.\r\nEnjoy complete freedom of movement during any activity; the four-way stretch fabric allows for a full range of motion, enabling you to execute complex techniques and movements with ease and precision.",
                },
                   new Product()
                {
                    Id = 16,
                    Name = "Hayabusa Kanpeki T3 LX Hybrid Sparring Gloves 7oz ",
                    ImageUrl = "https://aagsport.com/cdn/shop/products/pKhP5YsPvYT5lvLmL8Shl1Yz-700x700_480x480.jpg",
                    Mark = "Hayabusa",
                    Price = 142.99M,
                    Description = "Hayabusa Kanpeki T3 LX Hybrid Sparring Gloves 7oz Italian Leather.  The Next Generation Of Kanpeki: The Hayabusa T3 LX 7oz MMA Gloves. Luxurious full-grain Italian leather.  Hayabusa Kanpeki T3 LX MMA Hybrids Sparring Gloves combine the best of both worlds.  For Fitness:  Maximize your high intensity interval training by going from the punching bag to the skipping rope, to crunches with a medicine ball and back to the bag.  For MMA:  The padding you need for heavy bag work with the flexibility of an open palm glove. This glove allows you to go from striking to grappling with ease while staying in place the whole time.  PERFECT FIT AND FEEL  The multi-directional Dual-X closure is unmatched when it comes to hand and wrist stabilization for the best protection and injury prevention possible.  INDUSTRY-LEADING WRIST SUPPORT  The best closure system ever created. Hayabusa’s patented wrist support technology helps eliminate hand strain to ensure the best in protection and safety.  CONSISTENT PERFORMANCE AND DURABILITY, PUNCH AFTER PUNCH  Hayabusa gloves are built to last. The attention to detail and craftsmanship guarantees a glove as resilient as the athletes who use it.",
                },
                   new Product()
                {
                    Id = 17,
                    Name = "Venum Koi Rashguard Long Sleeves Black Blue",
                    ImageUrl = "https://www.thefightfactory.com.au/cdn/shop/products/cl-sport-longsleeve-rash-guard-cl-sport-tropics-rashguard-long-sleeve-blue-30570066608171_760x.png?v=1721166388%27",
                    Mark = "Venum",
                    Price = 59.95M,
                    Description = "Venum Koi Rashguard Long Sleeves Black Blue.  Expert Tip: Venum Rashguards have very tight Fit. If you want to be more comfortable, we advise you to take minimal one size more than you take for a classic compression top.  With its one-of-a-kind attention to detail, the Venum Koi Rashguard brings an exclusive quality design like no other.  Made with a blend of spandex and elastane, the Venum Koi Rashguard perfectly fits every curve of your body, which minimizes your opponents’ grasps during grappling as well as protecting you against cuts and other skin abrasions.  The distinctive Koi design is sublimated into the fabric and the seams have been specifically strengthened for longer lasting vibrant durability.  Day after day, fight after fight, dominate your opponent with the Venum Koi Rashguard.  Specification's Venum Koi Rash Guard :  • Composition: 35% Cotton 65% Polyester • Care instructions: Do not bleach, do not iron, do not tumble dry, machine wash at 30°C • Sport: MMA, Grappling, BJJ • Collar shape: Round neck • Pattern / Color: Printed • Extras: Quick drying • Additional information: Reinforced seams, Silicone elastic bands at the bottom, Protects from chafing and burning • Properties: Breathable, quick drying",
                },
                   new Product()
                {
                    Id = 18,
                    Name = "Venum Elite Boxing Gloves Microfiber White Silver",
                    ImageUrl = "https://eu.venum.com/cdn/shop/files/a509146d1d982199d9b22789bb3414a5f84d8073_VENUM_0984_210_1.jpg?v=1744031393",
                    Mark = "Venum",
                    Price = 89.95M,
                    Description = "Venum Elite Boxing Gloves Microfiber White Silver.\r\n\r\nThe triple density foam balances the shock, improving you as a fighter without the stress on your arms during impacts.\r\n\r\nAssembled and hand-sewn in Thailand, these boxing gloves have been designed for regular and intensive use.\r\n\r\nThe unique design and brand new colors are fit for all the fighters, no matter their level.\r\n\r\nThe reinforced seams and mesh panels combined with their ergonomic shape will bring you a comfortable fit and feel as if you are truly one with the glove.\r\n\r\nSpecification's Venum Elite Boxing Gloves :\r\n\r\n• Fully handmade in Thailand\r\n• Premium semi leather construction\r\n• Specific mesh panel placed under the fist for great thermal regulation\r\n• Triple density foam\r\n• Reinforced palm for a maximum absorption\r\n• 100% full attached thumb for a better injury prevention\r\n• Strengthened seams for a long-lasting quality\r\n• Large Velcro enclosure\r\n• Long cuffs improving wrist protection",
                },
                   new Product()
                {
                    Id = 19,
                    Name = "Venum Power Training System Lite - PTS Lite",
                    ImageUrl = "https://www.venum.com/cdn/shop/products/a_252Fc_252F9_252Fd_252Fac9db668ba094dea00e671838375208e3a323fcb_PTS_LIGHT_SD_02.jpg?v=1658483964&width=1946",
                    Mark = "Venum",
                    Price = 99.99M,
                    Description = "The PTS Lite, or Venum Power Training System Lite is a lite version of the original PTS.\r\n\r\nIt is a modular exercise system that will allow you to develop your endurance as well as your strength and your durability.\r\n\r\nEasily transportable and attachable almost anywhere, the Venum PTS Lite adapts to athletes of all levels: the variety and intensity of the exercises is adjustable to your goals, your level and your favorite discipline.\r\n\r\nInstalling the Power Training System is quick and easy, in the gym as well as at home training.",
                },
                   new Product()
                {
                    Id = 20,
                    Name = "Children's Shin Guards Without Foot Protection Cyborg",
                    ImageUrl = "https://static2.groundgame.com/hpeciai/4c3e2722b4b5b934246f2e5942b0b6ed/pol_il_Dzieciece-ochraniacze-piszczeli-bez-stopy-Cyborg-Czarne-1649.jpg",
                    Mark = "Punch Round",
                    Price = 34.90M,
                    Description = "Children's shin guards without a protective panel on the instep for kickboxing training. The shin guards are comfortable to wear and, thanks to their fastening with 2 wide Velcro straps, they adapt perfectly to the shape of the leg. The thick foam padding does an excellent job of absorbing impact force, protecting the shins from injury. The material on the inside is skin-friendly and minimises the risk of abrasions. The classic design makes the pads fit in with the rest of your training outfit and equipment.",
                }
            };
            return product;
       }
                       
    }
}
