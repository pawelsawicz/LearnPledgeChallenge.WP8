using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;

namespace LearnPledgeChallenge.WP8.Data
{
    public class PledgeRepository
    {
        private readonly RestClient _restClient;
        private readonly IDeserializer _deserializer;

        public PledgeRepository()
        {
            _restClient = new RestClient();
            _deserializer = new JsonDeserializer();
        }

        public async void Add(Pledge pledgeToAdd)
        {
            _restClient.BaseUrl = "http://wepromi.se/pledges";
            var request = new RestRequest();
            var response = await _restClient.GetResponseAsync(request);
        }
    }

    public class Pledge
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PledgeText { get; set; }
        public string Forfeit { get; set; }
        public DateTime ExpirationDateTime { get; set; }
    }
}
