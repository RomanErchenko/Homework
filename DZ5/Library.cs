using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public class Library
    {
        //Створюемо приватний масив
        private Book[] books = new Book[100];
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                    return books[index].Name + " - " + books[index].Author + " - " + books[index].Anotation + " - " + books[index].Pages + " - " + books[index].Genre + " - " + books[index].YearOfProduce;
                else
                    return "Спроба звернення за межі бібліотекі.";
            }
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (i == count)
                    { 
                    break;
                    }
                    if (index == books[i].Name)
                    {
                        return books[i].Name + " - " + books[i].Author + " - " + books[i].Anotation + " - " + books[i].Pages + " - " + books[i].Genre + " - " + books[i].YearOfProduce;

                    }
                }
                return "Немае книжки.";
            }
        }
        private int count = 0;
        // створюємо Бульбашковий метод сортування
        private void BubbleSortBooks(Book[] books)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - 1 - i; j++)
                {
                    int authorComparison = string.Compare(books[j].Author, books[j + 1].Author, StringComparison.OrdinalIgnoreCase);

                    // Сортируем по автору
                    if (authorComparison > 0 || (authorComparison == 0 &&
                         string.Compare(books[j].Name, books[j + 1].Name, StringComparison.OrdinalIgnoreCase) > 0))
                    {
                        // Зміна книг
                        Book temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }
        }
        //Метод додавання
        public void Add(Book book)
        {
            if (count >= books.Length)
            {
                Console.WriteLine("переповнення");
                return;
            }

            books[count] = book;
            count++;
            BubbleSortBooks(books);
        }
        //Метод Додавання книги 
        public void Add(BooksWithImages mybook)
        {
            Book book = (Book)mybook;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                }
            }
            if (books.Length > 1)
            {
                BubbleSortBooks(books);
            }
        }
        //Вивод до консолі
        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Название: " + books[i].Name + ", Автор: " + books[i].Author);
            }
        }
    }
}

