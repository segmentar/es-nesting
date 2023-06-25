using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNester
    {
        public static void Debug_NesterBase(SGText text_STATIC, SNNested left, SNNested right, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SNNester) + ' ' + "::" + ' ' + nameof(Debug_NesterBase) + ' ' + '{',
                        String.Empty + '.' + "debug",
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(text_STATIC) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(left) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(right) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(text_STATIC) + ':',
                        String.Empty + text_STATIC,
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + nameof(left) + ':',
                        String.Empty + left,
                        String.Empty,
                        String.Empty + '~' + "30" + ' ' + nameof(right) + ':',
                        String.Empty + right,
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
