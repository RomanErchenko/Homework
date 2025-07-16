using System.Data.Common;
using System.Text;
using System.Text.RegularExpressions;

namespace PDZ4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Напишіть жартівливу програму «Дешифратор», яка в текстовому файлі
            //могла б замінити всі прийменники слово «ГАВ!».
            string input = "Після вечері поіду до міста";
            string pattern= @"\b( у|на|під|над|біля|серед|після|до|перед|для|заради)\b";
            var regex = new Regex(pattern);
            string[] inputMass = input.ToLower().Split(" ");
            for (int i = 0; i < inputMass.Length; i++)
            {
                if (regex.IsMatch(inputMass[i]))
                {
                    inputMass[i] = "гав";
                   
                }
            
            }
            string output = string.Join(" ", inputMass);
            Console.WriteLine(output);
           Console.ReadKey();


            
        }
    }
}
