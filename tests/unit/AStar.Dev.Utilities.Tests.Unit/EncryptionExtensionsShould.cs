using AStar.Dev.Utilities;
using JetBrains.Annotations;

namespace AStar.Dev.Utilities;

[TestSubject(typeof(EncryptionExtensions))]
public class EncryptionExtensionsShould
{

    [Fact]
    public void EncryptTheTextAsExpected()
        => "SomeIrrelevantText".Encrypt("oe3QnEe&@NnJ$$^L$1N@4WVKFayaAAbO", "sBA&3z*4cQf%$ww!").ShouldBe("PQGmSBnvuHDkD9fVoKrSOjQGRLWgCci5GXa0g2DM5L0=");

    [Fact]
    public void DecryptTheTextAsExpected()
        => "PQGmSBnvuHDkD9fVoKrSOjQGRLWgCci5GXa0g2DM5L0=".Decrypt("oe3QnEe&@NnJ$$^L$1N@4WVKFayaAAbO", "sBA&3z*4cQf%$ww!").ShouldBe("SomeIrrelevantText");
}