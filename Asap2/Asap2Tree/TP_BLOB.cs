using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asap2
{
    [Base()]
    public class TP_BLOB : Asap2Base
    {
        /// <summary>
        /// Characteristic types 
        /// </summary>

        public TP_BLOB(Location location, UInt64 bypassVersion, UInt64 blobVersion) : base(location)
        {
            this.byPassVersion = bypassVersion;
            this.blobVersion = blobVersion;
        }

        public TP_BLOB(Location location, UInt64 version, string interfaceSpeed, UInt64 resetCfg) : base(location)
        {
            this.version = version;
            this.interfaceSpeed = interfaceSpeed;
            this.resetCfg = resetCfg;
        }

        public TP_BLOB(Location location, UInt64 blobVersion, string kwpVersion, string byteOrderString) : base(location)
        {
            this.blobVersion = blobVersion;
            this.byteOrderString = byteOrderString;
            this.kwpVersion = kwpVersion;
        }

        public TP_BLOB(Location location, UInt64 cppVersion, UInt64 blobVersion, UInt64 canMessageIdTransmit, UInt64 canMessageIdReceive, UInt64 logicalccpAddress, decimal byteOrder, string strNum1, UInt64 num1, string strNum2, UInt64 num2, string strNum3, UInt64 num3, string strNum4, UInt64 num4, string strNum5, UInt64 num5, string strStr1, string str1, string strStr2, string str2, string strStr3, string str3) : base(location)
        {

            IDictionary<string, UInt64> r = new Dictionary<string, UInt64>();
            r[strNum1] = num1;
            r[strNum2] = num2;
            r[strNum3] = num3;
            r[strNum4] = num4;
            r[strNum5] = num5;

            this.baudrate = r["BAUDRATE"];
            this.samplePoint = r["SAMPLE_POINT"];
            this.sampleRate = r["SAMPLE_RATE"];
            this.btlCycles = r["BTL_CYCLES"];
            this.sjw = r["SJW"];

            this.cppVersion = cppVersion;
            this.blobVersion = blobVersion;
            this.canMessageIdTransmit = canMessageIdTransmit;
            this.canMessageIdReceive = canMessageIdReceive;
            this.logicalccpAddress = logicalccpAddress;
            this.byteOrder = byteOrder;
        }

        [Element(1, IsArgument = true, Comment = " Num1           ")]
        public UInt64 byPassVersion { get; private set; }

        [Element(2, IsArgument = true, Comment = "CCP Version, High Byte: Version Low Byte : subversion (dec.)")]
        public UInt64 cppVersion { get; private set; }

        [Element(3, IsArgument = true, Comment = "Blob-Version, High Byte: Version Low Byte : subversion (dec.)")]
        public UInt64 blobVersion { get; private set; }

        [Element(4, IsArgument = true, Comment = "CAN-Message ID for 'Transmitting to ECU (CRM)' Bit31 = 1: extended Identifier Bit31 = 0: standard Identifier")]
        public UInt64 canMessageIdTransmit { get; private set; }

        [Element(5, IsArgument = true, Comment = "CAN-Message ID for 'Receiving from ECU (DTM)' Bit31 = 1: extended Identifier Bit31 = 0: standard Identifier")]
        public UInt64 canMessageIdReceive { get; private set; }

        [Element(6, IsArgument = true, Comment = "Logical CCP-Address of the (station address)")]
        public UInt64 logicalccpAddress { get; private set; }

        [Element(7, IsArgument = true, Comment = " Byte order of Multiple-byte-items 1 = high Byte first, 2 = low byte first")]
        public decimal byteOrder { get; private set; }

        [Element(8, IsArgument = true, Comment = "")]
        public string byteOrderString { get; private set; }

        [Element(9, IsArgument = true, Comment = "Baudrate in Hz")]
        public decimal baudrate { get; private set; }

        [Element(10, IsArgument = true, Comment = "Samplepoint in %")]
        public decimal samplePoint { get; private set; }

        [Element(11, IsArgument = true, Comment = "SampleRate 1 or 3")]
        public decimal sampleRate { get; private set; }

        [Element(12, IsArgument = true, Comment = "BtlCycles")]
        public decimal btlCycles { get; private set; }

        [Element(13, IsArgument = true, Comment = "Sjw")]
        public decimal sjw { get; private set; }

        [Element(14, IsArgument = true, Comment = "Version")]
        public decimal version { get; private set; }
        [Element(15, IsArgument = true, Comment = "interfaceSpeed")]
        public string interfaceSpeed { get; private set; }
        [Element(16, IsArgument = true, Comment = "ResetCfg")]

        public UInt64 resetCfg { get; private set; }

        [Element(16, IsArgument = true, Comment = "kwpVersion")]
        public string kwpVersion { get; private set; }
        public DISTAB_CFG distab_cfg { get; set; }
        public CODE_CHK code_chk { get; set; }
        public ETK_CFG etk_cfg { get; set; }
        public CHECKSUM_PARAM checksum_param { get; set; }
        public K_LINE k_line { get; set; }
        public CAN can { get; set; }
        public RESERVED_DISTAB_MEMORY reserved_distab_memory { get; set; }
        public List<DEFINED_PAGES> defined_pages = new List<DEFINED_PAGES>();
        public List<DIAG_BAUD> diag_baud = new List<DIAG_BAUD>();
        public List<decimal> optional_cmd = new List<decimal>();
        public DATA_ACCESS data_access { get; set; }
        public CHECKSUM checksum { get; set; }
        public COPY copy { get; set; }
        public FLASH flash { get; set; }
        public TIME_DEF time_def { get; set; }
        public PAGE_SWITCH page_switch { get; set; }
    }

}
