using System.Reflection;

namespace Mod18FinPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DSource = "vid.mp4";

            if (File.Exists(DSource))
                File.Delete(DSource);


            Console.Write("Введите ссылку на видео: ");
            string link = Console.ReadLine();

            var sender = new Sender();

            var videoInfo = new VideoInfoReciever(link);
            var VideoDownload = new VideoDownloader(link, DSource);

            var infoCommand = new GetInfoCommand(videoInfo);
            sender.SetCommand(infoCommand);
            sender.Run();

            var downloadCommand = new DownloadCommand(VideoDownload);
            sender.SetCommand(downloadCommand);
            sender.Run();

            while (!File.Exists(DSource))
            {

            }
            Thread.Sleep(1000);

        }
    }
}
