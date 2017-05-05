using NUnit.Framework;
using TestStack.Seleno.Configuration.Contracts;
using TestStack.Seleno;

namespace BartlettAreTheQAs
{
    [SetUpFixture]
    public class BrowserStackLocalServerRunner
    {
        private static readonly IConfigurationProvider Configuration = new ConfigurationProvider();
        private static readonly ILifecycleTask LocalTestRunnerServer = new PrivateLocalServer(Configuration);

        [OneTimeSetUp]
        public void StartLocalServer()
        {
            if (Configuration.RunTestLocally)
            {
                LocalTestRunnerServer.Start();
            }
        }

        [OneTimeTearDown]
        public void StopLocalServerRunner()
        {
            if (Configuration.RunTestLocally)
            {
                LocalTestRunnerServer.Stop();
            }
        }
    }
}