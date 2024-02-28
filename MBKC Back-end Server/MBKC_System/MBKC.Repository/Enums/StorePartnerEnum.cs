﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBKC.Repository.Enums
{
    public class StorePartnerEnum
    {
        public enum Status
        {
            INACTIVE = 0,
            ACTIVE = 1,
            DISABLE = 2
        }

        public enum KeySort
        {
            DESC,
            ASC,
        }
    }
}
