using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod18FinPractice
{
    internal class DownloadCommand : ICommand
    {
        VideoDownloader _downloader;

        public DownloadCommand(VideoDownloader downloader)
        {
            _downloader = downloader;
        }

        public void Execute()
        {
            _downloader.Download();
        }
    }
}
