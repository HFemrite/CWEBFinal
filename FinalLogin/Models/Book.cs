//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalLogin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string CoverType { get; set; }
        public string LastRead { get; set; }
        public int TimesRead { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
