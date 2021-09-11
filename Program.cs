using System;
using System.IO;
namespace FortniteExternalConsole
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Fortnite";
            string logpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FortniteGame\Saved\Logs\FortniteGame.log";
            using (StreamReader streamReader = new StreamReader(File.Open(logpath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                while (true)
                {
                    if (!streamReader.EndOfStream)
                    {
                        string readtoend = streamReader.ReadToEnd();
                        if (readtoend.Length > 1)
                            Console.WriteLine(readtoend);
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
        }
    }
}
