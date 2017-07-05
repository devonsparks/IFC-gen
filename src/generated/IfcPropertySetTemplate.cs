/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcPropertySetTemplate : IfcPropertyTemplateDefinition 
	{
		public IfcPropertySetTemplate(IfcPropertySetTemplateHasPropertyTemplates hasPropertyTemplates,
				IfcPropertySetTemplateTypeEnum templateType,
				Boolean templateTypeSpecified,
				String applicableEntity,
				IfcOwnerHistory ownerHistory,
				String globalId,
				String name,
				String description,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(ownerHistory,
				globalId,
				name,
				description,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.hasPropertyTemplatesField = hasPropertyTemplates;
			this.templateTypeField = templateType;
			this.templateTypeSpecifiedField = templateTypeSpecified;
			this.applicableEntityField = applicableEntity;
		}
	}
}