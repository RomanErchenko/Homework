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
        private static Library check=null;
        protected Library()
        { }
        public static Library Check()
        {
            if (check == null)
            {
                check = new Library();
            }
            
             return check; 
        }
        public Book this[string index]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    
                    if (index == books[i].Name)
                    {
                        return books[i];

                    }
                }
                return null;
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

