using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Event
{
    public class NameEventArgs : EventArgs
    {
        public string Name { get; set; }

        public NameEventArgs(string name)
        {
            Name = name;
        }
        public NameEventArgs()
        {
        }

        public void updated(NameEventArgs e)
        {
            Console.WriteLine($"Name is changed {e.Name}");
        }
    }
}
