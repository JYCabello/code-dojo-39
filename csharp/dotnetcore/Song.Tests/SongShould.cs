using song;

namespace Song.Tests;

public class SongShould
{
    private const string baseRhyme = "";
    
    [Fact(DisplayName = "Produce the base nursery rhyme")]
    public void Test1()
    {
        using var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        Program.Main(Array.Empty<string>());
        Assert.Equal(baseRhyme, stringWriter.ToString());
    }
}
