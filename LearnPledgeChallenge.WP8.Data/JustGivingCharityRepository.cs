using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace LearnPledgeChallenge.WP8.Data
{
    public class JustGivingCharityRepository
    {
        private readonly RestClient _restClient;
        private readonly List<int> _recommendedCharities = new List<int>(3)
        {
            2344,
            11490,
            18570
        };

        public JustGivingCharityRepository()
        {
            _restClient = new RestClient();
        }

        public List<Chairty> GetRecommendedChairties()
        {
            var listOfResult = new List<Chairty>();

            foreach (var charityId in _recommendedCharities)
            {
                _restClient.BaseUrl = string.Format("https://api-sandbox.justgiving.com/0f938d22/v1/charity/{0}", charityId);
                var restRequest = new RestRequest();
                var restResponse = _restClient.ExecuteAsync(restRequest, (response, handler) =>
                {
                    if (response.ResponseStatus == ResponseStatus.Completed)
                    {

                    }
                });
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
        
    }
}
