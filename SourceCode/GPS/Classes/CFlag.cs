﻿using System;

namespace AgOpenGPS
{
    class CFlag
    {
        //WGS84 Lat Long
        public double latitude = 0;
        public double longitude = 0;

        //UTM coordinates
        public double northing = 0;
        public double easting = 0;

        //color of the flag - 0 is red, 1 is green, 2 is purple
        public int color = 0;

        public int ID = 0;

        //constructor
        public CFlag(double _lati, double _longi, double _easting, double _northing, int _color, int _ID)
        {
            latitude = Math.Round(_lati, 7);
            longitude = Math.Round(_longi, 7);
            easting = Math.Round(_easting, 7);
            northing = Math.Round(_northing, 7);
            color = _color;
            ID = _ID;
        }
    }
}
