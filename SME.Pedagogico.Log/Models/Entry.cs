using System;

namespace SME.Pedagogico.Log.Models
{
    public class Entry : Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================

        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; } = null;

        public virtual Action Action { get; set; }
        public virtual Application Application { get; set; }
        public virtual Connection Connection { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual User User { get; set; }

        #endregion ==================== ATTRIBUTES ====================
    }
}