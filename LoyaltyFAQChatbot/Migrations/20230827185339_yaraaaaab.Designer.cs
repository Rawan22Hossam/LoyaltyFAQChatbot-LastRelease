﻿// <auto-generated />
using System;
using LoyaltyFAQChatbot.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoyaltyFAQChatbot.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230827185339_yaraaaaab")]
    partial class yaraaaaab
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LoyaltyFAQChatbot.Models.Answer", b =>
                {
                    b.Property<int>("answerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("answerId"));

                    b.Property<string>("answerText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("questionId")
                        .HasColumnType("int");

                    b.HasKey("answerId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("LoyaltyFAQChatbot.Models.Coupons", b =>
                {
                    b.Property<int>("couponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("couponId"));

                    b.Property<int>("couponNumber")
                        .HasColumnType("int");

                    b.Property<string>("couponStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("couponValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("expiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("mobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("couponId");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("LoyaltyFAQChatbot.Models.Question", b =>
                {
                    b.Property<int>("questionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("questionId"));

                    b.Property<TimeSpan>("expiryDate")
                        .HasColumnType("time");

                    b.Property<string>("questionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("questionId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("LoyaltyFAQChatbot.Models.SupportTicket", b =>
                {
                    b.Property<int>("ticketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ticketId"));

                    b.Property<DateTime>("creationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isSolved")
                        .HasColumnType("bit");

                    b.Property<string>("mobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("questionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ticketDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("ticketId");

                    b.ToTable("SupportTickets");
                });

            modelBuilder.Entity("LoyaltyFAQChatbot.Models.Transaction", b =>
                {
                    b.Property<int>("transactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("transactionId"));

                    b.Property<DateTime>("transactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("transactionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("transactionPoints")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("transactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("transactionId");

                    b.ToTable("transactions");
                });

            modelBuilder.Entity("LoyaltyFAQChatbot.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("mobileNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("points")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}