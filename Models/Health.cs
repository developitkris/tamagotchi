using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Satisfaction
  {
    private int _food;
    private int _sleep;
    private int _play;
    public int Meals;
    public int Energy;
    public int Mood;

    public Satisfaction (int food, int sleep, int play)
    {
      Meals = food;
      Energy = sleep;
      Mood = play;
    }

    public void SetMeals(int newFood)
    {
      _food = newFood;
    }
    public int GetMeals()
    {
      return _food;
    }
    public void SetEnergy (int newSleep)
    {
      _sleep = newSleep;
    }
    public int GetEnergy ()
    {
      return _sleep;
    }
    public void SetMood (int newPlay)
    {
      _play = newPlay;
    }
    public int GetMood ()
    {
      return _play;
    }
    // public string GetSatisfaction()
    // {
    //   return "'s food level is: " Meals + "sleep level is: " + Energy + "play level is: " + Mood;
    // }
  }
}
