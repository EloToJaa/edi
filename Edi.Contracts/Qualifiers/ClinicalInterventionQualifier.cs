using System.Collections.Generic;
using Edi.Contracts.Interfaces;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Clinical intervention qualifier
/// </summary>
public class ClinicalInterventionQualifier : IQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator ClinicalInterventionQualifier(string s) => new ClinicalInterventionQualifier { Code = s };

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
		{ "1", "Drug treatment" },
		{ "2", "Surgical procedure" },
	};
}