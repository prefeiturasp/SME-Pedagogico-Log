using System.Collections.Generic;

namespace SME.Pedagogico.Log.Models
{
    public class Action : Abstracts.Entity
    {
        #region ==================== ATTRIBUTES ====================

        public string Description { get; set; } = null;

        public virtual List<Entry> EntryList { get; set; } = new List<Entry>();

        #endregion ==================== ATTRIBUTES ====================
    }
}