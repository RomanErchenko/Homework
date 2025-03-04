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
        public Book this[string name]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    
                    if (name == books[i].Name)
                    {
                        return books[i];
                    }
                }
                return null;
            }
        }
        private int count = 0;
        private void BubbleSortBooks(Book[] books)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - 1 - i; j++)
                {
                    int authorComparison = string.Compare(books[j].Author, books[j + 1].Author, StringComparison.OrdinalIgnoreCase);
                    if (authorComparison > 0 || (authorComparison == 0 &&
                         string.Compare(books[j].Name, books[j + 1].Name, StringComparison.OrdinalIgnoreCase) > 0))
                    {
                        Book temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }
        }
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
        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Название: " + books[i].Name + ", Автор: " + books[i].Author);
            }
        }
    }
}

