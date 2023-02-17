using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.Util;

namespace MyEnergyApp.API
{
    internal class Youtube
    {
        public static async Task YouTubeService(string search)
        {
            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCDRz0y5NHzkhHaD6zxlNXa7beiK0lJ_ww"
            });

            var searchListRequest = service.Search.List("snippet");
            searchListRequest.Q = search;
            searchListRequest.RegionCode = "se";
            searchListRequest.MaxResults = 10;


            var results = await searchListRequest.ExecuteAsync();

            if (!results.Items.Any())
            {
                Console.WriteLine("No videos");
            }
            foreach (var video in results.Items)
            {
                Console.WriteLine($"{video.Snippet.Title} - {video.Snippet.ChannelTitle} - (https://www.youtube.com/watch?v={video.Id.VideoId})");
                Console.WriteLine();
            }
        }
    }
}
