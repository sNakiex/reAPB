using FrameWork.NetWork;

namespace LobbyServer.TCP.Packets
{
    static public class LOGIN_PUZZLE
    {
        static public void Send(LobbyClient client)
        {
            PacketOut Out = new PacketOut((uint)Opcodes.LOGIN_PUZZLE);

            //05.05.2019 : version 1.19.7.806251 -> change the numbers below in order to change support for latest game version
            Out.WriteInt32Reverse(1);
            Out.WriteInt32Reverse(19);
            Out.WriteInt32Reverse(7);
            Out.WriteInt32Reverse(806251);

            Out.WriteByte(0x05);
            for (int i = 0; i < client.ECrypt.Key.Length; i++) Out.WriteByte(client.ECrypt.Key[i]);
            Out.WriteUInt32Reverse(0);
            Out.WriteUInt32Reverse(0);
            Out.WriteUInt32Reverse(0);
            client.SendTCP(Out);
        }
    }
}
