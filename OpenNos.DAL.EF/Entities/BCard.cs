﻿/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */
 
using static OpenNos.Domain.BCardType;

namespace OpenNos.DAL.EF
{
    public class BCard
    {
        #region Properties

        public short BCardId { get; set; }

        public byte SubType { get; set; }

        public CardType Type { get; set; }

        public int FirstData { get; set; }

        public int SecondData { get; set; }

        public virtual Card Card { get; set; }

        public short CardId { get; set; }

        public bool Delayed { get; set; }


        #endregion
    }
}