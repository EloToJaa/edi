using System.Collections.Generic;
using Edi.Contracts.Interfaces;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// First/last sequence message transfer indication
/// </summary>
public class FirstLastSequenceMessageTransferIndication : IQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator FirstLastSequenceMessageTransferIndication(string s) => new FirstLastSequenceMessageTransferIndication { Code = s };

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
		{ "C", "Creation" },
		{ "F", "Final" },
	};
}