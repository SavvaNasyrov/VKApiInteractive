namespace VKApiInteractive.Controllers
{
    public class Handler
    {
        private readonly string ACSESS_TOKEN;
        private readonly string Version;
        private HttpClient _httpClient;

        public Handler()
        {
            ACSESS_TOKEN = File.ReadAllText("bin\\Debug\\net7.0\\TOKEN.txt");
            Version = "5.131";
        }

        public string HandleUsersGet(string IDs)
        {
            _httpClient = new HttpClient();
            string result = "";

            HttpResponseMessage response = _httpClient.GetAsync($"https://api.vk.com/method/wall.get?owner_id={IDs}&count=5&lang=ru&access_token={ACSESS_TOKEN}&v={Version}").Result;

            if (response.IsSuccessStatusCode) 
            {
                result = response.Content.ReadAsStringAsync().Result;
            }

            return result;
        }
    }
}
