using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsExamples.Domain.Services
{
    public class LegalAgeService : ILegalAgeService
    {
        public int GetLegalAgeForRegion(string region)
        {
            switch (region)
            {
                case "USA":
                    return 21;
                default:
                    return 18;
            }
        }
    }
}
