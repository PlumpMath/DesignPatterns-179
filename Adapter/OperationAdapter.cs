﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class OperationAdapter : IOperator
    {
        public LegacyOperator legacyOperator = new LegacyOperator();

        public IOperator Operation()
        {
           legacyOperator.Operation();
            return this;
        }
    }
}
