//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sadecefikirler.Models
{
    using System;
    
    public partial class SP_GetProject_Result
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public byte[] Picture { get; set; }
    }
}