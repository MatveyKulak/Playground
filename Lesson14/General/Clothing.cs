namespace Lesson14.General
{
    public class Clothing : Product
    {
        public int Size { get; set; }
        public string Material { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Товар: {Name}, Цена: {Price}, Размер: {Size}, Материал: {Material}");
        }
    }
}
