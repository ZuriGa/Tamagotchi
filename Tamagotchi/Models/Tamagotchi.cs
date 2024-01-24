using System.Collections.Generic;

namespace TamagotchiProject.Models
{
  public class Tamagotchi
  {
    public Tamagotchi(string tamagotchiName, int foodLevel, int attentionLevel, int restLevel)
    {
      Name = tamagotchiName;
      Food = foodLevel;
      Attention = attentionLevel;
      Rest = restLevel;
      _instances.Add(this);
      Id = _instances.Count;
      Die = false;

    }
    public string Name { get; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    public int Id { get; }
    public bool Die { get; set; }
    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

    
    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void CheckLevels()
    {
      if (Food == 0)
      {
        Die = true;
      }
      else if (Attention == 0)
      {
        Die = true;
      }
      else if (Rest == 0)
      {
        Die = true;
      }
    }

    public static void DecreaseLevels()
    {
      foreach (Tamagotchi tamagotchi in _instances)
      {
        tamagotchi.Food -= 1;
        tamagotchi.Attention -= 1;
        tamagotchi.Rest -= 1;
      }
    }

  }
}