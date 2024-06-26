using System.Collections.Generic;
using Edi.Contracts.Interfaces;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Text subject qualifier
/// </summary>
public class TextSubjectQualifier : IQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator TextSubjectQualifier(string s) => new TextSubjectQualifier { Code = s };

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
		{ "AAA", "Goods description" },
		{ "AAB", "Terms of payments" },
		{ "AAC", "Dangerous goods additional information" },
		{ "AAD", "Dangerous goods, technical name" },
		{ "AAE", "Acknowledgement description" },
		{ "AAF", "Rate additional information" },
		{ "AAG", "Party instructions" },
		{ "AAH", "Customs information" },
		{ "AAI", "General information" },
		{ "AAJ", "Additional conditions of sale/purchase" },
		{ "AAK", "Price conditions" },
		{ "AAL", "Goods dimensions in characters" },
		{ "AAM", "Equipment re-usage restrictions" },
		{ "AAN", "Handling restriction" },
		{ "AAO", "Error description (free text)" },
		{ "AAP", "Response (free text)" },
		{ "AAQ", "Package content's description" },
		{ "AAR", "Terms of delivery" },
		{ "AAS", "Bill of lading remarks" },
		{ "AAT", "Mode of settlement information" },
		{ "AAU", "Consignment invoice information" },
		{ "AAV", "Clearance invoice information" },
		{ "AAW", "Letter of credit information" },
		{ "AAX", "License information" },
		{ "AAY", "Certification statements" },
		{ "AAZ", "Additional export information" },
		{ "ABA", "Tariff statements" },
		{ "ABC", "Conditions of sale or purchase" },
		{ "ABD", "Nature of transaction" },
		{ "ABE", "Additional terms and/or conditions (documentary credit)" },
		{ "ABF", "Instructions or information about standby documentary credit" },
		{ "ABG", "Instructions or information about partial shipment(s)" },
		{ "ABH", "Instructions or information about transhipment(s)" },
		{ "ABI", "Additional handling instructions documentary credit" },
		{ "ABJ", "Domestic routing information" },
		{ "ABK", "Chargeable category of equipment" },
		{ "ABL", "Government information" },
		{ "ABM", "Onward routing information" },
		{ "ABN", "Accounting information" },
		{ "ABO", "Discrepancy information" },
		{ "ABP", "Confirmation instructions" },
		{ "ABQ", "Method of issuance" },
		{ "ABR", "Documents delivery instructions" },
		{ "ABS", "Additional conditions" },
		{ "ABT", "Information/instructions about additional amounts covered" },
		{ "ABU", "Deferred payment termed additional" },
		{ "ABV", "Acceptance terms additional" },
		{ "ABW", "Negotiation terms additional" },
		{ "ABX", "Document name and documentary requirements" },
		{ "ABY", "Regulatory information" },
		{ "ABZ", "Instructions/information about revolving documentary credit" },
		{ "ACA", "Documentary requirements" },
		{ "ACB", "Additional information" },
		{ "ACC", "Factor assignment clause" },
		{ "ACD", "Reason" },
		{ "ACE", "Dispute" },
		{ "ACF", "Additional attribute information" },
		{ "ACG", "Absence declaration" },
		{ "ACH", "Aggregation statement" },
		{ "ACI", "Compilation statement" },
		{ "ACJ", "Definitional exception" },
		{ "ACK", "Privacy statement" },
		{ "ACL", "Quality statement" },
		{ "ACM", "Statistical description" },
		{ "ACN", "Statistical definition" },
		{ "ACO", "Statistical name" },
		{ "ACP", "Statistical title" },
		{ "ACQ", "Off-dimension information" },
		{ "ACR", "Unexpected stops information" },
		{ "ACS", "Principles" },
		{ "ACT", "Terms and definition" },
		{ "ACU", "Segment name" },
		{ "ACV", "Simple data element name" },
		{ "ACW", "Scope" },
		{ "ACX", "Message type name" },
		{ "ACY", "Introduction" },
		{ "ACZ", "Glossary" },
		{ "ADA", "Functional definition" },
		{ "ADB", "Examples" },
		{ "ADC", "Cover page" },
		{ "ADE", "Code value name" },
		{ "ADF", "Code list name" },
		{ "ADG", "Clarification of usage" },
		{ "ADH", "Composite data element name" },
		{ "ADI", "Field of application" },
		{ "ADJ", "Type of assets and liabilities" },
		{ "ADK", "Promotion information" },
		{ "ADL", "Meter condition" },
		{ "ADM", "Meter reading information" },
		{ "ADN", "Type of transaction reason" },
		{ "ADO", "Type of survey question" },
		{ "ADP", "Carrier's agent counter information" },
		{ "ADQ", "Description of work item on equipment" },
		{ "ADR", "Message definition" },
		{ "ADS", "Booked item information" },
		{ "ADT", "Source of document" },
		{ "ADU", "Note" },
		{ "ADV", "Fixed part of segment clarification text" },
		{ "ADW", "Characteristics of goods" },
		{ "ADX", "Additional discharge instructions" },
		{ "ADY", "Container stripping instructions" },
		{ "ADZ", "CSC (Container Safety Convention) plate information" },
		{ "AEA", "Cargo remarks" },
		{ "AEB", "Temperature control instructions" },
		{ "AEC", "Text refers to expected data" },
		{ "AED", "Text refers to received data" },
		{ "AEE", "Section clarification text" },
		{ "ALC", "Allowance/charge information" },
		{ "ALL", "All documents" },
		{ "ARR", "Arrival conditions" },
		{ "AUT", "Authentication" },
		{ "BLC", "Bill of lading clause" },
		{ "BLR", "Transport document remarks" },
		{ "CCI", "Customs clearance instructions" },
		{ "CEX", "Customs clearance instructions export" },
		{ "CHG", "Change information" },
		{ "CIP", "Customs clearance instruction import" },
		{ "CLP", "Clearance place requested" },
		{ "CLR", "Loading remarks" },
		{ "COI", "Order information" },
		{ "CUR", "Customer remarks" },
		{ "CUS", "Customs declaration information" },
		{ "DAR", "Damage remarks" },
		{ "DCL", "Declaration" },
		{ "DEL", "Delivery information" },
		{ "DIN", "Delivery instructions" },
		{ "DOC", "Documentation instructions" },
		{ "DUT", "Duty declaration" },
		{ "EUR", "Effective used routing" },
		{ "FBC", "First block to be printed on the transport contract" },
		{ "GBL", "Government bill of lading information" },
		{ "GEN", "Entire transaction set" },
		{ "GS7", "Further information concerning GGVS par. 7" },
		{ "HAN", "Handling instructions" },
		{ "HAZ", "Hazard information" },
		{ "ICN", "Information for consignee" },
		{ "IIN", "Insurance instructions" },
		{ "IMI", "Invoice mailing instructions" },
		{ "IND", "Commercial invoice item description" },
		{ "INS", "Insurance information" },
		{ "INV", "Invoice instruction" },
		{ "IRP", "Information for railway purpose" },
		{ "ITR", "Inland transport details" },
		{ "ITS", "Testing instructions" },
		{ "LIN", "Line item" },
		{ "LOI", "Loading instruction" },
		{ "MCO", "Miscellaneous charge order" },
		{ "MKS", "Additional marks/numbers information" },
		{ "ORI", "Order instruction" },
		{ "OSI", "Other service information" },
		{ "PAC", "Packing/marking information" },
		{ "PAI", "Payment instructions information" },
		{ "PAY", "Payables information" },
		{ "PKG", "Packaging information" },
		{ "PKT", "Packaging terms information" },
		{ "PMD", "Payment detail/remittance information" },
		{ "PMT", "Payment information" },
		{ "PRD", "Product information" },
		{ "PRF", "Price calculation formula" },
		{ "PRI", "Priority information" },
		{ "PUR", "Purchasing information" },
		{ "QIN", "Quarantine instructions" },
		{ "QQD", "Quality demands/requirements" },
		{ "QUT", "Quotation instruction/information" },
		{ "RAH", "Risk and handling information" },
		{ "REG", "Regulatory information" },
		{ "RET", "Return to origin information" },
		{ "REV", "Receivables" },
		{ "RQR", "Requested routes/routing instructions" },
		{ "RQT", "Tariffs and route requested" },
		{ "SAF", "Safety information" },
		{ "SIC", "Sender's instruction to carrier" },
		{ "SIN", "Special instructions" },
		{ "SLR", "Ship line requested" },
		{ "SPA", "Special permission for transport, generally" },
		{ "SPG", "Special permission concerning the goods to be transported" },
		{ "SPH", "Special handling" },
		{ "SPP", "Special permission concerning package" },
		{ "SPT", "Special permission concerning transport means" },
		{ "SRN", "Subsidiary risk number (IATA/DGR)" },
		{ "SSR", "Special service request" },
		{ "SUR", "Supplier remarks" },
		{ "TCA", "Tariff and class applied" },
		{ "TDT", "Transport details remarks" },
		{ "TRA", "Transportation information" },
		{ "TRR", "Requested tariff" },
		{ "TXD", "Tax declaration" },
		{ "WHI", "Warehouse instruction/information" },
		{ "ZZZ", "Mutually defined" },
	};
}