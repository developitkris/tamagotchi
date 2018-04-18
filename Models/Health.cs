using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Health
  {
    public Eat (string foodType, int timeGiven)
    {
      _food = foodType;
      _eatTime = timeGiven;
    }
    public Sleep (int sleepLength, int timeGiven)
    {
      _sleep = sleepLength;
      _sleepTime = timeGiven;
    }
    public Play (int howLong, int timeGiven)
    {
      _play = howLong;
      _playTime = timeGiven;
    }
    public string GetHealth()
    {
      return tamaName + "'s food level is: " Eat + "sleep level is: " + Sleep + "play level is: " + Play;
    }
  }
}
