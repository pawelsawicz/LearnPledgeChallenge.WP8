using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;

namespace LearnPledgeChallenge.WP8.Data
{
    public class JustGivingCharityRepository
    {
        private readonly RestClient _restClient;
        private readonly IDeserializer _deserializer;

        private readonly List<int> _recommendedCharities = new List<int>(3)
        {
            2344,
            11490,
            18570
        };

        public JustGivingCharityRepository()
        {
            _restClient = new RestClient();
            _deserializer= new JsonDeserializer();
        }

        public async Task<List<Chairty>> GetRecommendedChairties()
        {
            var listOfResult = new List<Chairty>();

            foreach (var charityId in _recommendedCharities)
            {
                _restClient.BaseUrl = string.Format("https://api-sandbox.justgiving.com/0f938d22/v1/charity/{0}", charityId);
                var restRequest = new RestRequest(Method.GET);
                restRequest.AddHeader("Accept", "application/json");

                var response = await _restClient.GetResponseAsync(restRequest);
                try
                {
                    listOfResult.Add(_deserializer.Deserialize<Chairty>(response));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return listOfResult;
        }

        public List<Chairty> SearchForCharities(string query)
        {
            return new List<Chairty>();
        }
    }

    public class Chairty
    {
        public string Name { get; set; }
        public string PageShortName { get; set;}
        public int Id { get; set; }
        public string LogoAbsoluteUrl { get; set; }

    }
}
