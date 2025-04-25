using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;
using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Utilities;

[TestSubject(typeof(FileInfoExtensions))]
public class FileInfoExtensionsShould()
{
    [Theory]
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
    public void ReturnExpectedResultFromIsImage(string  filePath, bool expected)
    {
        var fileSystem = new MockFileSystem();
        var fileInfo          = fileSystem.FileInfo.New(filePath);

        fileInfo.IsImage().ShouldBe(expected);
    }
}