using ApplicationTemplate.Context;
using ApplicationTemplate.Models;
using ApplicationTemplate.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Repository
{
    internal class MovieRepository
    {
        private FileService _fileService = new FileService();

        private readonly MovieContext _context;
        /*
        public Media Search(string searchString)
        {
            
            var results = _fileService.Movies.Where(x => x.Title.Contains(searchString, StringComparison.CurrentCultureIgnoreCase));
            return results.FirstOrDefault();
            
        }
        
        public List<Media> Get()
        {
            return new List<Media>(_context.Movies);
        }
        public MovieRepository()
        {
            _context = new DataContext();
        }
        */
    }
}
