﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VBIDEApi.Behind
{
    /// <summary>
    /// CoClass LinkedWindows
    /// SupportByVersion VBIDE, 12,14,5.3
    /// </summary>
    [SupportByVersion("VBIDE", 12, 14, 5.3)]
    [EntityType(EntityType.IsCoClass)]
    public class LinkedWindows : NetOffice.VBIDEApi.Behind._LinkedWindows, NetOffice.VBIDEApi.LinkedWindows
    {
        #pragma warning disable

        #region Fields

        private static Type _type;

        #endregion

        #region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(LinkedWindows);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not intended to use
        /// </summary>
        public LinkedWindows() : base()
        {

        }

        #endregion

        #region Static CoClass Methods
        #endregion

        #region Events

        #endregion

        #pragma warning restore
    }
}
