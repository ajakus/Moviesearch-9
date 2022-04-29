using ApplicationTemplate.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate
{
    internal class MovieRepository
    {
        private FileService _fileService = new FileService();
        public Media Search(string searchString)
        {
            
            var results = _fileService.Movies.Where(x => x.Title.Contains(searchString, StringComparison.CurrentCultureIgnoreCase));
            return results.FirstOrDefault();
            
        }
    }
}
