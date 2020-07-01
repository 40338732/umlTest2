using System;

namespace umlTest
{
    class Program
    {
        
            static void Main(string[] args)
            {
                User user = new User();

                user.UserId = 123456;
                user.Name = "Admistrator";
                user.CreateTime = DateTime.Now;

                Console.WriteLine(user.ViewUserAccount());
                Console.ReadLine();

            }
        
    }
}
