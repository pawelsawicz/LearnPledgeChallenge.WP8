using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public async Task<bool> Add(Pledge pledgeToAdd)
        {
            _restClient.BaseUrl = "http://wepromi.se/api/v1/pledges.json";
            var request = new RestRequest(Method.POST);
            request.AddParameter("pledge[name]", pledgeToAdd.Name);
            request.AddParameter("pledge[ends_at]", pledgeToAdd.ExpirationDateTime.ToString("dd/MM/yyyy"));
            request.AddParameter("pledge[forfeit]", pledgeToAdd.Forfeit);
            request.AddParameter("pledge[pledge]", pledgeToAdd.PledgeText);
            request.AddParameter("pledge[email]", pledgeToAdd.Email);
            var response = await _restClient.GetResponseAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
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
