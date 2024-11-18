using NoobGGApp.Domain.Common.Entities;
using NoobGGApp.Domain.ValueObjects;
using TSID.Creator.NET;

namespace NoobGGApp.Domain.Entities;

public sealed class Game : EntityBase<long>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }


    public Game()
    {
        Id = TsidCreator.GetTsid().ToLong();
    }

    public ICollection<GameRegion> GameRegions { get; set; } = [];
}