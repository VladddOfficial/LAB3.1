using System;

class MainClass {
  public static void Main (string[] args) {
    double totaldis = 0;
    double totaltime = 0;
    for (int i = 1; i <= 7; i++) 
    {
      Console.WriteLine ("Enter the distance covered by car #" + i + ": ");
    var dis = Console.ReadLine();
    double distance = Convert.ToDouble(dis);
    totaldis += distance; 
    Console.WriteLine ("Enter the time taken by car #" + i + ": ");
    var t = Console.ReadLine();
    double time = Convert.ToDouble(t);
    totaltime += time;
    Console.WriteLine ("The speed of this car is " + distance/time + " miles/hour");
    }
    Console.WriteLine ("The average speed of the cars is " + totaldis/totaltime);
  }
}