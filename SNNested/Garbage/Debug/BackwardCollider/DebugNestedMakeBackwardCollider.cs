using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNested
    {
        public static void Debug_BackwardCollider(SGSymbol symbol, SGDelimiter delimiter, SGConditional conditional, SGText text, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SNNested) + ' ' + "::" + ' ' + nameof(Debug_BackwardCollider) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(symbol) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(delimiter) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(conditional) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(text) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(symbol) + ':',
                        String.Empty + symbol,
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + nameof(delimiter) + ':',
                        String.Empty + delimiter,
                        String.Empty,
                        String.Empty + '~' + "30" + ' ' + nameof(conditional) + ':',
                        String.Empty + conditional,
                        String.Empty,
                        String.Empty + '~' + "40" + ' ' + nameof(text) + ':',
                        String.Empty + text
                    });

                    Console.Out.WriteLine(message);
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
