using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment;

public class Singleton
{
    private static Singleton _singleton;
    private Singleton()
    {

    }
    public static Singleton Company
    {
        get
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
                return _singleton;
        }

    }

    public void GetFood(string name)
    {
       if (name != null)
       {
         Console.WriteLine($"There is a {name} in the store");
       }
       else
       {
        Console.WriteLine($"Give me the {name} in the store");
       }
    }
    
}
