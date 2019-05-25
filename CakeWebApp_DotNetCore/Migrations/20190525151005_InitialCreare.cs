using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CakeWebApp_DotNetCore.Migrations
{
    public partial class InitialCreare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHUCVUs",
                columns: table => new
                {
                    MaChucVu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenChucVu = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHUCVUs", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "DANHMUCSANPHAMs",
                columns: table => new
                {
                    MaDanhMuc = table.Column<int>(nullable: false),
                    MaDanhMucCha = table.Column<int>(nullable: true),
                    TenDanhMuc = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DANHMUCSANPHAMs", x => x.MaDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "GIOHANGs",
                columns: table => new
                {
                    MaGioHang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SoLuongLoaiSP = table.Column<int>(nullable: false),
                    TongTien = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GIOHANGs", x => x.MaGioHang);
                });

            migrationBuilder.CreateTable(
                name: "HINHANHs",
                columns: table => new
                {
                    MaHinhAnh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Link = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HINHANHs", x => x.MaHinhAnh);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANGs",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenKhachhang = table.Column<string>(maxLength: 50, nullable: false),
                    SoDienThoai = table.Column<string>(maxLength: 15, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANGs", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LOAIADMINs",
                columns: table => new
                {
                    MaLoaiAdmin = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenLoaiAdmin = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAIADMINs", x => x.MaLoaiAdmin);
                });

            migrationBuilder.CreateTable(
                name: "THANHVIENs",
                columns: table => new
                {
                    MaThanhVien = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenThanhVien = table.Column<string>(maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: false),
                    SDT = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordTK = table.Column<string>(maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 200, nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THANHVIENs", x => x.MaThanhVien);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIENs",
                columns: table => new
                {
                    MaNhanVien = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaChucVu = table.Column<int>(nullable: false),
                    TenNhanVien = table.Column<string>(maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: false),
                    SDT = table.Column<string>(maxLength: 15, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 200, nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "date", nullable: false),
                    TienLuong = table.Column<string>(maxLength: 12, nullable: false),
                    TienTroCap = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIENs", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NHANVIENs_CHUCVUs_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "CHUCVUs",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SANPHAMs",
                columns: table => new
                {
                    MaSanPham = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaDanhMuc = table.Column<int>(nullable: false),
                    MaHinhAnh = table.Column<int>(nullable: false),
                    TenSanPham = table.Column<string>(maxLength: 200, nullable: false),
                    GiaBan = table.Column<string>(maxLength: 12, nullable: false),
                    ChietKhau = table.Column<string>(maxLength: 12, nullable: false),
                    NgayTaoSP = table.Column<DateTime>(type: "date", nullable: false),
                    LuotXemSP = table.Column<int>(nullable: false),
                    LuotThichSP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANPHAMs", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK_SANPHAMs_DANHMUCSANPHAMs_MaDanhMuc",
                        column: x => x.MaDanhMuc,
                        principalTable: "DANHMUCSANPHAMs",
                        principalColumn: "MaDanhMuc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SANPHAMs_HINHANHs_MaHinhAnh",
                        column: x => x.MaHinhAnh,
                        principalTable: "HINHANHs",
                        principalColumn: "MaHinhAnh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GIAODICHes",
                columns: table => new
                {
                    MaGiaoDich = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaGioHang = table.Column<int>(nullable: false),
                    MaKhachHang = table.Column<int>(nullable: true),
                    MaThanhVien = table.Column<int>(nullable: true),
                    TinhTrang = table.Column<string>(maxLength: 10, nullable: false),
                    GhiChu = table.Column<string>(maxLength: 200, nullable: true),
                    ThoiDiemGiaoDich = table.Column<DateTime>(nullable: false),
                    TongTien = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GIAODICHes", x => x.MaGiaoDich);
                    table.ForeignKey(
                        name: "FK_GIAODICHes_GIOHANGs_MaGioHang",
                        column: x => x.MaGioHang,
                        principalTable: "GIOHANGs",
                        principalColumn: "MaGioHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GIAODICHes_KHACHHANGs_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KHACHHANGs",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GIAODICHes_THANHVIENs_MaThanhVien",
                        column: x => x.MaThanhVien,
                        principalTable: "THANHVIENs",
                        principalColumn: "MaThanhVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TAIKHOANADMINs",
                columns: table => new
                {
                    MaTaiKhoan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaLoaiAdmin = table.Column<int>(nullable: false),
                    MaNhanVien = table.Column<int>(nullable: true),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordTK = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAIKHOANADMINs", x => x.MaTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TAIKHOANADMINs_LOAIADMINs_MaLoaiAdmin",
                        column: x => x.MaLoaiAdmin,
                        principalTable: "LOAIADMINs",
                        principalColumn: "MaLoaiAdmin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TAIKHOANADMINs_NHANVIENs_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NHANVIENs",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETGIOHANGs",
                columns: table => new
                {
                    MaSanPham = table.Column<int>(nullable: false),
                    MaGioHang = table.Column<int>(nullable: false),
                    SoLuongSP = table.Column<int>(nullable: false),
                    ThanhTien = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETGIOHANGs", x => new { x.MaGioHang, x.MaSanPham });
                    table.ForeignKey(
                        name: "FK_CHITIETGIOHANGs_GIOHANGs_MaGioHang",
                        column: x => x.MaGioHang,
                        principalTable: "GIOHANGs",
                        principalColumn: "MaGioHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CHITIETGIOHANGs_SANPHAMs_MaSanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SANPHAMs",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DONHANGs",
                columns: table => new
                {
                    MaDonHang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaGiaoDich = table.Column<int>(nullable: false),
                    MaNhanVien = table.Column<int>(nullable: true),
                    TinhTrangGiaohang = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DONHANGs", x => x.MaDonHang);
                    table.ForeignKey(
                        name: "FK_DONHANGs_GIAODICHes_MaGiaoDich",
                        column: x => x.MaGiaoDich,
                        principalTable: "GIAODICHes",
                        principalColumn: "MaGiaoDich",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DONHANGs_NHANVIENs_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NHANVIENs",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETGIOHANGs_MaSanPham",
                table: "CHITIETGIOHANGs",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_DONHANGs_MaGiaoDich",
                table: "DONHANGs",
                column: "MaGiaoDich");

            migrationBuilder.CreateIndex(
                name: "IX_DONHANGs_MaNhanVien",
                table: "DONHANGs",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_GIAODICHes_MaGioHang",
                table: "GIAODICHes",
                column: "MaGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GIAODICHes_MaKhachHang",
                table: "GIAODICHes",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_GIAODICHes_MaThanhVien",
                table: "GIAODICHes",
                column: "MaThanhVien");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIENs_MaChucVu",
                table: "NHANVIENs",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMs_MaDanhMuc",
                table: "SANPHAMs",
                column: "MaDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMs_MaHinhAnh",
                table: "SANPHAMs",
                column: "MaHinhAnh");

            migrationBuilder.CreateIndex(
                name: "IX_TAIKHOANADMINs_MaLoaiAdmin",
                table: "TAIKHOANADMINs",
                column: "MaLoaiAdmin");

            migrationBuilder.CreateIndex(
                name: "IX_TAIKHOANADMINs_MaNhanVien",
                table: "TAIKHOANADMINs",
                column: "MaNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHITIETGIOHANGs");

            migrationBuilder.DropTable(
                name: "DONHANGs");

            migrationBuilder.DropTable(
                name: "TAIKHOANADMINs");

            migrationBuilder.DropTable(
                name: "SANPHAMs");

            migrationBuilder.DropTable(
                name: "GIAODICHes");

            migrationBuilder.DropTable(
                name: "LOAIADMINs");

            migrationBuilder.DropTable(
                name: "NHANVIENs");

            migrationBuilder.DropTable(
                name: "DANHMUCSANPHAMs");

            migrationBuilder.DropTable(
                name: "HINHANHs");

            migrationBuilder.DropTable(
                name: "GIOHANGs");

            migrationBuilder.DropTable(
                name: "KHACHHANGs");

            migrationBuilder.DropTable(
                name: "THANHVIENs");

            migrationBuilder.DropTable(
                name: "CHUCVUs");
        }
    }
}
