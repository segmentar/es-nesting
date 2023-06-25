using Core;

namespace Core.Shared
{
    using System;

    public partial class SNNester
    {
        public SNNester(SGSymbol symbol, Int32 minimum, SNNested left, SNNested right, Boolean debug)
        {
            this.Symbol = symbol;

            this.Minimum = minimum;

            this.Left = left;

            this.Right = right;

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
