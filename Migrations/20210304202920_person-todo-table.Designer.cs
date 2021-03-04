﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TodoManager.Data;

namespace TodoManager.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20210304202920_person-todo-table")]
    partial class persontodotable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TodoManager.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("NickName")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("TodoManager.Models.TodoTask", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AssignedUserID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.HasKey("ID");

                    b.HasIndex("AssignedUserID");

                    b.ToTable("TodoTasks");
                });

            modelBuilder.Entity("TodoManager.Models.TodoTask", b =>
                {
                    b.HasOne("TodoManager.Models.Person", "AssignedUser")
                        .WithMany("AssignedTasks")
                        .HasForeignKey("AssignedUserID");

                    b.Navigation("AssignedUser");
                });

            modelBuilder.Entity("TodoManager.Models.Person", b =>
                {
                    b.Navigation("AssignedTasks");
                });
#pragma warning restore 612, 618
        }
    }
}