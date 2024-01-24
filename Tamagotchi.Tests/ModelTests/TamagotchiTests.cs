using Microsoft.VisualStudio.TestTools.UnitTesting;
using TamagotchiProject.Models;
using System.Collections.Generic;
using System;

namespace TamagotchiProject.Tests
{
  [TestClass]
  public class TamagotchiTest : IDisposable
  {
    public void Dispose()
    {
      Tamagotchi.ClearAll();
    }

    [TestMethod]
    public void TamagotchiConstructor_CreatesInstanceOfTamagotchi_Tamagotchi()
  {
    Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",1,2,3);
    Assert.AreEqual(typeof(Tamagotchi), newTamagotchi.GetType());
  }
  
  [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Tamagotchi";
      Tamagotchi newTamagotchi = new Tamagotchi(name,2,3,4);
      string result = newTamagotchi.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetFood_ReturnsFood_Int()
    {
      int food = 100;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",food,4,5);
      int result = newTamagotchi.Food;
      Assert.AreEqual(food, result);
    }

    [TestMethod]
    public void GetAttention_ReturnsAttention_Int()
    {
      int attention = 100;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",3,attention,5);
      int result = newTamagotchi.Attention;
      Assert.AreEqual(attention, result);
    }

    [TestMethod]
    public void GetRest_ReturnsRest_Int()
    {
      int rest = 100;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",3,4,rest);
      int result = newTamagotchi.Rest;
      Assert.AreEqual(rest, result);
    }

    [TestMethod]
    public void SetFood_SetsFood_Int()
    {
      int food = 85;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",0,4,5);
      newTamagotchi.Food = food;
      int result = newTamagotchi.Food;
      Assert.AreEqual(food, result);
    }

    [TestMethod]
    public void SetAttention_SetsAttention_Int()
    {
      int attention = 85;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",0,4,5);
      newTamagotchi.Attention = attention;
      int result = newTamagotchi.Attention;
      Assert.AreEqual(attention, result);
    }

    [TestMethod]
    public void SetRest_SetsRest_Int()
    {
      int rest = 85;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",0,4,5);
      newTamagotchi.Rest = rest;
      int result = newTamagotchi.Rest;
      Assert.AreEqual(rest, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllTamagotchiInstances_List()
    {
      // Arrange
      Tamagotchi t1 = new Tamagotchi("Test Tamagotchi",0,4,5);
      Tamagotchi t2 = new Tamagotchi("Test Tamagotchi",0,4,5);
      Tamagotchi t3 = new Tamagotchi("Test Tamagotchi",0,4,5);
      List<Tamagotchi> expected = new List<Tamagotchi> { t1, t2, t3 };
      // Act
      List<Tamagotchi> actualResult = Tamagotchi.GetAll();
      // Assert
      CollectionAssert.AreEqual(expected, actualResult);
    }

    [TestMethod]
    public void GetId_ReturnTamagotchiId_Int()
    {
      
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",0,4,5);
      int result = newTamagotchi.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetDie_ReturnsDie_Bool()
    {
      bool expected = false;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",3,4,5);
      bool result = newTamagotchi.Die;
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void SetDie_ReturnsDie_Bool()
    {
      bool expected = true;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",3,4,5);
      newTamagotchi.Die = true;
      bool result = newTamagotchi.Die;
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CheckLevels_SetsDieToTrueIfFoodOrAttentionOrRestAre0_Void()
    {
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",3,4,5);
      newTamagotchi.Rest = 0;
      newTamagotchi.CheckLevels();
      bool expected = true;
      Assert.AreEqual(expected,newTamagotchi.Die);
    }

    [TestMethod]
    public void DecreaseLevels_DecreasesLevelsOfAllInstancesBy1_Void()
    {
      Tamagotchi newTamagotchi1 = new Tamagotchi("Test Tamagotchi",3,4,5);
      Tamagotchi newTamagotchi2 = new Tamagotchi("Test Tamagotchi",3,4,5);
      Tamagotchi.DecreaseLevels();
      int expected = 2;
      Assert.AreEqual(expected,newTamagotchi1.Food);
      Assert.AreEqual(expected,newTamagotchi2.Food);
    }

    [TestMethod]
    public void Find_LocatesItemInInstancesThatMatchesSpecifiedId_Tamagotchi()
    {
      string name01 = "Work";
      string name02 = "School";
      Tamagotchi newTamagotchi1 = new Tamagotchi(name01,3,4,5);
      Tamagotchi newTamagotchi2 = new Tamagotchi(name02,3,4,5);
      Tamagotchi result = Tamagotchi.Find(2);
      Assert.AreEqual(newTamagotchi2, result);
    }
    
  }
}