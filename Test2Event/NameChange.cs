using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Event
{
    public delegate void EventDelegate(NameEventArgs e);
    public class NameChange
    {
        public event EventDelegate NameChanged;

        public void UpdateName(string name)
        {
            nameChanged(new NameEventArgs(name));
        }

        protected virtual void nameChanged(NameEventArgs e)
        {
            NameChanged.Invoke(new NameEventArgs(e.Name));
        }
    }
}
