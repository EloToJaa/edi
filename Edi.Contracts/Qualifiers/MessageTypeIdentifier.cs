using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Message type identifier
/// </summary>
public class MessageTypeIdentifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator MessageTypeIdentifier(string s) => new MessageTypeIdentifier { Code = s };

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
		{ "APERAK", "Application error and acknowledgement message" },
		{ "AUTACK", "Secure authentication and acknowledgement message" },
		{ "AUTHOR", "Authorization message" },
		{ "BANSTA", "Banking status message" },
		{ "BAPLIE", "Bayplan/stowage plan occupied and empty locations message" },
		{ "BAPLTE", "Bayplan/stowage plan total numbers message" },
		{ "BOPBNK", "Bank transactions and portfolio transactions report message" },
		{ "BOPCUS", "Balance of payment customer transaction report message" },
		{ "BOPDIR", "Direct balance of payment declaration message" },
		{ "BOPINF", "Balance of payment information from customer message" },
		{ "CALINF", "Vessel call information message" },
		{ "CASINT", "Request for legal administration action in civil proceedings message" },
		{ "CASRES", "Legal administration response in civil proceedings message" },
		{ "COARRI", "Container discharge/loading report message" },
		{ "CODECO", "Container gate-in/gate-out report message" },
		{ "CODENO", "Permit expiration/clearance ready notice message" },
		{ "COEDOR", "Container stock report message" },
		{ "COHAOR", "Container special handling order message" },
		{ "COMDIS", "Commercial dispute message" },
		{ "CONAPW", "Advice on pending works message" },
		{ "CONDPV", "Direct payment valuation message" },
		{ "CONDRA", "Drawing administration message" },
		{ "CONDRO", "Drawing organisation message" },
		{ "CONEST", "Establishment of contract message" },
		{ "CONITT", "Invitation to tender message" },
		{ "CONPVA", "Payment valuation message" },
		{ "CONQVA", "Quantity valuation message" },
		{ "CONRPW", "Response of pending works message" },
		{ "CONTEN", "Tender message" },
		{ "CONTRL", "Syntax and service report message" },
		{ "CONWQD", "Work item quantity determination message" },
		{ "COPARN", "Container announcement message" },
		{ "COPINO", "Container pre-notification message" },
		{ "COPRAR", "Container discharge/loading order message" },
		{ "COREOR", "Container release order message" },
		{ "COSTCO", "Container stuffing/stripping confirmation message" },
		{ "COSTOR", "Container stuffing/stripping order message" },
		{ "CREADV", "Credit advice message" },
		{ "CREEXT", "Extended credit advice message" },
		{ "CREMUL", "Multiple credit advice message" },
		{ "CUSCAR", "Customs cargo report message" },
		{ "CUSDEC", "Customs declaration message" },
		{ "CUSEXP", "Customs express consignment declaration message" },
		{ "CUSREP", "Customs conveyance report message" },
		{ "CUSRES", "Customs response message" },
		{ "DEBADV", "Debit advice message" },
		{ "DEBMUL", "Multiple debit advice message" },
		{ "DELFOR", "Delivery schedule message" },
		{ "DELJIT", "Delivery just in time message" },
		{ "DESADV", "Despatch advice message" },
		{ "DESTIM", "Equipment damage and repair estimate message" },
		{ "DGRECA", "Dangerous goods recapitulation message" },
		{ "DIRDEB", "Direct debit message" },
		{ "DIRDEF", "Directory definition message" },
		{ "DOCADV", "Documentary credit advice message" },
		{ "DOCAMA", "Advice of an amendment of a documentary credit message" },
		{ "DOCAMI", "Documentary credit amendment information message" },
		{ "DOCAMR", "Request for an amendment of a documentary credit message" },
		{ "DOCAPP", "Documentary credit application message" },
		{ "DOCARE", "Response to an amendment of a documentary credit message" },
		{ "DOCINF", "Documentary credit issuance information message" },
		{ "FINCAN", "Financial cancellation message" },
		{ "FINSTA", "Financial statement of an account message" },
		{ "GENRAL", "General purpose message" },
		{ "GESMES", "Generic statistical message" },
		{ "HANMOV", "Cargo/goods handling and movement message" },
		{ "IFCSUM", "Forwarding and consolidation summary message" },
		{ "IFTCCA", "Forwarding and transport shipment charge calculation message" },
		{ "IFTDGN", "Dangerous goods notification message" },
		{ "IFTFCC", "International transport freight costs and other charges message" },
		{ "IFTIAG", "Dangerous cargo list message" },
		{ "IFTMAN", "Arrival notice message" },
		{ "IFTMBC", "Booking confirmation message" },
		{ "IFTMBF", "Firm booking message" },
		{ "IFTMBP", "Provisional booking message" },
		{ "IFTMCS", "Instruction contract status message" },
		{ "IFTMIN", "Instruction message" },
		{ "IFTRIN", "Forwarding and transport rate information message" },
		{ "IFTSAI", "Forwarding and transport schedule and availability information message" },
		{ "IFTSTA", "International multimodal status report message" },
		{ "IFTSTQ", "International multimodal status request message" },
		{ "INSPRE", "Insurance premium message" },
		{ "INVOIC", "Invoice message" },
		{ "INVRPT", "Inventory report message" },
		{ "ITRRPT", "In transit report detail message" },
		{ "JAPRES", "Job application result message" },
		{ "JINFDE", "Job information demand message" },
		{ "JOBAPP", "Job application proposal message" },
		{ "JOBCON", "Job order confirmation message" },
		{ "JOBMOD", "Job order modification message" },
		{ "JOBOFF", "Job order message" },
		{ "MEDPID", "Person identification message" },
		{ "MEDREQ", "Medical service request message" },
		{ "MEDRPT", "Medical service report message" },
		{ "MEQPOS", "Means of transport and equipment position message" },
		{ "MOVINS", "Stowage instruction message" },
		{ "MSCONS", "Metered services consumption report message" },
		{ "ORDCHG", "Purchase order change request message" },
		{ "ORDERS", "Purchase order message" },
		{ "ORDRSP", "Purchase order response message" },
		{ "OSTENQ", "Order status enquiry message" },
		{ "OSTRPT", "Order status report message" },
		{ "PARTIN", "Party information message" },
		{ "PAXLST", "Passenger list message" },
		{ "PAYDUC", "Payroll deductions advice message" },
		{ "PAYEXT", "Extended payment order message" },
		{ "PAYMUL", "Multiple payment order message" },
		{ "PAYORD", "Payment order message" },
		{ "PRICAT", "Price/sales catalogue message" },
		{ "PRODAT", "Product data message" },
		{ "PRODEX", "Product exchange reconciliation message" },
		{ "PROINQ", "Product inquiry message" },
		{ "PRPAID", "Insurance premium payment message" },
		{ "QALITY", "Quality data message" },
		{ "QUOTES", "Quote message" },
		{ "RDRMES", "Raw data reporting message" },
		{ "REBORD", "Reinsurance bordereau message" },
		{ "RECADV", "Receiving advice message" },
		{ "RECALC", "Reinsurance calculation message" },
		{ "RECECO", "Credit risk cover message" },
		{ "RECLAM", "Reinsurance claims message" },
		{ "REMADV", "Remittance advice message" },
		{ "REPREM", "Reinsurance premium message" },
		{ "REQDOC", "Request for document message" },
		{ "REQOTE", "Request for quote message" },
		{ "RESETT", "Reinsurance settlement message" },
		{ "RESMSG", "Reservation message" },
		{ "RETACC", "Reinsurance technical account message" },
		{ "SAFHAZ", "Safety and hazard data message" },
		{ "SANCRT", "International movement of goods governmental regulatory message" },
		{ "SLSFCT", "Sales forecast message" },
		{ "SLSRPT", "Sales data report message" },
		{ "SSIMOD", "Modification of identity details message" },
		{ "SSRECH", "Worker's insurance history message" },
		{ "SSREGW", "Notification of registration of a worker message" },
		{ "STATAC", "Statement of account message" },
		{ "SUPCOT", "Superannuation contributions advice message" },
		{ "SUPMAN", "Superannuation maintenance message" },
		{ "SUPRES", "Supplier response message" },
		{ "TANSTA", "Tank status report message" },
		{ "VATDEC", "Value added tax message" },
		{ "VESDEP", "Vessel departure message" },
		{ "WASDIS", "Waste disposal information message" },
		{ "WKGRDC", "Work grant decision message" },
		{ "WKGRRE", "Work grant request message" },
	};
}