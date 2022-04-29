using System;
using System.Collections.Generic;
using System.IO;
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
    private readonly ShowRepository _showRepository;
    private readonly VideoRepository _videoRepository;

    public CombinerService()
    {
        _movieRepository = new MovieRepository();
        _showRepository = new ShowRepository();
        _videoRepository = new VideoRepository();
    }

    public List<Media> SearchAllMedia(string searchString)
    {
        _mediaList.Add(_movieRepository.Search(searchString));
        _mediaList.Add(_showRepository.Search(searchString));
        _mediaList.Add(_videoRepository.Search(searchString));
        return _mediaList;
    }



}
