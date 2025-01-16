using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChunRiYingV2;

public class ApiRequests
{
    static HttpClient client = new HttpClient();

    public static async Task<ArrayList> GetImages(string keyword)
    {
        ArrayList images = new ArrayList();

        Console.WriteLine("hello");

        var resp = client.GetAsync("https://mygoapi.miyago9267.com/mygo/img?keyword=" + keyword).Result;

        images = JsonConvert.DeserializeObject<dynamic>(resp.Content.ReadAsStringAsync().Result)!.urls.ToObject<ArrayList>();
        
        return images;
    }
}