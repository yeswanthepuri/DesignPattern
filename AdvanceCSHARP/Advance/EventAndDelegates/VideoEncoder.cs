using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.EventAndDelegates
{
    public class VideoEncoder
    {
        //1--> Create a Event
        //2--> Define the event based on the delegate
        //3--> Raise the event.


        //public delegate void VideoEncodingEventHandler(object source, VideoEventArgs eventArgs);

        //

        /* You dont need to create a delegate every time you can make use of the existing 
         * 
         * EventHandler 
         * EventHandler<T> T is type of event
         * 
         * 
         * public event VideoEncodingEventHandler VideoEncoded // This is with custom delegate Old way...;   
         * */
        public event EventHandler<VideoEventArgs>? VideoEncoded;   


        public void Encode(Video video)
        {
            Console.WriteLine("Video Is Encoded...");
            Thread.Sleep(1000);
            OnVideoEncoded(video);
        }


        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }

    }
}
