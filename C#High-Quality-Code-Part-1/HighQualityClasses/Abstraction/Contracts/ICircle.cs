﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Contracts
{
    public interface ICircle : IFigure
    {
        double Radius { get; set; }
    }
}
