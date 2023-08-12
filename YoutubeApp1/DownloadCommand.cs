using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YoutubeApp1
{
    internal class DownloadCommand : ICommand
    {
        internal YoutubeClient client;
        internal readonly string videoUrl;
        internal readonly string savePath;
        public DownloadCommand(YoutubeClient client, string videoUrl, string savePath)
        {
            this.client = client;
            this.videoUrl = videoUrl;
            this.savePath = savePath;
        }

        public async Task ExecuteAsync()
        {
           Video video = await client.Videos.GetAsync(videoUrl);

            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Автор: {video.Author}");

            await client.Videos.DownloadAsync(videoUrl,savePath );
        }
    }
}
