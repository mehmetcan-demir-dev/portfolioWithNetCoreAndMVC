﻿// <auto-generated />
using System;
using Data_Access_Layer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data_Access_Layer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221005115441_mig_todolist_squad_add")]
    partial class mig_todolist_squad_add
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity_Layer.Concrete.About", b =>
                {
                    b.Property<int>("aboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aboutAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutAge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("aboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.Contact", b =>
                {
                    b.Property<int>("contactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contactDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.Experience", b =>
                {
                    b.Property<int>("experienceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("experienceDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experienceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experienceImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experienceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("experienceID");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.Feature", b =>
                {
                    b.Property<int>("featureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("featureHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("featureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("featureTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("featureID");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.Message", b =>
                {
                    b.Property<int>("messageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("messageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("messageMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("messageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("messageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.Portfolio", b =>
                {
                    b.Property<int>("portfolioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("portfolioImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolioImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolioImage3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolioImage4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolioImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolioImageUrl2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolioPlatform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolioPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("portfolioStatus")
                        .HasColumnType("bit");

                    b.Property<string>("portfolioTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("portfolioValue")
                        .HasColumnType("int");

                    b.Property<string>("projectUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("portfolioID");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.Service", b =>
                {
                    b.Property<int>("serviceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("serviceImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serviceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("serviceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.Skill", b =>
                {
                    b.Property<int>("skillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("skillTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("skillValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("skillID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.SocialMedia", b =>
                {
                    b.Property<int>("socialMediaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("socialMediaIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socialMediaTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socialMediaUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("socialMediaID");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.Squad", b =>
                {
                    b.Property<int>("memberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("memberFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memberImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memberTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projectProgress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("memberID");

                    b.ToTable("Squads");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.ToDoList", b =>
                {
                    b.Property<int>("jobID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("jobContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("jobStatus")
                        .HasColumnType("bit");

                    b.HasKey("jobID");

                    b.ToTable("ToDoLists");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<string>("userImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userNickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userSecName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.UserMessage", b =>
                {
                    b.Property<int>("messageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("messageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("messageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("messageID");

                    b.HasIndex("userID");

                    b.ToTable("UserMessages");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.UserMessage", b =>
                {
                    b.HasOne("Entity_Layer.Concrete.User", "User")
                        .WithMany("UserMessages")
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity_Layer.Concrete.User", b =>
                {
                    b.Navigation("UserMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
