using System;
using MinBox.ShapeLibrary;

class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle(5);
        var triangle = new Triangle(3, 4, 5);

        double circleArea = circle.CalculateArea();
        double triangleArea = triangle.CalculateArea();

        Console.WriteLine($"Площадь круга: {circleArea}");
        Console.WriteLine($"Площадь треугольника: {triangleArea}");

        bool isRightAngleTriangle = triangle.IsRightAngleTriangle();
        Console.WriteLine($"Треугольник прямоугольный: {isRightAngleTriangle}");


        /*2 задание
            SELECT P.ProductName, C.CategoryName
            FROM Products P
            LEFT JOIN ProductCategory PC ON P.ProductID = PC.ProductID
            LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID;
        */
    }
}
