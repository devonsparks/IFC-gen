/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcQuantityTime : IfcPhysicalSimpleQuantity 
	{
		public IfcQuantityTime(Double timeValue,
				Boolean timeValueSpecified,
				String formula,
				IfcNamedUnit unit,
				String name,
				String description,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(unit,
				name,
				description,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.timeValueField = timeValue;
			this.timeValueSpecifiedField = timeValueSpecified;
			this.formulaField = formula;
		}
	}
}