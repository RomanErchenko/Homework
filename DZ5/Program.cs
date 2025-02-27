
using DZ5;
using System.Text;

class Program
{
    //Завдання. До попереднього прикладу, додати клас Library. В ньому створити закритий масив книжок на 100 елементів
    //зробити відкритий метод - AddBook() - який додає книгу в масив, але після кожного додавання сортує за втором а в
    //межах автора по назві книги. 
    // Також створити розширину книгу BookWithImages - додати масив байтів що буде містити ілюстрацію до книги.Метод що
    // додає книги в бібліотеку повине мати перевантаження який приймає такий тип - в самому методі - ми повинні
    // приводитись до базової книги якщо це потрібно і додаватись в масив

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        // Створюємо єкземпляри book1 book2,та запрвнюємо поля
        Book book1 = new Book("Лангольери", "Стивен Кинг")
        {
            Pages = 150,
            Price = 10000,
            Anotation = "Гарно",
            Genre = "Жахи",
            YearOfProduce = 1985
        };
        Book book2 = new Book("Некрономікон", "Лавкрафт")
        {
            Pages = 290,
            Price = 1000,
            Anotation = "Гарно",
            Genre = "Фантастика",
            YearOfProduce = 1853
        };
        Book book3 = new Book("Міфи Ктулху", "Лавкрафт")
        {
            Pages = 290,
            Price = 1000,
            Anotation = "Гарно",
            Genre = "Фантастика",
            YearOfProduce = 1853
        };
        Book book4 = new Book("Хроніки Аркхейму", "Лавкрафт")
        {
            Pages = 290,
            Price = 1000,
            Anotation = "Гарно",
            Genre = "Фантастика",
            YearOfProduce = 1853
        };
        Book book5 = new Book("Воно", "Стівен Кінг")
        {
            Pages = 290,
            Price = 1000,
            Anotation = "Гарно",
            Genre = "Фантастика",
            YearOfProduce = 1853
        };
        Book book6 = new Book("Зелена миля", "Стівен Кинг")
        {
            Pages = 290,
            Price = 1000,
            Anotation = "Гарно",
            Genre = "Фантастика",
            YearOfProduce = 1853
        };
        Book book7 = new Book("451 градус за Фаренгейтом", "Бредбері")
        {
            Pages = 290,
            Price = 1000,
            Anotation = "Гарно",
            Genre = "Фантастика",
            YearOfProduce = 1853
        };
        Book book8 = new Book("Вино з кульбаб", "Бредбері")
        {
            Pages = 290,
            Price = 1000,
            Anotation = "Гарно",
            Genre = "Фантастика",
            YearOfProduce = 1853
        };

        Library lib = new Library();
        lib.Add(book1);
        lib.Add(book2);
        lib.Add(book3);
        lib.Add(book4);
        lib.Add(book5);
        lib.Add(book6);
        lib.Add(book7);
        lib.Add(book8);
        Console.WriteLine(new string('-', 30));
        //lib.Show();
        Console.WriteLine(lib[0]);
        Console.WriteLine(new string('-', 30));
        Console.WriteLine(lib["Вино з кульбаб"]);
        Console.ReadKey();
    }
}
