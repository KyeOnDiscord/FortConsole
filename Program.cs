using System;
using System.IO;
using System.Threading;
namespace FortniteExternalConsole
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Fortnite";
            string logpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FortniteGame\Saved\Logs\FortniteGame.log";
            if (File.Exists(logpath))
            {
                using (StreamReader streamReader = new StreamReader(File.Open(logpath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    while (true)
                    {
                        string readtoend = streamReader.ReadToEnd();
                        if (readtoend.Length > 1)
                            Console.WriteLine(readtoend);
                        Thread.Sleep(500);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Could not find Fortnite log files at {logpath}");
                Console.ReadKey(true);
            }
            
        }
    }
}
