using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khachs",
                columns: table => new
                {
                    MaKhach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenKhach = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachs", x => x.MaKhach);
                });

            migrationBuilder.CreateTable(
                name: "LoaiHangs",
                columns: table => new
                {
                    MaLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHangs", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCaps",
                columns: table => new
                {
                    MaNCC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenNCC = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCaps", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieus",
                columns: table => new
                {
                    MaThuongHieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nuoc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieus", x => x.MaThuongHieu);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonBans",
                columns: table => new
                {
                    MaHDBan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaKhach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayBan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonBans", x => x.MaHDBan);
                    table.ForeignKey(
                        name: "FK_HoaDonBans_Khachs_MaKhach",
                        column: x => x.MaKhach,
                        principalTable: "Khachs",
                        principalColumn: "MaKhach",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonBans_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonNhaps",
                columns: table => new
                {
                    MaHDNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaNCC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonNhaps", x => x.MaHDNhap);
                    table.ForeignKey(
                        name: "FK_HoaDonNhaps_NhaCungCaps_MaNCC",
                        column: x => x.MaNCC,
                        principalTable: "NhaCungCaps",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonNhaps_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hangs",
                columns: table => new
                {
                    MaHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaThuongHieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaNCC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DonGiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Anh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hangs", x => x.MaHang);
                    table.ForeignKey(
                        name: "FK_Hangs_LoaiHangs_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiHangs",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hangs_NhaCungCaps_MaNCC",
                        column: x => x.MaNCC,
                        principalTable: "NhaCungCaps",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hangs_ThuongHieus_MaThuongHieu",
                        column: x => x.MaThuongHieu,
                        principalTable: "ThuongHieus",
                        principalColumn: "MaThuongHieu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHDBans",
                columns: table => new
                {
                    MaHDBan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHDBans", x => new { x.MaHDBan, x.MaHang });
                    table.ForeignKey(
                        name: "FK_ChiTietHDBans_Hangs_MaHang",
                        column: x => x.MaHang,
                        principalTable: "Hangs",
                        principalColumn: "MaHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietHDBans_HoaDonBans_MaHDBan",
                        column: x => x.MaHDBan,
                        principalTable: "HoaDonBans",
                        principalColumn: "MaHDBan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHDNhaps",
                columns: table => new
                {
                    MaHDNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChietKhau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHDNhaps", x => new { x.MaHDNhap, x.MaHang });
                    table.ForeignKey(
                        name: "FK_ChiTietHDNhaps_Hangs_MaHang",
                        column: x => x.MaHang,
                        principalTable: "Hangs",
                        principalColumn: "MaHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietHDNhaps_HoaDonNhaps_MaHDNhap",
                        column: x => x.MaHDNhap,
                        principalTable: "HoaDonNhaps",
                        principalColumn: "MaHDNhap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHDBans_MaHang",
                table: "ChiTietHDBans",
                column: "MaHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHDNhaps_MaHang",
                table: "ChiTietHDNhaps",
                column: "MaHang");

            migrationBuilder.CreateIndex(
                name: "IX_Hangs_MaLoai",
                table: "Hangs",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_Hangs_MaNCC",
                table: "Hangs",
                column: "MaNCC");

            migrationBuilder.CreateIndex(
                name: "IX_Hangs_MaThuongHieu",
                table: "Hangs",
                column: "MaThuongHieu");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBans_MaKhach",
                table: "HoaDonBans",
                column: "MaKhach");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBans_MaNhanVien",
                table: "HoaDonBans",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhaps_MaNCC",
                table: "HoaDonNhaps",
                column: "MaNCC");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhaps_MaNhanVien",
                table: "HoaDonNhaps",
                column: "MaNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHDBans");

            migrationBuilder.DropTable(
                name: "ChiTietHDNhaps");

            migrationBuilder.DropTable(
                name: "HoaDonBans");

            migrationBuilder.DropTable(
                name: "Hangs");

            migrationBuilder.DropTable(
                name: "HoaDonNhaps");

            migrationBuilder.DropTable(
                name: "Khachs");

            migrationBuilder.DropTable(
                name: "LoaiHangs");

            migrationBuilder.DropTable(
                name: "ThuongHieus");

            migrationBuilder.DropTable(
                name: "NhaCungCaps");

            migrationBuilder.DropTable(
                name: "NhanViens");
        }
    }
}
