namespace AStar.Dev.Utilities.Unit.Tests;

public class ObjectExtensionsShould
{
    [Fact]
    public void ContainTheToJsonMethodWhichReturnsTheExpectedString()
        => ObjectExtensions
                .ToJson(new AnyClass())
                .Should().Be("{\"AnyInt\":0,\"AnyString\":\"\"}");
}
