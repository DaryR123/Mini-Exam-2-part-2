using System;

class MainClass {
  public static void Main (string[] args) 



}
  public static double DetermineHypotenuse (double hypotenuse)
{
double side1;
double side2;
double hypotenuse;

Console.WriteLine("Enter Side 1");
 side1= Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Enter Side 2");
 side2= Convert.ToDouble(Console.ReadLine());

 hypotenuse = Math.Sqrt((side1 * side1) + (side2*side2));

 Console.WriteLine("The hypotenuse is "+ hypotenuse);






  }
}