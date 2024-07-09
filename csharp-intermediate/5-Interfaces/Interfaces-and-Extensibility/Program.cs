namespace CSharp
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
            */

            var dbMigrator = new DbMigrator(new FileLogger("C:\\tools\\log.txt")); 
            dbMigrator.Migrate(); 
            
        }
    }
}