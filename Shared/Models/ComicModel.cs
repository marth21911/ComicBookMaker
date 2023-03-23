
using System;
using System.Collections.Generic;

public class ComicModel
{
    public string Title { get; set; }
    
    public string Creator { get; set; }
    
    public int NumberOfTiles { get; set; }
    
    public List<string> Images { get; set; }
    
    public List<string> Text { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    public DateTime ReleaseDate { get; set; }
    
    public int Issue { get; set; }
    
    public string Description { get; set; }
}
