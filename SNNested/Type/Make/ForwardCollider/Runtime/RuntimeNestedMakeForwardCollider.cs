using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNested
    {
        public static SNNested Runtime_MakeNestedForwardCollider(SGSymbol symbol, SGDelimiter delimiter, SGConditional conditional, SGText text)
        {
            SNNested nestedResult = default;

            nestedResult = MakeNestedForwardCollider(symbol, delimiter, conditional, text, SAPolicy.NestedDebugPolicy);

            return nestedResult;
        }
    }
}
