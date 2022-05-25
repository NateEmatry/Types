namespace Types
{
    // In the C# alphabet, an interface starts with an I!

    /*
        "An interface is effectively a list of the members that a type will need
        to provide if it wants to implement the interface." - Book

    */

    public interface IDemoInterface {

        // Static field. Instance fields not allowed
        static int demoInt;

        // Property
        int demoInteger { get; set; }
        string demoString { get; set; }

        // Methods

        int modInt(int i);
        string modString(string s);



    }

    public class DemoInterfaceClass : IDemoInterface {

        public int demoInteger { get; set; }
        public string demoString { get; set; } = "";

        public int modInt(int i) {
            return ++i;
        }

        public string modString(string s) {

            return "Ah say, " + s;
        }

    }
}