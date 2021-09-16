using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class VideoEventsArgs: EventArgs
    {
        public Video Video { get; set; }
    }

    
    public class VideoEncode
    {
        public delegate void VideoHandler(object source, VideoEventsArgs e);
        public event VideoHandler VideoEvent;

        public void VideoEncoding()
        {
            Console.WriteLine("Video Encoding");
            Thread.Sleep(3000);
            Console.WriteLine("Encoding Done");

            //VideoHandler v;

           // v = mail.Mail;

            //VideoEvent += mail.Mail;
           // VideoEvent += mail.SMS;

           // MailServices mailServices = new MailServices();
           //mailServices.Mail(video);
        }

        public void OnEncoded(Video video)
        {
            if (VideoEvent != null)
            {
                VideoEvent(this, new VideoEventsArgs() { Video=video});
            }
        }

    }
    public class Video
    {
        public string Title = "Part 2 Advanced";
    }

    public class Services
    {
        public void Mail(object source, VideoEventsArgs e)
        {
            Console.WriteLine($"----->Sendig Mail Service--{e.Video.Title}");
        }
        public void SMS(object source, VideoEventsArgs e)
        {
            Console.WriteLine($"----->Sendig SMS Service--{e.Video.Title}");
        }

    }

    
}
