﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent.models.Nodes
{
    public abstract class Node
    {
        public abstract float[] Compute(float[] inputs);
    }
}
