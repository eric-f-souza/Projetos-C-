namespace ScreenSound.Models.Podcast;

internal class Podcast
{
    private readonly List<Episodio> episodios = new();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }

    private int totalEpisodios => episodios.Count;

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Resumo Do podcast de titulo {Nome} hospedado no Host: {Host}\n");
        Console.WriteLine("Lista de episodios publicados\n");
        if (episodios.Count > 0)
        {
            Console.WriteLine($"Total de episodios publicados: {totalEpisodios}");
            foreach (var episodio in episodios.OrderBy(ep => ep.Ordem)) Console.WriteLine(episodio.Resumo);
        }
        else
        {
            Console.WriteLine("Nenhum episodio publicado");
        }
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        Console.WriteLine("\nEpisodio adicionado com sucesso");
    }
}