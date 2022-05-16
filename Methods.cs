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

        // Ref arguments


    }

}