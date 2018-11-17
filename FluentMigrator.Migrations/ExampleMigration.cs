namespace FluentMigrator.Migrations
{
    [Migration(1)]
    public class ExampleMigration : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("FluentMigrator.Migrations.UserDefinedTables.sql");
            Execute.EmbeddedScript("FluentMigrator.Migrations.Max.sql");
            Execute.EmbeddedScript("FluentMigrator.Migrations.CurrentTime.sql");
        }

        public override void Down()
        {
            Execute.Sql("DROP FUNCTION [dbo].[CurrentTime]");
            Execute.Sql("DROP PROCEDURE [dbo].[Max]");
            Execute.Sql("DROP VIEW [dbo].[UserDefinedTables]");
        }
    }
}
