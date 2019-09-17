using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    

    class Program
    {
        static void Main(string[] args)
        {
            // basic use of a delegate
            MathDelegate mathOperation = Add;

            float a = 5;
            float b = 7;

            float result = mathOperation(a, b);


            // using a delegate to change which function gets used
            bool subtractionIsMoreFunThanAddition = true;

            MathDelegate mathOperation2;

            if (subtractionIsMoreFunThanAddition)
            {
                mathOperation2 = Subtract;
            }
            else
            {
                mathOperation2 = Add;
            }

            result = mathOperation2(a, b);


            // a more complex, useful example
            List<MagicNumber> magNums = new List<MagicNumber>
            {
                new MagicNumber() { Number = 4,  IsMagic = true },
                new MagicNumber() { Number = 36, IsMagic = false },
                new MagicNumber() { Number = 78, IsMagic = true },
                new MagicNumber() { Number = 23, IsMagic = false },
                new MagicNumber() { Number = 42, IsMagic = true }
            };

            // print out original MagicNumbers
            Console.WriteLine("Before:");

            foreach (MagicNumber magNum in magNums)
                Console.WriteLine(magNum.Number + "\t" + magNum.IsMagic);

            // apply the specified function to everything in the List
            ApplyModifierToAll(Increment, magNums);
            ApplyModifierToAll(Magicify, magNums);

            // print out modified MagicNumbers
            Console.WriteLine("\nAfter:");

            foreach (MagicNumber magNum in magNums)
                Console.WriteLine(magNum.Number + "\t" + magNum.IsMagic);


            // exit prompt
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // methods for MathDelegate
        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }

        public static float Power(float root, float exp)
        {
            return (float)Math.Pow(root, exp);
        }


        // methods for MagicNumber
        public static void Increment(MagicNumber magNum)
        {
            ++magNum.Number;
        }

        public static void Decrement(MagicNumber magNum)
        {
            --magNum.Number;
        }

        public static void Magicify(MagicNumber magNum)
        {
            magNum.IsMagic = true;
        }

        public static void DeMagicify(MagicNumber magNum)
        {
            magNum.IsMagic = false;
        }

        // a method to apply a new method to the MagicNumber delegate
        public static void ApplyModifierToAll(MagicNumberModifier modifier, List<MagicNumber> magNums)
        {
            foreach (MagicNumber number in magNums)
                modifier(number);
        }
    }
}
