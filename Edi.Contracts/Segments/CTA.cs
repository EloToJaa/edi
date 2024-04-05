using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a person or a department to whom communication should be directed.
/// </summary>
[EdiSegment, EdiPath("CTA")]
public class CTA
{
	/// <summary>
	/// Code specifying the function of a contact (e.g. department or person).
	/// </summary>
	[EdiValue("X(3)", Path = "CTA/0")]
	public ContactFunctionCoded? ContactFunctionCoded { get; set; }

	/// <summary>
	/// Code and/or name of a department or employee. Code preferred.
	/// </summary>
	[EdiPath("CTA/1")]
	public CTA_DepartmentOrEmployeeDetails? DepartmentOrEmployeeDetails { get; set; }
}

/// <summary>
/// Code and/or name of a department or employee. Code preferred.
/// </summary>
[EdiElement]
public class CTA_DepartmentOrEmployeeDetails
{
	/// <summary>
	/// Internal identification code.
	/// </summary>
	[EdiValue("X(17)", Path = "CTA/*/0")]
	public string? DepartmentOrEmployeeIdentification { get; set; }

	/// <summary>
	/// The department or person within an organizational entity.
	/// </summary>
	[EdiValue("X(35)", Path = "CTA/*/1")]
	public string? DepartmentOrEmployee { get; set; }
}