using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log4Net.Async;
//using Serilog;



namespace Log4Net2Seq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Serilog.Log.Logger = new Serilog.LoggerConfiguration()                
            //    .WriteTo.Seq("http://localhost:5341")
            //    .CreateLogger();
            //Serilog.Debugging.SelfLog.Enable(Console.Error);

            //Serilog.Log.Information("Hello, {Name} Start()!", Environment.UserName);

            //// Important to call at exit so that batched events are flushed.
            //Serilog.Log.CloseAndFlush();

            string q = string.Empty;
            while (q != "q")
            {
                logger.InfoFormat("Hello,1, {0}, from log4net!", Environment.UserName);
                logger.InfoFormat("Hello,2, {0}, from log4net!", Environment.UserName);
                logger.InfoFormat("Hello,3, {0}, from log4net!", Environment.UserName);

                Console.WriteLine("Press q to leave");
                q = Console.ReadLine();
            }

            Console.WriteLine("ByeBye, Press any key to leave");
            Console.ReadKey(true);

            //Serilog.Log.CloseAndFlush();

        }
    }
}
