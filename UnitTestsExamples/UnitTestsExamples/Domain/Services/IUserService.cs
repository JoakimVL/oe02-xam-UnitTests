using System;
using System.Collections.Generic;
using System.Text;
using UnitTestsExamples.Domain.Models;

namespace UnitTestsExamples.Domain.Services
{
    public interface IUserService
    {

        // returns true if user < 18
        bool IsUnderage(User user);

        //checks name
        string GetName(User user);
    }
}

