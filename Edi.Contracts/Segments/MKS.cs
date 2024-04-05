using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify to which market and/or through which sales distribution channel and/or for which end-use the sales of product/service have been made or are given as forecast.
/// </summary>
[EdiSegment, EdiPath("MKS")]
public class MKS
{
	/// <summary>
	/// Identification of the subject areas to which the specified conditions apply.
	/// </summary>
	[EdiValue("X(3)", Path = "MKS/0")]
	public SectorSubjectIdentificationQualifier? SectorSubjectIdentificationQualifier { get; set; }

	/// <summary>
	/// Identification of sales channel for marketing data, sales, forecast, planning...
	/// </summary>
	[EdiPath("MKS/1")]
	public MKS_SalesChannelIdentification? SalesChannelIdentification { get; set; }

	/// <summary>
	/// Code specifying the action to be taken or already taken.
	/// </summary>
	[EdiValue("X(3)", Path = "MKS/2")]
	public ActionRequestNotificationCoded? ActionRequestNotificationCoded { get; set; }

}

/// <summary>
/// Identification of sales channel for marketing data, sales, forecast, planning...
/// </summary>
[EdiElement]
public class MKS_SalesChannelIdentification
{
	/// <summary>
	/// Code identifying a sales channel for marketing information.
	/// </summary>
	[EdiValue("X(17)", Path = "MKS/*/0")]
	public string? SalesChannelIdentifier { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "MKS/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "MKS/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}