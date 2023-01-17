
namespace seeSharp.Repositories;

public class DogsRepository
{
  private List<Dog> dogDb;
  public DogsRepository()
  {
    this.dogDb = new List<Dog>(){

new Dog(1, "Bandit", 4, Enum.Breeds.Doodle, true),
new Dog(2, "Lassy", 102, Enum.Breeds.Retriever, true),
new Dog(3, "Brandi", 5, Enum.Breeds.Poodle, false),
new Dog(4, "Hank", 8, Enum.Breeds.Muggle, true)
            };
  }
  internal List<Dog> Get()
  {
    return dogDb;
  }

  internal Dog Create(Dog dogData)
  {

    dogDb.Add(dogData);
    return dogData;
  }
}
