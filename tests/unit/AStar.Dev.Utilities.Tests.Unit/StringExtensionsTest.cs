using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Utilities;

[TestSubject(typeof(StringExtensions))]
public class StringExtensionsTest
{

    [Theory]
    [InlineData("",              false)]
    [InlineData("textfile.txt",  false)]
    [InlineData("comma.csv",     false)]
    [InlineData("filename.png",  true)]
    [InlineData("filename.jpg",  true)]
    [InlineData("filename.jpeg", true)]
    [InlineData("filename.jpEg", true)]
    [InlineData("filename.bmp",  true)]
    [InlineData("filename.jfif", true)]
    [InlineData("filename.jif",  true)]
    [InlineData("filename.gif",  true)]
    [InlineData("filename.GIF",  true)]
    public void IsImageShouldReturnExpectedResults(string fileName, bool expected)
        => fileName.IsImage().ShouldBe(expected);
}