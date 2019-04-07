using System.Collections.Generic;

namespace SME.Pedagogico.Log.Models
{
    public class User : Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================

        public string UserId { get; set; } = null;
        public string Username { get; set; } = null;

        public virtual List<Entry> EntryList { get; set; } = new List<Entry>();

        #endregion ==================== ATTRIBUTES ====================
    }
}