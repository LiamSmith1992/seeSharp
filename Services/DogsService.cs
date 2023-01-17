

namespace seeSharp.Services;

public class DogsService
{
  private readonly DogsRepository _repo;
  public DogsService(DogsRepository repo)
  {
    _repo = repo;
  }

  internal Dog Create(Dog dogData)
  {
    Dog newDog = _repo.Create(dogData);
    return newDog;
  }
  internal List<Dog> Get()
  {
    List<Dog> dogs = _repo.Get();
    return dogs;
  }
}
