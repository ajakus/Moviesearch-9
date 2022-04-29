using ApplicationTemplate.Models;
using System.Collections.Generic;

namespace ApplicationTemplate.Services;

/// <summary>
///     This service interface only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public interface IFileService
{
    public string movieFilePath { get; set; }



    public List<Movie> Movies { get; set; }





}
