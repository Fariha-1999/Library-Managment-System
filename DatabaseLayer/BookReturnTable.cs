//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookReturnTable
    {
        public int BookReturnID { get; set; }
        public int BookID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime IssueDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public System.DateTime CurrentDate { get; set; }
        public int UserID { get; set; }
    
        public virtual BookTable BookTable { get; set; }
        public virtual EmployeeTable EmployeeTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
