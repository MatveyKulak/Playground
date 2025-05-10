namespace Lesson_19.Events.FileDownload
{
    public class DownloadEventArgs : EventArgs
    {
        public string FileName { get; }

        public DownloadEventArgs (string fileName)
        {
            FileName = fileName;
        }
    }
}
