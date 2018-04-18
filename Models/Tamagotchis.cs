using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class TamagotchiPet
  {
    public int _timePassed;
    private string _nickName;
    private int _age;
    private int _weight;
    public Health _health;

    private static List<TamagotchiPet> _pets = new List<TamagotchiPet> {};

    public TamagotchiPet (string tamaName, int tamaAge, int tamaWeight, Health healthStats)
    {
      _nickName = tamaName;
      _age = tamaAge;
      _weight = tamaWeight;
      _health = Health healthStats;
    }
    public void SetTime(int newTime)
    {
      _timePassed = newTime;
    }
    public int GetTime()
    {
      return _timePassed;
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
    public static List<TamagotchiPet> GetAll()
    {
        return _pets;
    }
    public void Save()
    {
        _pets.Add(this);
    }
    public static void ClearAll()
    {
      _pets.Clear();
    }
  }
}
