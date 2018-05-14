using System;
using System.Collections.Generic;
using System.Text;

namespace Wine
{
    public class Container
    {
        public virtual void Pour()
        {
            Console.WriteLine("Container::Pour");
        }
    }
}
