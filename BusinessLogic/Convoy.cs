﻿namespace BusinessLogic
{
    using System.Collections.Generic;

    using Data;

    public class Convoy
    {
        #region Properties
        public Locomotive Locomotive { get; internal set; }
        public List<AbstractWagon> WagonList { get; internal set; }
        #endregion

        #region Constructor
        public Convoy(string locomotiveInfo)
        {
            this.Locomotive = new Locomotive(locomotiveInfo);
        }
        #endregion
    }
}
