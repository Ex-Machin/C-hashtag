using System;

public class Cuboid 
{
    public int a = 0;
    public int b = 0;
    public int h = 0;

    public int Volume()
    {
        return a * b * h;
    }
}

public class Program 
{
    public static void Main()
    {
        Cuboid cuboid = new Cuboid();
        cuboid.a = 1;
        cuboid.b = 2;
        cuboid.h = 45;
        Console.WriteLine(cuboid.Volume());
    }
}