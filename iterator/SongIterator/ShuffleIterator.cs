namespace SongIterator;

public class ShuffleIterator : IIterator<Song>
{
    private readonly List<Song> _shuffledSongs;
    private int _currentIndex;

    public ShuffleIterator(SongAggregate aggregate)
    {
        _shuffledSongs = aggregate.Songs.OrderBy(_ => Guid.NewGuid()).ToList();
    }

    public bool HasNext()
    {
        return _currentIndex < _shuffledSongs.Count;
    }

    public Song Next()
    {
        return _shuffledSongs[_currentIndex++];
    }
}