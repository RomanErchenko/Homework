using P1_3;

namespace P1_3_2
{
    internal class Program
    {
        static public void Exep(Handler sender,HandlerEventArgs e)
        {
            Console.WriteLine(e.exception.ToString());
           

        }
        static void Main(string[] args)
        {
            MyCollection<string> collection = new MyCollection<string>();
            Handler handler1 = new Handler();
           // handler1.myExep += new Exeptionevent(Exep);
            handler1.myExep += Exep;

            for (int i = 0; i < 100; i++) 
            {
             collection.Add(i.ToString());
            }
           // Handler handler = new Handler();

            for (int i = 0; i < 2; i++)
            {
                new Thread(handler1.Count).Start(collection);
            }

            Console.ReadKey();
        }
    }
}
