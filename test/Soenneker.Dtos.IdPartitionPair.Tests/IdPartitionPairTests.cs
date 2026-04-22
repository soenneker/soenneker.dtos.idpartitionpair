using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.IdPartitionPair.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class IdPartitionPairTests : HostedUnitTest
{
    public IdPartitionPairTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
