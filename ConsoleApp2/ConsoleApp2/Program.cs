namespace ConsoleApp2
{
    internal class Program
    {
        public int MyProperty { get; set; }
        


        static void Main(string[] args)
        {
            /*
             * Enumy
             * 
            var myDirection = default(Direction); // 0 

            myDirection = Direction.Down;

            var enumString = myDirection.ToString();

            var enumFromString = Enum.Parse(typeof(Direction), "Right");

            foreach (var enumitem in Enum.GetValues(typeof(Direction)))
            {
                Console.WriteLine(enumitem);
            }
            */

            var mapper = new UserMapper();

            var entity = new UserEntity
            {
                Name = "Marek",
                Age = 21,
                Email = "test@test.com"
            };
              
            var dto = mapper.Map(entity);



        }
    }



    public enum Direction : long // defaultowo int
    {
        Unknown = 0,
        Left = 10,
        Right = 100,
        Up,
        Down
    }

}