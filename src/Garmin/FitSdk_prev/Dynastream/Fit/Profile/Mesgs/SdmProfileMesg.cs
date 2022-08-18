#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Garmin Canada Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2022 Garmin International, Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.67Release
// Tag = production/akw/21.67.00-0-gd790f76b
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the SdmProfile profile message.
    /// </summary>
    public class SdmProfileMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="SdmProfileMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Enabled = 0;
            public const byte SdmAntId = 1;
            public const byte SdmCalFactor = 2;
            public const byte Odometer = 3;
            public const byte SpeedSource = 4;
            public const byte SdmAntIdTransType = 5;
            public const byte OdometerRollover = 7;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public SdmProfileMesg() : base(Profile.GetMesg(MesgNum.SdmProfile))
        {
        }

        public SdmProfileMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            Object val = GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set MessageIndex field</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Enabled field</summary>
        /// <returns>Returns nullable Bool enum representing the Enabled field</returns>
        public Bool? GetEnabled()
        {
            object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set Enabled field</summary>
        /// <param name="enabled_">Nullable field value to be set</param>
        public void SetEnabled(Bool? enabled_)
        {
            SetFieldValue(0, 0, enabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SdmAntId field</summary>
        /// <returns>Returns nullable ushort representing the SdmAntId field</returns>
        public ushort? GetSdmAntId()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToUInt16(val));
            
        }

        /// <summary>
        /// Set SdmAntId field</summary>
        /// <param name="sdmAntId_">Nullable field value to be set</param>
        public void SetSdmAntId(ushort? sdmAntId_)
        {
            SetFieldValue(1, 0, sdmAntId_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SdmCalFactor field
        /// Units: %</summary>
        /// <returns>Returns nullable float representing the SdmCalFactor field</returns>
        public float? GetSdmCalFactor()
        {
            Object val = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set SdmCalFactor field
        /// Units: %</summary>
        /// <param name="sdmCalFactor_">Nullable field value to be set</param>
        public void SetSdmCalFactor(float? sdmCalFactor_)
        {
            SetFieldValue(2, 0, sdmCalFactor_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Odometer field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the Odometer field</returns>
        public float? GetOdometer()
        {
            Object val = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Odometer field
        /// Units: m</summary>
        /// <param name="odometer_">Nullable field value to be set</param>
        public void SetOdometer(float? odometer_)
        {
            SetFieldValue(3, 0, odometer_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SpeedSource field
        /// Comment: Use footpod for speed source instead of GPS</summary>
        /// <returns>Returns nullable Bool enum representing the SpeedSource field</returns>
        public Bool? GetSpeedSource()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set SpeedSource field
        /// Comment: Use footpod for speed source instead of GPS</summary>
        /// <param name="speedSource_">Nullable field value to be set</param>
        public void SetSpeedSource(Bool? speedSource_)
        {
            SetFieldValue(4, 0, speedSource_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SdmAntIdTransType field</summary>
        /// <returns>Returns nullable byte representing the SdmAntIdTransType field</returns>
        public byte? GetSdmAntIdTransType()
        {
            Object val = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set SdmAntIdTransType field</summary>
        /// <param name="sdmAntIdTransType_">Nullable field value to be set</param>
        public void SetSdmAntIdTransType(byte? sdmAntIdTransType_)
        {
            SetFieldValue(5, 0, sdmAntIdTransType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the OdometerRollover field
        /// Comment: Rollover counter that can be used to extend the odometer</summary>
        /// <returns>Returns nullable byte representing the OdometerRollover field</returns>
        public byte? GetOdometerRollover()
        {
            Object val = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToByte(val));
            
        }

        /// <summary>
        /// Set OdometerRollover field
        /// Comment: Rollover counter that can be used to extend the odometer</summary>
        /// <param name="odometerRollover_">Nullable field value to be set</param>
        public void SetOdometerRollover(byte? odometerRollover_)
        {
            SetFieldValue(7, 0, odometerRollover_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
