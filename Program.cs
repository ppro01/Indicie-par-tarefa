using System;

class Program
{
    static void Main(string[] args)
    {
        printEven(getVector());
    }

    static void printEven(int[] allPositions)
    {
        for (int i = 0; i  < allPositions.Length; i++){
            if (i % 2 == 0)
            {
                Console.WriteLine("o {0}° numero é {1}", i + 1, allPositions[i]);
            }
        }
    }

    static int[] getVector()
    {
        int[] givenVector = new int[15];

        for (int i = 0; i < givenVector.Length; i++)
        {
            Console.WriteLine("Digite o {0}° número", i+1 );
            givenVector[i] = int.Parse(Console.ReadLine());

        }

        return givenVector;
    }


}
