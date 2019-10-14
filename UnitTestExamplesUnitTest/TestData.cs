using System;
using System.Collections.Generic;
using System.Text;
using UnitTestsExamples.Domain.Models;

namespace UnitTestExamplesUnitTest
{
    public class TestData
    {
        public static User[] TestUser => new[] {
            new User { Name = "Busta Rhymes", Age = 16, Region = "USA" },
            new User {Name = "Jay-Z", Age = 44, Region = "USA"}
        };
    }
}
