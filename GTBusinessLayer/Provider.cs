﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GTBusinessLayer
{
    public class Provider
    {
        public string Brand { get; private set; }

        public Provider(string brand)
        {
            Brand = brand;
        }
    }
}
