using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YoutubeApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("введите url видео");
            string videoUrl=Console.ReadLine();
            Console.WriteLine("введите путь сохранения");
            string savePath=Console.ReadLine(); 
            YoutubeClient client = new YoutubeClient();
            ICommand downloadcommands = new DownloadCommand(client, videoUrl,savePath);
            ExecuteCommand execute = new ExecuteCommand();
            execute.ExecuteCommandAsync(downloadcommands);
        }
    }
}
