using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class MyTamagotchi
  {
    private string _nickName;
    private int _age;
    private int _weight;
    private Health _health;
    private static List<MyTamagotchi> _pet = new List<MyTamagotchi>{};

    public MyTamagotchi(string tamaName, int tamaAge, int tamaWeight, Health healthStats)
    {
      _nickName = tamaName;
      _age = tamaAge;
      _weight = tamaWeight;
      _health = healthStats;
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
    {
      _age = newAge;
    }
    public int GetAge()
    {
      return _age;
    }
    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
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
