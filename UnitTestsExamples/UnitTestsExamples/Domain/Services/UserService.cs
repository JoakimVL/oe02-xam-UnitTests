using System;
using System.Collections.Generic;
using System.Text;
using UnitTestsExamples.Domain.Models;

namespace UnitTestsExamples.Domain.Services
{
    public class UserService : IUserService
    {
        private ILegalAgeService LegalAgeService;

        public UserService(ILegalAgeService ageService)
        {
            LegalAgeService = ageService;
        }

        public string GetName(User user)
        {
            return user?.Name;
        }

        public bool IsUnderage(User user)
        {
            return user?.Age < LegalAgeService.GetLegalAgeForRegion(user.Region);
        }
    }
}
