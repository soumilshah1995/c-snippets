// Github: https://github.com/soumilshah1995
// Youtube: https://www.youtube.com/channel/UC_eOodxvwS_H7x2uLQa-svw?view_as=subscriber
// Blog: https://soumilshah1995.blogspot.com
// Twitter: soumil44145290
// FaceBook: https://www.facebook.com/soumilshah1995/
// Linkedin : https://www.linkedin.com/in/shah-soumil/

// Website: https://soumilshah.herokuapp.com

using System;
using System.IO;

namespace myos
{
    public abstract class LogBase{
        public abstract void Log(string Messsage);
    }

    public class Logger: LogBase{

        private String CurrentDirectory
        {
            get;
            set;
        }

        private String FileName{
            get;
            set;
        }

        private String FilePath {
            get;
            set;
        }

        public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrentDirectory + "/"  + this.FileName;
        
        }

        public override void Log(string Messsage)
        {
           
            System.Console.WriteLine("Logged : {0}", Messsage);

            using (System.IO.StreamWriter w = System.IO.File.AppendText(this.FilePath))
            {
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("  :{0}", Messsage);
                w.WriteLine("-----------------------------------------------");
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
          
            var logger = new Logger();
            logger.Log("Soumil Nitin Shah");

        }
    }
}
