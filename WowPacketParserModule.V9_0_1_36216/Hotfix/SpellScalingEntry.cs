using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.SpellScaling, HasIndexInData = false)]
    public class SpellScalingEntry
    {
        public int SpellID { get; set; }
        public int Class { get; set; }
        public uint MinScalingLevel { get; set; }
        public uint MaxScalingLevel { get; set; }
        public short ScalesFromItemLevel { get; set; }
    }
}
