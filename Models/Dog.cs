using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using seeSharp.Enum;
namespace seeSharp.Models;

public class Dog
{
  public Dog(int id, string name, int age, Breeds breed, bool goodDog)
  {
    Id = id;
    Name = name;
    Age = age;
    Breed = breed;
    GoodDog = goodDog;
  }
  public int Id { get; set; }
  public string Name { get; set; }
  public int Age { get; set; }
  public Breeds Breed { get; set; }
  public bool GoodDog { get; set; }
}
