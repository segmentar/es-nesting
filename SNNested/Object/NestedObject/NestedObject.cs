using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNested
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
                String.Empty + nameof(SNNested) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Symbol) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Position) + ':' + ' ' + Position,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Symbol) + ':',
                String.Empty + Symbol
            });
        }
    }
}
