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
    
    public partial class S_SMSContent1
    {
        public S_SMSContent1()
        {
            this.S_SMSRecord_Current = new HashSet<S_SMSRecord_Current1>();
            this.S_SMSRecord_History = new HashSet<S_SMSRecord_History1>();
        }
    
        public int ID { get; set; }
        public int UID { get; set; }
        public string SMSContent { get; set; }
        public string msgId { get; set; }
        public System.DateTime SendDateTime { get; set; }
        public bool isDel { get; set; }
        public int SMID { get; set; }
        public string BlackList { get; set; }
        public int ResultCode { get; set; }
        public int smsCount { get; set; }
    
        public virtual S_SMSMission1 S_SMSMission { get; set; }
        public virtual UserInfo1 UserInfo { get; set; }
        public virtual ICollection<S_SMSRecord_Current1> S_SMSRecord_Current { get; set; }
        public virtual ICollection<S_SMSRecord_History1> S_SMSRecord_History { get; set; }
    }
}
