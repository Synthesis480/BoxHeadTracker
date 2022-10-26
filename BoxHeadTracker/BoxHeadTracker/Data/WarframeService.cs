using System.IO;
using System.Net;
using System.Net.Http.Headers;

namespace BoxHeadTracker.Data
{
    public class WarframeService {
        public readonly string Platform = "pc";

        public async Task<WorldState> GetWarframeAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new System.Uri("http://api.warframestat.us/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            WorldState worldState = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync(Platform);

                if (response.IsSuccessStatusCode)
                {
                    worldState = await response.Content.ReadAsAsync<WorldState>();
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return worldState ;


        }
    }
}