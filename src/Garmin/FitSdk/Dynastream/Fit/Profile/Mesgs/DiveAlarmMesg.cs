#region Copyright
///////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Garmin International, Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2022 Garmin International, Inc.
///////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.84Release
// Tag = production/akw/21.84.00-0-g894a113c
///////////////////////////////////////////////////////////////////////////////////

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
    /// Implements the DiveAlarm profile message.
    /// </summary>
    public class DiveAlarmMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="DiveAlarmMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte MessageIndex = 254;
            public const byte Depth = 0;
            public const byte Time = 1;
            public const byte Enabled = 2;
            public const byte AlarmType = 3;
            public const byte Sound = 4;
            public const byte DiveTypes = 5;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public DiveAlarmMesg() : base(Profile.GetMesg(MesgNum.DiveAlarm))
        {
        }

        public DiveAlarmMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field
        /// Comment: Index of the alarm</summary>
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
        /// Set MessageIndex field
        /// Comment: Index of the alarm</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Depth field
        /// Units: m</summary>
        /// <returns>Returns nullable float representing the Depth field</returns>
        public float? GetDepth()
        {
            Object val = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToSingle(val));
            
        }

        /// <summary>
        /// Set Depth field
        /// Units: m</summary>
        /// <param name="depth_">Nullable field value to be set</param>
        public void SetDepth(float? depth_)
        {
            SetFieldValue(0, 0, depth_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Time field
        /// Units: s</summary>
        /// <returns>Returns nullable int representing the Time field</returns>
        public int? GetTime()
        {
            Object val = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            if(val == null)
            {
                return null;
            }

            return (Convert.ToInt32(val));
            
        }

        /// <summary>
        /// Set Time field
        /// Units: s</summary>
        /// <param name="time_">Nullable field value to be set</param>
        public void SetTime(int? time_)
        {
            SetFieldValue(1, 0, time_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Enabled field</summary>
        /// <returns>Returns nullable Bool enum representing the Enabled field</returns>
        public Bool? GetEnabled()
        {
            object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            Bool? value = obj == null ? (Bool?)null : (Bool)obj;
            return value;
        }

        /// <summary>
        /// Set Enabled field</summary>
        /// <param name="enabled_">Nullable field value to be set</param>
        public void SetEnabled(Bool? enabled_)
        {
            SetFieldValue(2, 0, enabled_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the AlarmType field</summary>
        /// <returns>Returns nullable DiveAlarmType enum representing the AlarmType field</returns>
        public DiveAlarmType? GetAlarmType()
        {
            object obj = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            DiveAlarmType? value = obj == null ? (DiveAlarmType?)null : (DiveAlarmType)obj;
            return value;
        }

        /// <summary>
        /// Set AlarmType field</summary>
        /// <param name="alarmType_">Nullable field value to be set</param>
        public void SetAlarmType(DiveAlarmType? alarmType_)
        {
            SetFieldValue(3, 0, alarmType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Sound field</summary>
        /// <returns>Returns nullable Tone enum representing the Sound field</returns>
        public Tone? GetSound()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            Tone? value = obj == null ? (Tone?)null : (Tone)obj;
            return value;
        }

        /// <summary>
        /// Set Sound field</summary>
        /// <param name="sound_">Nullable field value to be set</param>
        public void SetSound(Tone? sound_)
        {
            SetFieldValue(4, 0, sound_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field DiveTypes</returns>
        public int GetNumDiveTypes()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the DiveTypes field</summary>
        /// <param name="index">0 based index of DiveTypes element to retrieve</param>
        /// <returns>Returns nullable SubSport enum representing the DiveTypes field</returns>
        public SubSport? GetDiveTypes(int index)
        {
            object obj = GetFieldValue(5, index, Fit.SubfieldIndexMainField);
            SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
            return value;
        }

        /// <summary>
        /// Set DiveTypes field</summary>
        /// <param name="index">0 based index of dive_types</param>
        /// <param name="diveTypes_">Nullable field value to be set</param>
        public void SetDiveTypes(int index, SubSport? diveTypes_)
        {
            SetFieldValue(5, index, diveTypes_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
