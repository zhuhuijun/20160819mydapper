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
    
    public partial class WatchingLog
    {
        public int ID { get; set; }
        public string DoorID { get; set; }
        public string DoorNo { get; set; }
        public string DoorName { get; set; }
        public string CardNo { get; set; }
        public string UserName { get; set; }
        public string UnitName { get; set; }
        public Nullable<System.DateTime> ReadDate { get; set; }
        public string Status { get; set; }
        public string InOutFlag { get; set; }
    }
}