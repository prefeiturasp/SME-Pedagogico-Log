using System.Collections.Generic;

namespace SME.Pedagogico.Log.Models
{
    public class Application : Abstracts.Entity
    {
        #region ==================== ATTRIBUTES ====================

        public string DigitalSignature { get; set; } = null;

        public virtual List<Entry> EntryList { get; set; } = new List<Entry>();

        #endregion ==================== ATTRIBUTES ====================
    }
}