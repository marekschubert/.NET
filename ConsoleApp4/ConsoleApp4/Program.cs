namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = new
            {
                Value1 = 1,
                Value2 = "asd"
            };

            var listOfInts = new List<int>
            {
                2, 5, 8, 1, 10, 15
            };

            var listOfStrings = new List<string>
            {
                "as", "sdf", "dfgd", "xcvx", "sdferw"
            };

            var listOfUser = new List<User>
            {
                new User
                {
                    Name= "Test",
                    Age= 1,
                    Email = "Test@",
                },
                new User
                {
                    Name = "Marek",
                    Age= 21,
                    Email = "asd"
                },
                new User
                {
                    Name= "Test2",
                    Age= 22,
                    Email = "asdsdf"
                }
            };


            listOfInts.ForEach(x => { Console.WriteLine(x); });


            Console.WriteLine(listOfUser.Average(x => x.Age));

             
            var someStrings = listOfStrings.Skip(1).Take(2).ToList();

            var convertedIntsToStrings = listOfInts.Select(x => x.ToString()).ToList();

            convertedIntsToStrings.ForEach(x => Console.WriteLine(x));

            var convStringsToInts = convertedIntsToStrings.Select(x => int.Parse(x)).ToList();

            convStringsToInts.ForEach(x => Console.WriteLine(x));

            
            
            var userViewModels = listOfUser
                .Select(x => new
                {
                    UserData = x,
                    Title = GetUserTitle(x.Age) // tutaj użyte, żeby w przypadku konieczności wielokrotnego użycia dużej funkcji, wywołać ją raz i potem używać policzonej wartości 
                })
                .Select(x => new UserViewModel
                {
                    Name = x.UserData.Name,
                    Age = x.UserData.Age,
                    Email = x.UserData.Email,
                    Title = x.Title,
                    Title2 = x.Title,
                    Title3 = x.Title
                })
                f.ToList();
            
            userViewModels.ForEach(x => Console.WriteLine(x));
            
            
        }



        private static string GetUserTitle(int userAge) => userAge > 20 ? "Title1" : "NoTitle";

    }









}