namespace SongIterator;

public interface IIterator<out T>
{
    bool HasNext();
    T Next();
}