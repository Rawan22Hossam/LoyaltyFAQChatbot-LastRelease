using LoyaltyFAQChatbot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoyaltyFAQChatbot.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.userId);
            builder.Property(t => t.userName).IsRequired();
            builder.Property(t => t.mobileNumber).HasMaxLength(11);
            builder.Property(t => t.points).HasMaxLength(200);
        }
    }
}
