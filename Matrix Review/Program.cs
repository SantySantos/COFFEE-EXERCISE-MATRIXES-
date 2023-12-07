//Coffee schedule matrix 
using System.Globalization;

class program
{
    static void Main(string[] args)
    {
        int[,] matrix1 = new int[3, 5];
        string[] ArrayDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        string[] TypeofCoffee = { "Cappuccino", "Mocha", "Choco" };
        double[] MoneyEarnedPerDay = new double[5];
        int[] MaxValue = new int[5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Please give me the value for the position: [ " + ArrayDays[i] + " , " + TypeofCoffee[j] + " ]"); //asking for values for the matrix 
                matrix1[j,i] = int.Parse(Console.ReadLine());
                MoneyEarnedPerDay[i] = matrix1[0, i] * 2.30 + matrix1[1,i] * 3.50 + matrix1[2,i] *5;
                MaxValue[i] = matrix1[0, i] + matrix1[1, i] + matrix1[2, i];
                
            }
        } 
        int maxvaluecalculate = MaxValue.Max();
          
        //printing the matrix
        for (int i = 0; i < 3; i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix1[i,j] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        //printing machine results 
        for(int i= 0; i<5; i++)
        {
            Console.WriteLine(ArrayDays[i]);
            Console.WriteLine("Money earned: " + MoneyEarnedPerDay[i]);
            for (int j = 0;j < 3; j++)
            {   
                Console.WriteLine("    -" + TypeofCoffee[j] + " = " + matrix1[j,i]);
            }
            Console.WriteLine() ;
        }
        Console.WriteLine("the day with more sells was: " +  "With " + maxvaluecalculate + " sells.");
    }
}

