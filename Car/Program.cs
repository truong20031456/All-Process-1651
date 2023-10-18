using System;

public class Singleton
{
    // Private static instance of the Singleton class
    private static Singleton _instance;

    // Private constructor to prevent external instantiation
    private Singleton()
    {
        // Initialization code, if any
    }

    // Public method to access the Singleton instance
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }

    public void SomeMethod()
    {
        Console.WriteLine("This is a method of the Singleton class.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get an instance of the Singleton
        Singleton singleton1 = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance();

        // Check if both references point to the same instance
        if (singleton1 == singleton2)
        {
            Console.WriteLine("singleton1 and singleton2 are the same instance.");
        }

        // Use the Singleton
        singleton1.SomeMethod();

        Console.ReadKey();
    }
}
