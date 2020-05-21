﻿// <auto-generated />
using COVID19.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COVID19.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20200520182928_InitialC")]
    partial class InitialC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("COVID19.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("TipsId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("COVID19.Models.Tips", b =>
                {
                    b.Property<int>("TipsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("TipsId");

                    b.ToTable("Tips");
                });

            modelBuilder.Entity("COVID19.Models.Comment", b =>
                {
                    b.HasOne("COVID19.Models.Tips", "Tips")
                        .WithMany("Comments")
                        .HasForeignKey("TipsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
