﻿/*
 * Copyright (C) 2012-2018 CypherCore <http://github.com/CypherCore>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Game.DataStorage
{
    public sealed class UnitPowerBarRecord
    {
        public uint Id;
        public float RegenerationPeace;
        public float RegenerationCombat;
        public uint[] FileDataID = new uint[6];
        public uint[] Color = new uint[6];
        public LocalizedString Name;
        public LocalizedString Cost;
        public LocalizedString OutOfError;
        public LocalizedString ToolTip;
        public float StartInset;
        public float EndInset;
        public ushort StartPower;
        public ushort Flags;
        public byte CenterPower;
        public byte BarType;
        public uint MinPower;
        public uint MaxPower;
    }
}
