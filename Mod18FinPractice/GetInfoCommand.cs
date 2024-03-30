using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod18FinPractice
{
    internal class GetInfoCommand : ICommand
    {
        VideoInfoReciever _infoReciever;

        public GetInfoCommand(VideoInfoReciever infoReciever)
        {
            _infoReciever = infoReciever;
        }

        public void Execute()
        {
            _infoReciever.ShowInfo();
        }
    }
}
