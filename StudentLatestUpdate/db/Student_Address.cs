//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentLatestUpdate.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Address
    {
        public int Address_id { get; set; }
        public string Address { get; set; }
        public int Address_student_id { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
