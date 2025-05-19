namespace Lesson_19.Events.FileDownload
{
    public class FileDownloader
    {
        public event EventHandler<DownloadEventArgs>? OnDownloadCompletedEvent;

        public void Download (string file)
        {
            Console.WriteLine($"Загрузка {file}...");
            Thread.Sleep(500);
            Console.WriteLine("Загрузка завершена.");

            OnDownloadCompletedEvent?.Invoke(this, new DownloadEventArgs(file));
        }
    }
}
