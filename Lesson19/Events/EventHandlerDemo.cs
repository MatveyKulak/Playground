using Lesson_19.Events.AlarmTrigger;
using Lesson_19.Events.FileDownload;
using Lesson_19.Events.PriceChanger;

namespace Lesson_19.Events
{
    public class EventHandlerDemo
    {
        public static void HandleTasks ()
        {
            var runner = new TaskRunner();

            runner.TaskCompletedEvent += () =>
            {
                Console.WriteLine("Получено уведомление: задача завершена.");
            };

            runner.Run();
        }

        public static void HandleStorePurchases ()
        {
            var store = new Store();

            // Подписчик 1: логирование
            store.OnPurchaseEvent += (product, price) =>
            {
                Console.WriteLine($"[ЛОГ]: Куплен {product} за {price}");
            };

            // Подписчик 2: начисление бонусов
            store.OnPurchaseEvent += (product, price) =>
            {
                var bonus = price * 0.05m;
                Console.WriteLine($"[БОНУСЫ]: Начислено {bonus} бонусов");
            };

            store.Buy("Наушники", 2000);
            store.Buy("Наушники", 2000);
        }

        public static void HandleAlarm ()
        {
            var alarm = new AlarmSystem();
            var police = new Police();
            var logger = new Logger();

            alarm.OnAlarmEvent += police.Respond;
            alarm.OnAlarmEvent += logger.Log;

            alarm.Trigger("Офис компании X");
        }

        public static void HandleButtonClicks ()
        {
            var button = new Button();

            button.OnClickEvent += (sender, args) =>
            {
                var btn = (Button)sender;
                Console.WriteLine($"Обработчик события: Кнопка была нажата {btn.Name}");
            };

            button.Click();
        }

        public static void HandleProductPriceChange ()
        {
            var product = new Product();

            product.OnPriceChangedEvent += (sender, args) =>
            {
                Console.WriteLine($"[LOG]: Старая цена: {args.OldPrice}, Новая цена: {args.NewPrice}");
            };

            product.SetPrice(100);
            product.SetPrice(120);
        }

        public static void HandleFileDownload ()
        {
            var downloader = new FileDownloader();

            var notifier = new Notifier();
            var logger = new Logger();

            downloader.OnDownloadCompletedEvent += notifier.Notify;
            downloader.OnDownloadCompletedEvent += logger.Log;

            downloader.Download("report.pdf");
        }
    }
}
