using Forexclub.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forexclub.Service
{
    internal class TestDataReader
    {
        public static TestsSettings GetTestsSettings()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName)
                .AddJsonFile("Forexclub/Resources/data.json").Build();

            var section = config.GetSection(nameof(TestsSettings));

            var testsSettings = section.Get<TestsSettings>();

            return testsSettings;
        }
    }
}
