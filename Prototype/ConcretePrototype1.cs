﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(String id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}
