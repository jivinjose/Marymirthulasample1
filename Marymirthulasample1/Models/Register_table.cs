//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marymirthulasample1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Register_table
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string address { get; set; }
        public string datex { get; set; }
        public string dateofbirth { get; set; }
    
        public virtual Register_table Register_table1 { get; set; }
        public virtual Register_table Register_table2 { get; set; }
    }
}
