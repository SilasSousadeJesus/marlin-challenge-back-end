using marlin_challenge_back_end.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace marlin_challenge_back_end.Data.Map
{
    public class PostMap : IEntityTypeConfiguration<PostModel>
    {
        public void Configure(EntityTypeBuilder<PostModel> builder) 
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Body).IsRequired();
        }
    }
}
