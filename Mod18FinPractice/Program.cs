using System.Reflection;

namespace Mod18FinPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destinationSource = "video.mp4";

            if (File.Exists(destinationSource))
                File.Delete(destinationSource);


            Console.Write("Введите ссылку на видео: ");
            string link = Console.ReadLine();

            var sender = new Sender();

            var videoInfo = new VideoInfoReciever(link);
            var VideoDownload = new VideoDownloader(link, destinationSource);

            var infoCommand = new GetInfoCommand(videoInfo);
            sender.SetCommand(infoCommand);
            sender.Run();

            var downloadCommand = new DownloadCommand(VideoDownload);
            sender.SetCommand(downloadCommand);
            sender.Run();

            while (!File.Exists(destinationSource))
            {

            }
            Thread.Sleep(1000);

        }
    }
}
