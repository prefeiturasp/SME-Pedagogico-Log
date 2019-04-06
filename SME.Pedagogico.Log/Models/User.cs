using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME.Pedagogico.Log.Models
{
    public class User
    {
        #region ==================== ATTRIBUTES ====================
        public string UserId { get; set; }
        public string Username { get; set; }

        public virtual List<Entry> EntryList { get; set; } = new List<Entry>();
        #endregion ==================== ATTRIBUTES ====================



        #region ==================== CONSTRUCTORS ====================
        #endregion ==================== CONSTRUCTORS ====================



        #region ==================== METHODS ====================
        #endregion ==================== METHODS ====================
    }
}
