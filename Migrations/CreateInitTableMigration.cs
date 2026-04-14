using FluentMigrator;
using FluentMigrator.Runner;

namespace DistractionTracker.Migrations
{
    [Migration(202612040935)]
    public class CreateInitTableMigration: Migration
    {
        public override void Up()
        {
            Create.Table("SessionsDb")
                .WithColumn("Id").AsGuid().PrimaryKey().Identity()
                .WithColumn("Username").AsString(100).NotNullable().Unique()
                .WithColumn("Start Time").AsDateTime().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("End Time").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("SessionsDb");
        }
    }
}
