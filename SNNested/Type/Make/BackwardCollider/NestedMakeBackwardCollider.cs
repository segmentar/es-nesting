using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNested
    {
        public static SNNested MakeNestedBackwardCollider(SGSymbol symbol, SGDelimiter delimiter, SGConditional conditional, SGText text, Boolean debug)
        {
            SNNested nestedResult = default;

            Debug_BackwardCollider(symbol, delimiter, conditional, text, debug);

            var replace = STWord.Runtime_MakeWordReplaceDefault(delimiter, symbol, text);

            var text_REPLACED = SGText.Runtime_MakeTextNew(replace.WordAfter);

            var layer = 0;

            var move = false;

            var position = (text.Value.Length - 1);

            var temporary = -1;

            do
            {
                var token = STToken.Runtime_MakeTokenNextIndex(symbol, 0, move, position, SAConstantAgreement.QueryBackwardDefault, text_REPLACED);

                if (token.Found is false)
                {
                    break;
                }
                else
                    "false".ToString();

                var safe_ONE__FIRST = true;

                safe_ONE__FIRST = safe_ONE__FIRST && conditional.Condition is true;

                safe_ONE__FIRST = safe_ONE__FIRST && (conditional.Value >= token.Position) is true;

                if (safe_ONE__FIRST is true)
                {
                    break;
                }
                else
                    "false".ToString();

                move = move || true;

                layer = layer + 1;

                position = token.Position;

                temporary = token.Position;

                continue;

            } while (true);

            var check = SGConditional.Runtime_MakeConditionalNew(temporary);

            if (check.Condition is false)
            {
                return nestedResult;
            }
            else
                "false".ToString();

            var sub = text.Value.Substring(check.Value, symbol.Value.Length);

            var symbol_SUB = SGSymbol.Runtime_MakeSymbolNew(sub);

            nestedResult = new SNNested(symbol_SUB, layer, check.Value, debug);

            return nestedResult;
        }
    }
}
