namespace Observer;

public interface ISubject
{
    void AddObserver(IObserver observer);

    void Notify();
}