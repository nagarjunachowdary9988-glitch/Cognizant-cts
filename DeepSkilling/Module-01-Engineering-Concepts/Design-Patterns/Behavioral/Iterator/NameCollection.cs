namespace Iterator;

public class NameCollection : IContainer
{

    private string[] names =
    {
        "Nagarjuna",
        "Alex",
        "John"
    };


    public IIterator CreateIterator()
    {
        return new NameIterator(names);
    }


    private class NameIterator : IIterator
    {

        private string[] names;

        private int index = 0;


        public NameIterator(string[] names)
        {
            this.names = names;
        }


        public bool HasNext()
        {
            return index < names.Length;
        }


        public string Next()
        {
            return names[index++];
        }

    }

}