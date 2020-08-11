using Microsoft.EntityFrameworkCore.Migrations;

namespace FAMSWPF.Migrations
{
    public partial class GeneralJournalItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GJ_Item_MainAccount_MainAccount",
                schema: "Transactions",
                table: "GJ_Item");

            migrationBuilder.DropForeignKey(
                name: "FK_GJ_Item_GeneralJournal_MainTranx",
                schema: "Transactions",
                table: "GJ_Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GJ_Item",
                schema: "Transactions",
                table: "GJ_Item");

            migrationBuilder.RenameTable(
                name: "GJ_Item",
                schema: "Transactions",
                newName: "GeneralJournalItems",
                newSchema: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_GJ_Item_MainTranx",
                schema: "Transactions",
                table: "GeneralJournalItems",
                newName: "IX_GeneralJournalItems_MainTranx");

            migrationBuilder.RenameIndex(
                name: "IX_GJ_Item_MainAccount",
                schema: "Transactions",
                table: "GeneralJournalItems",
                newName: "IX_GeneralJournalItems_MainAccount");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralJournalItems",
                schema: "Transactions",
                table: "GeneralJournalItems",
                column: "GTAccId");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralJournalItems_MainAccount_MainAccount",
                schema: "Transactions",
                table: "GeneralJournalItems",
                column: "MainAccount",
                principalSchema: "Foundation",
                principalTable: "MainAccount",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralJournalItems_GeneralJournal_MainTranx",
                schema: "Transactions",
                table: "GeneralJournalItems",
                column: "MainTranx",
                principalSchema: "Transactions",
                principalTable: "GeneralJournal",
                principalColumn: "GenTranxId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralJournalItems_MainAccount_MainAccount",
                schema: "Transactions",
                table: "GeneralJournalItems");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralJournalItems_GeneralJournal_MainTranx",
                schema: "Transactions",
                table: "GeneralJournalItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralJournalItems",
                schema: "Transactions",
                table: "GeneralJournalItems");

            migrationBuilder.RenameTable(
                name: "GeneralJournalItems",
                schema: "Transactions",
                newName: "GJ_Item",
                newSchema: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_GeneralJournalItems_MainTranx",
                schema: "Transactions",
                table: "GJ_Item",
                newName: "IX_GJ_Item_MainTranx");

            migrationBuilder.RenameIndex(
                name: "IX_GeneralJournalItems_MainAccount",
                schema: "Transactions",
                table: "GJ_Item",
                newName: "IX_GJ_Item_MainAccount");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GJ_Item",
                schema: "Transactions",
                table: "GJ_Item",
                column: "GTAccId");

            migrationBuilder.AddForeignKey(
                name: "FK_GJ_Item_MainAccount_MainAccount",
                schema: "Transactions",
                table: "GJ_Item",
                column: "MainAccount",
                principalSchema: "Foundation",
                principalTable: "MainAccount",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GJ_Item_GeneralJournal_MainTranx",
                schema: "Transactions",
                table: "GJ_Item",
                column: "MainTranx",
                principalSchema: "Transactions",
                principalTable: "GeneralJournal",
                principalColumn: "GenTranxId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
