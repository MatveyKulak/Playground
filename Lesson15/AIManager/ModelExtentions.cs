namespace Lesson15.AIManager
{
    public static class ModelExtentions
    {
        public static List<ModelLibrary.Model> GetModelsAbove(this List<ModelLibrary.Model> models, double accurancy)
        {
            return models.Where(m => m.Accuracy > accurancy).ToList();
        }
    }
}
