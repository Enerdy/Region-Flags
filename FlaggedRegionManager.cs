﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI.DB;

namespace RegionFlags
{
    class FlaggedRegionManager
    {
        private Dictionary<string, FlaggedRegion> regions;
        
        public FlaggedRegionManager()
        {
            regions = new Dictionary<string, FlaggedRegion>();
            regions.Add("test", new FlaggedRegion( null ));
        }

        public FlaggedRegion getRegion( string region )
        {
            if( regions.ContainsKey(region))
            {
                return regions[region];
            }

            return null;
        }
    }
}