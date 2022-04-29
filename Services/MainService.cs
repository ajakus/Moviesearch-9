using System;

namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{

     
    

    public void Invoke()
    {
        var combiner = new CombinerService();

        Console.WriteLine("Enter search string: ");
        var searchString = Console.ReadLine();
        var results = combiner.SearchAllMedia(searchString);

        results.ForEach(Console.WriteLine);






      

        

   
    }
}
