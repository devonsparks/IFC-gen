/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcResourceTime : IfcSchedulingTime 
	{
		public IfcResourceTime(String scheduleWork,
				Double scheduleUsage,
				Boolean scheduleUsageSpecified,
				String scheduleStart,
				String scheduleFinish,
				String scheduleContour,
				String levelingDelay,
				Boolean isOverAllocated,
				Boolean isOverAllocatedSpecified,
				String statusTime,
				String actualWork,
				Double actualUsage,
				Boolean actualUsageSpecified,
				String actualStart,
				String actualFinish,
				String remainingWork,
				Double remainingUsage,
				Boolean remainingUsageSpecified,
				Double completion,
				Boolean completionSpecified,
				String name,
				IfcDataOriginEnum dataOrigin,
				Boolean dataOriginSpecified,
				String userDefinedDataOrigin,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(name,
				dataOrigin,
				dataOriginSpecified,
				userDefinedDataOrigin,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.scheduleWorkField = scheduleWork;
			this.scheduleUsageField = scheduleUsage;
			this.scheduleUsageSpecifiedField = scheduleUsageSpecified;
			this.scheduleStartField = scheduleStart;
			this.scheduleFinishField = scheduleFinish;
			this.scheduleContourField = scheduleContour;
			this.levelingDelayField = levelingDelay;
			this.isOverAllocatedField = isOverAllocated;
			this.isOverAllocatedSpecifiedField = isOverAllocatedSpecified;
			this.statusTimeField = statusTime;
			this.actualWorkField = actualWork;
			this.actualUsageField = actualUsage;
			this.actualUsageSpecifiedField = actualUsageSpecified;
			this.actualStartField = actualStart;
			this.actualFinishField = actualFinish;
			this.remainingWorkField = remainingWork;
			this.remainingUsageField = remainingUsage;
			this.remainingUsageSpecifiedField = remainingUsageSpecified;
			this.completionField = completion;
			this.completionSpecifiedField = completionSpecified;
		}
	}
}