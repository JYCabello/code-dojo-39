using song;

namespace Song.Tests;

public class RhymerShould
{
    private const string BaseRhyme = @"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a bird;
How absurd to swallow a bird.
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a cat;
Fancy that to swallow a cat!
She swallowed the cat to catch the bird,
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a dog;
What a hog, to swallow a dog!
She swallowed the dog to catch the cat,
She swallowed the cat to catch the bird,
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a cow;
I don't know how she swallowed a cow!
She swallowed the cow to catch the dog,
She swallowed the dog to catch the cat,
She swallowed the cat to catch the bird,
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!

There was an old lady who swallowed a horse...
...She's dead, of course!";

    public static IEnumerable<object[]> SingleAnimals =>
        new[]
        {
            new object[]
            {
                "fly ",
                @"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!"
            },
            new object[]
            {
                "dog ",
                @"There was an old lady who swallowed a dog.
I don't know why she swallowed a dog - perhaps she'll die!"
            },
        };

    [Fact(DisplayName = "Should produce the default Rhyme")]
    public void Test1() =>
        Assert.Equal(BaseRhyme, new Rhymer().Produce());

    [Theory(DisplayName = "Should produce a Rhyme for a single animal")]
    [MemberData(nameof(SingleAnimals))]
    public void Test2(string animal, string expected) =>
        Assert.Equal(expected, new Rhymer().Produce(new[] { animal }));
}
