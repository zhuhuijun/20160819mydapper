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
    
    public partial class t_b_Consumer
    {
        public int f_ConsumerID { get; set; }
        public string f_ConsumerNO { get; set; }
        public string f_ConsumerName { get; set; }
        public Nullable<long> f_CardNO { get; set; }
        public int f_GroupID { get; set; }
        public byte f_AttendEnabled { get; set; }
        public byte f_ShiftEnabled { get; set; }
        public byte f_DoorEnabled { get; set; }
        public System.DateTime f_BeginYMD { get; set; }
        public System.DateTime f_EndYMD { get; set; }
        public int f_PIN { get; set; }
        public int f_PrivilegeTypeID { get; set; }
    }
}
