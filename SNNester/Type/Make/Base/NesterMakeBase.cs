using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNester
    {
        public static SNNester MakeNesterBase(SGText text_STATIC, SNNested left, SNNested right, Boolean debug)
        {
            SNNester nesterResult = default;

            Debug_NesterBase(text_STATIC, left, right, debug);

            var safe_ONE__FIRST = false;

            safe_ONE__FIRST = safe_ONE__FIRST || (left == default) is true;

            safe_ONE__FIRST = safe_ONE__FIRST || (right == default) is true;

            if (safe_ONE__FIRST is true)
            {
                return nesterResult;
            }
            else
                "false".ToString();

            var value_LEFT = (left.Position + 1);

            var value_RIGHT = (right.Position - 1);

            goto align_DIFFERENCE;

            align_DIFFERENCE:
            {
                var value_RIGHT__ALIGN_DIFFERENCE = value_RIGHT;

                value_RIGHT__ALIGN_DIFFERENCE = value_RIGHT__ALIGN_DIFFERENCE - value_LEFT;

                value_RIGHT = value_RIGHT__ALIGN_DIFFERENCE;
            }

            goto align_ENO;

            align_ENO:
            {
                var value_RIGHT__ALIGN_ENO = value_RIGHT;

                value_RIGHT__ALIGN_ENO = value_RIGHT__ALIGN_ENO + 1;

                value_RIGHT = value_RIGHT__ALIGN_ENO;
            }

            var symbol = SGSymbol.Runtime_MakeSymbolNew(text_STATIC.Value.Substring(value_LEFT, value_RIGHT));

            var minimum = Math.Min(left.Layer, right.Layer);

            nesterResult = new SNNester(symbol, minimum, left, right, debug);

            return nesterResult;
        }
    }
}
