using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify the number of units.
/// </summary>
[EdiSegment, EdiPath("EQN")]
public class EQN : ISegment
{
	/// <summary>
	/// Identification of number of units and its purpose.
	/// </summary>
	[EdiPath("EQN/0")]
	public EQN_NumberOfUnitDetails? NumberOfUnitDetails { get; set; }
}

/// <summary>
/// Identification of number of units and its purpose.
/// </summary>
[EdiElement]
public class EQN_NumberOfUnitDetails : IElement
{
	/// <summary>
	/// Number of units of a certain type.
	/// </summary>
	[EdiValue("9(15)", Path = "EQN/*/0", Mandatory = false)]
	public decimal? NumberOfUnits { get; set; }

	/// <summary>
	/// Indication of the objective of number of units information.
	/// </summary>
	[EdiValue("X(3)", Path = "EQN/*/1", Mandatory = false)]
	public NumberOfUnitsQualifier? NumberOfUnitsQualifier { get; set; }
}