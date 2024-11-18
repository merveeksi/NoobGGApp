using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoobGGApp.Domain.Entities;

namespace NoobGGApp.Infrastructure.Persistence.EntityFramework.Configurations;

public sealed class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        
            // Relationships
            builder.HasMany<GameRegion>(x => x.GameRegions)
                .WithOne(x => x.Game)
                .HasForeignKey(x => x.GameId);
    }
}