// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApp.DbContexts;

#nullable disable

namespace TodoApp.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20220612080553_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("TodoApp.Entities.TodoInfo", b =>
                {
                    b.Property<int>("Seq")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly?>("CompleteDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Memo")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("TodoDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Seq");

                    b.HasIndex("UserId");

                    b.ToTable("TodoInfo");
                });

            modelBuilder.Entity("TodoApp.Entities.UserInfo", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("TodoApp.Entities.TodoInfo", b =>
                {
                    b.HasOne("TodoApp.Entities.UserInfo", "User")
                        .WithMany("Todos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TodoApp.Entities.UserInfo", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
