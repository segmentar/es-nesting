using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNested
    {
        public SNNested(SGSymbol symbol, Int32 layer, Int32 position, Boolean debug)
        {
            this.Symbol = symbol;

            this.Layer = layer;

            this.Position = position;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
