namespace Types
{
    public static class MethodsDemo {

        // Out parameters
        public static int Divide(int quotient, int divisor, out int remainder) {

            if (divisor == 0)
                throw new DivideByZeroException();

            remainder = quotient % divisor;

            return quotient / divisor;
        }

        // Ref arguments: Passing in a reference to a value type like &ref in C.
        // Note: A reference cannot live longer than the variable it refers to.
        public static string AppendInBed(ref string s) {

            s += " in bed";
            return s;
        }

        // In parameter: A read-only reference.
        public static void PrintPlusOne(in int x) {

            Console.WriteLine($"{x} plus one equals {x + 1}");
        }

    }

}