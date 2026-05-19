using Soenneker.Tests.HostedUnit;

namespace Soenneker.Stytch.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class StytchOpenApiClientRunnerTests : HostedUnitTest
{
    public StytchOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
