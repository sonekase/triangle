using System;
using System.Collections.Generic;

class Triangle
{
  private int SideOne;
  private int SideTwo;
  private int SideThree;

  public Triangle(int sOne, int sTwo, int sThree)
  {
    SideOne = sOne;
    SideTwo = sTwo;
    SideThree = sThree;
  }
  public int GetSideOne()
  {
    return SideOne;
  }
  public int GetSideTwo()
  {
    return SideTwo;
  }
  public int GetSideThree()
  {
    return SideThree;
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter side one");
    int sOne = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side two");
    int sTwo = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side three");
    int sThree = int.Parse(Console.ReadLine());

    Triangle newTriangle = new Triangle (sOne, sTwo, sThree);
    int halfSum = (newTriangle.GetSideOne() + newTriangle.GetSideTwo() + newTriangle.GetSideThree()) / 2;
    if(newTriangle.GetSideOne() > halfSum || newTriangle.GetSideTwo() > halfSum || newTriangle.GetSideThree() > halfSum)
    {
      Console.WriteLine("This is NOT a TRIANGLE");
    } else if(newTriangle.GetSideOne() == newTriangle.GetSideTwo() && newTriangle.GetSideTwo() == newTriangle.GetSideThree())
    {
      Console.WriteLine("This is an equilateral triangle");
    } else if (newTriangle.GetSideOne() == newTriangle.GetSideTwo() || newTriangle.GetSideTwo() == newTriangle.GetSideThree() || newTriangle.GetSideOne() == newTriangle.GetSideThree())
    {
      Console.WriteLine("This is an isosceles triangle");
    } else
    {
      Console.WriteLine("It's just a SCALENE triangle");
    }
  }
}
