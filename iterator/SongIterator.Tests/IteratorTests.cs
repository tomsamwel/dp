namespace SongIterator.Tests;

public class IteratorTests
{
    private List<Song> GenerateSongs(int count)
    {
        var songs = new List<Song>();
        for (int i = 1; i <= count; i++)
        {
            songs.Add(new Song { Title = "Song" + i, Artist = "Artist" + i });
        }
        return songs;
    }

    [Test]
    public void Test_ShuffleIterator()
    {
        var playlist = new SongAggregate { Songs = GenerateSongs(50) };
        var iterator = new ShuffleIterator(playlist);

        var shuffledSongs = new List<Song>();
        while (iterator.HasNext())
        {
            shuffledSongs.Add(iterator.Next());
        }

        Assert.That(shuffledSongs, Is.Not.EqualTo(playlist.Songs));
        Assert.That(shuffledSongs.Count, Is.EqualTo(playlist.Songs.Count));
    }

    [Test]
    public void Test_AscendingOrderIterator()
    {
        var playlist = new SongAggregate { Songs = GenerateSongs(50) };
        var iterator = new AscendingOrderIterator(playlist);

        var ascendingSongs = new List<Song>();
        while (iterator.HasNext())
        {
            ascendingSongs.Add(iterator.Next());
        }

        Assert.That(ascendingSongs, Is.EqualTo(playlist.Songs));
        Assert.That(ascendingSongs, Has.Count.EqualTo(playlist.Songs.Count));
    }

    [Test]
    public void Test_CollectionNotExposed()
    {
        var playlist = new SongAggregate { Songs = GenerateSongs(50) };
        var iterator = new ShuffleIterator(playlist);

        Assert.That(iterator.GetType().GetProperties().Any(p => p.PropertyType == typeof(List<Song>)), Is.False);
    }
    
    [Test]
    public void Test_EmptyPlaylist()
    {
        var playlist = new SongAggregate { Songs = new List<Song>() };
        var iterator = new ShuffleIterator(playlist);
        Assert.IsFalse(iterator.HasNext());
    }

    [Test]
    public void Test_SingleSongPlaylist()
    {
        var playlist = new SongAggregate { Songs = new List<Song> { new Song { Title = "A", Artist = "Artist1" } } };
        var iterator = new ShuffleIterator(playlist);
        Assert.IsTrue(iterator.HasNext());
        Assert.That(iterator.Next().Title, Is.EqualTo("A"));
    }

    [Test]
    public void Test_GetIterator()
    {
        var playlist = new SongAggregate { Songs = new List<Song> { new Song { Title = "A", Artist = "Artist1" } } };
        var iterator = playlist.GetShuffleIterator();
        Assert.That(iterator, Is.InstanceOf<ShuffleIterator>());
    }

    [Test]
    public void Test_SongClass()
    {
        var song = new Song { Title = "A", Artist = "Artist1" };
        Assert.Multiple(() =>
        {
            Assert.That(song.Title, Is.EqualTo("A"));
            Assert.That(song.Artist, Is.EqualTo("Artist1"));
        });
    }
    
    [Test]
    public void Test_SongTitleGetter()
    {
        var song = new Song { Title = "A", Artist = "Artist1" };
        Assert.That(song.Title, Is.EqualTo("A"));
    }

    [Test]
    public void Test_SongArtistGetter()
    {
        var song = new Song { Title = "A", Artist = "Artist1" };
        Assert.That(song.Artist, Is.EqualTo("Artist1"));
    }

    [Test]
    public void Test_GetShuffleIterator()
    {
        var playlist = new SongAggregate { Songs = new List<Song> { new Song { Title = "A", Artist = "Artist1" } } };
        var iterator = playlist.GetShuffleIterator();
        Assert.That(iterator, Is.InstanceOf<ShuffleIterator>());
        Assert.That(iterator.HasNext(), Is.True);
    }

    [Test]
    public void Test_GetAscendingOrderIterator()
    {
        var playlist = new SongAggregate { Songs = new List<Song> { new Song { Title = "A", Artist = "Artist1" } } };
        var iterator = playlist.GetAscendingOrderIterator();
        Assert.That(iterator, Is.InstanceOf<AscendingOrderIterator>());
        Assert.That(iterator.HasNext(), Is.True);
    }
}