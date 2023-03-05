using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_messagetable_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message2_Writers_ReceiverID",
                table: "Message2");

            migrationBuilder.DropForeignKey(
                name: "FK_Message2_Writers_SenderID",
                table: "Message2");

            migrationBuilder.RenameTable(
                name: "Message2",
                newName: "Message2s");

            migrationBuilder.AddColumn<int>(
                name: "MessageID",
                table: "Message2s",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "MessageDate",
                table: "Message2s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MessageDetails",
                table: "Message2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MessageStatus",
                table: "Message2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Message2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message2s",
                table: "Message2s",
                column: "MessageID");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_ReceiverID",
                table: "Message2s",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_SenderID",
                table: "Message2s",
                column: "SenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_Writers_ReceiverID",
                table: "Message2s",
                column: "ReceiverID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_Writers_SenderID",
                table: "Message2s",
                column: "SenderID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_Writers_ReceiverID",
                table: "Message2s");

            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_Writers_SenderID",
                table: "Message2s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message2s",
                table: "Message2s");

            migrationBuilder.DropIndex(
                name: "IX_Message2s_ReceiverID",
                table: "Message2s");

            migrationBuilder.DropIndex(
                name: "IX_Message2s_SenderID",
                table: "Message2s");

            migrationBuilder.DropColumn(
                name: "MessageID",
                table: "Message2s");

            migrationBuilder.DropColumn(
                name: "MessageDate",
                table: "Message2s");

            migrationBuilder.DropColumn(
                name: "MessageDetails",
                table: "Message2s");

            migrationBuilder.DropColumn(
                name: "MessageStatus",
                table: "Message2s");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Message2s");

            migrationBuilder.RenameTable(
                name: "Message2s",
                newName: "Message2");

            migrationBuilder.AddForeignKey(
                name: "FK_Message2_Writers_ReceiverID",
                table: "Message2",
                column: "ReceiverID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message2_Writers_SenderID",
                table: "Message2",
                column: "SenderID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
