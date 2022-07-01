﻿// <auto-generated />
using LazyLoadingSample.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LazyLoadingSample.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("DeptUser", b =>
                {
                    b.Property<string>("DeptsDeptId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsersUserId")
                        .HasColumnType("TEXT");

                    b.HasKey("DeptsDeptId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("DeptUser");
                });

            modelBuilder.Entity("LazyLoadingSample.Entities.Dept", b =>
                {
                    b.Property<string>("DeptId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DeptId");

                    b.ToTable("Dept");
                });

            modelBuilder.Entity("LazyLoadingSample.Entities.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DeptUser", b =>
                {
                    b.HasOne("LazyLoadingSample.Entities.Dept", null)
                        .WithMany()
                        .HasForeignKey("DeptsDeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LazyLoadingSample.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
