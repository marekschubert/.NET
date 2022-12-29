namespace ConsoleApp1
{
    internal class Program
    {
        public int Variable { get; set; }

        static void Main(string[] args)
        {
            var myClass = new MyClass();
            /*
             * 
             * ref - przekazywanie referencji zmiennych typu prostego, musi być i w definicji funkcji, i w wywołaniu
             * out - jeśli argument funkcji jest oznaczony jako out, to musi być "zmodyfikowany" i mieć przypisaną jakąś wartość
             * 
            Console.WriteLine("Hello, World!");

            var f = 5;
            var s = 2;

            var result = 0;

            var isOk = Sum(f, s, out result);

            Console.WriteLine(result);
            */

            /*
            var someNumberInString = "5";

            var isSucceeded = int.TryParse(someNumberInString, out var result);


            if (isSucceeded) 
            {
                Console.WriteLine(result);
            }
            else
            {
                // error, wrong format
            }
            */

            /*

            // ?? - jesli nie jest nullem, to przypisz to co po lewej, a jeśli jest, to to co po prawej, można zapisać w jednej linicje jak i++:
            myClass.Variable ??= "costam2";

            myClass.Variable = "JesliNIEJestNullem" ?? "JesliJestNullem";

            Console.WriteLine(myClass?.Variable);
            */

            /*
             * switch expression - ładniejsza forma switcha

            var option = 3;
            var firstNumber = 3;
            var secondNumber = 4;
            var output = 0;

            output = option switch
            {
                0 => firstNumber + secondNumber,
                1 => firstNumber - secondNumber,
                2 => firstNumber * secondNumber,
                3 => firstNumber / secondNumber,
                _ => 0,
            };
            */

            /*
             * możliwość przekazywania dwóch (i więcej) wyników funkcji, przechowywane w polach Item1, Item2...
            var a = myClass.SomeFunction();

            //a.Item1;
            //a.Item2;
            */

            /*
             * 
             * typowy try catch finally, można łapać wyjątki i wyświetlać ich dane, finally wykonyje się zawsze, niezależnie od nie/powodzenia try
            try
            {
                MyClass mC = null;

                mC.Variable = "5";
            }
            catch ( Exception exception)
            {
                //exception.Message= 
                //
            }
            finally
            {
                //

            }
            */

            /*
            // nullowalne zmienne - normalnie inty mają jakąś wartość, domyślnie 0. ale jak się doda znak zapytania to wtedy może też być nullem (można jemu przypisać)
            int? i;
            // tak samo można zrobić z propertkami, czyli można je zrobić np. nullowalnymi doublami
            */

            /*
             * nameof(zmienna) - przechowuje nazwę zmiennej, niezależnie od ewentualnych zmian nazwy zmiennej
            var a = 4;

            var nameOfA = nameof(a);

            typeof(typ) - typ zmiennej

            var c = typeof(int)
            */








        }
        /*
        private static bool Sum(int f, int s, out int result)
        {
            result = f + s;

            return true;
        }
        */

        
        


    }

    public class MyClass
    {
        public string Variable { get; set; }

        public (int, bool) SomeFunction()
        {
            return (5 + 2, true);

        }

    }
}