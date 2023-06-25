using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNested
    {
        public static SNNested Runtime_MakeNestedBackwardCollider(SGSymbol symbol, SGDelimiter delimiter, SGConditional conditional, SGText text)
        {
            SNNested nestedResult = default;

            nestedResult = MakeNestedBackwardCollider(symbol, delimiter, conditional, text, SAPolicy.NestedDebugPolicy);

            return nestedResult;
        }
    }
}
