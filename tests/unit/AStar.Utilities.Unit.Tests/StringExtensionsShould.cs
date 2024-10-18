using AStar.Utilities.Unit.Tests.Helpers;

namespace AStar.Utilities.Unit.Tests;

public class StringExtensionsShould
{
    [Fact]
    public void ReturnTrueForCallToIsNullWhenStringIsNull()
    {
        string nullString = null!;

        nullString.IsNull().Should().BeTrue();
    }

    [Fact]
    public void ReturnFalseForCallToIsNullWhenStringIsNotNull()
    {
        var nullString = string.Empty;

        nullString.IsNull().Should().BeFalse();
    }

    [Fact]
    public void ReturnFalseForCallToIsNotNullWhenStringIsNull()
    {
        string nullString = null!;

        nullString.IsNotNull().Should().BeFalse();
    }

    [Fact]
    public void ReturnTrueForCallToIsNotNullWhenStringIsNotNull()
    {
        var nullString = string.Empty;

        nullString.IsNotNull().Should().BeTrue();
    }

    [Fact]
    public void ReturnTheExpectedObjectFromTheFromJsonMethod()
    {
        const string testJson = "{\"Id\":1}";

        var objectFromJson = testJson.FromJson<AnyClass>();

        objectFromJson.Id.Should().Be(1);
    }
}
