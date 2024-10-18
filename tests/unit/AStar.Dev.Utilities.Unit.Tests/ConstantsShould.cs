namespace AStar.Dev.Utilities.Unit.Tests;

public class ConstantsShould
{
    [Fact]
    public void ContainTheExpectedWebDeserialisationSettingsSetting()
        => Constants.WebDeserialisationSettings
                        .ToJson()
                        .Should()
                        .Be("{\"Converters\":[],\"TypeInfoResolver\":null,\"TypeInfoResolverChain\":[],\"AllowTrailingCommas\":false,\"DefaultBufferSize\":16384,\"Encoder\":null,\"DictionaryKeyPolicy\":null,\"IgnoreNullValues\":false,\"DefaultIgnoreCondition\":0,\"NumberHandling\":1,\"PreferredObjectCreationHandling\":0,\"IgnoreReadOnlyProperties\":false,\"IgnoreReadOnlyFields\":false,\"IncludeFields\":false,\"MaxDepth\":0,\"PropertyNamingPolicy\":{},\"PropertyNameCaseInsensitive\":true,\"ReadCommentHandling\":0,\"UnknownTypeHandling\":0,\"UnmappedMemberHandling\":0,\"WriteIndented\":false,\"ReferenceHandler\":null,\"IsReadOnly\":false}");
}
