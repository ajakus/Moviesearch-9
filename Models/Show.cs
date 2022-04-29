using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public class Show : Media
    {
        private FileService _fileService;

        public UInt64 Season { get; set; }
        public UInt64 Episode { get; set; }

        public List<string> Writers { get; set; }

        public string Format { get; set; }

        public override string ToString()
        {
            Console.WriteLine("Shows with this title: ");
            return this.Title;
        }

    }

    
}
