using LoyaltyFAQChatbot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoyaltyFAQChatbot.EntityConfiguration
{
    public class SupportTicketConfiguration : IEntityTypeConfiguration<SupportTicket>
    {
        public void Configure(EntityTypeBuilder<SupportTicket> builder)
        {
            builder.HasKey(t => t.ticketId);
            builder.Property(t => t.creationDate).IsRequired();
            builder.Property(t => t.isSolved).IsRequired();
            builder.Property(t => t.ticketDescription).IsRequired();

        }
    }
}
