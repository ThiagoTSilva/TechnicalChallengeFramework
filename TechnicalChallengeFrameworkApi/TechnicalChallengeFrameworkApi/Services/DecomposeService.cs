using System;
using System.Threading.Tasks;
using TechnicalChallengeFrameworkApi.Services.Interfaces;
using TechnicalChallengeFrameworkApi.Domain;
using System.Linq;

namespace TechnicalChallengeFrameworkApi.Services
{
    public class DecomposeService : IDecomposeService
    {
        public NumberResult KnowNumberDivisor(float number)
        {
            var numberResult = new NumberResult();
            

            for(float x = 1; x <= number; x++)
            {
                float aux = number / x;

                if(aux % 1 == 0)
                {
                    var dividerNumbers = new DividerNumbers
                    {
                        Dividers = x
                    };
                    numberResult.DividerNumbers.Add(dividerNumbers);
                }
            }


            foreach(var dividers in numberResult.DividerNumbers.Select(c => c.Dividers))
            {
                if (IsNumeroPrimo(dividers) == true || dividers == 1)
                {
                    var primeDividers = new PrimeDividers
                    {
                        Primes = dividers
                    };

                    numberResult.PrimeDividers.Add(primeDividers);
                }
            }


          return numberResult;

        }

        static bool IsNumeroPrimo(float number)
        {
            bool bPrimo = true;
            float factor = number / 2;

            for (int i = 2; i <= factor; i++)
            {
                if ((number % i) == 0)
                    bPrimo = false;
            }
            return bPrimo;
        }

    }
}
