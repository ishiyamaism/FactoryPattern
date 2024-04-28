
namespace FactoryPattern.Exceptions;

public class InvalidArgumentException : ArgumentException
{
  public int Value { get; }
  public InvalidArgumentException(int value) : base($"指定した数字が間違っています: {value}")
  {
    Value = value;
  }
}
