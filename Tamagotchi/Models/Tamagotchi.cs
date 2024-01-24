using System.Collections.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;

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
    private static List<Tamagotchi> _instances = new List<Tamagotchi> { };


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
      if (Food < 1)
      {
        Die = true;
      }
      else if (Attention < 1)
      {
        Die = true;
      }
      else if (Rest < 1)
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

    public static Tamagotchi Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    // public static async Task TimerStart()
    // {
    //   var timer = new PeriodicTimer(TimeSpan.FromSeconds(10));

    //   while (await timer.WaitForNextTickAsync())
    //   {
    //     // Console.WriteLine("Hello World after 10 seconds");
    //     DecreaseLevels();
    //   }
    // }

    private static bool isTimerRunning = false;
    private static readonly object lockObject = new object();

    public static async Task TimerStart()
    {
      lock (lockObject)
      {
        if (isTimerRunning)
        {
          // Timer is already running, exit
          return;
        }

        isTimerRunning = true;
      }

      try
      {
        var timer = new PeriodicTimer(TimeSpan.FromSeconds(10));

        while (await timer.WaitForNextTickAsync())
        {
          DecreaseLevels();
          foreach (Tamagotchi tamagotchi in _instances)
          {
            tamagotchi.CheckLevels();
          }
        }
      }
      finally
      {
        // Ensure to reset the flag when the timer is done or an exception occurs
        isTimerRunning = false;
      }
    }

    //   public static void StartTimer() {
    //     Timer t = new Timer(TimerCallback, null, 0, 1000);
    //     Console.ReadLine();
    //  }

  }
}