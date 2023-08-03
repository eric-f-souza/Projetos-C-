using System.Text.Json.Serialization;

namespace ScreenSound_API.Models.Music;
internal class Music
{
    private string[] shades = { "C","C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
    [JsonPropertyName("song")]
    public string? Song { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("duration_ms")]
    public int DurationMs { get; set; }

    //public double Duration => (double) DurationMs / 100;

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
    [JsonPropertyName("year")]
    public string YearString { get; set; }
    [JsonPropertyName("key")]
    public int KeyInt { get; set; }
    public int Year
    {
        get
        {
            return int.Parse(YearString);
        }
    }

    public String Key
    {
        get
        {
            return shades[KeyInt];
        }
    }

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Song: {Song}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {DurationMs/1000}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Launch year : {YearString}");
        Console.WriteLine($"Key: {KeyInt}");
        Console.WriteLine($"Key: {Key}");
    }

}
