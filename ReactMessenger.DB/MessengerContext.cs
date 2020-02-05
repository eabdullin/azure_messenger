using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ReactMessenger.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactMessenger.DB
{
    public class MessengerContext : DbContext
    {
        public MessengerContext(IOptions<CosmosDbOptions> options)
        {
            this.cosmosDbOptions = options.Value;
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Message> Messages { get; set; }

        private CosmosDbOptions cosmosDbOptions;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (cosmosDbOptions == null) throw new ArgumentNullException();
            optionsBuilder.UseCosmos(
            cosmosDbOptions.Url,
            cosmosDbOptions.Key,
            cosmosDbOptions.Database,
            x =>
            {
                x.ConnectionMode(Microsoft.Azure.Cosmos.ConnectionMode.Gateway);
            }
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToContainer("Users");
            modelBuilder.Entity<Message>().ToContainer("Messages");
        }
    }
}
