using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Exam.Objective1_1
{
    class UsingAsyncAndAwait
    {
        // Listing 1-18 async and await
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
