using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PhoneBook.API.Models
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        private const string MSSQL = "MSSQL";
        private const string MySQL = "MySQL";
        private const string PostgreSQL = "PostgreSQL";
        private const string SQLite = "SQLite";
        private const string InMemory = "InMemory";

        public ApplicationDbContext CreateDbContext(params string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            string provider = GetEnvironmentVariable("DB_PROVIDER", InMemory);
            if (string.IsNullOrEmpty(provider)) throw new ArgumentException("The given database provider was invalid");

            var connectionString = GetConnectionString(provider);

            switch (provider)
            {
                case MSSQL:
                    {
                        optionsBuilder.UseSqlServer(connectionString);
                    }
                    break;
                case MySQL:
                    {
                        optionsBuilder.UseMySql(connectionString);
                    }
                    break;
                case PostgreSQL:
                    {
                        optionsBuilder.UseNpgsql(connectionString);
                    }
                    break;
                case SQLite:
                    {
                        optionsBuilder.UseSqlite(connectionString);
                    }
                    break;
                case InMemory:
                    {
                        optionsBuilder.UseInMemoryDatabase(connectionString);
                    }
                    break;
            }

            return new ApplicationDbContext(optionsBuilder.Options);
        }

        private static string GetConnectionString(string provider)
        {
            string host = GetEnvironmentVariable("DB_HOST", "localhost");
            string password = GetEnvironmentVariable("DB_PASSWORD");
            string database = GetEnvironmentVariable("DB_DATABASE");
            string filename = GetEnvironmentVariable("DB_FILENAME", Path.Combine(Directory.GetCurrentDirectory(), "PhoneBook.db"));

            switch (provider)
            {
                case MSSQL:
                    {
                        string port = GetEnvironmentVariable("DB_PORT", "1433");
                        string user = GetEnvironmentVariable("DB_USER", "sa");
                        return $"Server={host};Port={port};Database={database};User Id={user};Password={password};";
                    }
                case MySQL:
                    {
                        string port = GetEnvironmentVariable("DB_PORT", "3306");
                        string user = GetEnvironmentVariable("DB_USER", "root");
                        return $"Server={host};Port={port};Database={database};User={user};Password={password};";
                    }
                case PostgreSQL:
                    {
                        string port = GetEnvironmentVariable("DB_PORT", "5432");
                        string user = GetEnvironmentVariable("DB_USER", "postgres");
                        return $"Host={host};Port={port};Database={database};Username={user};Password={password};";
                    }
                case SQLite:
                    {
                        return $"Data Source={filename}";
                    }
                case InMemory:
                    {
                        return new Guid().ToString();
                    }
            }

            return null;
        }

        private static string GetEnvironmentVariable(string key, string defaultValue = "")
        {
            return (Environment.GetEnvironmentVariable(key) ?? defaultValue).Trim();
        }
    }
}
