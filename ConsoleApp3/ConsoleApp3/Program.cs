namespace ConsoleApp3
{
    internal class Program
    {
        public delegate int DelegateName(int a);

        static void Main(string[] args)
        {
            /*
             * Delegaty i lambdy
             * 
             * Delegatów już się nie używa, wszędzie należy zastąpić lambdą
             * 
             * Można zapisać sobie funkcję zapisaną lambdą, pisząc Func<arg1Type, arg2Type, arg3Type, ..., outType> nazwa = *wyrażenie lambda*, np (x, y, z) => {... return x + y + z;};
             * 
             * Chcąc stworzyć funkcję, która dostaje jako argument funkcję zapisaną lambdą, trzeba dać analogicznie Func<...> nazwa
             * 
             * 
            DelegateName someVariable = delegate(int a) { return 2; };

            Func<int, int> someVariablee =  (a) => a * 2;
            
            someVariable(5);

            SomeFunction2(someVariable);*/

            var listOfStrings = new List<string>
            {
                "a", "b", "c", "d", "e", "f"
            };


            var stringMatchingExpression = GetFirstOrDefault(listOfStrings, x => x.StartsWith("b"));

            Console.WriteLine(stringMatchingExpression);
        }

        private static string GetFirstOrDefault(List<string> strings, Func<string, bool> functionToCheck)
        {
            foreach (var item in strings) 
            {
                if (functionToCheck(item))
                {
                    return item;
                }
            }
            return null;
        }


        private static int SomeFunction1(int a)
        {
            return 2;


        }
        private static void SomeFunction2(DelegateName someFunction1)
        {
            var a = someFunction1(6);


        }

    }
}