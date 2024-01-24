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

    }
    public string Name { get; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; }

  }
}