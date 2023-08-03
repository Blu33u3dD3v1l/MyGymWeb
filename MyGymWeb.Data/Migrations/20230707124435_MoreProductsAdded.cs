using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    public partial class MoreProductsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Mark",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "GymId", "ImageUrl", "Mark", "Name", "Price" },
                values: new object[,]
                {
                    { 6, "At Fitness Superstore, we have the most rigorous remanufacturing process in the industry. All machines are disassembled, sand blasted, and repainted. Parts, belts, bearings, and batteries are replaced on every machine. All other parts that are worn more that 25% are replaced. We guarantee (Covered by our Warranty) your machine to be in “like new” working and “close to new” cosmetic condition. Click Play on the video below for through details.", null, "https://www.fitnesssuperstore.com/v/vspfiles/templates/fitness-resp/images/homepage/product-slider/precor-ellipticals.jpg", "Force USA G20.", "New & Refurbished Gym & Fitness Equipment For Sale", 150m },
                    { 7, "The French Fitness FSR100 Commercial Functional Smith Rack System features an innovative structure that combines arm and leg stations for strengthening different muscle groups and executing comprehensive workouts, limiting the need to switch between gym equipment. The FSR100 is a complete training system made with a heavy-duty steel frame reinforced with a durable powder-coated finish. Utilizes sturdy aircraft cable with a tensile strength of 2,000lb that's guaranteed to withstand intense long-lasting use. Standard weight horns let you organize weights on the machine for easy accessibility. Engage in intense weightlifting or strength training right in the comfort of your home with the French Fitness FSR100 Commercial Functional Smith Rack System.", null, "https://cdn3.volusion.com/aqyor.dadrn/v/vspfiles/photos/FF-FSR100-2.jpg?v-cache=1682102760", "Force USA G20.", "Smith Machine", 880m },
                    { 8, "This multi-station workhorse provides health club quality strength training for up to three people simultaneously (with optional GKR9). The G9 series of gyms features a multi-function Press Arm Station for bench press, incline press, shoulder press and chest supported mid row exercises. The Perfect Pec Station with fully adjustable range of motion allows users to achieve deeper muscle penetration for faster, more defined results. The Leg Press/ Calf Press Station operates on its own separate weight stack, with a 2 to 1 weight ratio, giving the G9 Gyms the awesome capacity of a 420 lb leg press. Add the optional Vertical Knee Raise / Dip Station (GKR9) and up to three people can workout simultaneously on the G9S.", null, "https://cdn3.volusion.com/aqyor.dadrn/v/vspfiles/photos/bsldG9S-2.jpg?v-cache=1669221040", "American Musle", "Body-Solid G9S Selectorized", 880m },
                    { 9, "The French Fitness FL70 Freeweight Leverage Gym System is a multifunctional training device that can be used by three people at the same time. The FL70 guarantees a complete heavy-duty workout without the need for a spotter. Perform high pulls, kicks, biceps/triceps, standing calves, press training and a lot more on this versatile leverage free weight gym.", null, "https://cdn3.volusion.com/aqyor.dadrn/v/vspfiles/photos/FF-FL70-2.jpg?v-cache=1624149541", "Olympic Weight", "French Fitness FL70 Freeweight", 1999m },
                    { 10, "Equipped with the Venum Gel Shock system, these Venum Body fitness gloves offer effective protection and shock absorption, so that you are comfortable during all phases of training.", null, "https://cdn.webshopapp.com/shops/16221/files/401178608/930x1240x3/venum-venum-aero-body-fitness-gloves-black-pink.jpg", "Venum", "Venum Aero Body Fitness Gloves Black Pink", 34.95m },
                    { 11, "These multi-purpose resistance bands are light and very easily transportable. These are muscle building accessories that, depending on the use and the resistance chosen, will help develop your strength, flexibility or mobility.", null, "https://cdn.webshopapp.com/shops/16221/files/360675752/930x1240x3/venum-venum-challenger-resistance-band-purple-22-3.jpg", "Venum", "Venum Challenger Resistance Band Purple", 34.60m },
                    { 12, "Isolating and recruiting every muscle within your core, the Venu Challenger abdominal wheel is a strength accessory used to build endurance, simple but incredibly effective.", null, "https://cdn.webshopapp.com/shops/16221/files/348996905/930x1240x3/venum-venum-challenger-abs-wheel-yellow-black-venu.jpg", "Venum", "Challenger ABS Wheel", 19.99m },
                    { 13, "Bad Boy has been involved in the sport since the early nineties and is one of the original supporters of mixed martial arts and Jiu Jitsu tournaments.", null, "https://cdn.webshopapp.com/shops/16221/files/422027250/466x544x1/image.jpg", "Bad Boy", "Bad Boy MMA Fightshorts Capo 2 White", 19.99m },
                    { 14, "Booster Boxing Gloves Pro Shield 3 Green.  Booster Boxing Gloves Pro Shield are a Top quality 100% handmade in Thailand genuine leather professional sparring and training gloves by Booster Fightgear.   Multi-layered high and low density foam core ensures the best protection for the knuckles and maximizes impact dispersion for ultimate fighter protection on the wrist.  Booster Pro Shield are made with a full +/- 8cm wide Velcro closure to ensure proper wrist support. Extra padded palm for increased support and added defensive protection   The interior lining is made to dry quickly to help rid the gloves of moisture and perspiration   Booster Pro Range Boxing Gloves are double stitched for extra durability with perfectly positioned attached thumb .  These gloves meet international standards and offer incredible results.  Specification’s Booster Boxing Gloves Pro Shield :  • Booster Kickboxing Gloves are Handmade in Thailand. • Attached thumb for extra safety. Booster Fight Gear Europe. • Durable Long Lasting Velcro closure. • 100% A-grade Cowhide Thai leather.", null, "https://cdn.webshopapp.com/shops/16221/files/395465361/466x544x1/image.jpg", "Booster", "Booster Boxing Gloves Pro Shield 3 Green", 129.00m },
                    { 15, "Venum Rafter Sweatshirt Dark Heather Grey.  The Venum Rafter sweatshirt is an ultra comfortable fleece crewneck.  The 3D printing on the chest gives an original relief to this sweatshirt, which can be worn with jeans as well as with the Venum Rafter jogging pants.  The design marks a notable graphic evolution compared to previous collections.  Specification's Venum Rafter Sweatshirt :  • 55% Cotton / 45% Polyester • Fleece lining • Jacquard bands • Embroidered Venum logo • 3D printing • Straight cut • Machine wash at 30 °: do not iron or tumble dry", null, "https://cdn.webshopapp.com/shops/16221/files/421682446/930x1240x3/venum-venum-rafter-sweatshirt-dark-heather-grey.jpg", "Venum", "Rafter Sweatshirt Dark Heather Grey", 49.95m },
                    { 16, "Hayabusa Kanpeki T3 LX Hybrid Sparring Gloves 7oz Italian Leather.  The Next Generation Of Kanpeki: The Hayabusa T3 LX 7oz MMA Gloves. Luxurious full-grain Italian leather.  Hayabusa Kanpeki T3 LX MMA Hybrids Sparring Gloves combine the best of both worlds.  For Fitness:  Maximize your high intensity interval training by going from the punching bag to the skipping rope, to crunches with a medicine ball and back to the bag.  For MMA:  The padding you need for heavy bag work with the flexibility of an open palm glove. This glove allows you to go from striking to grappling with ease while staying in place the whole time.  PERFECT FIT AND FEEL  The multi-directional Dual-X closure is unmatched when it comes to hand and wrist stabilization for the best protection and injury prevention possible.  INDUSTRY-LEADING WRIST SUPPORT  The best closure system ever created. Hayabusa’s patented wrist support technology helps eliminate hand strain to ensure the best in protection and safety.  CONSISTENT PERFORMANCE AND DURABILITY, PUNCH AFTER PUNCH  Hayabusa gloves are built to last. The attention to detail and craftsmanship guarantees a glove as resilient as the athletes who use it.", null, "https://cdn.webshopapp.com/shops/16221/files/323824938/930x1240x3/hayabusa-hayabusa-kanpeki-t3-lx-hybrid-sparring-gl.jpg", "Hayabusa", "Hayabusa Kanpeki T3 LX Hybrid Sparring Gloves 7oz ", 142.99m },
                    { 17, "Venum Koi Rashguard Long Sleeves Black Blue.  Expert Tip: Venum Rashguards have very tight Fit. If you want to be more comfortable, we advise you to take minimal one size more than you take for a classic compression top.  With its one-of-a-kind attention to detail, the Venum Koi Rashguard brings an exclusive quality design like no other.  Made with a blend of spandex and elastane, the Venum Koi Rashguard perfectly fits every curve of your body, which minimizes your opponents’ grasps during grappling as well as protecting you against cuts and other skin abrasions.  The distinctive Koi design is sublimated into the fabric and the seams have been specifically strengthened for longer lasting vibrant durability.  Day after day, fight after fight, dominate your opponent with the Venum Koi Rashguard.  Specification's Venum Koi Rash Guard :  • Composition: 35% Cotton 65% Polyester • Care instructions: Do not bleach, do not iron, do not tumble dry, machine wash at 30°C • Sport: MMA, Grappling, BJJ • Collar shape: Round neck • Pattern / Color: Printed • Extras: Quick drying • Additional information: Reinforced seams, Silicone elastic bands at the bottom, Protects from chafing and burning • Properties: Breathable, quick drying", null, "https://cdn.webshopapp.com/shops/16221/files/433053093/930x1240x3/venum-venum-koi-rashguard-long-sleeves-black-blue.jpg", "Venum", "Venum Koi Rashguard Long Sleeves Black Blue", 59.95m },
                    { 18, "Venum Elite Boxing Gloves Microfiber White Silver.\r\n\r\nThe triple density foam balances the shock, improving you as a fighter without the stress on your arms during impacts.\r\n\r\nAssembled and hand-sewn in Thailand, these boxing gloves have been designed for regular and intensive use.\r\n\r\nThe unique design and brand new colors are fit for all the fighters, no matter their level.\r\n\r\nThe reinforced seams and mesh panels combined with their ergonomic shape will bring you a comfortable fit and feel as if you are truly one with the glove.\r\n\r\nSpecification's Venum Elite Boxing Gloves :\r\n\r\n• Fully handmade in Thailand\r\n• Premium semi leather construction\r\n• Specific mesh panel placed under the fist for great thermal regulation\r\n• Triple density foam\r\n• Reinforced palm for a maximum absorption\r\n• 100% full attached thumb for a better injury prevention\r\n• Strengthened seams for a long-lasting quality\r\n• Large Velcro enclosure\r\n• Long cuffs improving wrist protection", null, "https://cdn.webshopapp.com/shops/16221/files/433528738/930x1240x3/venum-venum-elite-boxing-gloves-microfiber-white-s.jpg", "Venum", "Venum Elite Boxing Gloves Microfiber White Silver", 89.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Mark",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
