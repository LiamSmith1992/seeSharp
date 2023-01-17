using System.Text.Json.Serialization;

namespace seeSharp.Enum;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Breeds
{
  Doodle,
  Poodle,
  Hound,
  Husky,
  Pit,
  Retriever,
  Muggle
}