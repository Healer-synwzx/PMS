//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class S_SMSRecord_History1
    {
        public int SRID { get; set; }
        public int SCID { get; set; }
        public int PID { get; set; }
        public int StatusCode { get; set; }
        public string DescContent { get; set; }
    
        public virtual P_PersonInfo1 P_PersonInfo { get; set; }
        public virtual S_SMSContent1 S_SMSContent { get; set; }
    }
}
