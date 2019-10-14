using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsExamples.Domain.Services
{
    public interface ILegalAgeService
    {
        int GetLegalAgeForRegion(string region);
    }
}
