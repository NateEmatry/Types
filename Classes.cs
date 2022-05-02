namespace Types
{
    // Public class: available to any code that uses this namespace
    public class FirstClass {

        private int _count;

        public FirstClass() {

            _count = 0;
        }

        public int GetNextValue() {

            _count += 1;
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
}