﻿// <auto-generated />
using System;
using DccyOrigination.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DccyOrigination.Migrations
{
    [DbContext(typeof(DccyDbContext))]
    [Migration("20180830025158_MyFirstMigrationtime")]
    partial class MyFirstMigrationtime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DccyOrigination.Models.AdmUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("DepId");

                    b.Property<string>("DetailedAddress");

                    b.Property<string>("Email");

                    b.Property<string>("Guid");

                    b.Property<DateTime>("LastLoginTime");

                    b.Property<int>("NumOfLogins");

                    b.Property<string>("Password");

                    b.Property<int>("RoleId");

                    b.Property<int>("Sex");

                    b.Property<string>("Tel");

                    b.Property<string>("ThumbnailImage");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserAccounts");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("admUser");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DepName");

                    b.Property<string>("Description");

                    b.Property<string>("Guid");

                    b.Property<string>("PGuid");

                    b.Property<int>("Pid");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("admDepartment");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmDepJur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepId");

                    b.Property<int>("JurId");

                    b.Property<int>("JurType");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("admDepJur");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmDepRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepId");

                    b.Property<int>("JurType");

                    b.Property<int>("RoleId");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("admDepRole");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmJurisdiction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<string>("Guid");

                    b.Property<string>("JurName");

                    b.Property<string>("PGuid");

                    b.Property<int>("Pid");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("admJurisdiction");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("OpTime");

                    b.Property<int>("OpType");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("admLog");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<string>("Guid");

                    b.Property<string>("PGuid");

                    b.Property<int>("Pid");

                    b.Property<string>("RoleName");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("admRole");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmRoleJur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdmJur");

                    b.Property<int>("AdmRoleId");

                    b.Property<int>("JurType");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("admRoleJur");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmUserDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdmDepId");

                    b.Property<int>("AdmUserId");

                    b.Property<int>("JurType");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("admUserDep");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmUserJurisdiction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdmJurisdictionId");

                    b.Property<int>("AdmUserId");

                    b.Property<int>("JurType");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("admUserJur");
                });

            modelBuilder.Entity("DccyOrigination.Models.SysManagement.AdmUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdmRoleId");

                    b.Property<int>("AdmUserId");

                    b.Property<int>("JurType");

                    b.Property<byte[]>("TimestampV")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("admUserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
