using Iterator;


NameCollection collection =
new NameCollection();


IIterator iterator =
collection.CreateIterator();



while(iterator.HasNext())
{
    Console.WriteLine(
        iterator.Next()
    );
}