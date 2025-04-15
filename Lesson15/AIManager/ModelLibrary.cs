namespace Lesson15.AIManager
{
    public class ModelLibrary
    {
        private List<Model> _models = new List<Model>();

        public void AddModel(Model model)
        {
            _models.Add(model);
        }

        public List<Model> GetModels()
        {
            return _models;
        }

        public List<Model> GetModelsByType(ModelType type)
        {
            return _models.Where(p => p.Type == type).ToList();
        }

        public List<Model> OrderByDate()
        {
            return _models.OrderBy(m => m.DateCreated).ToList();
        }
        public class Model
        {
            public string Name { get; set; }
            public ModelType Type { get; set; }
            public DateTime DateCreated { get; set; }
            public double Accuracy { get; set; }

            public string GetModelInfo()
            {
                return $"Name: {Name}, {Type} - {Accuracy} (Created: {DateCreated:dd/MM/yyyy})";
            }

            public override string ToString()
            {
                return $"{Name} ({Type}, {Accuracy})";
            }
        }
    }
}
