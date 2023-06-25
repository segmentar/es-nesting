using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
        
    public partial class SNNest
    {
        public static SNNest MakeNestNew(SNNester parent, SNNester child, List<SNNester> chainList, Boolean debug)
        {
            SNNest nestResult = default;

            nestResult = new SNNest(parent, child, chainList, debug);

            return nestResult;
        }
    }
}
