namespace AStar.Dev.Utilities.Unit.Tests;

public class StringExtensionsShould
{
    private readonly string? nullString = null;
    private readonly string notNullString = "value does not matter";
    private readonly string whitespaceString = " ";
    private readonly string anyJson = "{\"AnyInt\":0,\"AnyString\":\"\"}";

    [Fact]
    public void ContainTheIsNullMethodWhichReturnsTheResult()
        => nullString.IsNull().Should().BeTrue();

    [Fact]
    public void ContainTheIsNotNullMethodWhichReturnsTheResult()
        => notNullString.IsNotNull().Should().BeTrue();

    [Fact]
    public void ContainTheIsNullOrWhiteSpaceMethodWhichReturnsTheResult()
        => whitespaceString.IsNullOrWhiteSpace().Should().BeTrue();

    [Fact]
    public void ContainTheIsNotNullOrWhiteSpaceMethodWhichReturnsTheResult()
        => notNullString.IsNotNullOrWhiteSpace().Should().BeTrue();

    [Fact]
    public void ContainTheFromJsonMethodWhichReturnsTheResult()
        => anyJson.FromJson<AnyClass>().Should().BeEquivalentTo<AnyClass>(new() { });

    [Fact]
    public void ContainTheFromJsonTakingJsonSerializerOptionsMethodWhichReturnsTheResult()
        => anyJson.FromJson<AnyClass>(new()).Should().BeEquivalentTo<AnyClass>(new() { });
}
