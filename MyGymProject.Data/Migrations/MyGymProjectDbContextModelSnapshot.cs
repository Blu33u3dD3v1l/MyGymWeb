﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyGymWeb.Data;

#nullable disable

namespace MyGymWeb.Data.Migrations
{
    [DbContext(typeof(MyGymProjectDbContext))]
    partial class MyGymProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.GroupEvents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EventTime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GroupTrainerNamesId")
                        .HasColumnType("int");

                    b.Property<int?>("GymId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupTrainerNamesId");

                    b.HasIndex("GymId");

                    b.HasIndex("TypeId");

                    b.ToTable("GroupEvents");
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.GroupTrainerName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("GroupTrainerNames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Desy Perez"
                        },
                        new
                        {
                            Id = 2,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kevin Friend"
                        });
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Gym", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AthleteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AthleteId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Gyms");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Description = "This Gym is most popular and most exclusive  private 1 on 1 and group boxing training facility! All of our classes are taught by world-class coaches in a fun and friendly environment. Hybrid offers both Boxing and Muay Thai Kickboxing semi-private classes which focus on proper boxing technique, kicking technique, shadow boxing drills, 1-on-1 mitt work, bag work, and High Intensity Interval Training so you can get amazing results in the fastest time possible. We cap all classes at 6 participants for a more personal group training experience. Burn over 500 calories per class.",
                            ImageUrl = "https://e0.pxfuel.com/wallpapers/668/410/desktop-wallpaper-boxing-for-resolution-boxing-boxeo.jpg",
                            Name = "BoxingGym",
                            Type = "BigBoxGym"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is not just gyms, nor ordinary spa. This is the unique lifestyle club in our country – places where, together with our club members, we realize our common vision of a meaningful life. What is it? To achieve change, health, personal balance and satisfaction through sport in a convenient and accessible way, saving time and effort, but without compromising the rhythm of the big city. Dynamically and purposefully, not with compulsion or with annoyance, but jointly, with fun and at with own pace. Each one of the clubs has a unique interior design, prepared by Pro Design Interiors.",
                            ImageUrl = "https://rare-gallery.com/uploads/posts/585296-adult-barbell.jpg",
                            Name = "BodyBuilding",
                            Type = "ClassicGym"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The Pilates method, with its proven beneficial effect on the body, is preferred as a training activity among a large number of ladies. The exercises are performed smoothly, with maximum control in each movement to avoid injuries and achieve the desired results. With regular exercise, you can improve your posture, even your gait. It is a unique system of exercises for stretching and strength, strengthening and toning muscles. No exercise is an end in itself, all the muscles of the body are activated. You will strengthen your muscles and shape your body so that it looks even more graceful, tight and beautiful. Pain in the neck and back is especially affected.By following the exact instructions, at the end of the workout you will feel your body toned and pleasantly relaxed.",
                            ImageUrl = "https://fitathletic.com/wp-content/uploads/2014/07/fit_athletic_blog_reformer-pilates-1.jpg",
                            Name = "PilatesGym",
                            Type = "PilatesGym"
                        },
                        new
                        {
                            Id = 5,
                            Description = "You are about to pass through the many dimensions of your own Self. This journey will take you through a transformation of consciousness, across a vital bridge connecting spirit and matter, Heaven and Earth, mind and body. And as you transform yourself, you transform the world.We are committed to providing you with the tools to support you on your journey to a full spectrum yoga experience.We will be glad to meet you!",
                            ImageUrl = "https://previews.123rf.com/images/popunderlight/popunderlight1801/popunderlight180100251/92852319-portrait-of-attractive-asian-girl-doing-yoga-exercise-in-gym.jpg",
                            Name = "YogaGym",
                            Type = "YogaGym"
                        });
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GymId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GymId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Introducing our sleek and stylish protein shaker bottle - the perfect companion for your workouts and active lifestyle!, Crafted with a perfect size.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0572/7397/4993/products/ShakerBanner_1_1080x.jpg?v=1676866459",
                            Mark = "WolvesFitness",
                            Name = "Wolves Fitness Shaker Bottle",
                            Price = 30
                        },
                        new
                        {
                            Id = 2,
                            Description = "The UFE 2in1 Protein Shaker is a premium shaker that is BPA, BPS and BPF free. The Shaker has a 700ml capacity and comes complete dual mixing.",
                            ImageUrl = "https://files.ekmcdn.com/alphasports86/images/urban-fitness-2in1-protein-shaker-700ml--2023-p.jpg?v=6FB99E0C-5E66-4D39-B4E2-7384D9AB6276",
                            Mark = "Urban Fitness",
                            Name = "Urban Fitness 2in1 Protein Shaker",
                            Price = 27
                        },
                        new
                        {
                            Id = 3,
                            Description = "ElephantSkin gloves are designed for (hobby) athletes who do not want to compromise on hygiene during their training.More training, less cleaning - that's the concept behind ElephantSkin's sustainable fitness glove.",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0585/3016/9008/products/elephantskin-fitness-handschuhe-titelbild.png?v=1644683288",
                            Mark = "ElephantSkin Fitness",
                            Name = "The Fitness Gloves",
                            Price = 17
                        },
                        new
                        {
                            Id = 4,
                            Description = "Keep your hard-earned muscles fed, whether youre at home or at the gym. Stay fit & consistent with your protein supplementation & stay strong around the clock, in the gym or at home. Pro series whey has a scientific combination of whey isolate (fast) for immediate absorption and whey concentrate (slow digesting) to give feed your muscles for longer time a protein drink thats richer & tastier than any whey protein in india",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0233/6459/9885/products/51v0EC9aP5L._SL1080.jpg?v=1666270776",
                            Mark = "Goodlife",
                            Name = "Pro Nutrition and Fitness",
                            Price = 50
                        },
                        new
                        {
                            Id = 5,
                            Description = "Products with electrical plugs are designed for use in the US. Outlets and voltage differ internationally and this product may require an adapter or converter for use in your destination. Please check compatibility before purchasing.",
                            ImageUrl = "https://fitness1.bg/products/u/levrone-wellness-series-l-carnitine-125000-1-l-1786f0c.jpg",
                            Mark = "Goodlife",
                            Name = "L-Carnitine",
                            Price = 14
                        });
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Trainer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Moto")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Practis")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("PricePerHour")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pilates"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Yoga"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Classic"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Boxing"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.GroupEvents", b =>
                {
                    b.HasOne("MyGymWeb.Data.Models.GroupTrainerName", "GroupTrainerNames")
                        .WithMany()
                        .HasForeignKey("GroupTrainerNamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyGymWeb.Data.Models.Gym", "Gym")
                        .WithMany("GroupsEvents")
                        .HasForeignKey("GymId");

                    b.HasOne("MyGymWeb.Data.Models.Type", "Type")
                        .WithMany("GroupsEvents")
                        .HasForeignKey("TypeId");

                    b.Navigation("GroupTrainerNames");

                    b.Navigation("Gym");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Gym", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Athlete")
                        .WithMany()
                        .HasForeignKey("AthleteId");

                    b.HasOne("MyGymWeb.Data.Models.Trainer", "Trainer")
                        .WithMany("Gyms")
                        .HasForeignKey("TrainerId");

                    b.Navigation("Athlete");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Product", b =>
                {
                    b.HasOne("MyGymWeb.Data.Models.Gym", "Gym")
                        .WithMany("Products")
                        .HasForeignKey("GymId");

                    b.Navigation("Gym");
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Trainer", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Gym", b =>
                {
                    b.Navigation("GroupsEvents");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Trainer", b =>
                {
                    b.Navigation("Gyms");
                });

            modelBuilder.Entity("MyGymWeb.Data.Models.Type", b =>
                {
                    b.Navigation("GroupsEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
