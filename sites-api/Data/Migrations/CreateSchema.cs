using FluentMigrator;

namespace sites_api.Data.Migrations
{
    [Migration(05022025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("site")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("type").AsString(120).NotNullable()
                .WithColumn("pageNumber").AsInt32().NotNullable()
                .WithColumn("price").AsInt32().NotNullable();



        }
    }
}
