using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SNNest
    {
        public static SNNest Runtime_MakeNestNew(SNNester parent, SNNester child, List<SNNester> chainList)
        {
            SNNest nestResult = default;

            nestResult = MakeNestNew(parent, child, chainList, SAPolicy.NestDebugPolicy);

            return nestResult;
        }
    }
}
