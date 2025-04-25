using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Utilities;

[TestSubject(typeof(RegexExtensions))]
public class RegexExtensionsShould
{
    [Theory]
    [InlineData("SOMETEXT",  false)]
    [InlineData("12345678",  false)]
    [InlineData("SomeText", true)]
    public void ReturnTheExpectedResultForTheLowercaseLetterCheck(string stringToCheck,  bool expected)
        => stringToCheck.ContainsAtLeastOneLowercaseLetter().ShouldBe(expected);

    [Theory]
    [InlineData("SOMETEXT", true)]
    [InlineData("sometext", false)]
    [InlineData("SomeText", true)]
    public void ReturnTheExpectedResultForTheUppercaseLetterCheck(string stringToCheck,  bool expected)
        => stringToCheck.ContainsAtLeastOneUppercaseLetter().ShouldBe(expected);

    [Theory]
    [InlineData("SOMETEXT", false)]
    [InlineData("12345678", true)]
    [InlineData("SomeText1", true)]
    public void ReturnTheExpectedResultForTheAtleastOneDigitCheck(string stringToCheck,  bool expected)
        => stringToCheck.ContainsAtLeastOneDigit().ShouldBe(expected);

    [Theory]
    [InlineData("SomeText",   false)]
    [InlineData("SomeText!",  true)]
    [InlineData("Some-Text",  true)]
    [InlineData("Some\\Text", true)]
    [InlineData("Some/Text",  true)]
    [InlineData("Some:Text",  true)]
    [InlineData("Some@Text",  true)]
    [InlineData("Some`Text",  true)]
    [InlineData("Some{Text",  true)]
    [InlineData("Some}Text",  true)]
    [InlineData("Some~Text",  true)]
    public void ReturnTheExpectedResultForTheAtLeastOneSpecialCharacterCheck(string stringToCheck,  bool expected)
    => stringToCheck.ContainsAtLeastOneSpecialCharacter().ShouldBe(expected);
}