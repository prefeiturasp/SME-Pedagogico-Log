using System.Collections.Generic;

namespace SME.Pedagogico.Log.Models
{
    public class Connection : Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================

        public string IP { get; set; } = "0.0.0.0";
        public string MachineName { get; set; } = null;

        public virtual List<Entry> EntryList { get; set; } = new List<Entry>();

        #endregion ==================== ATTRIBUTES ====================
    }
}