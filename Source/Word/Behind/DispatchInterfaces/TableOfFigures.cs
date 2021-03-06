﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.WordApi;

namespace NetOffice.WordApi.Behind
{
	/// <summary>
	/// DispatchInterface TableOfFigures 
	/// SupportByVersion Word, 9,10,11,12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845310.aspx </remarks>
	[SupportByVersion("Word", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class TableOfFigures : COMObject, NetOffice.WordApi.TableOfFigures
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.WordApi.TableOfFigures);
                return _contractType;
            }
        }
        private static Type _contractType;


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

        private static Type _type;
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(TableOfFigures);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public TableOfFigures() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837721.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual NetOffice.WordApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.Application>(this, "Application", typeof(NetOffice.WordApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837901.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual Int32 Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195906.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197475.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual string Caption
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Caption");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Caption", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836752.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual bool IncludeLabel
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "IncludeLabel");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "IncludeLabel", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845415.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual bool RightAlignPageNumbers
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "RightAlignPageNumbers");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RightAlignPageNumbers", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840513.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual bool UseHeadingStyles
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "UseHeadingStyles");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "UseHeadingStyles", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195933.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual Int32 LowerHeadingLevel
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "LowerHeadingLevel");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "LowerHeadingLevel", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837676.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual Int32 UpperHeadingLevel
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "UpperHeadingLevel");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "UpperHeadingLevel", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838302.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual bool IncludePageNumbers
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "IncludePageNumbers");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "IncludePageNumbers", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196830.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual NetOffice.WordApi.Range Range
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.Range>(this, "Range", typeof(NetOffice.WordApi.Range));
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff191925.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual bool UseFields
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "UseFields");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "UseFields", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837175.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual string TableID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TableID");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TableID", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838729.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual NetOffice.WordApi.HeadingStyles HeadingStyles
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.HeadingStyles>(this, "HeadingStyles", typeof(NetOffice.WordApi.HeadingStyles));
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838101.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual NetOffice.WordApi.Enums.WdTabLeader TabLeader
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.WordApi.Enums.WdTabLeader>(this, "TabLeader");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "TabLeader", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197199.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual bool UseHyperlinks
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "UseHyperlinks");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "UseHyperlinks", value);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192747.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual bool HidePageNumbersInWeb
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "HidePageNumbersInWeb");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "HidePageNumbersInWeb", value);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838319.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual void Delete()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838896.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual void UpdatePageNumbers()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "UpdatePageNumbers");
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837320.aspx </remarks>
		[SupportByVersion("Word", 9,10,11,12,14,15,16)]
		public virtual void Update()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Update");
		}

		#endregion

		#pragma warning restore
	}
}


