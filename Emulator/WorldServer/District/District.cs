using System.Net.Sockets;

namespace WorldServer.Districts
{
    public enum DistrictTypes
    {
        SOCIAL = 1,
        FINANCIAL = 2,
        FINANCIAL_ANARCHY = 8, //not supported yet
        FINANCIAL_DYNAMIC = 0, //unknown type ID
        FINANCIAL_OPENCONFLICT = 0, //unknown type ID
        TUTORIAL = 14, 
        WATERFRONT = 21,
        WATERFRONT_ANARCHY = 27, //not supported yet
        WATERFRONT_DYNAMIC = 0, //unknown type ID
        WATERFRONT_OPENCONFLICT = 0, //unknown type ID
        BAYLAN_SHIPPING = 33,
        THE_BEACON = 34,
        ASYLUM = 0 //unknown type ID
    }

    public class District
    {
        public TcpClient tcp
        {
            get;
            set;
        }

        public const ushort SocialLimit = 200;
        public const ushort ActionLimit = 100;

        public District(TcpClient Tcp)
        {
            tcp = Tcp;
        }

        public District(DistrictTypes type, byte id)
        {
            _type = type;
            Type = (byte)type;
            Id = id;
        }

        private DistrictTypes _type;

        public byte Type
        {
            get;
            private set;
        }

        public byte Id;
        public ushort Enforcers = 0, Criminals = 0, Queue = 0, Port;
        public string IP = null;
        public uint Key = 0;

        public byte isFull()
        {
            if (Type == (byte)DistrictTypes.SOCIAL) return Enforcers + Criminals >= SocialLimit ? (byte)1 : (byte)0;
            else return Enforcers + Criminals >= ActionLimit ? (byte)1 : (byte)0;
        }

        public override string ToString()
        {
            string result = "";
            switch (_type)
            {
                default:
                    FrameWork.Logger.Log.Error("District error", "Wrong district type specified, please chose valid one!");
                    break;
                case DistrictTypes.SOCIAL:
                    result += "Social-Breakwater Marina";
                    break;
                case DistrictTypes.TUTORIAL:
                    result += "Tutorial-Financial";
                    break;
                case DistrictTypes.FINANCIAL:
                    result += "Missions-Financial";
                    break;
                case DistrictTypes.WATERFRONT:
                    result += "Missions-Waterfront";
                    break;
            }
            result += "-EN-" + Id.ToString();
            return result;
        }
    }

    public class SocialDistrict : District
    {
        public SocialDistrict(byte id) : base(DistrictTypes.SOCIAL, id)
        { }
    }

    public class TutorialDistrict : District
    {
        public TutorialDistrict(byte id) : base(DistrictTypes.TUTORIAL, id)
        { }
    }

    public class FinancialDistrict : District
    {
        public FinancialDistrict(byte id) : base(DistrictTypes.FINANCIAL, id)
        { }
    }

    public class WaterFrontDistrict : District
    {
        public WaterFrontDistrict(byte id) : base(DistrictTypes.WATERFRONT, id)
        { }
    }
}
