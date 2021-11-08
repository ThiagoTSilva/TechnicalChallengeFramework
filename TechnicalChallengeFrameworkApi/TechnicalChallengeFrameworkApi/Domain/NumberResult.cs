using System;
using System.Collections.Generic;

namespace TechnicalChallengeFrameworkApi.Domain
{
    public class NumberResult
    {
        public NumberResult()
        {
            PrimeDividers = new List<PrimeDividers>();
            DividerNumbers = new List<DividerNumbers>();
        }

        public virtual ICollection<PrimeDividers> PrimeDividers { get; set; }
        public virtual ICollection<DividerNumbers> DividerNumbers { get; set; }

    }
}
