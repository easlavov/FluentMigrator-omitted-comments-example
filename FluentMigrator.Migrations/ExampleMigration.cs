namespace FluentMigrator.Migrations
{
    [Migration(1)]
    public class ExampleMigration : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("FluentMigrator.Migrations.UserDefinedTables.sql");
        }

        public override void Down()
        {
            Execute.Sql("DROP VIEW [dbo].[UserDefinedTables]");
        }
    }
}
