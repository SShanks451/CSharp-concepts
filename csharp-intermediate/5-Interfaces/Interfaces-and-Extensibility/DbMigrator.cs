﻿namespace CSharp
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migratin started at " + DateTime.Now);

            // Details of migrating the database

            _logger.LogInfo("Migratin finished at " + DateTime.Now);

        }
    }
}