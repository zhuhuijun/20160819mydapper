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
    
    public partial class t_d_AttendenceData
    {
        public int f_RecID { get; set; }
        public Nullable<int> f_ConsumerID { get; set; }
        public Nullable<System.DateTime> f_AttDate { get; set; }
        public Nullable<System.DateTime> f_Onduty1 { get; set; }
        public string f_Onduty1Desc { get; set; }
        public Nullable<System.DateTime> f_Offduty1 { get; set; }
        public string f_Offduty1Desc { get; set; }
        public Nullable<System.DateTime> f_Onduty2 { get; set; }
        public string f_Onduty2Desc { get; set; }
        public Nullable<System.DateTime> f_Offduty2 { get; set; }
        public string f_Offduty2Desc { get; set; }
        public int f_LateTime { get; set; }
        public int f_LeaveEarlyTime { get; set; }
        public decimal f_OvertimeTime { get; set; }
        public decimal f_AbsenceDay { get; set; }
    }
}
