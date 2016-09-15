using System;
using SQLite;
using Xamagon.SeedApp.Common.Utilities;

namespace Xamagon.SeedApp.Data.Entities
{
    public abstract class EntityBase
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Unique]
        public string Key { get; set; }

        public DateTimeOffset CreatedOn { get; set; } = DateTime.UtcNow;

        protected EntityBase()
        {
            Key = RandomTextGenerator.GenerateRandomString(12);
        }
    }
}