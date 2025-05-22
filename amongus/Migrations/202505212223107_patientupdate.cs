namespace amongus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patientupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "PatientCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "PatientCode", c => c.String(maxLength: 5));
        }
    }
}
