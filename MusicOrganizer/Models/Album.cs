namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Title { get; set; }
    public Album(string title)
    {
      Title = title;
    }
  }
}