namespace SongIterator;

public class SongAggregate
{
    public required List<Song> Songs { get; set; }

    public IIterator<Song> GetShuffleIterator()
    {
        return new ShuffleIterator(this);
    }

    public IIterator<Song> GetAscendingOrderIterator()
    {
        return new AscendingOrderIterator(this);
    }
}