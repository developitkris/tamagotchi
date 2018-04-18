using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Health
  {
    private int _food;
    private int _sleep;
    private int _play;
    public int Eat;
    public int Sleep;
    public int Play;

    public Health (int ate, int slept, int played)
    {
      Eat = ate;
      Sleep = slept;
      Play = played;
    }

    public void SetEat(int newFood)
    {
      _food = newFood;
    }
    public int GetEat()
    {
      return _food;
    }
    public void SetSleep (int newSleep)
    {
      _sleep = newSleep;
    }
    public int GetSleep ()
    {
      return _sleep;
    }
    public void SetPlay (int newPlay)
    {
      _play = newPlay;
    }
    public int GetPlay ()
    {
      return _play;
    }
    // public string GetHealth()
    // {
    //   return "'s food level is: " Eat + "sleep level is: " + Sleep + "play level is: " + Play;
    // }
  }
}
