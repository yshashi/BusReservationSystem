using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusReservationSystem.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bus_Type",
                columns: table => new
                {
                    Bus_Type_Id = table.Column<int>(nullable: false),
                    Bus_Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bus_Type", x => x.Bus_Type_Id);
                });

            migrationBuilder.CreateTable(
                name: "Route_Details",
                columns: table => new
                {
                    Route_Id = table.Column<int>(nullable: false),
                    Departure_Station = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Destination_Station = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Route_De__6DC9D9115B4E79A7", x => x.Route_Id);
                });

            migrationBuilder.CreateTable(
                name: "Type_Of_Ticket",
                columns: table => new
                {
                    Ticket_Type_Id = table.Column<int>(nullable: false),
                    Ticket_Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Type_Of___B272714221014921", x => x.Ticket_Type_Id);
                });

            migrationBuilder.CreateTable(
                name: "User_Type",
                columns: table => new
                {
                    User_Type_Id = table.Column<int>(nullable: false),
                    User_type_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Type", x => x.User_Type_Id);
                });

            migrationBuilder.CreateTable(
                name: "Bus_Details",
                columns: table => new
                {
                    Bus_Id = table.Column<int>(nullable: false),
                    Registration_Number = table.Column<int>(nullable: true),
                    Total_Seats = table.Column<int>(nullable: true),
                    Bus_Type_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bus_Deta__B0524D192ABDD14D", x => x.Bus_Id);
                    table.ForeignKey(
                        name: "FK__Bus_Detai__Bus_T__3E52440B",
                        column: x => x.Bus_Type_Id,
                        principalTable: "Bus_Type",
                        principalColumn: "Bus_Type_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bus_Fare",
                columns: table => new
                {
                    Fare_Id = table.Column<int>(nullable: false),
                    Route_Id = table.Column<int>(nullable: true),
                    Fare_Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Bus_Type_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bus_Fare__495DB84F66705523", x => x.Fare_Id);
                    table.ForeignKey(
                        name: "FK__Bus_Fare__Bus_Ty__440B1D61",
                        column: x => x.Bus_Type_Id,
                        principalTable: "Bus_Type",
                        principalColumn: "Bus_Type_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Bus_Fare__Route___4316F928",
                        column: x => x.Route_Id,
                        principalTable: "Route_Details",
                        principalColumn: "Route_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    User_Id = table.Column<int>(nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    User_Type_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Login__206D917094606AEB", x => x.User_Id);
                    table.ForeignKey(
                        name: "FK__Login__User_Type__4BAC3F29",
                        column: x => x.User_Type_Id,
                        principalTable: "User_Type",
                        principalColumn: "User_Type_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bus_Schedule",
                columns: table => new
                {
                    Schedule_Id = table.Column<int>(nullable: false),
                    Bus_Id = table.Column<int>(nullable: false),
                    Driver_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Route_Id = table.Column<int>(nullable: false),
                    Departure_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Arrival_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Booked_Seats = table.Column<int>(nullable: true),
                    Available_Seats = table.Column<int>(nullable: true),
                    Arrival_Time = table.Column<TimeSpan>(nullable: true),
                    Departure_Time = table.Column<TimeSpan>(nullable: true),
                    Fare_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bus_Sche__8C4D3C5B5121E932", x => x.Schedule_Id);
                    table.ForeignKey(
                        name: "FK__Bus_Sched__Bus_I__46E78A0C",
                        column: x => x.Bus_Id,
                        principalTable: "Bus_Details",
                        principalColumn: "Bus_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Bus_Sched__Fare___48CFD27E",
                        column: x => x.Fare_Id,
                        principalTable: "Bus_Fare",
                        principalColumn: "Fare_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Bus_Sched__Route__47DBAE45",
                        column: x => x.Route_Id,
                        principalTable: "Route_Details",
                        principalColumn: "Route_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(nullable: false),
                    First_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Last_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Date_Of_Birth = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Email_Id = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Pincode = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Contact_No = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    User_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customer_Id);
                    table.ForeignKey(
                        name: "FK__Customer__User_I__4E88ABD4",
                        column: x => x.User_Id,
                        principalTable: "Login",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ticket_Booking",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(nullable: false),
                    Available_Seats = table.Column<int>(nullable: true),
                    Fare = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Date_Of_Booking = table.Column<DateTime>(type: "date", nullable: true),
                    Onward_Journey_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Return_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Customer_Id = table.Column<int>(nullable: true),
                    Ticket_Type_Id = table.Column<int>(nullable: true),
                    Schedule_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ticket_B__35ABFDC0EF7B357D", x => x.Booking_Id);
                    table.ForeignKey(
                        name: "FK__Ticket_Bo__Custo__534D60F1",
                        column: x => x.Customer_Id,
                        principalTable: "Customer",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Ticket_Bo__Sched__5535A963",
                        column: x => x.Schedule_Id,
                        principalTable: "Bus_Schedule",
                        principalColumn: "Schedule_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Ticket_Bo__Ticke__5441852A",
                        column: x => x.Ticket_Type_Id,
                        principalTable: "Type_Of_Ticket",
                        principalColumn: "Ticket_Type_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Payment_Id = table.Column<int>(nullable: false),
                    Card_Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Bank_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Card_No = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Card_Holder_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Total_Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Booking_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payments__DA6C7FC1BE7AFC0B", x => x.Payment_Id);
                    table.ForeignKey(
                        name: "FK__Payments__Bookin__5812160E",
                        column: x => x.Booking_Id,
                        principalTable: "Ticket_Booking",
                        principalColumn: "Booking_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ticket_Cancellation",
                columns: table => new
                {
                    Cancellation_Id = table.Column<int>(nullable: false),
                    Booking_Id = table.Column<int>(nullable: true),
                    Refund_Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Cancellation_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Ticket_Type_Id = table.Column<int>(nullable: true),
                    Customer_Id = table.Column<int>(nullable: true),
                    Schedule_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ticket_C__BC9DC290867F8B3D", x => x.Cancellation_Id);
                    table.ForeignKey(
                        name: "FK__Ticket_Ca__Booki__5BE2A6F2",
                        column: x => x.Booking_Id,
                        principalTable: "Ticket_Booking",
                        principalColumn: "Booking_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Ticket_Ca__Custo__5DCAEF64",
                        column: x => x.Customer_Id,
                        principalTable: "Customer",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Ticket_Ca__Sched__5EBF139D",
                        column: x => x.Schedule_Id,
                        principalTable: "Bus_Schedule",
                        principalColumn: "Schedule_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Ticket_Ca__Ticke__5CD6CB2B",
                        column: x => x.Ticket_Type_Id,
                        principalTable: "Type_Of_Ticket",
                        principalColumn: "Ticket_Type_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bus_Details_Bus_Type_Id",
                table: "Bus_Details",
                column: "Bus_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bus_Fare_Bus_Type_Id",
                table: "Bus_Fare",
                column: "Bus_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bus_Fare_Route_Id",
                table: "Bus_Fare",
                column: "Route_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bus_Schedule_Bus_Id",
                table: "Bus_Schedule",
                column: "Bus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bus_Schedule_Fare_Id",
                table: "Bus_Schedule",
                column: "Fare_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bus_Schedule_Route_Id",
                table: "Bus_Schedule",
                column: "Route_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_User_Id",
                table: "Customer",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Login_User_Type_Id",
                table: "Login",
                column: "User_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Booking_Id",
                table: "Payments",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Booking_Customer_Id",
                table: "Ticket_Booking",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Booking_Schedule_Id",
                table: "Ticket_Booking",
                column: "Schedule_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Booking_Ticket_Type_Id",
                table: "Ticket_Booking",
                column: "Ticket_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Cancellation_Booking_Id",
                table: "Ticket_Cancellation",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Cancellation_Customer_Id",
                table: "Ticket_Cancellation",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Cancellation_Schedule_Id",
                table: "Ticket_Cancellation",
                column: "Schedule_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_Cancellation_Ticket_Type_Id",
                table: "Ticket_Cancellation",
                column: "Ticket_Type_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Ticket_Cancellation");

            migrationBuilder.DropTable(
                name: "Ticket_Booking");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Bus_Schedule");

            migrationBuilder.DropTable(
                name: "Type_Of_Ticket");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Bus_Details");

            migrationBuilder.DropTable(
                name: "Bus_Fare");

            migrationBuilder.DropTable(
                name: "User_Type");

            migrationBuilder.DropTable(
                name: "Bus_Type");

            migrationBuilder.DropTable(
                name: "Route_Details");
        }
    }
}
