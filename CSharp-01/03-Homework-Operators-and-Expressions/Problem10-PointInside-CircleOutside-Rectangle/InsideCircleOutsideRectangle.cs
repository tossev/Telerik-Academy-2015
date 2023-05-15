using System;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top X1 =1, left Y1 =-1, width X2 =6, height Y2 =2).
//if (xp is between x1 and x2) AND (yp is between y1 and y2) then the point(xp,yp) is inside the rectangle.
//Пояснение: правоъгълникът е зададен чрез координатите на горния си ляв и долния си десен ъгъл.
//Една точка е вътре в даден правоъгълник със стени успоредни на координатните оси, когато е вдясно от лявата му стена, вляво от дясната му стена, надолу от горната му стена и нагоре от долната му стена.


namespace Problem10_PointInside_CircleOutside_Rectangle
{
class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("Enter point \"x\": ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter point \"y\": ");
        double y = double.Parse(Console.ReadLine());
        bool inACircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;
        bool inRect = ((x >= 1 && x <= 6) && (y >= -1 && y <= 2));
        bool outRect = ((x > -1 && x > 5) || (y > -1 && y > 1));
        bool inCircleOutRectangle = inACircle && outRect;
        Console.WriteLine("The point is in the circle and out the rectangle ===> " + inCircleOutRectangle);
  
    }
}
}
