namespace NoobGGApp.Application.Common.Interfaces;

public interface ICacheable
{
    string CacheGroup { get; } // Optional: For grouping related cache keys
    // New properties for cache option
}