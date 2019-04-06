using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME.Pedagogico.Log.Models
{
    public class Permission : Abstracts.Entity
    {
        #region ==================== ATTRIBUTES ====================
        public virtual List<Entry> EntryList { get; set; } = new List<Entry>();
        #endregion ==================== ATTRIBUTES ====================



        #region ==================== CONSTRUCTORS ====================
        #endregion ==================== CONSTRUCTORS ====================



        #region ==================== METHODS ====================
        #endregion ==================== METHODS ====================
    }
}
