using System.Collections.Generic;

namespace SME.Pedagogico.Log.Models
{
    public class Permission : Abstracts.Entity
    {
        #region ==================== ATTRIBUTES ====================

        public virtual List<Entry> EntryList { get; set; } = new List<Entry>();

        #endregion ==================== ATTRIBUTES ====================
    }
}