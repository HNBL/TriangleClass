using System;

class Program
{

    static void Main(string[] args)

    {

        Triangle Tri = new Triangle();


        int b= 3;
        double[] Arr = new double[b];
        
      
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Ведите значение {0}-ой строны треугольника", i + 1);
                double a = Convert.ToDouble(Console.ReadLine());
                Arr[i] = Tri.InitSide(a);
            }
           

        if (Tri.TryangleExit(Arr))
        {
            Tri.P(Arr);
            Tri.S(Arr);
            Tri.SetSide(Arr);
        }
       else Console.WriteLine("Треугольник не существует, повторите ввод значений");






    }
        


}