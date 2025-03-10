using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InT.Repository.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    A_SSN = table.Column<int>(type: "int", nullable: false),
                    A_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admin__C37734FE4EEB0C72", x => x.A_SSN);
                });

            migrationBuilder.CreateTable(
                name: "brand",
                columns: table => new
                {
                    b_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    b_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__brand__56B8275311181CD8", x => x.b_Code);
                });

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    c_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__color__0B18F0EEC14DE22B", x => x.c_Code);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    M_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Message__18B1A317860AF466", x => x.M_ID);
                });

            migrationBuilder.CreateTable(
                name: "search_history",
                columns: table => new
                {
                    S_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    notification = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__search_h__A3DFF16D86D404A9", x => x.S_ID);
                });

            migrationBuilder.CreateTable(
                name: "USERR",
                columns: table => new
                {
                    U_SSN = table.Column<int>(type: "int", nullable: false),
                    U_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USERR__3A06FD8FA209E569", x => x.U_SSN);
                });

            migrationBuilder.CreateTable(
                name: "Admin_Phone",
                columns: table => new
                {
                    A_SSN = table.Column<int>(type: "int", nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admin_Ph__820D013416215AC3", x => new { x.A_SSN, x.Phone_Number });
                    table.ForeignKey(
                        name: "FK__Admin_Pho__A_SSN__3E52440B",
                        column: x => x.A_SSN,
                        principalTable: "Admin",
                        principalColumn: "A_SSN");
                });

            migrationBuilder.CreateTable(
                name: "Guidance",
                columns: table => new
                {
                    G_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    G_content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_SSN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Guidance__153A8ED2B6A0AA66", x => x.G_ID);
                    table.ForeignKey(
                        name: "FK__Guidance__A_SSN__5535A963",
                        column: x => x.A_SSN,
                        principalTable: "Admin",
                        principalColumn: "A_SSN");
                });

            migrationBuilder.CreateTable(
                name: "model",
                columns: table => new
                {
                    m_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    m_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    b_Code = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__model__2B3C4A37A2C28094", x => x.m_Code);
                    table.ForeignKey(
                        name: "FK__model__b_Code__4BAC3F29",
                        column: x => x.b_Code,
                        principalTable: "brand",
                        principalColumn: "b_Code");
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    C_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    c_plate_number = table.Column<int>(type: "int", nullable: true),
                    c_Code = table.Column<int>(type: "int", nullable: true),
                    b_Code = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Car__A9FDEC12A64A3DDA", x => x.C_ID);
                    table.ForeignKey(
                        name: "FK__Car__b_Code__45F365D3",
                        column: x => x.b_Code,
                        principalTable: "brand",
                        principalColumn: "b_Code");
                    table.ForeignKey(
                        name: "FK__Car__c_Code__44FF419A",
                        column: x => x.c_Code,
                        principalTable: "color",
                        principalColumn: "c_Code");
                });

            migrationBuilder.CreateTable(
                name: "Admin_Manage_USER",
                columns: table => new
                {
                    U_SSN = table.Column<int>(type: "int", nullable: false),
                    A_SSN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admin_Ma__C6318EC0C08A3EAE", x => new { x.U_SSN, x.A_SSN });
                    table.ForeignKey(
                        name: "FK__Admin_Man__A_SSN__6D0D32F4",
                        column: x => x.A_SSN,
                        principalTable: "Admin",
                        principalColumn: "A_SSN");
                    table.ForeignKey(
                        name: "FK__Admin_Man__U_SSN__6E01572D",
                        column: x => x.U_SSN,
                        principalTable: "USERR",
                        principalColumn: "U_SSN");
                });

            migrationBuilder.CreateTable(
                name: "User_Message_send_receive",
                columns: table => new
                {
                    U_SSN = table.Column<int>(type: "int", nullable: false),
                    M_ID = table.Column<int>(type: "int", nullable: false),
                    A_SSN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User_Mes__A44E908AC72371DA", x => new { x.U_SSN, x.M_ID, x.A_SSN });
                    table.ForeignKey(
                        name: "FK__User_Mess__A_SSN__52593CB8",
                        column: x => x.A_SSN,
                        principalTable: "Admin",
                        principalColumn: "A_SSN");
                    table.ForeignKey(
                        name: "FK__User_Mess__U_SSN__5070F446",
                        column: x => x.U_SSN,
                        principalTable: "USERR",
                        principalColumn: "U_SSN");
                    table.ForeignKey(
                        name: "FK__User_Messa__M_ID__5165187F",
                        column: x => x.M_ID,
                        principalTable: "Message",
                        principalColumn: "M_ID");
                });

            migrationBuilder.CreateTable(
                name: "User_Phone",
                columns: table => new
                {
                    U_SSN = table.Column<int>(type: "int", nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User_Pho__7B7CC84537928C8E", x => new { x.U_SSN, x.Phone_Number });
                    table.ForeignKey(
                        name: "FK__User_Phon__U_SSN__3B75D760",
                        column: x => x.U_SSN,
                        principalTable: "USERR",
                        principalColumn: "U_SSN");
                });

            migrationBuilder.CreateTable(
                name: "User_search",
                columns: table => new
                {
                    U_SSN = table.Column<int>(type: "int", nullable: false),
                    S_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User_sea__3A06FD8FEAED6457", x => x.U_SSN);
                    table.ForeignKey(
                        name: "FK__User_sear__U_SSN__656C112C",
                        column: x => x.U_SSN,
                        principalTable: "USERR",
                        principalColumn: "U_SSN");
                    table.ForeignKey(
                        name: "FK__User_searc__S_ID__66603565",
                        column: x => x.S_ID,
                        principalTable: "search_history",
                        principalColumn: "S_ID");
                });

            migrationBuilder.CreateTable(
                name: "User_Guidance_view",
                columns: table => new
                {
                    U_SSN = table.Column<int>(type: "int", nullable: false),
                    G_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User_Gui__0B5555625D04C383", x => new { x.U_SSN, x.G_ID });
                    table.ForeignKey(
                        name: "FK__User_Guid__U_SSN__5812160E",
                        column: x => x.U_SSN,
                        principalTable: "USERR",
                        principalColumn: "U_SSN");
                    table.ForeignKey(
                        name: "FK__User_Guida__G_ID__59063A47",
                        column: x => x.G_ID,
                        principalTable: "Guidance",
                        principalColumn: "G_ID");
                });

            migrationBuilder.CreateTable(
                name: "Admin_Mnage_car",
                columns: table => new
                {
                    C_ID = table.Column<int>(type: "int", nullable: false),
                    A_SSN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Admin_Mn__A9FDEC12D5B1E801", x => x.C_ID);
                    table.ForeignKey(
                        name: "FK__Admin_Mna__A_SSN__693CA210",
                        column: x => x.A_SSN,
                        principalTable: "Admin",
                        principalColumn: "A_SSN");
                    table.ForeignKey(
                        name: "FK__Admin_Mnag__C_ID__6A30C649",
                        column: x => x.C_ID,
                        principalTable: "Car",
                        principalColumn: "C_ID");
                });

            migrationBuilder.CreateTable(
                name: "Car_Photo",
                columns: table => new
                {
                    Photo_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_ID = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Car_Phot__7A07F6C29F750EED", x => x.Photo_ID);
                    table.ForeignKey(
                        name: "FK__Car_Photo__C_ID__48CFD27E",
                        column: x => x.C_ID,
                        principalTable: "Car",
                        principalColumn: "C_ID");
                });

            migrationBuilder.CreateTable(
                name: "search_car",
                columns: table => new
                {
                    C_ID = table.Column<int>(type: "int", nullable: false),
                    S_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__search_c__A9FDEC12D7691AB4", x => x.C_ID);
                    table.ForeignKey(
                        name: "FK__search_car__C_ID__628FA481",
                        column: x => x.C_ID,
                        principalTable: "Car",
                        principalColumn: "C_ID");
                    table.ForeignKey(
                        name: "FK__search_car__S_ID__619B8048",
                        column: x => x.S_ID,
                        principalTable: "search_history",
                        principalColumn: "S_ID");
                });

            migrationBuilder.CreateTable(
                name: "User_Car_view",
                columns: table => new
                {
                    U_SSN = table.Column<int>(type: "int", nullable: false),
                    C_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User_Car__0099234E2C0F9B90", x => new { x.U_SSN, x.C_ID });
                    table.ForeignKey(
                        name: "FK__User_Car___U_SSN__5BE2A6F2",
                        column: x => x.U_SSN,
                        principalTable: "USERR",
                        principalColumn: "U_SSN");
                    table.ForeignKey(
                        name: "FK__User_Car_v__C_ID__5CD6CB2B",
                        column: x => x.C_ID,
                        principalTable: "Car",
                        principalColumn: "C_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_Manage_USER_A_SSN",
                table: "Admin_Manage_USER",
                column: "A_SSN");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_Mnage_car_A_SSN",
                table: "Admin_Mnage_car",
                column: "A_SSN");

            migrationBuilder.CreateIndex(
                name: "IX_Car_b_Code",
                table: "Car",
                column: "b_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Car_c_Code",
                table: "Car",
                column: "c_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Car_Photo_C_ID",
                table: "Car_Photo",
                column: "C_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Guidance_A_SSN",
                table: "Guidance",
                column: "A_SSN");

            migrationBuilder.CreateIndex(
                name: "IX_model_b_Code",
                table: "model",
                column: "b_Code");

            migrationBuilder.CreateIndex(
                name: "IX_search_car_S_ID",
                table: "search_car",
                column: "S_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Car_view_C_ID",
                table: "User_Car_view",
                column: "C_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Guidance_view_G_ID",
                table: "User_Guidance_view",
                column: "G_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Message_send_receive_A_SSN",
                table: "User_Message_send_receive",
                column: "A_SSN");

            migrationBuilder.CreateIndex(
                name: "IX_User_Message_send_receive_M_ID",
                table: "User_Message_send_receive",
                column: "M_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_search_S_ID",
                table: "User_search",
                column: "S_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin_Manage_USER");

            migrationBuilder.DropTable(
                name: "Admin_Mnage_car");

            migrationBuilder.DropTable(
                name: "Admin_Phone");

            migrationBuilder.DropTable(
                name: "Car_Photo");

            migrationBuilder.DropTable(
                name: "model");

            migrationBuilder.DropTable(
                name: "search_car");

            migrationBuilder.DropTable(
                name: "User_Car_view");

            migrationBuilder.DropTable(
                name: "User_Guidance_view");

            migrationBuilder.DropTable(
                name: "User_Message_send_receive");

            migrationBuilder.DropTable(
                name: "User_Phone");

            migrationBuilder.DropTable(
                name: "User_search");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Guidance");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "USERR");

            migrationBuilder.DropTable(
                name: "search_history");

            migrationBuilder.DropTable(
                name: "brand");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "Admin");
        }
    }
}
