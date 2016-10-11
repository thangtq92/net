using System;

namespace Net.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreadtedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { get; set; }
    }
}