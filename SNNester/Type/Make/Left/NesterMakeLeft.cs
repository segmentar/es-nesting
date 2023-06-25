using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNester
    {
        public static SNNester MakeNesterLeft(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, SGText text_DYNAMIC, Boolean debug)
        {
            SNNester nesterResult = default;

            Debug_NesterLeft(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, text_DYNAMIC, debug);

            var nested_LEFT = SNNested.Runtime_MakeNestedBackwardCollider(symbol_RIGHT, delimiter_RIGHT, new ConditionalSimple(SAConstant.ConditionalUnsuccess).Simple, text_DYNAMIC);

            var safe_ONE__FIRST = (nested_LEFT == default) is true;

            if (safe_ONE__FIRST is true)
            {
                return nesterResult;
            }
            else
                "false".ToString();

            var nested_RIGHT = SNNested.Runtime_MakeNestedForwardCollider(symbol_LEFT, delimiter_LEFT, new ConditionalSimple(nested_LEFT.Position).Simple, text_DYNAMIC);

            goto align_SWITCH;

            align_SWITCH:
            {
                var nested_LEFT__SWITCH = nested_RIGHT;

                var nested_RIGHT__SWITCH = nested_LEFT;

                nested_RIGHT = nested_RIGHT__SWITCH;

                nested_LEFT = nested_LEFT__SWITCH;
            }

            nesterResult = MakeNesterBase(text_STATIC, nested_LEFT, nested_RIGHT, debug);

            return nesterResult;
        }
    }
}
