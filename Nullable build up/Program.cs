using System;

namespace Nullable_build_up
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Title = "tuples";
            var x = Cats()?.Item1 + Cats()?.Item2 + Cats()?.Item3;
            Console.WriteLine(x != null ? $"The cats total is = {x}" : "incomplete");
            var y = Labs()?.Item1 + Labs()?.Item2 + Labs()?.Item3;
            Console.WriteLine(y != null ? $"The labs total = {y}" : "incomplete");
            var z = Exam()?.Item1 + Exam()?.Item2 + Exam()?.Item3 + Exam()?.Item4 + Exam()?.Item5 + Exam()?.Item6;
            Console.WriteLine(z != null ? $"The exam total = {z}" : "incomplete");

            Console.ReadKey();
        }

        private static (double?, double?, double?)? Cats()
        {
            double? cat1 = 5;
            double? cat2 = 5;
            double? cat3 = 5;

            return (cat1, cat2, cat3);
        }

        private static (double?, double?, double?)? Labs()
        {
            double? lab1 = 5;
            double? lab2 = 5;
            double? lab3 = 5;
            return (lab1, lab2, lab3);
        }

        private static (double?, double?, double?, double?, double?, double?)? Exam()
        {
            double? unit1 = 10;
            double? unit2 = null;
            double? unit3 = 10;
            double? unit4 = 10;
            double? unit5 = 10;
            double? unit6 = 10;
            return (unit1, unit2, unit3, unit4, unit5, unit6);
        }
    }
}