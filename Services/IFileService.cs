using System.Collections.Generic;

namespace ApplicationTemplate.Services;

/// <summary>
///     This service interface only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public interface IFileService
{
    public string movieFilePath { get; set; }
    public string showFilePath { get; set; }
    public string videoFilePath { get; set; }


    public List<Movie> Movies { get; set; }

    public List<Show> Shows { get; set; }

    public List<Video> Videos { get; set; }




}
