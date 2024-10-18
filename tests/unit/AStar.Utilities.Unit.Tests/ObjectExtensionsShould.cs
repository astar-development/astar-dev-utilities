using AStar.Utilities.Unit.Tests.Helpers;

namespace AStar.Utilities.Unit.Tests;

public class ObjectExtensionsShould
{
    [Fact]
    public void ReturnTheJsonRepresentationOfThePassedObject()
    {
        var anyClass = new AnyClass { Id = 1 };

        anyClass.ToJson().Should().Be("{\"Id\":1}");
    }
}
