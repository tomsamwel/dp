namespace SongIterator;

public static class Program
{
    public static void Main()
    {
        var playlist = new SongAggregate
        {
            Songs = new List<Song>
            {
                new() { Title = "Hey Jude", Artist = "The Beatles" },
                new() { Title = "Bohemian Rhapsody", Artist = "Queen" },
                new() { Title = "Billie Jean", Artist = "Michael Jackson" },
                new() { Title = "Stairway to Heaven", Artist = "Led Zeppelin" },
                new() { Title = "Hotel California", Artist = "The Eagles" },
                new() { Title = "Smells Like Teen Spirit", Artist = "Nirvana" }
            }
        };

        var shuffleIterator = playlist.GetShuffleIterator();
        // IIterator<Song> shuffleIterator = new ShuffleIterator(playlist);

        var ascendingOrderIterator = playlist.GetAscendingOrderIterator();
        // IIterator<Song> ascendingOrderIterator = new AscendingOrderIterator(playlist);

        Console.WriteLine("Shuffled Playlist:");
        while (shuffleIterator.HasNext())
        {
            var song = shuffleIterator.Next();
            Console.WriteLine($"{song.Title} by {song.Artist}");
        }

        Console.WriteLine("\nAscending Order Playlist:");
        while (ascendingOrderIterator.HasNext())
        {
            var song = ascendingOrderIterator.Next();
            Console.WriteLine($"{song.Title} by {song.Artist}");
        }
    }
}