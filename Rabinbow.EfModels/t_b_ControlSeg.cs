//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rabinbow.EfModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_b_ControlSeg
    {
        public int f_ControlSegID { get; set; }
        public string f_ControlSegName { get; set; }
        public Nullable<byte> f_DateControl { get; set; }
        public byte f_Monday { get; set; }
        public byte f_Tuesday { get; set; }
        public byte f_Wednesday { get; set; }
        public byte f_Thursday { get; set; }
        public byte f_Friday { get; set; }
        public byte f_Saturday { get; set; }
        public byte f_Sunday { get; set; }
        public System.DateTime f_BeginHMS1 { get; set; }
        public System.DateTime f_EndHMS1 { get; set; }
        public System.DateTime f_BeginHMS2 { get; set; }
        public System.DateTime f_EndHMS2 { get; set; }
        public System.DateTime f_BeginHMS3 { get; set; }
        public System.DateTime f_EndHMS3 { get; set; }
        public System.DateTime f_BeginYMD { get; set; }
        public System.DateTime f_EndYMD { get; set; }
        public int f_ControlSegIDLinked { get; set; }
        public byte f_ReaderCount { get; set; }
        public int f_LimitedTimesOfDay { get; set; }
        public int f_LimitedTimesOfHMS1 { get; set; }
        public int f_LimitedTimesOfHMS2 { get; set; }
        public int f_LimitedTimesOfHMS3 { get; set; }
        public int f_ControlByHoliday { get; set; }
    }
}