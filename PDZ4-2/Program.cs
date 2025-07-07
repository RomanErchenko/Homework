using System.Text.RegularExpressions;

namespace PDZ4_2
{
    internal class Program
    {
        //Напишіть консольну програму, яка дозволяє користувачеві зареєструватися під «Логіном»,
        //що складається тільки з символів латинського алфавіту, і пароля, що складається з цифр і символів.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Login");
           string login= "Frank";
            Console.WriteLine("Enter Password");
           string password = "12345";

            var log = new Regex(@"[A-Za-z]");
            var pas = new Regex(@"^\d+$");

            if (log.IsMatch(login))
            {
                Console.WriteLine("Login is sucsess");
            }
            else
            {
                Console.WriteLine("Login is wrong");
            }
            if (pas.IsMatch(password))
            {
                Console.WriteLine("Password is sucsess");
            }
            else
            {
                Console.WriteLine("Password is wrong");
            }
            Console.ReadKey();  
        }
    }
}
