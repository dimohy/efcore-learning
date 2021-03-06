// <auto-generated />
using EFCoreFirstApp.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityTest.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20220531011827_first-2")]
    partial class first2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("EFCoreFirstApp.Entities.Todo", b =>
                {
                    b.Property<int>("Seq")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Seq");

                    b.HasIndex("UserId");

                    b.ToTable("Todo");
                });

            modelBuilder.Entity("EFCoreFirstApp.Entities.UserInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("EFCoreFirstApp.Entities.Todo", b =>
                {
                    b.HasOne("EFCoreFirstApp.Entities.UserInfo", "User")
                        .WithMany("Todos")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFCoreFirstApp.Entities.UserInfo", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
