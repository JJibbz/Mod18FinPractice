using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;


namespace Mod18FinPractice
{
    internal class VideoDownloader
    {
        public string link { get; set; }
        public string destinationSource { get; set; }

        public VideoDownloader(string link, string destinationSource)
        {
            this.link = link;
            this.destinationSource = destinationSource;
        }

        public async void Download()
        {
            var client = new YoutubeClient();

            var streamManifest = await client.Videos.Streams.GetManifestAsync(link);

            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await client.Videos.Streams.DownloadAsync(streamInfo, destinationSource);
        }
    }
}
