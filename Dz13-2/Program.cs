using Dz13_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz13_1
{
    class Program
    {
        //Створіть клас InnerElementList<T>, який реалізує інтерфейси
        //IEnumerable<T>, IEnumerator<T>. Реалізуйте у ньому весь необхідний
        //функціонал використання циклу foreach з цією колекцією.
        //Створіть клас OuterElementList<T>, який реалізує інтерфейси
        //IEnumerable<T>, IEnumerator<T>.Реалізуйте у ньому весь необхідний
        //функціонал використання циклу foreach з цією колекцією.Ця колекція
        //має містити елементи типу InnerElementList.
        //Створіть екземпляр колекції OuterElementList та заповніть його
        //елементами InnerElementList.Пройдіться елементами InnerElementList
        //за допомогою вкладених циклів foreach.

        static void Main(string[] args)
        {
            OuterElementList<InnerElementList<string>> values =
            new OuterElementList<InnerElementList<string>>(3)
            { new InnerElementList<string>{"value1","value2","value3" }, new InnerElementList<string> { "value4", "value5", "value6" }, new InnerElementList<string> { "value7", "value8", "value9" } };
           

            foreach (var elem in values)
            {
                foreach (var item in elem)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
