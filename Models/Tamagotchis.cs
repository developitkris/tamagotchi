using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class MyTamagotchi
  {
    private string _nickName;
    private int _age;
    private int _weight;
    private Satisfaction _meter;
    private static List<MyTamagotchi> _pet = new List<MyTamagotchi>{};

    public MyTamagotchi(string tamaName, int tamaAge, int tamaWeight, Satisfaction meter)
    {
      _nickName = tamaName;
      _age = tamaAge;
      _weight = tamaWeight;
      _meter = meter;
    }

    public void SetName(string newName)
    {
      _nickName = newName;
    }
    public string GetName()
    {
      return _nickName;
    }
    public void SetAge(int newAge)
    { //every time food, point, sleep is clicked
      _age = newAge +1;
    }
    public int GetAge()
    {
      return _age;
    }
    public void SetWeight(int newWeight)
    { //every time food is clicked twice
      _weight = newWeight *2;
    }
    public int GetWeight()
    {
      return _weight;
    }
    public static List<MyTamagotchi> GetAll()
    {
        return _pet;
    }
    public void Save()
    {
        _pet.Add(this);
    }
    public static void ClearAll()
    {
      _pet.Clear();
    }
  }
}
