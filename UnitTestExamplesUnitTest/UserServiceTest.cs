using Moq;
using System;
using UnitTestsExamples.Domain.Models;
using UnitTestsExamples.Domain.Services;
using Xunit;

namespace UnitTestExamplesUnitTest
{
    public class UserServiceTest
    {
        private User[] testUser;

        public UserServiceTest()
        {
            testUser = TestData.TestUser;
        }
        
        //Age: If younger than 18 don't give access.
        [Fact]
        public void IsUnderAge_Returns_True_When_AgeLowerThan18()
        {
            //arrange
            User underAgeUser = testUser[0]; //our test user (Busta Rhymes) is underage in the USA
            bool expectedResult = true;
            
            var mockLegalService = new Mock<ILegalAgeService>();
            mockLegalService.Setup(repo => repo.GetLegalAgeForRegion(underAgeUser.Region))
                            .Returns(21);

            UserService userService = new UserService(mockLegalService.Object);            

            //act
            bool isUnderAgeUser = userService.IsUnderage(underAgeUser);

            //assert
            Assert.Equal(expectedResult, isUnderAgeUser);
        }
    }
}
