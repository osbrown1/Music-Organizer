using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests : IDisposable
  {

    public void Dispose()
    {
      Album.ClearAll();
    }
    
    [TestMethod]
    public void 
    AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("test");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }

        [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Walk the dog.";

      //Act
      Album newAlbum = new Album(title);
      string result = newAlbum.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Walk the dog.";
      Album newAlbum = new Album(title);

      //Act
      string updatedTitle = "Do the dishes";
      newAlbum.Title = updatedTitle;
      string result = newAlbum.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_AlbumList()
    {
      // Arrange
      List<Album> newList = new List<Album> { };

      // Act
      List<Album> result = Album.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAlbums_AlbumList()
    {
      //Arrange
      string title01 = "Walk the dog";
      string title02 = "Wash the dishes";
      Album newAlbum1 = new Album(title01);
      Album newAlbum2 = new Album(title02);
      List<Album> newList = new List<Album> { newAlbum1, newAlbum2 };

      //Act
      List<Album> result = Album.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_AlbumInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Walk the dog.";
      Album newAlbum = new Album(title);

      //Act
      int result = newAlbum.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectAlbum_Album()
    {
      //Arrange
      string title01 = "Walk the dog";
      string title02 = "Wash the dishes";
      Album newAlbum1 = new Album(title01);
      Album newAlbum2 = new Album(title02);

      //Act
      Album result = Album.Find(2);

      //Assert
      Assert.AreEqual(newAlbum2, result);
    }
  }
}