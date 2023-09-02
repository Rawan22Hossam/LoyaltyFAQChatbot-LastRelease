using LoyaltyFAQChatbot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoyaltyFAQChatbot.EntityConfiguration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.transactionId);
            builder.Property(t => t.transactionType).IsRequired();
            builder.Property(t => t.transactionPoints).IsRequired();
            builder.Property(t => t.transactionDate).IsRequired();
            builder.Property(t => t.transactionDescription).IsRequired();

        }
    }
}
