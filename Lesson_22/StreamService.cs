using System.Text;

namespace Lesson_22
{
    public class BinaryFileService
    {
        public void WriteBytes (string path, byte[] data)
        {
            using var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            fs.Write(data, 0, data.Length);
        }

        public byte[] ReadBytes (string path)
        {
            using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var buffer = new byte[fs.Length];
            fs.ReadExactly(buffer);

            return buffer;
        }
    }

    public class StreamFileService
    {
        public void Write (string path, string content)
        {
            using var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.Write(content);
        }

        public string Read (string path)
        {
            using var reader = new StreamReader(path, Encoding.UTF8);

            return reader.ReadToEnd();
        }
    }
}
