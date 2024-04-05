using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify summary information relating to the document/message.
/// </summary>
[EdiSegment, EdiPath("DMS")]
public class DMS
{
	/// <summary>
	/// Reference number assigned to the document/message by the issuer.
	/// </summary>
	[EdiValue("X(35)", Path = "DMS/0")]
	public string? DocumentMessageNumber { get; set; }

	/// <summary>
	/// Document/message identifier expressed in code.
	/// </summary>
	[EdiValue("X(3)", Path = "DMS/1")]
	public DocumentMessageNameCoded? DocumentMessageNameCoded { get; set; }

	/// <summary>
	/// Total number of items, having separate goods descriptions.
	/// </summary>
	[EdiValue("9(15)", Path = "DMS/2")]
	public int? TotalNumberOfItems { get; set; }

}