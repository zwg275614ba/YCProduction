using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YCProduction.Model.Entitys.Base
{
    public class BaseCustomerInfo : PrimaryKey<int>
    {
        [DisplayName("客户Id")]
        public string CustomerId { get; set; }
        [DisplayName("客户公司")]
        public string CustomerCompany { get; set; }
        [DisplayName("法人代表")]
        public string LegalPerson{get;set;}
        [DisplayName("联系人")]
        public string Contact { get; set; }
        [DisplayName("职务")]
        public string Position { get; set; }
        [DisplayName("联系电话")]
        public string Phone { get; set; }
        [DisplayName("联系地址")]
        public string Address { get; set; }
        [DisplayName("开户银行")]
        public string Bank { get; set; }
        [DisplayName("开户账号")]
        public string OpenAccount { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}
