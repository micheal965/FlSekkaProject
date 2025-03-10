﻿// <auto-generated />
using System;
using Int.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InT.Repository.Migrations
{
    [DbContext(typeof(FiElSekkaContext))]
    [Migration("20250310015907_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdminManageUser", b =>
                {
                    b.Property<int>("USsn")
                        .HasColumnType("int")
                        .HasColumnName("U_SSN");

                    b.Property<int>("ASsn")
                        .HasColumnType("int")
                        .HasColumnName("A_SSN");

                    b.HasKey("USsn", "ASsn")
                        .HasName("PK__Admin_Ma__C6318EC0C08A3EAE");

                    b.HasIndex("ASsn");

                    b.ToTable("Admin_Manage_USER", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.Admin", b =>
                {
                    b.Property<int>("ASsn")
                        .HasColumnType("int")
                        .HasColumnName("A_SSN");

                    b.Property<string>("AName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("A_Name");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.HasKey("ASsn")
                        .HasName("PK__Admin__C37734FE4EEB0C72");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.AdminMnageCar", b =>
                {
                    b.Property<int>("CId")
                        .HasColumnType("int")
                        .HasColumnName("C_ID");

                    b.Property<int?>("ASsn")
                        .HasColumnType("int")
                        .HasColumnName("A_SSN");

                    b.HasKey("CId")
                        .HasName("PK__Admin_Mn__A9FDEC12D5B1E801");

                    b.HasIndex("ASsn");

                    b.ToTable("Admin_Mnage_car", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.AdminPhone", b =>
                {
                    b.Property<int>("ASsn")
                        .HasColumnType("int")
                        .HasColumnName("A_SSN");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Phone_Number");

                    b.HasKey("ASsn", "PhoneNumber")
                        .HasName("PK__Admin_Ph__820D013416215AC3");

                    b.ToTable("Admin_Phone", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.Brand", b =>
                {
                    b.Property<int>("BCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("b_Code");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BCode"));

                    b.Property<string>("BName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("b_Name");

                    b.HasKey("BCode")
                        .HasName("PK__brand__56B8275311181CD8");

                    b.ToTable("brand", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.Car", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("C_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CId"));

                    b.Property<int?>("BCode")
                        .HasColumnType("int")
                        .HasColumnName("b_Code");

                    b.Property<int?>("CCode")
                        .HasColumnType("int")
                        .HasColumnName("c_Code");

                    b.Property<int?>("CPlateNumber")
                        .HasColumnType("int")
                        .HasColumnName("c_plate_number");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("location");

                    b.HasKey("CId")
                        .HasName("PK__Car__A9FDEC12A64A3DDA");

                    b.HasIndex("BCode");

                    b.HasIndex("CCode");

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.CarPhoto", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Photo_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhotoId"));

                    b.Property<int>("CId")
                        .HasColumnType("int")
                        .HasColumnName("C_ID");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("photo");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoId")
                        .HasName("PK__Car_Phot__7A07F6C29F750EED");

                    b.HasIndex("CId");

                    b.ToTable("Car_Photo", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.Color", b =>
                {
                    b.Property<int>("CCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("c_Code");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CCode"));

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("c_Name");

                    b.HasKey("CCode")
                        .HasName("PK__color__0B18F0EEC14DE22B");

                    b.ToTable("color", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.Guidance", b =>
                {
                    b.Property<int>("GId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("G_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GId"));

                    b.Property<int?>("ASsn")
                        .HasColumnType("int")
                        .HasColumnName("A_SSN");

                    b.Property<string>("GContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("G_content");

                    b.HasKey("GId")
                        .HasName("PK__Guidance__153A8ED2B6A0AA66");

                    b.HasIndex("ASsn");

                    b.ToTable("Guidance", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.Message", b =>
                {
                    b.Property<int>("MId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("M_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime");

                    b.HasKey("MId")
                        .HasName("PK__Message__18B1A317860AF466");

                    b.ToTable("Message", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.Model", b =>
                {
                    b.Property<int>("MCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("m_Code");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MCode"));

                    b.Property<int?>("BCode")
                        .HasColumnType("int")
                        .HasColumnName("b_Code");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("m_Name");

                    b.HasKey("MCode")
                        .HasName("PK__model__2B3C4A37A2C28094");

                    b.HasIndex("BCode");

                    b.ToTable("model", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.SearchCar", b =>
                {
                    b.Property<int>("CId")
                        .HasColumnType("int")
                        .HasColumnName("C_ID");

                    b.Property<int?>("SId")
                        .HasColumnType("int")
                        .HasColumnName("S_ID");

                    b.HasKey("CId")
                        .HasName("PK__search_c__A9FDEC12D7691AB4");

                    b.HasIndex("SId");

                    b.ToTable("search_car", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.SearchHistory", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("S_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SId"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Notification")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("notification");

                    b.HasKey("SId")
                        .HasName("PK__search_h__A3DFF16D86D404A9");

                    b.ToTable("search_history", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.UserMessageSendReceive", b =>
                {
                    b.Property<int>("USsn")
                        .HasColumnType("int")
                        .HasColumnName("U_SSN");

                    b.Property<int>("MId")
                        .HasColumnType("int")
                        .HasColumnName("M_ID");

                    b.Property<int>("ASsn")
                        .HasColumnType("int")
                        .HasColumnName("A_SSN");

                    b.HasKey("USsn", "MId", "ASsn")
                        .HasName("PK__User_Mes__A44E908AC72371DA");

                    b.HasIndex("ASsn");

                    b.HasIndex("MId");

                    b.ToTable("User_Message_send_receive", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.UserPhone", b =>
                {
                    b.Property<int>("USsn")
                        .HasColumnType("int")
                        .HasColumnName("U_SSN");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Phone_Number");

                    b.HasKey("USsn", "PhoneNumber")
                        .HasName("PK__User_Pho__7B7CC84537928C8E");

                    b.ToTable("User_Phone", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.UserSearch", b =>
                {
                    b.Property<int>("USsn")
                        .HasColumnType("int")
                        .HasColumnName("U_SSN");

                    b.Property<int?>("SId")
                        .HasColumnType("int")
                        .HasColumnName("S_ID");

                    b.HasKey("USsn")
                        .HasName("PK__User_sea__3A06FD8FEAED6457");

                    b.HasIndex("SId");

                    b.ToTable("User_search", (string)null);
                });

            modelBuilder.Entity("Int.Core.Entities.Userr", b =>
                {
                    b.Property<int>("USsn")
                        .HasColumnType("int")
                        .HasColumnName("U_SSN");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<string>("UName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("U_Name");

                    b.HasKey("USsn")
                        .HasName("PK__USERR__3A06FD8FA209E569");

                    b.ToTable("USERR", (string)null);
                });

            modelBuilder.Entity("UserCarView", b =>
                {
                    b.Property<int>("USsn")
                        .HasColumnType("int")
                        .HasColumnName("U_SSN");

                    b.Property<int>("CId")
                        .HasColumnType("int")
                        .HasColumnName("C_ID");

                    b.HasKey("USsn", "CId")
                        .HasName("PK__User_Car__0099234E2C0F9B90");

                    b.HasIndex("CId");

                    b.ToTable("User_Car_view", (string)null);
                });

            modelBuilder.Entity("UserGuidanceView", b =>
                {
                    b.Property<int>("USsn")
                        .HasColumnType("int")
                        .HasColumnName("U_SSN");

                    b.Property<int>("GId")
                        .HasColumnType("int")
                        .HasColumnName("G_ID");

                    b.HasKey("USsn", "GId")
                        .HasName("PK__User_Gui__0B5555625D04C383");

                    b.HasIndex("GId");

                    b.ToTable("User_Guidance_view", (string)null);
                });

            modelBuilder.Entity("AdminManageUser", b =>
                {
                    b.HasOne("Int.Core.Entities.Admin", null)
                        .WithMany()
                        .HasForeignKey("ASsn")
                        .IsRequired()
                        .HasConstraintName("FK__Admin_Man__A_SSN__6D0D32F4");

                    b.HasOne("Int.Core.Entities.Userr", null)
                        .WithMany()
                        .HasForeignKey("USsn")
                        .IsRequired()
                        .HasConstraintName("FK__Admin_Man__U_SSN__6E01572D");
                });

            modelBuilder.Entity("Int.Core.Entities.AdminMnageCar", b =>
                {
                    b.HasOne("Int.Core.Entities.Admin", "ASsnNavigation")
                        .WithMany("AdminMnageCars")
                        .HasForeignKey("ASsn")
                        .HasConstraintName("FK__Admin_Mna__A_SSN__693CA210");

                    b.HasOne("Int.Core.Entities.Car", "CIdNavigation")
                        .WithOne("AdminMnageCar")
                        .HasForeignKey("Int.Core.Entities.AdminMnageCar", "CId")
                        .IsRequired()
                        .HasConstraintName("FK__Admin_Mnag__C_ID__6A30C649");

                    b.Navigation("ASsnNavigation");

                    b.Navigation("CIdNavigation");
                });

            modelBuilder.Entity("Int.Core.Entities.AdminPhone", b =>
                {
                    b.HasOne("Int.Core.Entities.Admin", "ASsnNavigation")
                        .WithMany("AdminPhones")
                        .HasForeignKey("ASsn")
                        .IsRequired()
                        .HasConstraintName("FK__Admin_Pho__A_SSN__3E52440B");

                    b.Navigation("ASsnNavigation");
                });

            modelBuilder.Entity("Int.Core.Entities.Car", b =>
                {
                    b.HasOne("Int.Core.Entities.Brand", "BCodeNavigation")
                        .WithMany("Cars")
                        .HasForeignKey("BCode")
                        .HasConstraintName("FK__Car__b_Code__45F365D3");

                    b.HasOne("Int.Core.Entities.Color", "CCodeNavigation")
                        .WithMany("Cars")
                        .HasForeignKey("CCode")
                        .HasConstraintName("FK__Car__c_Code__44FF419A");

                    b.Navigation("BCodeNavigation");

                    b.Navigation("CCodeNavigation");
                });

            modelBuilder.Entity("Int.Core.Entities.CarPhoto", b =>
                {
                    b.HasOne("Int.Core.Entities.Car", "CIdNavigation")
                        .WithMany("CarPhotos")
                        .HasForeignKey("CId")
                        .IsRequired()
                        .HasConstraintName("FK__Car_Photo__C_ID__48CFD27E");

                    b.Navigation("CIdNavigation");
                });

            modelBuilder.Entity("Int.Core.Entities.Guidance", b =>
                {
                    b.HasOne("Int.Core.Entities.Admin", "ASsnNavigation")
                        .WithMany("Guidances")
                        .HasForeignKey("ASsn")
                        .HasConstraintName("FK__Guidance__A_SSN__5535A963");

                    b.Navigation("ASsnNavigation");
                });

            modelBuilder.Entity("Int.Core.Entities.Model", b =>
                {
                    b.HasOne("Int.Core.Entities.Brand", "BCodeNavigation")
                        .WithMany("Models")
                        .HasForeignKey("BCode")
                        .HasConstraintName("FK__model__b_Code__4BAC3F29");

                    b.Navigation("BCodeNavigation");
                });

            modelBuilder.Entity("Int.Core.Entities.SearchCar", b =>
                {
                    b.HasOne("Int.Core.Entities.Car", "CIdNavigation")
                        .WithOne("SearchCar")
                        .HasForeignKey("Int.Core.Entities.SearchCar", "CId")
                        .IsRequired()
                        .HasConstraintName("FK__search_car__C_ID__628FA481");

                    b.HasOne("Int.Core.Entities.SearchHistory", "SIdNavigation")
                        .WithMany("SearchCars")
                        .HasForeignKey("SId")
                        .HasConstraintName("FK__search_car__S_ID__619B8048");

                    b.Navigation("CIdNavigation");

                    b.Navigation("SIdNavigation");
                });

            modelBuilder.Entity("Int.Core.Entities.UserMessageSendReceive", b =>
                {
                    b.HasOne("Int.Core.Entities.Admin", "ASsnNavigation")
                        .WithMany("UserMessageSendReceives")
                        .HasForeignKey("ASsn")
                        .IsRequired()
                        .HasConstraintName("FK__User_Mess__A_SSN__52593CB8");

                    b.HasOne("Int.Core.Entities.Message", "MIdNavigation")
                        .WithMany("UserMessageSendReceives")
                        .HasForeignKey("MId")
                        .IsRequired()
                        .HasConstraintName("FK__User_Messa__M_ID__5165187F");

                    b.HasOne("Int.Core.Entities.Userr", "USsnNavigation")
                        .WithMany("UserMessageSendReceives")
                        .HasForeignKey("USsn")
                        .IsRequired()
                        .HasConstraintName("FK__User_Mess__U_SSN__5070F446");

                    b.Navigation("ASsnNavigation");

                    b.Navigation("MIdNavigation");

                    b.Navigation("USsnNavigation");
                });

            modelBuilder.Entity("Int.Core.Entities.UserPhone", b =>
                {
                    b.HasOne("Int.Core.Entities.Userr", "USsnNavigation")
                        .WithMany("UserPhones")
                        .HasForeignKey("USsn")
                        .IsRequired()
                        .HasConstraintName("FK__User_Phon__U_SSN__3B75D760");

                    b.Navigation("USsnNavigation");
                });

            modelBuilder.Entity("Int.Core.Entities.UserSearch", b =>
                {
                    b.HasOne("Int.Core.Entities.SearchHistory", "SIdNavigation")
                        .WithMany("UserSearches")
                        .HasForeignKey("SId")
                        .HasConstraintName("FK__User_searc__S_ID__66603565");

                    b.HasOne("Int.Core.Entities.Userr", "USsnNavigation")
                        .WithOne("UserSearch")
                        .HasForeignKey("Int.Core.Entities.UserSearch", "USsn")
                        .IsRequired()
                        .HasConstraintName("FK__User_sear__U_SSN__656C112C");

                    b.Navigation("SIdNavigation");

                    b.Navigation("USsnNavigation");
                });

            modelBuilder.Entity("UserCarView", b =>
                {
                    b.HasOne("Int.Core.Entities.Car", null)
                        .WithMany()
                        .HasForeignKey("CId")
                        .IsRequired()
                        .HasConstraintName("FK__User_Car_v__C_ID__5CD6CB2B");

                    b.HasOne("Int.Core.Entities.Userr", null)
                        .WithMany()
                        .HasForeignKey("USsn")
                        .IsRequired()
                        .HasConstraintName("FK__User_Car___U_SSN__5BE2A6F2");
                });

            modelBuilder.Entity("UserGuidanceView", b =>
                {
                    b.HasOne("Int.Core.Entities.Guidance", null)
                        .WithMany()
                        .HasForeignKey("GId")
                        .IsRequired()
                        .HasConstraintName("FK__User_Guida__G_ID__59063A47");

                    b.HasOne("Int.Core.Entities.Userr", null)
                        .WithMany()
                        .HasForeignKey("USsn")
                        .IsRequired()
                        .HasConstraintName("FK__User_Guid__U_SSN__5812160E");
                });

            modelBuilder.Entity("Int.Core.Entities.Admin", b =>
                {
                    b.Navigation("AdminMnageCars");

                    b.Navigation("AdminPhones");

                    b.Navigation("Guidances");

                    b.Navigation("UserMessageSendReceives");
                });

            modelBuilder.Entity("Int.Core.Entities.Brand", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Models");
                });

            modelBuilder.Entity("Int.Core.Entities.Car", b =>
                {
                    b.Navigation("AdminMnageCar");

                    b.Navigation("CarPhotos");

                    b.Navigation("SearchCar");
                });

            modelBuilder.Entity("Int.Core.Entities.Color", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Int.Core.Entities.Message", b =>
                {
                    b.Navigation("UserMessageSendReceives");
                });

            modelBuilder.Entity("Int.Core.Entities.SearchHistory", b =>
                {
                    b.Navigation("SearchCars");

                    b.Navigation("UserSearches");
                });

            modelBuilder.Entity("Int.Core.Entities.Userr", b =>
                {
                    b.Navigation("UserMessageSendReceives");

                    b.Navigation("UserPhones");

                    b.Navigation("UserSearch");
                });
#pragma warning restore 612, 618
        }
    }
}
