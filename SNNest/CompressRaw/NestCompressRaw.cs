using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SNNest
    {
        public SNNester Parent;

        public SNNester Child;

        public List<SNNester> ChainList;
    }
}
