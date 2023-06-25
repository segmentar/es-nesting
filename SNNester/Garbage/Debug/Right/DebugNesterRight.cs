using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNester
    {
        public static void Debug_NesterRight(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, SGText text_DYNAMIC, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SNNester) + ' ' + "::" + ' ' + nameof(Debug_NesterRight) + ' ' + '{',
                        String.Empty + '~' + "01" + ' ' + nameof(symbol_LEFT) + ':' + ' ' + ". . .",
                        String.Empty + '~' + "02" + ' ' + nameof(symbol_RIGHT) + ':' + ' ' + ". . .",
                        String.Empty + '~' + "03" + ' ' + nameof(delimiter_LEFT) + ':' + ' ' + ". . .",
                        String.Empty + '~' + "04" + ' ' + nameof(delimiter_RIGHT) + ':' + ' ' + ". . .",
                        String.Empty + '~' + "05" + ' ' + nameof(text_STATIC) + ':' + ' ' + ". . .",
                        String.Empty + '~' + "06" + ' ' + nameof(text_DYNAMIC) + ':' + ' ' + ". . .",
                        String.Empty + '~' + "07" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(symbol_LEFT) + ':',
                        String.Empty + symbol_LEFT,
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + nameof(symbol_RIGHT) + ':',
                        String.Empty + symbol_RIGHT,
                        String.Empty,
                        String.Empty + '~' + "30" + ' ' + nameof(delimiter_LEFT) + ':',
                        String.Empty + delimiter_LEFT,
                        String.Empty,
                        String.Empty + '~' + "40" + ' ' + nameof(delimiter_RIGHT) + ':',
                        String.Empty + delimiter_RIGHT,
                        String.Empty,
                        String.Empty + '~' + "50" + ' ' + nameof(text_STATIC) + ':',
                        String.Empty + text_STATIC,
                        String.Empty,
                        String.Empty + '~' + "60" + ' ' + nameof(text_DYNAMIC) + ':',
                        String.Empty + text_DYNAMIC,
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
