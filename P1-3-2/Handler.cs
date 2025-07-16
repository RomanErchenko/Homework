using P1_3;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace P1_3_2
{
    public delegate void Exeptionevent(Handler sender,HandlerEventArgs e);
    public class HandlerEventArgs
    { 
      public Exception exception;
        public HandlerEventArgs( Exception l)
        {
            exception =l;
        
        }
    
    }
  
    public class Handler
    {
        object block = new object();
        int hash = Thread.CurrentThread.GetHashCode();
       // MyCollection<string> my = new MyCollection<string>();
        int count = 0;

        public event Exeptionevent? myExep = null;

       
        public void Count(object p)
        {
            
             MyCollection<string> my = p as MyCollection<string>; 

            int hash = Thread.CurrentThread.GetHashCode();

            Monitor.Enter(block);
           // lock (block)
            {
                foreach (string c in my)
                {
                    if (count == 10)
                    {

                       
                            Console.WriteLine($"thread # {hash}");
                            count = 0;
                            Thread.Sleep(200);

                            Monitor.Wait(block);
                        
                    }
                    Monitor.Pulse(block);
                    Console.WriteLine($"thread # {hash}: value {c}");
                    Thread.Sleep(100);
                    count++;


                }
                 Exception l = new Exception($"thread # {hash}");
                 myExep?.Invoke(this, new HandlerEventArgs(l));
               
            }
            Monitor.Exit(block);
            
           
           

        }

       
    }
}
