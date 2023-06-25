using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNester
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SNNester) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Symbol) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Minimum) + ':' + ' ' + Minimum,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Left) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Right) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Symbol) + ':',
                String.Empty + Symbol,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Left) + ':',
                String.Empty + Left,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(Right) + ':',
                String.Empty + Right
            });
        }
    }
}
