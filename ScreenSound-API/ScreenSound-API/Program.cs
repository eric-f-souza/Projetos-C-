using System.Text.Json;
using ScreenSound_API.Filters;
using ScreenSound_API.Models.Music;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        //Console.WriteLine(resposta);
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        //musics[1090].ExibirDetalhesMusica();
        //LinqFilter.FilterGenreMusic(musics);
        //LinqOrder.ShowListArtistsAlphabeticalOrder(musics);
        //LinqFilter.FilterArtisByGenreMusical(musics,"rock");
        //LinqFilter.FilterMusicByArtist(musics, "Taylor Swift");
        //LinqFilter.FilterMusicByYear(musics, 2019);
        LinqFilter.FilterByTonality(musics);

        //FavoritesMusics ericSongsList = new("Eric");

        //ericSongsList.AddFavoriteMusic(musics[0]);
        //ericSongsList.AddFavoriteMusic(musics[377]);
        //ericSongsList.AddFavoriteMusic(musics[3]);
        //ericSongsList.AddFavoriteMusic(musics[5]);
        //ericSongsList.AddFavoriteMusic(musics[6]);

        //ericSongsList.ShowFavoritesMusics();

        //var AleSongsList = new FavoritesMusics("Ale");

        //AleSongsList.AddFavoriteMusic(musics[10]);
        //AleSongsList.AddFavoriteMusic(musics[200]);
        //AleSongsList.AddFavoriteMusic(musics[321]);
        //AleSongsList.AddFavoriteMusic(musics[55]);
        //AleSongsList.AddFavoriteMusic(musics[69]);

        //AleSongsList.ShowFavoritesMusics();

        //AleSongsList.GenerateJsonFile();


    }
    catch (Exception e)
    {
        Console.WriteLine($"Erro: {e.Message}");
    }
    

}
