using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify an account and a related financial institution.
/// </summary>
[EdiSegment, EdiPath("FII")]
public class FII
{
	/// <summary>
	/// Code giving specific meaning to a party.
	/// </summary>
	[EdiValue("X(3)", Path = "FII/0")]
	public PartyQualifier? PartyQualifier { get; set; }

	/// <summary>
	/// Identification of an account holder by account number and/or account holder name in one or two lines. Number preferred.
	/// </summary>
	[EdiPath("FII/1")]
	public FII_AccountIdentification? AccountIdentification { get; set; }

	/// <summary>
	/// Identification of a financial institution by code branch number, or name and name of place. Code or branch number preferred.
	/// </summary>
	[EdiPath("FII/2")]
	public FII_InstitutionIdentification? InstitutionIdentification { get; set; }

	/// <summary>
	/// Identification of the name of a country or other geographical entity as specified in ISO 3166.
	/// </summary>
	[EdiValue("X(3)", Path = "FII/3")]
	public string? CountryCoded { get; set; }

}

/// <summary>
/// Identification of an account holder by account number and/or account holder name in one or two lines. Number preferred.
/// </summary>
[EdiElement]
public class FII_AccountIdentification
{
	/// <summary>
	/// Account number of the holder of the account.
	/// </summary>
	[EdiValue("X(35)", Path = "FII/*/0")]
	public string? AccountHolderNumber { get; set; }

	/// <summary>
	/// Name of the holder of the account.
	/// </summary>
	[EdiValue("X(35)", Path = "FII/*/1")]
	public string? AccountHolderName1 { get; set; }

	/// <summary>
	/// Name of the holder of the account.
	/// </summary>
	[EdiValue("X(35)", Path = "FII/*/2")]
	public string? AccountHolderName2 { get; set; }

	/// <summary>
	/// Identification of the name or symbol of the monetary unit involved in the transaction.
	/// </summary>
	[EdiValue("X(3)", Path = "FII/*/3")]
	public string? CurrencyCoded { get; set; }
}

/// <summary>
/// Identification of a financial institution by code branch number, or name and name of place. Code or branch number preferred.
/// </summary>
[EdiElement]
public class FII_InstitutionIdentification
{
	/// <summary>
	/// Code identifying an institution.
	/// </summary>
	[EdiValue("X(11)", Path = "FII/*/0")]
	public string? InstitutionNameIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "FII/*/1")]
	public CodeListQualifier? CodeListQualifier1 { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "FII/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded1 { get; set; }

	/// <summary>
	/// Number identifying a branch of an institution.
	/// </summary>
	[EdiValue("X(17)", Path = "FII/*/3")]
	public string? InstitutionBranchNumber { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "FII/*/4")]
	public CodeListQualifier? CodeListQualifier2 { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "FII/*/5")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded2 { get; set; }

	/// <summary>
	/// Name of an institution.
	/// </summary>
	[EdiValue("X(70)", Path = "FII/*/6")]
	public string? InstitutionName { get; set; }

	/// <summary>
	/// Official name of the place where the institution branch is situated.
	/// </summary>
	[EdiValue("X(70)", Path = "FII/*/7")]
	public string? InstitutionBranchPlace { get; set; }
}