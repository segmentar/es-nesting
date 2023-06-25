using Core;

namespace Core.Shared
{
    using System;
        
    public partial class SNNest
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SNNest) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Child) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Parent) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ChainList) + ':' + ' ' + ". . ." + ' ' + $"[{ChainList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Child) + ':',
                String.Empty + Child,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Parent) + ':',
                String.Empty + Parent,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ChainList) + ':',
                String.Empty + String.Join('\n'.ToString(), ChainList),
            });
        }
    }
}
