﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;

namespace OpenNos.GameObject.Packets.ClientPackets
{
    [PacketHeader(":")]
    public class FamilyChatPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0, serializeToEnd: true)]
        public string Message { get; set; }

        #endregion
    }
}