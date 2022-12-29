namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Extension methods - klasa i metody muszą być statyczne, a w metodzie w argumentach musi być: this *typ* nazwa
            var someStrings = new List<string>();

            someStrings.SomeFunction();


            var str = "asd";

            str.SomeStringFunction();

            someStrings.Where(x => x.Length > 2);

             
        }


        

    }

    public static class MyClass
    {

        public static void SomeStringFunction(this string someString) 
        {
            

        }

        public static void SomeFunction(this List<string> someList)
        {



        }


    }




}