using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To provide details of the function of a monetary amount.
/// </summary>
[EdiSegment, EdiPath("ARD")]
public class ARD
{
	/// <summary>
	/// To identify the function of a related monetary amount.
	/// </summary>
	[EdiPath("ARD/0")]
	public ARD_MonetaryFunction? MonetaryFunction { get; set; }
}

/// <summary>
/// To identify the function of a related monetary amount.
/// </summary>
[EdiElement]
public class ARD_MonetaryFunction
{
	/// <summary>
	/// To specify the function of a related monetary amount.
	/// </summary>
	[EdiValue("X(3)", Path = "ARD/*/0")]
	public MonetaryFunctionCoded? MonetaryFunctionCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "ARD/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "ARD/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}