// <auto-generated />
using EFCoreFirstApp.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityTest.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("EntityTest.Entities.Todo", b =>
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

            modelBuilder.Entity("EntityTest.Entities.UserDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("EntityTest.Entities.UserInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("EntityTest.Entities.Todo", b =>
                {
                    b.HasOne("EntityTest.Entities.UserInfo", "User")
                        .WithMany("Todos")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityTest.Entities.UserDetail", b =>
                {
                    b.HasOne("EntityTest.Entities.UserInfo", "User")
                        .WithOne("Detail")
                        .HasForeignKey("EntityTest.Entities.UserDetail", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityTest.Entities.UserInfo", b =>
                {
                    b.Navigation("Detail")
                        .IsRequired();

                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
