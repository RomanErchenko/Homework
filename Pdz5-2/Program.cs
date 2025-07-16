using System.Xml;

namespace Pdz5_2
{
    internal class Program
    {
        //З файлу TelephoneBook.xml (файл повинен був бути створений у процесі
        //виконання додаткового завдання) виведіть на екран лише номери телефонів.
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("telephone.xml");

            XmlNodeList phones = doc.GetElementsByTagName("Phone");

            foreach (XmlNode ph in phones)
            {
                Console.WriteLine("Phone " + ph.InnerText);

            }

            Console.ReadKey();  
        }

    }
}
