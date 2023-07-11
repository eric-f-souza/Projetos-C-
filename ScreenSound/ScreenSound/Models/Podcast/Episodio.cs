namespace ScreenSound.Models.Podcast;

internal class Episodio
{
    public List<string> convidados = new();

    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }

    public string Resumo =>
        $"N° {Ordem}, Titulo: {Titulo}, duração: ({Duracao} min), Convidados: {string.Join(", ", convidados)}\n";


    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }

    public void ExibirResumo()
    {
        Console.WriteLine(Resumo);
    }
}