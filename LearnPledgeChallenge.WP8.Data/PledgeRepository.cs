using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnPledgeChallenge.WP8.Data
{
    public class PledgeRepository
    {
        public void Add()
        {
            
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
