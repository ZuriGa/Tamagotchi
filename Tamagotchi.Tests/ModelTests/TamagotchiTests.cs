using Microsoft.VisualStudio.TestTools.UnitTesting;
using TamagotchiProject.Models;
using System.Collections.Generic;
using System;

namespace TamagotchiProject.Tests
{
  [TestClass]
  public class TamagotchiTest
  {
    [TestMethod]
    public void TamagotchiConstructor_CreatesInstanceOfTamagotchi_Tamagotchi()
  {
    Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",1,2);
    Assert.AreEqual(typeof(Tamagotchi), newTamagotchi.GetType());
  }
  
  [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Tamagotchi";
      Tamagotchi newTamagotchi = new Tamagotchi(name,2,3);
      string result = newTamagotchi.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetFood_ReturnsFood_Int()
    {
      int food = 100;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",food,3);
      int result = newTamagotchi.Food;
      Assert.AreEqual(food, result);
    }

    [TestMethod]
    public void GetAttention_ReturnsAttention_Int()
    {
      int attention = 100;
      Tamagotchi newTamagotchi = new Tamagotchi("Test Tamagotchi",3,attention);
      int result = newTamagotchi.Attention;
      Assert.AreEqual(attention, result);
    }
  }
}