using Famecipe.Common;
using Famecipe.Models;

namespace Famecipe.Services;

public class RecipeService
{
    public readonly IRepository<Recipe> _repository;

    public RecipeService(IRepository<Recipe> repository)
    {
        _repository = repository;
    }

    public async Task<Recipe> CreateRecipe(Recipe Recipe)
    {
        try
        {
            Recipe.WhenUpdatedUTC = DateTime.UtcNow;
            Recipe.Identifier = Guid.NewGuid().ToString();
            return await _repository.Create(Recipe);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task DeleteRecipe(string identifier)
    {
        try
        {
            await _repository.Delete(identifier);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task UpdateRecipe(string identifier, Recipe recipe)
    {
        try
        {
            recipe.WhenUpdatedUTC = DateTime.UtcNow;
            await _repository.Update(identifier, recipe);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<Recipe>> GetRecipes()
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

    public async Task<Recipe> GetRecipe(string identifier)
    {
        try
        {
            return await _repository.Get(identifier);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
