namespace Types
{
    // Public class: available to any code that uses this namespace
    public class FirstClass {

        // The author likes to put underscores at the start of field identifiers
        // to distinguish them from local variables.
        private int _count;

        // A static member is not associated with a particular instance of a class. (Not OOP.)
        private static int _totalCount;

        // A static property only has access to other static members.
        public static int TotalCount => _totalCount;

        public FirstClass() {

            _count = 0;
        }

        public int GetNextValue() {

            _count += 1;
            _totalCount += 1;
            return _count;
        }

        public void PrintPhrase() {

            Console.WriteLine(new PhraseGenerator().GetPhrase());
        }

    }


    // Internal class
    internal class PhraseGenerator {

        public string GetPhrase() {

            string phrase = $"Thank you for using this method.";

            return phrase;
        }
    }


    // Static class
    public static class DumbMath {

        private static int _TwoValue = 2;
        private static int _ThreeValue = 3;

        public static int TimesTwo(int val) {

            return val * _TwoValue;
        }

        public static int TimesThree(int val) {

            return val * _ThreeValue;
        }
    }
}