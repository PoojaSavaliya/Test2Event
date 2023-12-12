namespace Test2Event
{
    public class Program
    {
        static void Main(string[] args)
        {
            NameChange n = new NameChange();
            NameEventArgs nameEvent = new NameEventArgs();
            n.NameChanged += nameEvent.updated;
            n.UpdateName("Pooja");
        }
    }
}