using System;

namespace ArrayExercises
{
    //Case 1: Do array exercise within Main method
    //Case 2: Put Array Exercise into a method within this class(ArrayExercise)
    //Case 3: Passthe array calue into a method(PrintOddValues) (within this class)
    //Case 4: Initialize the array value as a member field of Program class (not recommended)
    //Case 5: Define a static method in another class

    class ArrayLib
    {
        public static void _PrintOddValues(int[] arrayValues)
        {
            for (int i = 0; i < arrayValues.Length; i++)
            {
                if (arrayValues[i] % 2 != 0)
                {
                    Console.WriteLine(arrayValues[i]);
                }

            }
        }
    }


    class Program
    {
        //Avoid creating static member variables for right now - Case 4
        static int[] staticValues = { 1, 1, 2, 3, 5, 8 };

        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 5, 8 };
            PrintOddValues(array);
            ArrayExercise();
            PrintOddValues(staticValues);

            ArrayLib._PrintOddValues(array);
        }

        static void PrintOddValues(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    Console.WriteLine(intArray[i]);
                }

            }

        }

        static void ArrayExercise()
        {
            int[] array = { 1, 1, 2, 3, 5, 8 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }

            }
        }
    }
}
