﻿using System;

namespace OrigoDB.Core.Models
{
    [Serializable]
    public class GeoLocation
    {
        public readonly string Name;
        public readonly LatLon Point;

        public GeoLocation(string name, LatLon point)
        {
            Point = point;
            Name = name;
        }
    }
}
