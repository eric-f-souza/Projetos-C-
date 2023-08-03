using ScreenSound_API.Models.Music;

namespace ScreenSound_API.Filters;
internal class LinqOrder
{
    public static void ShowListArtistsAlphabeticalOrder(List<Music> listMusics)
    {
        var SortedAlphabeticalArtistList = listMusics.OrderBy(music => music.Artist).Select(music => music.Artist).Distinct().ToList();
        Console.WriteLine("Artist Alphabetical Order");
        foreach (var artist in SortedAlphabeticalArtistList)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
