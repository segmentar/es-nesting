using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNester
    {
        public static SNNester Runtime_MakeNesterLeft(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, SGText text_DYNAMIC)
        {
            SNNester nesterResult = default;

            nesterResult = MakeNesterLeft(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, text_DYNAMIC, SAPolicy.NesterDebugPolicy);

            return nesterResult;
        }
    }
}
