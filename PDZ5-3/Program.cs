using System.Xml;

namespace PDZ5_3
{
    //Створіть .xml файл, який би відповідав наступним вимогам:
//• ім'я файлу: TelephoneBook.xml
//• кореневий елемент: “MyContacts”
//• тег “Contact”, і в ньому має бути записано ім'я контакту
//та атрибут “TelephoneNumber” зі значенням номера телефону.
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "telephone.xml";

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "  ";

            using (XmlWriter writer = XmlWriter.Create(path, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("ListOfTelefons");

                writer.WriteStartElement("Human");
                writer.WriteAttributeString("Mobile", "8897 - 686868");
                writer.WriteElementString("Name", "Bred");
                writer.WriteElementString("Phone", "5000-234-1112");
                writer.WriteEndElement();

                writer.WriteStartElement("Human");
                writer.WriteAttributeString("Mobile", "55555 - 686868");
                writer.WriteElementString("Name", "Pit");
                writer.WriteElementString("Phone", "2300-777-2212");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();

            }


            Console.WriteLine("XML was created: " + path);
            Console.ReadKey();
        }
    }
}
