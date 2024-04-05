using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify the instructions for payment.
/// </summary>
[EdiSegment, EdiPath("PAI")]
public class PAI
{
	/// <summary>
	/// Indication of method of payment employed or to be employed.
	/// </summary>
	[EdiPath("PAI/0")]
	public PAI_PaymentInstructionDetails? PaymentInstructionDetails { get; set; }
}

/// <summary>
/// Indication of method of payment employed or to be employed.
/// </summary>
[EdiElement]
public class PAI_PaymentInstructionDetails
{
	/// <summary>
	/// Identification of the method employed or to be employed in order that a payment may be made or regarded as made. The method may or may not be tied to a guarantee.
	/// </summary>
	[EdiValue("X(3)", Path = "PAI/*/0")]
	public PaymentConditionsCoded? PaymentConditionsCoded { get; set; }

	/// <summary>
	/// Identification of the means of guarantee.
	/// </summary>
	[EdiValue("X(3)", Path = "PAI/*/1")]
	public PaymentGuaranteeCoded? PaymentGuaranteeCoded { get; set; }

	/// <summary>
	/// Indication of the instrument of payment, which may include a guarantee.
	/// </summary>
	[EdiValue("X(3)", Path = "PAI/*/2")]
	public PaymentMeansCoded? PaymentMeansCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PAI/*/3")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PAI/*/4")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Identification of the channel of payment.
	/// </summary>
	[EdiValue("X(3)", Path = "PAI/*/5")]
	public PaymentChannelCoded? PaymentChannelCoded { get; set; }
}