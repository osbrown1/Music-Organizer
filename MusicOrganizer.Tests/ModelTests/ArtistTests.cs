using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable

  {
    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
      public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
      {
        Artist newArtist = new Artist("Prince");
        Assert.AreEqual(typeof(Artist), newArtist.GetType());
      }

      [TestMethod]
      public void GetName_ReturnsName_String()
      {
        string artistName = "Beastie Boys";
        Artist newArtist = new Artist(artistName);

        string result = newArtist.ArtistName;

        Assert.AreEqual(artistName, result); 
      }

      [TestMethod]
      public void SetArtistName_SetArtistName_string()
      {
        string artistName = "Test Artist";
        Artist newArtist = new Artist(artistName);

        string updatedArtistName = "Brittany Spears";
        newArtist.ArtistName = updatedArtistName;
        string result = newArtist.ArtistName;
        Assert.AreEqual(updatedArtistName, result);
      }

      [TestMethod]
      public void GetId_ReturnsArtistId_Int()
      {
        string artistName = "Enya";
        Artist newArtist = new Artist(artistName);
        int result = newArtist.Id;
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetAll_ReturnsArtists_ArtistList()
      {
      string artistName01 = "Brittany Spears";
      string artistName02 = "Enya";
      Artist newArtist1 = new Artist(artistName01);
      Artist newArtist2 = new Artist(artistName02);
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };
      List<Artist> result = Artist.GetAll();
      CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void Find_ReturnsCorrectArtist_Artist()
      {
      string artistName01 = "Brittany Spears";
      string artistName02 = "Enya";
      Artist newArtist1 = new Artist(artistName01);
      Artist newArtist2 = new Artist(artistName02);

      Artist result = Artist.Find(2);

      Assert.AreEqual(newArtist2, result);
      }

      [TestMethod]
      public void AddItem_AssociatesItemWithCategory_ItemLIst()
      {
        string title = "One";
        Album newAlbum = new Album(title);
        List<Album> newList = new List<Album> { newAlbum };
        string newArtistName = "The Beatles";
        Artist newArtist = new Artist(newArtistName);
        newArtist.AddAlbum(newAlbum);
        List<Album> result = newArtist.Albums;
        CollectionAssert.AreEqual(newList, result);
      }
    } 
  }

