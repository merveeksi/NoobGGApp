using NoobGGApp.Application.Common.Models.ObjectStorage;

namespace NoobGGApp.Application.Common.Interf;

public interface IObjectStorage
{
    Task<string> UploadObjectAsync(UploadObjectRequestDto requestDto, CancellationToken cancellationToken = default);
}