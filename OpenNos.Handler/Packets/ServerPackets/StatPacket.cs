﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenNos.Domain;

namespace OpenNos.Handler
{
    [Header("stat")]
    class StatPacket : PacketBase

    {
        #region Properties

        [PacketIndex(0)]
        public int CurrentHp { get; set; }

        [PacketIndex(1)]
        public int MaxHp { get; set; }

        [PacketIndex(2)]
        public short CurrentMp { get; set; }

        [PacketIndex(3)]
        public short MaxMp { get; set; }

        [PacketIndex(4)]
        public byte Unknow { get; set; }

        [PacketIndex(5)]
        public short Unknow1 { get; set; }

        #endregion
    }

}