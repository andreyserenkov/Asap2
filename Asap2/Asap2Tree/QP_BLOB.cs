﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class QP_BLOB : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public QP_BLOB(Location location, decimal daqNumber, string identNum1, UInt64 num1, string identNum2, UInt64 num2, string identNum3, UInt64 num3, string identNum4, UInt64 num4) : base(location)
        {
            IDictionary<string, UInt64> r = new Dictionary<string, UInt64>();
            r[identNum1] = num1;
            r[identNum2] = num2;
            r[identNum3] = num3;
            r[identNum4] = num4;
            this.length = r["LENGTH"];
            this.canIdFixed = r["CAN_ID_FIXED"];
            this.firstPid = r["FIRST_PID"];
            this.raster = r["RASTER"];

            this.daqNumber = daqNumber;
        }

        [Element(1, IsArgument = true)]
        public decimal daqNumber { get; private set; }

        [Element(2, IsArgument = true)]
        public decimal length { get; private set; }

        [Element(3, IsArgument = true)]
        public decimal canIdFixed { get; private set; }
        [Element(4, IsArgument = true)]
        public decimal firstPid { get; private set; }
        [Element(5, IsArgument = true)]
        public decimal raster { get; private set; }

    }
}
