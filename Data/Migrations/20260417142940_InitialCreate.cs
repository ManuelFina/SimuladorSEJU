using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimuladorSEJU.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadosCausa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosCausa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Juzgados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juzgados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCausa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCausa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Causas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Circunscripcion = table.Column<int>(type: "int", nullable: false),
                    Expediente = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Caratula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    TipoCausaId = table.Column<int>(type: "int", nullable: false),
                    EstadoCausaId = table.Column<int>(type: "int", nullable: false),
                    JuzgadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Causas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Causas_EstadosCausa_EstadoCausaId",
                        column: x => x.EstadoCausaId,
                        principalTable: "EstadosCausa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Causas_Juzgados_JuzgadoId",
                        column: x => x.JuzgadoId,
                        principalTable: "Juzgados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Causas_TiposCausa_TipoCausaId",
                        column: x => x.TipoCausaId,
                        principalTable: "TiposCausa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Causas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eventos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leida = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificaciones_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CausaId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Causas_CausaId",
                        column: x => x.CausaId,
                        principalTable: "Causas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Causas_EstadoCausaId",
                table: "Causas",
                column: "EstadoCausaId");

            migrationBuilder.CreateIndex(
                name: "IX_Causas_JuzgadoId",
                table: "Causas",
                column: "JuzgadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Causas_TipoCausaId",
                table: "Causas",
                column: "TipoCausaId");

            migrationBuilder.CreateIndex(
                name: "IX_Causas_UsuarioId",
                table: "Causas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_UsuarioId",
                table: "Eventos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_UsuarioId",
                table: "Notificaciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_CausaId",
                table: "Publicaciones",
                column: "CausaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "Causas");

            migrationBuilder.DropTable(
                name: "EstadosCausa");

            migrationBuilder.DropTable(
                name: "Juzgados");

            migrationBuilder.DropTable(
                name: "TiposCausa");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
