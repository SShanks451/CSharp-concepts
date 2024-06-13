namespace CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}