﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSolution.Interfaces.TrainSolution
{
    public interface IGraphRepository
    {
        void BuildGraph(string filename);
    }
}
