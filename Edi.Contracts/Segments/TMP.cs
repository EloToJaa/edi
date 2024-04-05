using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify the temperature setting.
/// </summary>
[EdiSegment, EdiPath("TMP")]
public class TMP
{
	/// <summary>
	/// A code giving specific meaning to the temperature.
	/// </summary>
	[EdiValue("X(3)", Path = "TMP/0")]
	public TemperatureQualifier? TemperatureQualifier { get; set; }

	/// <summary>
	/// The temperature under which the goods are (to be) stored or shipped.
	/// </summary>
	[EdiPath("TMP/1")]
	public TMP_TemperatureSetting? TemperatureSetting { get; set; }
}

/// <summary>
/// The temperature under which the goods are (to be) stored or shipped.
/// </summary>
[EdiElement]
public class TMP_TemperatureSetting
{
	/// <summary>
	/// The actual temperature value in degrees Celsius (e.g. 008, 020).
	/// </summary>
	[EdiValue("9(3)", Path = "TMP/*/0")]
	public int? TemperatureSetting { get; set; }

	/// <summary>
	/// Indication of the unit of measurement in which weight (mass), capacity, length, area, volume or other quantity is expressed.
	/// </summary>
	[EdiValue("X(3)", Path = "TMP/*/1")]
	public string? MeasureUnitQualifier { get; set; }
}