﻿// <auto-generated />
using System;
using FitnessSite.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessSite.Data.Migrations
{
    [DbContext(typeof(FitnessSiteDbContext))]
    partial class FitnessSiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FitnessSite.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TrainingId")
                        .HasColumnType("uniqueidentifier");

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

                    b.HasIndex("TrainerId");

                    b.HasIndex("TrainingId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("673fc005-4fbb-403b-8931-61c02f901f56"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e58d020a-8b2e-4638-ab42-d61fc242ed18",
                            Email = "ivantrainer@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "IVANTRAINER@GMAIL.COM",
                            NormalizedUserName = "IVANTRAINER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPkFrXPoUKAiePrdfD7MpV8GM3DDLiGHeL0t59CRhINfNeFNYk5KsFBtvu4333byRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "BNB3HKKNVR6EQGG33PZ2PKZZ2E3A3BRM",
                            TwoFactorEnabled = false,
                            UserName = "ivantrainer@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("3cb73cf9-de66-4109-aa37-b36b72787df7"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cc188f75-7cf1-43eb-9b59-45b85f0db93b",
                            Email = "mariatrainer@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "MARIATRAINER@GMAIL.COM",
                            NormalizedUserName = "MARIATRAINER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAED2g4IMnJy5+pVB/Al2nlBK2s6EfebghA0LGqA+e1qJ45j9COBwKW9gIxV6jhrmKvw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3RCFHYMOTYHUGUNQDYGDXXG5OWPTH5J4",
                            TwoFactorEnabled = false,
                            UserName = "mariatrainer@gmail.com"
                        });
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<int?>("Kilogram")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Reps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Exercises", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a56d7b9c-1fc0-4340-983b-5a6401fd994b"),
                            Description = "An exercise in which a person, keeping a prone position with thehandspalms down under the shoulders",
                            ImageUrl = "https://blog.nasm.org/hubfs/power-pushups.jpg",
                            Name = "Push-Ups",
                            Reps = "10",
                            Sets = "4",
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("3feee688-0784-40c8-8f72-5f960e6d573d"),
                            Description = "Start in a tabletop position on your hands and knees, then lower down toyour forearms with your elbows stacked beneath your shoulders. Step yo  feet back until your body makes a line from shoulders to heels.",
                            ImageUrl = "https://blog-images-1.pharmeasy.in/blog/production/wp-content/uploads/2021/01/06152556/3.jpg",
                            Name = "Plank",
                            Reps = "8",
                            Sets = "3",
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("3de69090-792a-4138-8b0b-bd3d31dbddb8"),
                            Description = "Pullup is a challenging upper body exercise where you grip an overhead bar  and lift your body until your chin is above that bar.",
                            ImageUrl = "https://calisthenicsworldwide.com/wp-content/uploads/2023/02/152-CWW_20-pull-ups.jpg",
                            Name = "Pull-Ups",
                            TypeId = 2
                        },
                        new
                        {
                            Id = new Guid("ea0c9cba-6849-4a46-8e80-d6e5f0495d5a"),
                            Description = "Cycling, also, when on a two-wheeled bicycle, called bicycling or biking  is the use of cycles for transport, recreation, exercise or sport. People engaged in cycling are referred to as cyclists,bicyclists, or bikers.",
                            ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/21/2022/05/Cube-Axial-WS-12-45369da.jpg?quality=90&resize=620%2C413",
                            Name = "Cycling",
                            TypeId = 2
                        },
                        new
                        {
                            Id = new Guid("ed5ce0b4-888e-4234-9255-26829db17b06"),
                            Description = "The bench press is a compound exercise that targets the muscles of the upper body. It involves lying on a bench and pressing weight upward using either a barbell or a pair of dumbbells.",
                            ImageUrl = "https://cdn.muscleandstrength.com/sites/default/files/barbell-bench-press_0.jpg",
                            Name = "Bench Press",
                            Reps = "10 - 12",
                            Sets = "4",
                            TypeId = 3
                        },
                        new
                        {
                            Id = new Guid("f953a21f-59b3-4e54-a152-99575045f187"),
                            Description = "A squat is a strength exercise in which the trainee lowers their hips from a standing position and then stands back up. During the descent, the hip and knee joints flex while the ankle joint dorsiflexes",
                            ImageUrl = "https://www.muscleandfitness.com/wp-content/uploads/2019/02/1109-Barbell-Back-Squat-GettyImages-614107160.jpg?quality=86&strip=all",
                            Name = "Squat",
                            Reps = "8 - 10",
                            Sets = "3-4",
                            TypeId = 3
                        });
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RecipientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SenderFirstName")
                        .IsRequired()
                        .HasMaxLength(747)
                        .HasColumnType("nvarchar(747)");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SenderLastName")
                        .IsRequired()
                        .HasMaxLength(747)
                        .HasColumnType("nvarchar(747)");

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Messages", (string)null);
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Muscle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Muscles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Biceps"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Triceps"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Shoulder"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Legs"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chest"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Abs"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Back"
                        });
                });

            modelBuilder.Entity("FitnessSite.Data.Models.MuscleExercise", b =>
                {
                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MuscleId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "MuscleId");

                    b.HasIndex("MuscleId");

                    b.ToTable("MuscleExercises", (string)null);

                    b.HasData(
                        new
                        {
                            ExerciseId = new Guid("2d41e21a-e8c8-4c7a-8690-3a846772b6b6"),
                            MuscleId = 7
                        },
                        new
                        {
                            ExerciseId = new Guid("23f41c9e-da15-4282-b5cc-1cbadb6ca92e"),
                            MuscleId = 2
                        },
                        new
                        {
                            ExerciseId = new Guid("8cb1af1b-b63a-458b-adfa-dc077a02c4f9"),
                            MuscleId = 6
                        },
                        new
                        {
                            ExerciseId = new Guid("88922675-b7df-4a4a-9313-231d2c13a3a2"),
                            MuscleId = 7
                        },
                        new
                        {
                            ExerciseId = new Guid("88922675-b7df-4a4a-9313-231d2c13a3a2"),
                            MuscleId = 3
                        },
                        new
                        {
                            ExerciseId = new Guid("2d41e21a-e8c8-4c7a-8690-3a846772b6b6"),
                            MuscleId = 1
                        },
                        new
                        {
                            ExerciseId = new Guid("2d41e21a-e8c8-4c7a-8690-3a846772b6b6"),
                            MuscleId = 2
                        },
                        new
                        {
                            ExerciseId = new Guid("23f41c9e-da15-4282-b5cc-1cbadb6ca92e"),
                            MuscleId = 5
                        },
                        new
                        {
                            ExerciseId = new Guid("a22ab0dd-3e6a-444f-b21d-b7f69707bb28"),
                            MuscleId = 4
                        },
                        new
                        {
                            ExerciseId = new Guid("6587e2a8-e9f1-4fd9-bd7e-503078be010b"),
                            MuscleId = 2
                        },
                        new
                        {
                            ExerciseId = new Guid("8cb1af1b-b63a-458b-adfa-dc077a02c4f9"),
                            MuscleId = 4
                        },
                        new
                        {
                            ExerciseId = new Guid("88922675-b7df-4a4a-9313-231d2c13a3a2"),
                            MuscleId = 6
                        });
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Trainer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(747)
                        .HasColumnType("nvarchar(747)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(747)
                        .HasColumnType("nvarchar(747)");

                    b.Property<decimal>("PricePerMonth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StartedAt")
                        .HasColumnType("int");

                    b.Property<string>("TelefoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Trainers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("438bfe04-c75e-4aad-ac1e-4284d07e7903"),
                            ApplicationUserId = new Guid("673fc005-4fbb-403b-8931-61c02f901f56"),
                            Description = "Hello, my name is Ivan. I know every type of exercise and i will be glad if i work with you! I work mostly with men.",
                            FirstName = "Ivan",
                            ImageUrl = "https://media.istockphoto.com/id/1072395722/photo/fitness-trainer-at-gym.jpg?s=612x612&w=0&k=20&c=3VBLCgbxG3bGNRp9Sc3tN_7G-g_DxXhGk9rhuZo-jkE=",
                            LastName = "Ivanov",
                            PricePerMonth = 89.99m,
                            StartedAt = 23,
                            TelefoneNumber = "0895543981",
                            Year = 31
                        },
                        new
                        {
                            Id = new Guid("94429628-91f2-4e7d-b265-4b350c1547ce"),
                            ApplicationUserId = new Guid("3cb73cf9-de66-4109-aa37-b36b72787df7"),
                            Description = "Hello, my name is Maria.I've been going to the gym since i was 16, and when i grow up i decide to become professional trainer. I work mostly with men.",
                            FirstName = "Maria",
                            ImageUrl = "https://media.istockphoto.com/id/856797530/photo/portrait-of-a-beautiful-woman-at-the-gym.jpg?s=612x612&w=0&k=20&c=0wMa1MYxt6HHamjd66d5__XGAKbJFDFQyu9LCloRsYU=",
                            LastName = "Asenova",
                            PricePerMonth = 84.99m,
                            StartedAt = 21,
                            TelefoneNumber = "0875587458",
                            Year = 28
                        });
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Training", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsEnded")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStarted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Trainings", (string)null);
                });

            modelBuilder.Entity("FitnessSite.Data.Models.TrainingExercise", b =>
                {
                    b.Property<Guid?>("TrainingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDoneForToday")
                        .HasColumnType("bit");

                    b.HasKey("TrainingId", "ExerciseId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("TrainingExercises", (string)null);
                });

            modelBuilder.Entity("FitnessSite.Data.Models.TypeExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("TypeExercises", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "In Home"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Outside"
                        },
                        new
                        {
                            Id = 3,
                            Name = "In the gym"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("FitnessSite.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.Trainer", "Trainer")
                        .WithMany("ApllicationUsers")
                        .HasForeignKey("TrainerId");

                    b.HasOne("FitnessSite.Data.Models.Training", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingId");

                    b.Navigation("Trainer");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Exercise", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.TypeExercise", "Type")
                        .WithMany("Exercises")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Message", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", null)
                        .WithMany("Messages")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("FitnessSite.Data.Models.Trainer", null)
                        .WithMany("Messages")
                        .HasForeignKey("TrainerId");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.MuscleExercise", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.Exercise", "Exercise")
                        .WithMany("MuscleExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessSite.Data.Models.Muscle", "Muscle")
                        .WithMany("MuscleExercises")
                        .HasForeignKey("MuscleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Muscle");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Trainer", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Training", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", "ApllicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApllicationUser");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.TrainingExercise", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.Exercise", "Exercise")
                        .WithMany("TrainingExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitnessSite.Data.Models.Training", "Training")
                        .WithMany("TrainingExercises")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("FitnessSite.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessSite.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Exercise", b =>
                {
                    b.Navigation("MuscleExercises");

                    b.Navigation("TrainingExercises");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Muscle", b =>
                {
                    b.Navigation("MuscleExercises");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Trainer", b =>
                {
                    b.Navigation("ApllicationUsers");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.Training", b =>
                {
                    b.Navigation("TrainingExercises");
                });

            modelBuilder.Entity("FitnessSite.Data.Models.TypeExercise", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
