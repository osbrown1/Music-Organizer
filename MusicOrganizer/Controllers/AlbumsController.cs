using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

    //category=artist and item=album and description=title
namespace MusicOrganizer.Controllers
{
  public class AlbumsController : Controller
  {

    [HttpGet("/artists/{artistId}/albums/new")]
    public ActionResult New(int artistId)
    {
      Artist artist = Artist.Find(artistId);
      return View(artist);
    }

    [HttpGet("/artist/{artistId}/album/{albumId}")]
    public ActionResult Show(int artistId, int albumId)
    {
      Album album = Album.Find(albumId);
      Artist artist = Artist.Find(artistId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("album", album);
      model.Add("artist", artist);
      return View(model);
    }
  }
}