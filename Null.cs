namespace Types
{
    /*
        By default, any reference type variable can contain the value "null".

        Value types cannot be assigned to null unless they have been declared
        as a nullable type.
     */

     public static class NullExamples {

         public static Nullable<int> nullInt1;
         public static int? nullInt2;

         public static void NullContextExample() {

             // Enabling the nullable annotation context.
             // With this feature enabled, a reference type cannot be null
             // unless explicitly defined as a nullable reference.
             #nullable enable

             string notNull = "I am not null";
             string? canBeNull = null;

             Console.WriteLine($"Not null string length: {notNull.Length}");
             Console.WriteLine($"Possibly null string length: {canBeNull.Length}");

             // Restoring the default
             #nullable restore

             string x = null;
             Console.WriteLine($"Possibly null string length: {x.Length}");

             // Null-forgiving operator
             string definitelyNotNull = null;
             string printMyLength = definitelyNotNull!;
             Console.WriteLine($"Length of definitely not null string: {printMyLength.Length}");

         }

     }
}