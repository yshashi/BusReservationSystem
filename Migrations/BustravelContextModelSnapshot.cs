﻿// <auto-generated />
using System;
using BusReservationSystem.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusReservationSystem.Migrations
{
    [DbContext(typeof(BustravelContext))]
    partial class BustravelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusReservationSystem.Repository.BusDetails", b =>
                {
                    b.Property<int>("BusId")
                        .HasColumnName("Bus_Id")
                        .HasColumnType("int");

                    b.Property<int?>("BusTypeId")
                        .HasColumnName("Bus_Type_Id")
                        .HasColumnType("int");

                    b.Property<int?>("RegistrationNumber")
                        .HasColumnName("Registration_Number")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSeats")
                        .HasColumnName("Total_Seats")
                        .HasColumnType("int");

                    b.HasKey("BusId")
                        .HasName("PK__Bus_Deta__B0524D192ABDD14D");

                    b.HasIndex("BusTypeId");

                    b.ToTable("Bus_Details");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.BusFare", b =>
                {
                    b.Property<int>("FareId")
                        .HasColumnName("Fare_Id")
                        .HasColumnType("int");

                    b.Property<int?>("BusTypeId")
                        .HasColumnName("Bus_Type_Id")
                        .HasColumnType("int");

                    b.Property<decimal?>("FareAmount")
                        .HasColumnName("Fare_Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("RouteId")
                        .HasColumnName("Route_Id")
                        .HasColumnType("int");

                    b.HasKey("FareId")
                        .HasName("PK__Bus_Fare__495DB84F66705523");

                    b.HasIndex("BusTypeId");

                    b.HasIndex("RouteId");

                    b.ToTable("Bus_Fare");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.BusSchedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .HasColumnName("Schedule_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ArrivalDate")
                        .HasColumnName("Arrival_Date")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("ArrivalTime")
                        .HasColumnName("Arrival_Time")
                        .HasColumnType("time");

                    b.Property<int?>("AvailableSeats")
                        .HasColumnName("Available_Seats")
                        .HasColumnType("int");

                    b.Property<int?>("BookedSeats")
                        .HasColumnName("Booked_Seats")
                        .HasColumnType("int");

                    b.Property<int>("BusId")
                        .HasColumnName("Bus_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DepartureDate")
                        .HasColumnName("Departure_Date")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("DepartureTime")
                        .HasColumnName("Departure_Time")
                        .HasColumnType("time");

                    b.Property<string>("DriverName")
                        .HasColumnName("Driver_Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("FareId")
                        .HasColumnName("Fare_Id")
                        .HasColumnType("int");

                    b.Property<int>("RouteId")
                        .HasColumnName("Route_Id")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId")
                        .HasName("PK__Bus_Sche__8C4D3C5B5121E932");

                    b.HasIndex("BusId");

                    b.HasIndex("FareId");

                    b.HasIndex("RouteId");

                    b.ToTable("Bus_Schedule");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.BusType", b =>
                {
                    b.Property<int>("BusTypeId")
                        .HasColumnName("Bus_Type_Id")
                        .HasColumnType("int");

                    b.Property<string>("BusType1")
                        .HasColumnName("Bus_Type")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("BusTypeId");

                    b.ToTable("Bus_Type");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnName("Customer_Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ContactNo")
                        .HasColumnName("Contact_No")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnName("Date_Of_Birth")
                        .HasColumnType("date");

                    b.Property<string>("EmailId")
                        .HasColumnName("Email_Id")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .HasColumnName("First_Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Gender")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .HasColumnName("Last_Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Pincode")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<int?>("UserId")
                        .HasColumnName("User_Id")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.Login", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("User_Id")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("UserTypeId")
                        .HasColumnName("User_Type_Id")
                        .HasColumnType("int");

                    b.HasKey("UserId")
                        .HasName("PK__Login__206D917094606AEB");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.Payments", b =>
                {
                    b.Property<int>("PaymentId")
                        .HasColumnName("Payment_Id")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .HasColumnName("Bank_Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("BookingId")
                        .HasColumnName("Booking_Id")
                        .HasColumnType("int");

                    b.Property<string>("CardHolderName")
                        .HasColumnName("Card_Holder_Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CardNo")
                        .HasColumnName("Card_No")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CardType")
                        .HasColumnName("Card_Type")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnName("Total_Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("PaymentId")
                        .HasName("PK__Payments__DA6C7FC1BE7AFC0B");

                    b.HasIndex("BookingId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.RouteDetails", b =>
                {
                    b.Property<int>("RouteId")
                        .HasColumnName("Route_Id")
                        .HasColumnType("int");

                    b.Property<string>("DepartureStation")
                        .HasColumnName("Departure_Station")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("DestinationStation")
                        .HasColumnName("Destination_Station")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("time");

                    b.HasKey("RouteId")
                        .HasName("PK__Route_De__6DC9D9115B4E79A7");

                    b.ToTable("Route_Details");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.TicketBooking", b =>
                {
                    b.Property<int>("BookingId")
                        .HasColumnName("Booking_Id")
                        .HasColumnType("int");

                    b.Property<int?>("AvailableSeats")
                        .HasColumnName("Available_Seats")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnName("Customer_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBooking")
                        .HasColumnName("Date_Of_Booking")
                        .HasColumnType("date");

                    b.Property<decimal?>("Fare")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime?>("OnwardJourneyDate")
                        .HasColumnName("Onward_Journey_Date")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnName("Return_Date")
                        .HasColumnType("date");

                    b.Property<int?>("ScheduleId")
                        .HasColumnName("Schedule_Id")
                        .HasColumnType("int");

                    b.Property<int?>("TicketTypeId")
                        .HasColumnName("Ticket_Type_Id")
                        .HasColumnType("int");

                    b.HasKey("BookingId")
                        .HasName("PK__Ticket_B__35ABFDC0EF7B357D");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("TicketTypeId");

                    b.ToTable("Ticket_Booking");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.TicketCancellation", b =>
                {
                    b.Property<int>("CancellationId")
                        .HasColumnName("Cancellation_Id")
                        .HasColumnType("int");

                    b.Property<int?>("BookingId")
                        .HasColumnName("Booking_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CancellationDate")
                        .HasColumnName("Cancellation_Date")
                        .HasColumnType("date");

                    b.Property<int?>("CustomerId")
                        .HasColumnName("Customer_Id")
                        .HasColumnType("int");

                    b.Property<decimal?>("RefundAmount")
                        .HasColumnName("Refund_Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("ScheduleId")
                        .HasColumnName("Schedule_Id")
                        .HasColumnType("int");

                    b.Property<int?>("TicketTypeId")
                        .HasColumnName("Ticket_Type_Id")
                        .HasColumnType("int");

                    b.HasKey("CancellationId")
                        .HasName("PK__Ticket_C__BC9DC290867F8B3D");

                    b.HasIndex("BookingId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("TicketTypeId");

                    b.ToTable("Ticket_Cancellation");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.TypeOfTicket", b =>
                {
                    b.Property<int>("TicketTypeId")
                        .HasColumnName("Ticket_Type_Id")
                        .HasColumnType("int");

                    b.Property<string>("TicketType")
                        .HasColumnName("Ticket_Type")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("TicketTypeId")
                        .HasName("PK__Type_Of___B272714221014921");

                    b.ToTable("Type_Of_Ticket");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .HasColumnName("User_Type_Id")
                        .HasColumnType("int");

                    b.Property<string>("UserTypeName")
                        .HasColumnName("User_type_Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("UserTypeId");

                    b.ToTable("User_Type");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.BusDetails", b =>
                {
                    b.HasOne("BusReservationSystem.Repository.BusType", "BusType")
                        .WithMany("BusDetails")
                        .HasForeignKey("BusTypeId")
                        .HasConstraintName("FK__Bus_Detai__Bus_T__3E52440B");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.BusFare", b =>
                {
                    b.HasOne("BusReservationSystem.Repository.BusType", "BusType")
                        .WithMany("BusFare")
                        .HasForeignKey("BusTypeId")
                        .HasConstraintName("FK__Bus_Fare__Bus_Ty__440B1D61");

                    b.HasOne("BusReservationSystem.Repository.RouteDetails", "Route")
                        .WithMany("BusFare")
                        .HasForeignKey("RouteId")
                        .HasConstraintName("FK__Bus_Fare__Route___4316F928");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.BusSchedule", b =>
                {
                    b.HasOne("BusReservationSystem.Repository.BusDetails", "Bus")
                        .WithMany("BusSchedule")
                        .HasForeignKey("BusId")
                        .HasConstraintName("FK__Bus_Sched__Bus_I__46E78A0C")
                        .IsRequired();

                    b.HasOne("BusReservationSystem.Repository.BusFare", "Fare")
                        .WithMany("BusSchedule")
                        .HasForeignKey("FareId")
                        .HasConstraintName("FK__Bus_Sched__Fare___48CFD27E")
                        .IsRequired();

                    b.HasOne("BusReservationSystem.Repository.RouteDetails", "Route")
                        .WithMany("BusSchedule")
                        .HasForeignKey("RouteId")
                        .HasConstraintName("FK__Bus_Sched__Route__47DBAE45")
                        .IsRequired();
                });

            modelBuilder.Entity("BusReservationSystem.Repository.Customer", b =>
                {
                    b.HasOne("BusReservationSystem.Repository.Login", "User")
                        .WithMany("Customer")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Customer__User_I__4E88ABD4");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.Login", b =>
                {
                    b.HasOne("BusReservationSystem.Repository.UserType", "UserType")
                        .WithMany("Login")
                        .HasForeignKey("UserTypeId")
                        .HasConstraintName("FK__Login__User_Type__4BAC3F29");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.Payments", b =>
                {
                    b.HasOne("BusReservationSystem.Repository.TicketBooking", "Booking")
                        .WithMany("Payments")
                        .HasForeignKey("BookingId")
                        .HasConstraintName("FK__Payments__Bookin__5812160E");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.TicketBooking", b =>
                {
                    b.HasOne("BusReservationSystem.Repository.Customer", "Customer")
                        .WithMany("TicketBooking")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Ticket_Bo__Custo__534D60F1");

                    b.HasOne("BusReservationSystem.Repository.BusSchedule", "Schedule")
                        .WithMany("TicketBooking")
                        .HasForeignKey("ScheduleId")
                        .HasConstraintName("FK__Ticket_Bo__Sched__5535A963");

                    b.HasOne("BusReservationSystem.Repository.TypeOfTicket", "TicketType")
                        .WithMany("TicketBooking")
                        .HasForeignKey("TicketTypeId")
                        .HasConstraintName("FK__Ticket_Bo__Ticke__5441852A");
                });

            modelBuilder.Entity("BusReservationSystem.Repository.TicketCancellation", b =>
                {
                    b.HasOne("BusReservationSystem.Repository.TicketBooking", "Booking")
                        .WithMany("TicketCancellation")
                        .HasForeignKey("BookingId")
                        .HasConstraintName("FK__Ticket_Ca__Booki__5BE2A6F2");

                    b.HasOne("BusReservationSystem.Repository.Customer", "Customer")
                        .WithMany("TicketCancellation")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Ticket_Ca__Custo__5DCAEF64");

                    b.HasOne("BusReservationSystem.Repository.BusSchedule", "Schedule")
                        .WithMany("TicketCancellation")
                        .HasForeignKey("ScheduleId")
                        .HasConstraintName("FK__Ticket_Ca__Sched__5EBF139D");

                    b.HasOne("BusReservationSystem.Repository.TypeOfTicket", "TicketType")
                        .WithMany("TicketCancellation")
                        .HasForeignKey("TicketTypeId")
                        .HasConstraintName("FK__Ticket_Ca__Ticke__5CD6CB2B");
                });
#pragma warning restore 612, 618
        }
    }
}
