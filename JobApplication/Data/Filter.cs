using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplication.Data
{
    public class Filter
    {
        public IList<string> Words { get; set; } = new List<string>();
        public IList<string> Sentences { get; set; } = new List<string>();
        public int Found { get; set; } = 0;
        public bool Finished { get; set; } = false;

        public Filter()
        {
            Words.Add(string.Empty);
        }
    }
}
