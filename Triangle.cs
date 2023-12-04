using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace TriangleClass

    public  class Triangle
    {

        public static double side;

        public double InitSide(double a)
        {
        
        side = a;

        return side;

        }

    public void P(double[] Arr)
    {
        double res = 0;
        foreach (var item in Arr)
        {
            
            res += item;
        }

        Console.WriteLine("Значение периметра треугольника {0} " ,res);
    }
    
    public void S(double[] Arr)
    {
        double p = 0;
        foreach (var item in Arr)
        {

            p += item;
        }
        p /= 2;

        double P = p * (p - Arr[0]) * (p - Arr[1]) * (p - Arr[2]);
        double S = Math.Sqrt(P);

        Console.WriteLine("Значение Площади треугольника {0: 0.00}  ", S);

    }

    public void SetSide(double[] Arr)
    {

        double p = 0;
        foreach (var item in Arr)
        {
            Console.WriteLine("Значение строны треугольника {0}  ",  item);

        }
        
       
    }

    public bool TryangleExit(double[]Arr)
    {

        if (Arr[0] + Arr[1]  > Arr[2] && Arr[0] + Arr[2] > Arr[1] && Arr[1] + Arr[2] > Arr[0] )
        {
            return true;
        }

        else return false;
    }














}


