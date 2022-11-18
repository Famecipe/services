using Famecipe.Common;
using Famecipe.Models;

namespace Famecipe.Services;

public class MetadataService
{
    public readonly IRepository<Metadata> _repository;

    public MetadataService(IRepository<Metadata> repository)
    {
        _repository = repository;
    }

    public async Task<Metadata> CreateMetadata(Metadata metadata)
    {
        try
        {
            return await _repository.Create(metadata);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task DeleteMetadata(string key)
    {
        try
        {
            await _repository.Delete(key);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task UpdateMetadata(string key, Metadata metadata)
    {
        try
        {
            await _repository.Update(key, metadata);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<Metadata>> GetMetadata()
    {
        try
        {
            return await _repository.Get();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<Metadata> GetMetadata(string key)
    {
        try
        {
            return await _repository.Get(key);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
