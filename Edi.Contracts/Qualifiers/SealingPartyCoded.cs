using System.Collections.Generic;
using Edi.Contracts.Interfaces;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Sealing party, coded
/// </summary>
public class SealingPartyCoded : IQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator SealingPartyCoded(string s) => new SealingPartyCoded { Code = s };

	/// <summary>
	/// Code of the value
	/// </summary>
	public string? Code { get; set; }

	/// <summary>
	/// Value converted from code
	/// </summary>
	public string? Value => Code is null ? null : (Qualifiers.ContainsKey(Code) ? Qualifiers[Code] : null);

	/// <summary>
	/// All possible values
	/// </summary>
	[JsonIgnore]
	public Dictionary<string, string> Qualifiers => new Dictionary<string, string>
	{
		{ "AA", "Consolidator" },
		{ "AB", "Unknown" },
		{ "CA", "Carrier" },
		{ "CU", "Customs" },
		{ "SH", "Shipper" },
		{ "TO", "Terminal operator" },
	};
}