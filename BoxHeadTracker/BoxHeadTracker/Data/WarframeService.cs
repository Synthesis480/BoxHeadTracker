namespace BoxHeadTracker.Data
{
    public class WarframeService {

        public Task<string> GetWarframeAsync()
        {
            var worldState = GetWorldStateAsync("http://api.warframestat.us/pc").Result;
            return Task.FromResult(worldState.sortie.rewardPool);

        }

        static async Task<WorldState> GetWorldStateAsync(string path)
        {
            HttpClient client = new HttpClient();
            WorldState worldState = null;
            try
            {
                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    worldState = await response.Content.ReadAsAsync<WorldState>();
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }
            
            return worldState;
        }
    }
}