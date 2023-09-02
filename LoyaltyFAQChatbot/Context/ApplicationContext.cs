using LoyaltyFAQChatbot.EntityConfiguration;
using LoyaltyFAQChatbot.Models;
using Microsoft.EntityFrameworkCore;

namespace LoyaltyFAQChatbot.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() { }

        public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new CouponsConfiguration());
            modelBuilder.ApplyConfiguration(new SupportTicketConfiguration());

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Question { get; set; }   
        public DbSet<Answer> Answers { get; set; }
        public DbSet <SupportTicket> SupportTickets { get; set; }
        public DbSet <Coupons> Coupons { get; set; }
        public DbSet <Transaction> transactions { get; set; }

    }
}
