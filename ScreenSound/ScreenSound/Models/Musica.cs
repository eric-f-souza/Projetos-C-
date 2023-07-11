namespace ScreenSound.Models;

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public Genero Genero { get; set; }

    public string DescricaoResumida =>
        $"A musica {Nome} pertence  à banda {Artista.Nome}\n";

    public int Somando(int a, int b)
    {
        return a + b;
    }

    public void DadosMusica()
    {
        Console.WriteLine($"Nome musica: {Nome}," +
                          $"\nArtista: {Artista.Nome}" +
                          $"\nDuração: {Duracao}");
        if (Disponivel)
            Console.WriteLine("Música esta disponível no Plano\n");
        else
            Console.WriteLine("Música indisponível no momento, para o plano base, adquira o Plano plus+\n");
    }
}