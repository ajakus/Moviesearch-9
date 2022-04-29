using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public class Movie : Media
    {
        public List<string> Genres { get; set; }


        public override string ToString()
        {

            Console.WriteLine("Movies with this title: ");
            return this.Title;
        }


    }

    }
