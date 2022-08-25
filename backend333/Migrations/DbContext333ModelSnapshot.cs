﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend333;

#nullable disable

namespace backend333.Migrations
{
    [DbContext(typeof(DbContext333))]
    partial class DbContext333ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("backend333.RequestModels.Community", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Community");
                });

            modelBuilder.Entity("backend333.RequestModels.CommunityComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CommunityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CommunityId");

                    b.ToTable("CommunityComment");
                });

            modelBuilder.Entity("backend333.RequestModels.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Instagram")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SoundCloud")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Twitter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("artist")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("producer")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("backend333.RequestModels.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("backend333.RequestModels.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MainText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("backend333.RequestModels.Tracks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bpm")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SongUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tune")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("backend333.RequestModels.CommunityComment", b =>
                {
                    b.HasOne("backend333.RequestModels.Community", null)
                        .WithMany("Comment")
                        .HasForeignKey("CommunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("backend333.RequestModels.Community", b =>
                {
                    b.Navigation("Comment");
                });
#pragma warning restore 612, 618
        }
    }
}
