﻿namespace SME.Pedagogico.Log.Models.Abstracts
{
    public class Entity : Table
    {
        #region ==================== ATTRIBUTES ====================

        public string Name { get; set; } = null;
        public string Code { get; set; } = null;

        #endregion ==================== ATTRIBUTES ====================
    }
}