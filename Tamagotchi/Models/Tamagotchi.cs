namespace TamagotchiProject.Models
{
  public class Tamagotchi
  {
    public Tamagotchi(string tamagotchiName, int foodLevel)
    {
      Name = tamagotchiName;
      Food = foodLevel;
    }
    public string Name { get; }
    public int Food { get; }
  }
}