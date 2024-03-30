using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Mod18FinPractice
{
    internal class VideoInfoReciever
    {
        public string link { get; set; }

        public VideoInfoReciever(string link)
        {
            this.link = link;
        }

        public void ShowInfo()
        {
            var client = new YoutubeClient();
            var info = client.Videos.GetAsync(link);

            Console.WriteLine("File info:");
            Console.WriteLine(info.Result.Title);
        }
    }
}
