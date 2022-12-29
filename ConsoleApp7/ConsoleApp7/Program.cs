using Newtonsoft.Json;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var someObject = new JSONExample
            {
                UserName = "test",
                SomeStrings = new List<string>
                {
                    "a", "s"
                },
                Value = 5
            };
            
            var json = JsonConvert.SerializeObject(someObject);


            Console.WriteLine(json);

            var someOtherObject = JsonConvert.DeserializeObject<JSONExample>(json);



        }
    }
}