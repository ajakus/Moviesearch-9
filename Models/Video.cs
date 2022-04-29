using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public class Video : Media
    {
        private FileService _fileService;
        public string Format { get; set; }
        public TimeSpan ? Duration { get; set; }

        public List<string> Regions { get; set; }
        public List<string> Genres { get; set; }



        public override string ToString()
        {
            Console.WriteLine("Videos with this title: ");
            return this.Title;
        }
    }
}
