namespace DelegateWithEvent;

class Program
{
    //create a delegate
    public delegate void MyDelegate(string username);

    class Publisher
    {
        //create an event in the publisher class
        public event MyDelegate myevent; //this is of the type as our delegate

        //raise the event in the publisher class
        public void raiseEvent(string username)
        {
            myevent(username);
        }
    }

    class SubscriberClass
    {
        //event handled method
        public void subscriberMethod(string username)
        {
            Console.WriteLine("Hello there! " + username);
        }

        //attach the event handler method to the event
        public void connect()
        {
            Publisher pc = new Publisher();
            pc.myevent += subscriberMethod;
            pc.raiseEvent("aakash");
            pc.raiseEvent("james");
        }
    }


    static void Main(string[] args)
    {
        SubscriberClass sc = new SubscriberClass();
        sc.connect();
    }
}

