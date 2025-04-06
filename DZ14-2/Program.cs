namespace DZ14_2
{
    internal class Program
    {
        //Створіть клас MyClassCollection. У тілі класу створіть відкритий
        //рядковий масив на 10 елементів.
       // Створіть методи GetEvenIndexValues() та GetOddIndexValues(),
       // що повертають IEnumerable.За допомогою оператора yield реалізуйте
       // в тілах методів механізм звернення до масиву рядків та повернення
       // всіх значень, що зберігаються за парним та непарним індексом відповідно.
       // У методі Main створіть екземпляр класу MyClassCollection, заповніть
       // його внутрішній масив і в циклах foreach обійдіть отримані спочатку
       // з GetEvenIndexValues() і потім з GetOddIndexValues() значення.

        static void Main(string[] args)
        {
            MyCollection<int> my = new MyCollection<int>();

            my.Add(1);
            my.Add(2);
            my.Add(3);  
            my.Add(4);
            my.Add(5);
            my.Add(6);
            my.Add(7);
            my.Add(8);
            my.Add(9);
            my.Add(10);


            foreach (var elem in my.GetEvenIndexValues())
            { 
             Console.WriteLine(elem);
            }

            foreach (var elem in my.GetOddIndexValues())
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();  
        }
    }
}
