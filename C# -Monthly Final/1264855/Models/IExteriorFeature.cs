﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1264855.Models
{
    public interface IExteriorFeature
    {
        void AddFeature(string[] feature);
        string GetFeature();
    }
}
