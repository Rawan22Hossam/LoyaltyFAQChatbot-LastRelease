using LoyaltyFAQChatbot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoyaltyFAQChatbot.EntityConfiguration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(t => t.questionId);
            builder.Property(t => t.questionText).IsRequired();
            builder.Property(t => t.creationDate);
            
        }
    }
}
