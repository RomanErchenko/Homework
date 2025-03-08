using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public class Book
    {
            //Приватні поля
            private double price;
            //Автовластивості
            // Автовластивость Анотація 
            public string Anotation { get; set; }
            // Автовластивость Жанр
            public string Genre { get; init; }
            //Автовластивость Сторінки
            public int Pages { get; init; }
            //Автовластивость Року
            public int YearOfProduce { get; init; }
            //Автовластивость Назва книги
            public string Name { get;}
            //Автовластивость автор
            public string Author { get;}
           
            public double Price
            {
                get
                {
                    return price;
                }
                set
                {
                    if (value > 100)
                    {
                        price = value;
                    }
                }
            }

            public Book(string name, string author)
            {
                Name = name;
                Author = author;
            }
          
            public void Open()
            {
                Console.WriteLine("Ви почали читати книгу");
                Console.WriteLine($"Назва книги: {Name}, Автор: {Author}, Жанр: {Genre}, Сторінки: {Pages}, Ціна: {Price}, Анотація: {Anotation}, Роки випуску: {YearOfProduce}");
            }
    }
}
