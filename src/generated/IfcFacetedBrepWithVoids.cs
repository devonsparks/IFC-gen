/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcFacetedBrepWithVoids : IfcFacetedBrep 
	{
		public IfcFacetedBrepWithVoids(IfcFacetedBrepWithVoidsVoids voids,
				IfcClosedShell outer,
				IfcStyledItem styledByItem,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(outer,
				styledByItem,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.voidsField = voids;
		}
	}
}