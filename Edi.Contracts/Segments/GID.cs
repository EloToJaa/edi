using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To indicate totals of a goods item.
/// </summary>
[EdiSegment, EdiPath("GID")]
public class GID
{
	/// <summary>
	/// Serial number differentiating each separate goods item entry of a consignment as contained in one document/declaration.
	/// </summary>
	[EdiValue("9(5)", Path = "GID/0")]
	public int? GoodsItemNumber { get; set; }

	/// <summary>
	/// Number and type of individual parts of a shipment.
	/// </summary>
	[EdiPath("GID/1")]
	public GID_NumberAndTypeOfPackages? NumberAndTypeOfPackages1 { get; set; }

	/// <summary>
	/// Number and type of individual parts of a shipment.
	/// </summary>
	[EdiPath("GID/2")]
	public GID_NumberAndTypeOfPackages? NumberAndTypeOfPackages2 { get; set; }

	/// <summary>
	/// Number and type of individual parts of a shipment.
	/// </summary>
	[EdiPath("GID/3")]
	public GID_NumberAndTypeOfPackages? NumberAndTypeOfPackages3 { get; set; }

	/// <summary>
	/// NUMBER AND TYPE OF PACKAGES
	/// </summary>
	[EdiPath("GID/4")]
	public GID_NumberAndTypeOfPackages? NumberAndTypeOfPackages4 { get; set; }

	/// <summary>
	/// NUMBER AND TYPE OF PACKAGES
	/// </summary>
	[EdiPath("GID/5")]
	public GID_NumberAndTypeOfPackages? NumberAndTypeOfPackages5 { get; set; }
}

/// <summary>
/// NUMBER AND TYPE OF PACKAGES
/// </summary>
[EdiElement]
public class GID_NumberAndTypeOfPackages
{
	/// <summary>
	/// Number of packages
	/// </summary>
	[EdiValue("9(8)", Path = "GID/*/0")]
	public int? NumberOfPackages { get; set; }

	/// <summary>
	/// Type of packages identification
	/// </summary>
	[EdiValue("X(17)", Path = "GID/*/1")]
	public string? TypeOfPackagesIdentification { get; set; }

	/// <summary>
	/// Code list qualifier
	/// </summary>
	[EdiValue("X(3)", Path = "GID/*/2")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code list responsible agency, coded
	/// </summary>
	[EdiValue("X(3)", Path = "GID/*/3")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Type of packages
	/// </summary>
	[EdiValue("X(35)", Path = "GID/*/4")]
	public string? TypeOfPackages { get; set; }

	/// <summary>
	/// Packaging related information, coded
	/// </summary>
	[EdiValue("X(3)", Path = "GID/*/5")]
	public PackagingRelatedInformationCoded? PackagingRelatedInformationCoded { get; set; }
}