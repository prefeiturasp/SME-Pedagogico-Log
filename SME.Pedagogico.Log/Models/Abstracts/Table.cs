using System;

namespace SME.Pedagogico.Log.Models.Abstracts
{
    public class Table
    {
        #region ==================== ATTRIBUTES ====================

        public string Id { get; set; } = null;

        #endregion ==================== ATTRIBUTES ====================



        #region ==================== METHODS ====================

        public virtual void NewId()
        {
            Id = Guid.NewGuid().ToString();
        }

        #endregion ==================== METHODS ====================
    }
}