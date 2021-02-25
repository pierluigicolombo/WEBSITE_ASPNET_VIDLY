namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMemberShipTypeTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            Sql("UPDATE MembershipTypes set Name='Pay as You Go' WHERE ID=1 ");
            Sql("UPDATE MembershipTypes set Name='Month' WHERE ID=2 ");
            Sql("UPDATE MembershipTypes set Name='5 Months' WHERE ID=3 ");
            Sql("UPDATE MembershipTypes set Name='5 Year' WHERE ID=4 ");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
