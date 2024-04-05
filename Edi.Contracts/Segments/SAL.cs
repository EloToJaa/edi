using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// Identification of a remuneration type.
/// </summary>
[EdiSegment, EdiPath("SAL")]
public class SAL
{
	/// <summary>
	/// Identification of the type of a remuneration.
	/// </summary>
	[EdiPath("SAL/0")]
	public SAL_RemunerationTypeIdentification? RemunerationTypeIdentification { get; set; }
}

/// <summary>
/// Identification of the type of a remuneration.
/// </summary>
[EdiElement]
public class SAL_RemunerationTypeIdentification
{
	/// <summary>
	/// Remuneration type in coded form.
	/// </summary>
	[EdiValue("X(3)", Path = "SAL/*/0")]
	public RemunerationTypeCoded? RemunerationTypeCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "SAL/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "SAL/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Name of remuneration type as free text.
	/// </summary>
	[EdiValue("X(35)", Path = "SAL/*/3")]
	public string? RemunerationType1 { get; set; }

	/// <summary>
	/// Name of remuneration type as free text.
	/// </summary>
	[EdiValue("X(35)", Path = "SAL/*/4")]
	public string? RemunerationType2 { get; set; }
}