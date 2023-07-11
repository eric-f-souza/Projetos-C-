namespace ScreenSound.Models;

internal class Album
{
    private readonly List<Musica> musicaList = new();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicaList.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicaList.Add(musica);
    }

    public void ListarMusicas()
    {
        Console.WriteLine($"Lista músicas do álbum {Nome}\n");
        musicaList.ForEach(musica => Console.WriteLine($" Música: {musica.Nome}"));
        Console.WriteLine($"Esse álbum tem um total de {DuracaoTotal} segundos\n");
    }
}