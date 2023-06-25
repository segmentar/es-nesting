using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SNNest
    {
        public SNNest(SNNester parent, SNNester child, List<SNNester> chainList, Boolean debug)
        {
            this.Parent = parent;

            this.Child = child;

            this.ChainList = chainList;

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
