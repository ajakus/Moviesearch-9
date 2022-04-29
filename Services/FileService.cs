using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ApplicationTemplate.Models;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;

namespace ApplicationTemplate.Services;

/// <summary>
///     This concrete service and method only exists an example.
///     It can either be copied and modified, or deleted.
/// </summary>
public class FileService : IFileService
{
    private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config")
        .GetCurrentClassLogger();

    public string movieFilePath { get; set; }


    public List<Movie> Movies { get; set; }



    public FileService()
    {
        movieFilePath = "files/movies.csv";
        Movies = new List<Movie>();
       


        try
        {
            StreamReader sr = new StreamReader(movieFilePath);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                
                Movie movie = new Movie();
                string line = sr.ReadLine();
                
                int idx = line.IndexOf('"');
                if (idx == -1)
                {
                    
                    string[] movieDetails = line.Split(',');
                    movie.MovieId = int.Parse(movieDetails[0]);
                    movie.Title = movieDetails[1];
            //        movie.Genres = movieDetails[2].Split('|').ToList();

                }

                Movies.Add(movie);
            }

            sr.Close();


            logger.Info("Movies in file", Movies.Count);
        }
        catch (Exception ex)
        {
            logger.Error(ex.Message);
        }
    }




}


