using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Point p1 = new Point( 1, 3, '*');
             p1.Draw();

             Point p2 = new Point( 4, 5, '#');
             p2.Draw();


             List<int> numList = new List<int>();

             numList.Add(0);
             numList.Add(1);
             numList.Add(2);

             int x = numList[0];
             int y = numList[1];
             int z = numList[2];

             foreach ( int i in numList)
             {
                 Console.WriteLine( i);
             }

             numList.RemoveAt(0);

             List<Point> pList = new List<Point>();
             pList.Add(p1);
             pList.Add(p2);

             Console.WriteLine();

             foreach ( Point j in pList)
             {

                 Console.WriteLine(j.x + "!" + j.y + "!" + j.sym + "!!!!"); 
             }

             Console.ReadLine(); 

           List<string> strList = new List<string>();

           strList.Add("*");
           strList.Add("#");
           strList.Add("$");

           foreach (string i in strList)
           {
               Console.WriteLine(i + "");
           }


           Point p1 = new Point(1, 1, '*');
           //p1.Draw();

           Point p2 = new Point(4, 1, '#');
           //p2.Draw();

           Point p3 = new Point(10, 5, '&');
           //p3.Draw();

           Point p4 = new Point(14, 15, '@');
           //p4.Draw();

           List<Point> pList = new List<Point>();
           pList.Add(p1);
           pList.Add(p2);
           pList.Add(p3);*/

            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(1, 77, 0, '+');
            HorizontalLine downLine = new HorizontalLine(1, 77, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Console.ReadLine();
        }
    }
}
