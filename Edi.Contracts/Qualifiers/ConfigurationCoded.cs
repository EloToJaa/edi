using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Configuration, coded
/// </summary>
public class ConfigurationCoded
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator ConfigurationCoded(string s) => new ConfigurationCoded { Code = s };

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
		{ "A", "Added to the configuration" },
		{ "D", "Deleted from the configuration" },
		{ "I", "Included in the configuration" },
	};
}