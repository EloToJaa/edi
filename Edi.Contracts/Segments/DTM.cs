using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify date, and/or time, or period.
/// </summary>
[EdiSegment, EdiPath("DTM")]
public class DTM
{
	/// <summary>
	/// Date and/or time, or period relevant to the specified date/time/period type.
	/// </summary>
	[EdiPath("DTM/0")]
	public DTM_DateTimePeriod? DateTimePeriod { get; set; }
}

/// <summary>
/// Date and/or time, or period relevant to the specified date/time/period type.
/// </summary>
[EdiElement]
public class DTM_DateTimePeriod
{
	/// <summary>
	/// Code giving specific meaning to a date, time or period.
	/// </summary>
	[EdiValue("X(3)", Path = "DTM/*/0")]
	public DateTimePeriodQualifier? DateTimePeriodQualifier { get; set; }

	/// <summary>
	/// The value of a date, a date and time, a time or of a period in a specified representation.
	/// </summary>
	[EdiValue("X(35)", Path = "DTM/*/1")]
	public string? DateTimePeriod { get; set; }

	/// <summary>
	/// Specification of the representation of a date, a date and time or of a period.
	/// </summary>
	[EdiValue("X(3)", Path = "DTM/*/2")]
	public DateTimePeriodFormatQualifier? DateTimePeriodFormatQualifier { get; set; }
}