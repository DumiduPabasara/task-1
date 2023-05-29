using System;

namespace GeometricShape
{
    class Program 
    { 

           public float length, breadth, radius, side, hieght, breadthfortriangle;
            static void Main(string[] args)
             {
         Program a = new Program();
        a.Rectangle();
        a.Circle();
        a.Triangle();
        Console.ReadKey();
        }
    public void Rectangle()
    {
        Console.WriteLine("Enter the Length for Rectangle");
        length = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the breadth for Rectangle");
        breadth = float.Parse(Console.ReadLine());
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Area of rectangle is :{0}", length * breadth);
    }
    public void Circle()
    {
        Console.WriteLine("Enter the Radius of the Circle");
        radius = float.Parse(Console.ReadLine());
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Area of Circle is:{0}", 3.14 * radius * radius);
    }
 
    public void Triangle()
    {
        Console.WriteLine("Enter the Breadth for Triangle ");
        breadthfortriangle = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Hieght for Triangle ");
        hieght = float.Parse(Console.ReadLine());
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Area of Triangle is:{0}", (breadthfortriangle * hieght) / 2);
    }
}  
} 
    
    

