using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplication.Data
{
    public class Resume
    {
        public string FileName { get; set; }
        public bool FileUploaded { get; set; } = false;
        public string UploadText { get; set; } = "Upload Resume";
        public IList<IList<string>> Sentences { get; set; } = new List<IList<string>>();

    }
}
