/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcColourRgb : IfcColourSpecification 
	{
		public IfcColourRgb(Double red,
				Boolean redSpecified,
				Double green,
				Boolean greenSpecified,
				Double blue,
				Boolean blueSpecified,
				String name,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(name,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.redField = red;
			this.redSpecifiedField = redSpecified;
			this.greenField = green;
			this.greenSpecifiedField = greenSpecified;
			this.blueField = blue;
			this.blueSpecifiedField = blueSpecified;
		}
	}
}