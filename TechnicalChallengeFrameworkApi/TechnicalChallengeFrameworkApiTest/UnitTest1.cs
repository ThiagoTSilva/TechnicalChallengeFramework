using System;
using Xunit;
using TechnicalChallengeFrameworkApi.Services;
using TechnicalChallengeFrameworkApi.Services.Interfaces;
using System.Collections.Generic;

namespace TechnicalChallengeFrameworkApiTest
{
    public class UnitTest1
    {
        private readonly IDecomposeService service;

        public UnitTest1(IDecomposeService service)
        {
            this.service = service;
        }

        [Fact]
        public void Test1()
        {
           var listDividers = new string[] {"1,3,5,9,15,45"};
            var list = new List<string>();
           var response = service.KnowNumberDivisor(45);

            foreach(var itens in response.DividerNumbers)
            {
                list.Add(itens.Dividers.ToString());
            }

            Assert.Equal(listDividers, list);
        }
    }
}
