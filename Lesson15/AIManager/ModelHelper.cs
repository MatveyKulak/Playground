namespace Lesson15.AIManager 
{ 
public static class ModelHelper
{
    public static int GetModelCount(List<ModelLibrary.Model> models)
    {
        return models.Count;
    }

    public static List<ModelLibrary.Model> GetModelsByType(List<ModelLibrary.Model> models, ModelType type)
    {
        ArgumentNullException.ThrowIfNull(models);

        return models.Where(m => m.Type == type).ToList();
    }

    public static List<ModelLibrary.Model> SortModelsByDate(List<ModelLibrary.Model> models)
    {
        if (models is null)
        {
            throw new ArgumentNullException(nameof(models));
        }

        return models.OrderBy(m => m.DateCreated).ToList();
    }
}
}

