namespace SongIterator;

public class AscendingOrderIterator : IIterator<Song>
{
    private readonly List<Song> _songs;
    private int _currentIndex;

    public AscendingOrderIterator(SongAggregate aggregate)
    {
        _songs = aggregate.Songs;
    }

    public bool HasNext()
    {
        return _currentIndex < _songs.Count;
    }

    public Song Next()
    {
        return _songs[_currentIndex++];
    }
}