using ScreenSound_API.Models.Music;

namespace ScreenSound_API.Filters;
internal class LinqFilter
{
    public static void FilterGenreMusic(List<Music> musicList)
    {
        var allGengeMusic = musicList.Select(generes => generes.Genre).Distinct().ToList();
        foreach (var gener in allGengeMusic)
        {
            Console.WriteLine($" - {gener}");
        }
    }

    public static void FilterArtisByGenreMusical(List<Music> musicList, string gener)
    {
        var artistByGere = musicList
            .Where(music => music.Genre.Contains(gener))
            .Select(music => music.Artist)
            .Distinct();

        Console.WriteLine($"Artists of the genge {gener}");
        foreach (var artist in artistByGere)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterMusicByArtist(List<Music> musicList, string artist)
    {
        var artistSongs = musicList.Where(music => music.Artist.Equals(artist))
            .Select(music => music.Song)
            .Distinct();
        Console.WriteLine($"Songs of {artist}\n");
        foreach (var artistSong in artistSongs)
        {
            Console.WriteLine($" - {artistSong}");
        }
    }

    public static void FilterMusicByYear(List<Music> muscsList, int year)
    {
        var yearMuscsList = muscsList.Where(music => music.Year == year)
            .Select(music => music.Song)
            .Distinct();
        Console.WriteLine($"Musics year {year}");
        foreach (var music in yearMuscsList)
        {
            Console.WriteLine($"- {music}");
        }
    }

    public static void FilterByTonality(List<Music> muscsList)
    {
        var songsByTonality = muscsList.Where(music => music.Key.Equals("C#"))
                .Select(music => music.Song)
                .Distinct();
        if (songsByTonality.Count() > 0)
        {
            Console.WriteLine($"Songs from tonality C#");
            foreach (var music in songsByTonality)
            {
                Console.WriteLine($" - {music}");
            }
        }
        else
        {
            Console.WriteLine("Invalid tonality");
        }
            
       
    }
}
