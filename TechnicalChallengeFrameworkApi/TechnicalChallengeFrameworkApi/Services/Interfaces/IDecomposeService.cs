using System;
using System.Threading.Tasks;
using TechnicalChallengeFrameworkApi.Domain;

namespace TechnicalChallengeFrameworkApi.Services.Interfaces
{
    public interface IDecomposeService
    {
        NumberResult KnowNumberDivisor(float number);
    }
}
