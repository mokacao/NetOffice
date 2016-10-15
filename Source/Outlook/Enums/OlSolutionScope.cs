using System;
using NetOffice;
namespace NetOffice.OutlookApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Outlook 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869771.aspx </remarks>
	[SupportByVersionAttribute("Outlook", 14,15,16)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum OlSolutionScope
	{
		 /// <summary>
		 /// SupportByVersion Outlook 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Outlook", 14,15,16)]
		 olHideInDefaultModules = 0,

		 /// <summary>
		 /// SupportByVersion Outlook 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Outlook", 14,15,16)]
		 olShowInDefaultModules = 1
	}
}