using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Models
{
    public class Movie// : Media
    {
        public int MovieId { get; set; }

        public string Title { get; set; }

        public string Genres { get; set; }
        
        
        public override string ToString()
        {

            Console.WriteLine("Movies with this title: ");
            return this.Title;
        }
        
    }

    }
