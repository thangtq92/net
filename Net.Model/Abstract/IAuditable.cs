using System;

namespace Net.Model.Abstract
{
    public class IAuditable
    {
        private DateTime? CreadtedDate { set; get; }
        private string CreatedBy { set; get; }
        private DateTime? UpdatedDate { set; get; }
        private string UpdatedBy { set; get; }

        private string MetaKeyword { set; get; }
        private string MetaDescription { set; get; }

        private bool Status { get; set; }
    }
}