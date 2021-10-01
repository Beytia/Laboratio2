using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    [CollectionDefinition(nameof(TestCollection))]
    public class TestCollection : ICollectionFixture<TestFixture>
    {
    }
}
