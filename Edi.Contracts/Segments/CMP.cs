using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a composite data element and to give its class and maintenance operation.
/// </summary>
[EdiSegment, EdiPath("CMP")]
public class CMP : ISegment
{
	/// <summary>
	/// Tag of a composite data element.
	/// </summary>
	[EdiValue("X(4)", Path = "CMP/0", Mandatory = true)]
	public string? CompositeDataElementTag { get; set; }

	/// <summary>
	/// To identify a designated class.
	/// </summary>
	[EdiValue("X(3)", Path = "CMP/1", Mandatory = false)]
	public ClassDesignatorCoded? ClassDesignatorCoded { get; set; }

	/// <summary>
	/// To indicate the type of data maintenance operation for an object, such as add, delete, replace.
	/// </summary>
	[EdiValue("X(3)", Path = "CMP/2", Mandatory = false)]
	public MaintenanceOperationCoded? MaintenanceOperationCoded { get; set; }

}