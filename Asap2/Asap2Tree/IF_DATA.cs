using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class IF_DATA : Asap2Base
    {
        public IF_DATA(Location location, string name) : base(location)
        {
            this.name = name;
        }

        public IF_DATA(Location location, string name, decimal xcpPlusAmlStructureVersion) : base(location)
        {
            this.name = name;
            this.xcpPlusAmlStructureVersion = xcpPlusAmlStructureVersion;
        }

        public string name { get; private set; }

        [Element(1)]
        public SEGMENT segment;

        [Element(2, IsArgument = false)]
        public PROTOCOL_LAYER protocol_layer { get; set; }
        [Element(3, IsArgument = false, Name = "CAL_PARAM_GROUP", Comment = "CAL_PARAM_GROUP for IF_DATA")]
        public List<CAL_PARAM_GROUP> cal_param_group = new List<CAL_PARAM_GROUP>();

        [Element(3, IsArgument = false, Name = "DAQ", Comment = "DAQ for IF_DATA")]
        public DAQ daq { get; set; }
        [Element(4, IsArgument = false, Name = "PAG", Comment = "PAG for IF_DATA")]
        public PAG pag { get; set; }
        [Element(5, IsArgument = false, Name = "PGM", Comment = "PGM for IF_DATA")]
        public PGM pgm { get; set; }
        [Element(6, IsArgument = false, Name = "XCP_ON_CAN", Comment = "XCP_ON_CAN for IF_DATA")]
        public XCP_ON_CAN xcp_on_can { get; set; }

        [Element(7, IsArgument = false, Name = "DAQ_EVENT", Comment = "XCP_ON_CAN for IF_DATA")]
        public DAQ_EVENT daq_event { get; set; }

        [Element(8, IsArgument = false, Name = "TP_BLOB", Comment = "TP_BLOB for IF_DATA")]
        public TP_BLOB tp_blob { get; set; }

        [Element(9, IsArgument = false, Name = "SOURCE", Comment = "SOURCE for IF_DATA")]
        public List<SOURCE> source = new List<SOURCE>();
        [Element(10, IsArgument = false, Name = "RASTER", Comment = "RASTER for IF_DATA")]
        public List<RASTER> raster = new List<RASTER>();

        [Element(11, IsArgument = false, Name = "RASTER", Comment = "RASTER for IF_DATA")]
        public SEED_KEY seed_key { get; set; }
        [Element(12, IsArgument = false, Name = "RASTER", Comment = "KP_BLOB for IF_DATA")]
        public KP_BLOB kp_blob { get; set; }

        [Element(13, IsArgument = true, Name = "XCP_PLUS_AML_STRUCTURE_VERSION")]
        public decimal xcpPlusAmlStructureVersion { get; private set; }


    }
}
