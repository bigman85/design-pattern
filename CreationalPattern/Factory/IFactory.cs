﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    internal interface IFactory
    {
        public IProduct CreateProduct();
    }
}
