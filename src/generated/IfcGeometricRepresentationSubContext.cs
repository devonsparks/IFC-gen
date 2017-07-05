/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcGeometricRepresentationSubContext : IfcGeometricRepresentationSubContexttemp 
	{
		public IfcGeometricRepresentationSubContext(Double targetScale,
				Boolean targetScaleSpecified,
				IfcGeometricProjectionEnum targetView,
				Boolean targetViewSpecified,
				String userDefinedTargetView,
				IfcGeometricRepresentationContextWorldCoordinateSystem worldCoordinateSystem,
				IfcDirection trueNorth,
				IfcGeometricRepresentationContextHasSubContexts hasSubContexts,
				IfcCoordinateOperation hasCoordinateOperation,
				Int64 coordinateSpaceDimension,
				Boolean coordinateSpaceDimensionSpecified,
				Double precision,
				Boolean precisionSpecified,
				String contextIdentifier,
				String contextType,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(worldCoordinateSystem,
				trueNorth,
				hasSubContexts,
				hasCoordinateOperation,
				coordinateSpaceDimension,
				coordinateSpaceDimensionSpecified,
				precision,
				precisionSpecified,
				contextIdentifier,
				contextType,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.targetScaleField = targetScale;
			this.targetScaleSpecifiedField = targetScaleSpecified;
			this.targetViewField = targetView;
			this.targetViewSpecifiedField = targetViewSpecified;
			this.userDefinedTargetViewField = userDefinedTargetView;
		}
	}
}