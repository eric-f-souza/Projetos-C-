using System.Text.Json;
using System.Threading.Channels;

namespace ScreenSound_API.Models.Music;
internal class FavoritesMusics
{
    public string Name { get; set; }
    public List<Music> ListFavoriteMusics { get; }

    public FavoritesMusics(string name)
    {
        Name = name;
        ListFavoriteMusics = new();
    }

    public void ShowFavoritesMusics()
    {
        Console.WriteLine($"{Name}'s favorite songs list");
        ListFavoriteMusics.ForEach(music => Console.Write($"Music: {music.Song} - Artist: {music.Artist}\n"));
        Console.WriteLine();
    }
    public void AddFavoriteMusic(Music musics)
    {
        ListFavoriteMusics.Add(musics);
    }

    public void GenerateJsonFile()
    {
        string FileName = $"Favorites_songs_{Name}.txt";
        //string json = JsonSerializer.Serialize(new
        //{
        //    name = Name,
        //    musics = ListFavoriteMusics
        //});

        //File.WriteAllText( FileName, json );
        //Console.WriteLine($"File created successfully {Path.GetFullPath(FileName)}");

        using (StreamWriter fileSW = new StreamWriter(FileName))
        {
            fileSW.WriteLine($"Favorites_songs_{Name}.txt");
            foreach (var music in ListFavoriteMusics)
            {
                fileSW.WriteLine($"Song: {music.Artist} - Artist {music.Artist}");
            }

            Console.WriteLine($"File created successfully {Path.GetFullPath(FileName)}");
        }
    }
}
