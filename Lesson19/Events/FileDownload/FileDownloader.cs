namespace Lesson_19.Events.FileDownload
{
    public class FileDownloader
    {
        public event EventHandler<DownloadEventArgs>? DownloadCompleted;

        public void Download (string file)
        {
            Console.WriteLine($"Загрузка {file}...");
            Thread.Sleep(500);
            Console.WriteLine("Загрузка завершена.");

            DownloadCompleted?.Invoke(this, new DownloadEventArgs(file));
        }
    }
}
