﻿using System;
using System.Linq;

namespace song;

public class Rhymer
{
    const string defaultRhyme = 
        @"There was an old lady who swallowed a fly.
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

    public string Produce() => Produce(Array.Empty<string>());

    private string FirstVerse(string animal) =>
        @$"There was an old lady who swallowed a {animal}.
I don't know why she swallowed a {animal} - perhaps she'll die!";

    private string SecondVerse(string animal, string animal2) =>
        FirstVerse(animal) + Environment.NewLine +
        @$"There was an old lady who swallowed a {animal2};
That wriggled and wiggled and tickled inside her.
She swallowed the {animal2} to catch the {animal};
I don't know why she swallowed a {animal} - perhaps she'll die!";
    public string Produce(string[] animals) =>
        animals.Length switch
        {
            1 => FirstVerse(animals[0]),
            2 => SecondVerse(animals[0], animals[1]),
            _ => defaultRhyme
        };
}