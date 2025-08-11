using Advance.EventAndDelegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Advance.EventAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {
            Console.WriteLine($"MessageService: Sending Message..{eventArgs.Video.Title}");
        }
    }
}
