//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Category
    {
        public T_Category()
        {
            this.T_Url = new HashSet<T_Url>();
        }
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
    
        public virtual ICollection<T_Url> T_Url { get; set; }
    }
}
