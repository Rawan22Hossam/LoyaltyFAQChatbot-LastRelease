using LoyaltyFAQChatbot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoyaltyFAQChatbot.EntityConfiguration
{
    public class CouponsConfiguration : IEntityTypeConfiguration<Coupons>
    {
        public void Configure(EntityTypeBuilder<Coupons> builder)
        {
            builder.HasKey(t => t.couponId);
            builder.Property(t => t.couponNumber).IsRequired();
            builder.Property(t => t.expiryDate).IsRequired();
            builder.Property(t => t.couponValue).IsRequired();
            builder.Property(t => t.couponStatus).IsRequired();
        }
       
    }
}
