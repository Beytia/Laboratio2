using System;
using System.Collections.Generic;
using System.Text;

namespace functions.IntegrationsTest
{
    [Collection(nameof(TestCollection))]
    class WelcomeTest
    {
        private TestFixture testFixture;
        private HttpResponseMessage httpResponseMessage;

        public WelcomeTest(TestFixture fixture)
        {
            testFixture = fixture;
        }

    [Fact]
    public async task WhenFunctionIsInvolked()
        {
            httpResponseMessage = await testFixture.Client.GetAsync("api/Welcome?name=Norman");
            Assert.True(httpResponseMessage.IsSuccessStatusCode);
        }
    }
}
