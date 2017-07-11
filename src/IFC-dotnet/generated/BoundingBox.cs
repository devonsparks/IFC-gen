/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundingbox.htm
	/// </summary>
	internal  partial class BoundingBox : GeometricRepresentationItem 
	{
		public CartesianPoint Corner {get;set;}

		public Double XDim {get;set;}

		public Double YDim {get;set;}

		public Double ZDim {get;set;}

		public BoundingBox(CartesianPoint corner,
				Double xDim,
				Double yDim,
				Double zDim,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.Corner = corner;
			this.XDim = xDim;
			this.YDim = yDim;
			this.ZDim = zDim;
		}
	}
}