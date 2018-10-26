using System;
namespace PuzzlerB9
{
  class Program
  {
    static void Foo(out int x, out int y)
    {
      x = 42;
      y = 123;
      Console.WriteLine (x == y);
    }
  
     static void Main(string[] args)
    {
      int parameter = Convert.ToInt32(Console.ReadLine());
      Foo(out parameter, out parameter)
      Foo(parameter, parameter)
    }
}
