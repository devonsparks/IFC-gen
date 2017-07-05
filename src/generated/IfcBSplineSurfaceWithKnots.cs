/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcBSplineSurfaceWithKnots : IfcBSplineSurface 
	{
		public IfcBSplineSurfaceWithKnots(Int64[] uMultiplicities,
				Int64[] vMultiplicities,
				Double[] uKnots,
				Double[] vKnots,
				IfcKnotType knotSpec,
				Boolean knotSpecSpecified,
				IfcBSplineSurfaceControlPointsList controlPointsList,
				Int64 uDegree,
				Boolean uDegreeSpecified,
				Int64 vDegree,
				Boolean vDegreeSpecified,
				IfcBSplineSurfaceForm surfaceForm,
				Boolean surfaceFormSpecified,
				IfcLogical uClosed,
				Boolean uClosedSpecified,
				IfcLogical vClosed,
				Boolean vClosedSpecified,
				IfcLogical selfIntersect,
				Boolean selfIntersectSpecified,
				IfcStyledItem styledByItem,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(controlPointsList,
				uDegree,
				uDegreeSpecified,
				vDegree,
				vDegreeSpecified,
				surfaceForm,
				surfaceFormSpecified,
				uClosed,
				uClosedSpecified,
				vClosed,
				vClosedSpecified,
				selfIntersect,
				selfIntersectSpecified,
				styledByItem,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.uMultiplicitiesField = uMultiplicities;
			this.vMultiplicitiesField = vMultiplicities;
			this.uKnotsField = uKnots;
			this.vKnotsField = vKnots;
			this.knotSpecField = knotSpec;
			this.knotSpecSpecifiedField = knotSpecSpecified;
		}
	}
}