using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class DelegateEvents_2
    {

    }

    
    public class VideoEncode
    {
        public delegate void VideoHandler();
        public event VideoHandler VideoEvent;
        public void VideoEncoding(Video video)
        {
            Services mail = new Services();
            Console.WriteLine("Video Encoding");
            Thread.Sleep(3000);
            Console.WriteLine("Encoding Done");

            //VideoHandler v;

           // v = mail.Mail;

            VideoEvent += mail.Mail;
            VideoEvent += mail.SMS;

           // MailServices mailServices = new MailServices();
           //mailServices.Mail(video);
        }

        public void OnEncoded()
        {
            if (VideoEvent != null)
            {
                VideoEvent();
            }
        }

    }
    public class Video
    {
        public string Title { get; set; }
    }

    public class Services
    {
        public void Mail()
        {
            Console.WriteLine("----->Sendig Mail Service");
        }
        public void SMS()
        {
            Console.WriteLine("----->Sendig SMS Service");
        }

    }

    
}
