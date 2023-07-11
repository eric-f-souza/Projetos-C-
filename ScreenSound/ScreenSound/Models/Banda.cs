namespace ScreenSound.Models;

internal class Banda
{
    private readonly List<Album> albums = new();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia banda {Nome}");
        albums.ForEach(album => Console.WriteLine($"Album: {album.Nome} com duração de ({album.DuracaoTotal})"));
    }
}