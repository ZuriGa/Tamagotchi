namespace TamagotchiProject.Models
{
  public class Tamagotchi
  {
    public Tamagotchi(string tamagotchiName, int foodLevel, int attentionLevel)
    {
      Name = tamagotchiName;
      Food = foodLevel;
      Attention = attentionLevel;
    }
    public string Name { get; }
    public int Food { get; }
    public int Attention { get; }
  }
}