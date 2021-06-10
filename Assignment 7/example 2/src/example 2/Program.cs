using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_2
{
    public class person
    {
        public string firstname;
        public string lastname;

        public void introduce()
        {
            Console.WriteLine("My name is " + firstname + " " + lastname);
        }
        
        }
    }
