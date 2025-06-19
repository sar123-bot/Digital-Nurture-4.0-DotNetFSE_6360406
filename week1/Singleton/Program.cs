using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET.Digital_Nurture_4._0_DotNetFSE_6360406.week1.Singleton
{
    
        public class Logger
        {
            private static Logger? _instance;
            private static readonly object _lock = new object();

            private Logger()
            {
                Console.WriteLine("Logger instance created.");
            }

            public static Logger GetInstance()
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }

            public void Log(string message)
            {
                Console.WriteLine($"Log Entry: {message}");
            }
        }

        class Program
        {
          static void Main(string[] args)
            {
                Logger logger1 = Logger.GetInstance();
                Logger logger2 = Logger.GetInstance();

                logger1.Log("This is the first log message.");
                logger2.Log("This is the second log message.");

                if (ReferenceEquals(logger1, logger2))
                {
                    Console.WriteLine("Both logger instances are the same. Singleton is working.");
                }
                else
                {
                    Console.WriteLine("Logger instances are different. Singleton failed.");
                }

                Console.ReadLine();
            }
        }
    }
