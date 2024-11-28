﻿// <auto-generated />
using System;
using Cinema.Storage.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cinema.Storage.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241128181612_ClientTableWasChanged")]
    partial class ClientTableWasChanged
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cinema.Core.Models.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("actors_pkey");

                    b.ToTable("actors", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Auditorium", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("uuid")
                        .HasColumnName("branch_id");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("auditoriums_pkey");

                    b.HasIndex("BranchId");

                    b.HasIndex(new[] { "Id", "BranchId" }, "unique_id_branch")
                        .IsUnique();

                    b.HasIndex(new[] { "Name", "BranchId" }, "unique_name_branch")
                        .IsUnique();

                    b.ToTable("auditoriums", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("city");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("region");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("zip_code");

                    b.HasKey("Id")
                        .HasName("branches_pkey");

                    b.HasIndex(new[] { "Name" }, "branches_name_key")
                        .IsUnique();

                    b.ToTable("branches", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("clients_pkey");

                    b.HasIndex(new[] { "Email" }, "clients_email_key")
                        .IsUnique();

                    b.ToTable("clients", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("genres_pkey");

                    b.ToTable("genres", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<int>("AgeRating")
                        .HasColumnType("integer")
                        .HasColumnName("age_rating");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("director");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval")
                        .HasColumnName("duration");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("image_path");

                    b.Property<string>("InclusiveAdaptation")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("inclusive_adaptation");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("language");

                    b.Property<string>("OriginalTitle")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("original_title");

                    b.Property<string>("Producer")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("producer");

                    b.Property<string>("ProductionStudio")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("production_studio");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("integer")
                        .HasColumnName("release_year");

                    b.Property<DateOnly>("RentalPeriodEnd")
                        .HasColumnType("date")
                        .HasColumnName("rental_period_end");

                    b.Property<DateOnly>("RentalPeriodStart")
                        .HasColumnType("date")
                        .HasColumnName("rental_period_start");

                    b.Property<string>("Screenplay")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("screenplay");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("title");

                    b.Property<string>("TrailerLink")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("trailer_link");

                    b.HasKey("Id")
                        .HasName("movies_pkey");

                    b.HasIndex(new[] { "ImagePath" }, "movies_image_path_key")
                        .IsUnique();

                    b.ToTable("movies", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Pricelist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<decimal>("Price")
                        .HasColumnType("money")
                        .HasColumnName("price");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("uuid")
                        .HasColumnName("session_id");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uuid")
                        .HasColumnName("status_id");

                    b.HasKey("Id")
                        .HasName("pricelist_pkey");

                    b.HasIndex("StatusId");

                    b.HasIndex(new[] { "SessionId", "StatusId" }, "unique_session_status")
                        .IsUnique();

                    b.ToTable("pricelist", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<Guid>("AuditoriumId")
                        .HasColumnType("uuid")
                        .HasColumnName("auditorium_id");

                    b.Property<short>("Column")
                        .HasColumnType("smallint")
                        .HasColumnName("column");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<short>("Row")
                        .HasColumnType("smallint")
                        .HasColumnName("row");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uuid")
                        .HasColumnName("status_id");

                    b.Property<short>("XPosition")
                        .HasColumnType("smallint")
                        .HasColumnName("x_position");

                    b.Property<short>("YPosition")
                        .HasColumnType("smallint")
                        .HasColumnName("y_position");

                    b.HasKey("Id")
                        .HasName("seats_pkey");

                    b.HasIndex("AuditoriumId");

                    b.HasIndex("StatusId");

                    b.HasIndex(new[] { "Row", "Column", "AuditoriumId" }, "unique_row_column")
                        .IsUnique();

                    b.HasIndex(new[] { "XPosition", "YPosition", "AuditoriumId" }, "unique_x_position_y_position")
                        .IsUnique();

                    b.ToTable("seats", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<Guid>("AuditoriumId")
                        .HasColumnType("uuid")
                        .HasColumnName("auditorium_id");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("end_time");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid")
                        .HasColumnName("movie_id");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_time");

                    b.HasKey("Id")
                        .HasName("sessions_pkey");

                    b.HasIndex("AuditoriumId");

                    b.HasIndex("MovieId");

                    b.ToTable("sessions", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("statuses_pkey");

                    b.HasIndex(new[] { "Name" }, "statuses_name_key")
                        .IsUnique();

                    b.ToTable("statuses", (string)null);
                });

            modelBuilder.Entity("Cinema.Core.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<Guid>("SeatId")
                        .HasColumnType("uuid")
                        .HasColumnName("seat_id");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("uuid")
                        .HasColumnName("session_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id")
                        .HasName("tickets_pkey");

                    b.HasIndex("ClientId");

                    b.HasIndex("SeatId");

                    b.HasIndex(new[] { "SessionId", "SeatId" }, "unique_session_seat")
                        .IsUnique();

                    b.ToTable("tickets", (string)null);
                });

            modelBuilder.Entity("MovieActor", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("uuid");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId", "ActorId")
                        .IsUnique();

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("MovieGenre", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.HasIndex("MovieId", "GenreId")
                        .IsUnique();

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("Cinema.Core.Models.Auditorium", b =>
                {
                    b.HasOne("Cinema.Core.Models.Branch", "Branch")
                        .WithMany("Auditoriums")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_branch");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Cinema.Core.Models.Pricelist", b =>
                {
                    b.HasOne("Cinema.Core.Models.Session", "Session")
                        .WithMany("Pricelists")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_session");

                    b.HasOne("Cinema.Core.Models.Status", "Status")
                        .WithMany("Pricelists")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_status");

                    b.Navigation("Session");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Cinema.Core.Models.Seat", b =>
                {
                    b.HasOne("Cinema.Core.Models.Auditorium", "Auditorium")
                        .WithMany("Seats")
                        .HasForeignKey("AuditoriumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_auditorium");

                    b.HasOne("Cinema.Core.Models.Status", "Status")
                        .WithMany("Seats")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_status");

                    b.Navigation("Auditorium");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Cinema.Core.Models.Session", b =>
                {
                    b.HasOne("Cinema.Core.Models.Auditorium", "Auditorium")
                        .WithMany("Sessions")
                        .HasForeignKey("AuditoriumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_auditorium");

                    b.HasOne("Cinema.Core.Models.Movie", "Movie")
                        .WithMany("Sessions")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_movie");

                    b.Navigation("Auditorium");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Cinema.Core.Models.Ticket", b =>
                {
                    b.HasOne("Cinema.Core.Models.Client", "Client")
                        .WithMany("Tickets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_client");

                    b.HasOne("Cinema.Core.Models.Seat", "Seat")
                        .WithMany("Tickets")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_seat");

                    b.HasOne("Cinema.Core.Models.Session", "Session")
                        .WithMany("Tickets")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_session");

                    b.Navigation("Client");

                    b.Navigation("Seat");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("MovieActor", b =>
                {
                    b.HasOne("Cinema.Core.Models.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinema.Core.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieGenre", b =>
                {
                    b.HasOne("Cinema.Core.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinema.Core.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cinema.Core.Models.Auditorium", b =>
                {
                    b.Navigation("Seats");

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("Cinema.Core.Models.Branch", b =>
                {
                    b.Navigation("Auditoriums");
                });

            modelBuilder.Entity("Cinema.Core.Models.Client", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Cinema.Core.Models.Movie", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("Cinema.Core.Models.Seat", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Cinema.Core.Models.Session", b =>
                {
                    b.Navigation("Pricelists");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Cinema.Core.Models.Status", b =>
                {
                    b.Navigation("Pricelists");

                    b.Navigation("Seats");
                });
#pragma warning restore 612, 618
        }
    }
}
