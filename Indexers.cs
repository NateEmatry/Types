namespace Types
{
    public class IndexerDemo {

        private string[] GreekLetters = { "Alpha", "Beta", "Gamma", "Delta", "Epsilon" };

        // Indexer, also called the default property

        public string this[int index] {

            get => GreekLetters[index % GreekLetters.Count()];
        }
    }
}