using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.API1.Migrations
{
    /// <inheritdoc />
    public partial class Rerelate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Students_StudentsId",
                table: "StudentTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Teachers_TeachersId",
                table: "StudentTeacher");

            migrationBuilder.RenameColumn(
                name: "TeachersId",
                table: "StudentTeacher",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "StudentTeacher",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeacher_TeachersId",
                table: "StudentTeacher",
                newName: "IX_StudentTeacher_TeacherId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Students_StudentId",
                table: "StudentTeacher",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Teachers_TeacherId",
                table: "StudentTeacher",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Students_StudentId",
                table: "StudentTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Teachers_TeacherId",
                table: "StudentTeacher");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "StudentTeacher",
                newName: "TeachersId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "StudentTeacher",
                newName: "StudentsId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeacher_TeacherId",
                table: "StudentTeacher",
                newName: "IX_StudentTeacher_TeachersId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Students_StudentsId",
                table: "StudentTeacher",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Teachers_TeachersId",
                table: "StudentTeacher",
                column: "TeachersId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
