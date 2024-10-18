namespace AStar.Dev.Utilities.Unit.Tests;

public class EnumExtensionsShould
{
    [Fact]
    public void ContainTheParseMethodReturningTheExpectedValue()
            => "Defined".ParseEnum<AnyEnum>().Should().Be(AnyEnum.Defined);

    [Fact]
    public void ContainTheParseMethodWhichThrowsArgumentExceptionWhenTheValueIsNotFound()
    {
        Action parseStringAction = () => "ThisDoesntExitst".ParseEnum<AnyEnum>();

        _ = parseStringAction.Should().Throw<ArgumentException>();
    }
}
