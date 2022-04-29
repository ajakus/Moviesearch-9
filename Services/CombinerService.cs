using System;
using System.Collections.Generic;
using System.IO;
using ApplicationTemplate.Models;
using ApplicationTemplate.Repository;
using Newtonsoft.Json;


namespace ApplicationTemplate.Services;

/// <summary>
///     This concrete service and method only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public class CombinerService
{
    private readonly List<Media> _mediaList = new();
    private readonly MovieRepository _movieRepository;

    public CombinerService()
    {
        _movieRepository = new MovieRepository();
    }
    /*
    public List<Media> SearchAllMedia(string searchString)
    {
        _mediaList.Add(_movieRepository.Search(searchString));

        return _mediaList;
    }

    */

}
