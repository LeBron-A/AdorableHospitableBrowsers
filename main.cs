using System;

class Program {
  public static void Main (string[] args) {
    const double inchesToCentimeters = 2.54;
    Console.WriteLine ("how many iches");
    double inch = Convert.ToDouble(Console.ReadLine());
    double centimeters = inch * inchesToCentimeters;
    Console.WriteLine("{0}in is {1}cm", inch, centimeters);
    
  }
}