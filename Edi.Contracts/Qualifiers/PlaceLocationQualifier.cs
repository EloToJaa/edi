using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Place/location qualifier
/// </summary>
public class PlaceLocationQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator PlaceLocationQualifier(string s) => new PlaceLocationQualifier { Code = s };

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
		{ "1", "Place of terms of delivery" },
		{ "2", "Payment place" },
		{ "4", "Goods receipt place" },
		{ "5", "Place of departure" },
		{ "7", "Place of delivery" },
		{ "8", "Place of destination" },
		{ "9", "Place/port of loading" },
		{ "10", "Place of acceptance" },
		{ "11", "Place/port of discharge" },
		{ "12", "Port of discharge" },
		{ "13", "Place of transhipment" },
		{ "14", "Location of goods" },
		{ "15", "Place of transfer responsibility" },
		{ "16", "Place of transfer of ownership" },
		{ "17", "Border crossing place" },
		{ "18", "Warehouse" },
		{ "19", "Factory/plant" },
		{ "20", "Place of ultimate destination of goods" },
		{ "21", "Terms of sale place" },
		{ "22", "Customs office of clearance" },
		{ "23", "Port of release" },
		{ "24", "Port of entry" },
		{ "25", "Country" },
		{ "26", "City" },
		{ "27", "Country of origin" },
		{ "28", "Country of destination of goods" },
		{ "29", "Railway station" },
		{ "30", "Country of source" },
		{ "31", "Building" },
		{ "32", "Beginning of chargeable section" },
		{ "33", "Baseport of discharge" },
		{ "34", "Baseport of loading" },
		{ "35", "Country of exportation/despatch" },
		{ "36", "Country of ultimate destination" },
		{ "37", "Country of last consignment" },
		{ "38", "Country of first destination" },
		{ "39", "Country of production" },
		{ "40", "Country of trading" },
		{ "41", "Customs office of entry" },
		{ "42", "Customs office of exit" },
		{ "43", "Place of Customs examination" },
		{ "44", "Place of authentication of document" },
		{ "45", "Customs office of destination (transit)" },
		{ "46", "Region of despatch" },
		{ "47", "Region of destination" },
		{ "48", "Region of production" },
		{ "49", "Country of transit" },
		{ "50", "Customs office of transit" },
		{ "51", "Country of invalid transit guarantee" },
		{ "52", "Country of destination (transit)" },
		{ "53", "Charge and freight due from" },
		{ "54", "Manufacturing department" },
		{ "55", "Charges and freight payable to" },
		{ "56", "End of chargeable section" },
		{ "57", "Place of payment" },
		{ "58", "Full track loading or unloading" },
		{ "60", "Place of arrival" },
		{ "61", "Next port of call" },
		{ "62", "On-carriage port" },
		{ "64", "First optional place of discharge" },
		{ "65", "Final port or place of discharge" },
		{ "66", "Express railway station" },
		{ "67", "Mixed cargo railway station" },
		{ "68", "Second optional place of discharge" },
		{ "69", "Next non-discharge port of call" },
		{ "70", "Third optional place of discharge" },
		{ "71", "Reconsolidation point" },
		{ "72", "Fourth optional place of discharge" },
		{ "73", "Bill of lading release office" },
		{ "74", "Transhipment excluding this place" },
		{ "75", "Transhipment limited to this place" },
		{ "76", "Original port of loading" },
		{ "77", "First port of call - non-discharging" },
		{ "78", "First port of call - discharging" },
		{ "79", "Place/port of first entry" },
		{ "80", "Place of despatch" },
		{ "81", "Fifth optional place of discharge" },
		{ "82", "Pre-carriage port" },
		{ "83", "Place of delivery (by on carriage)" },
		{ "84", "Transport contract place of acceptance" },
		{ "85", "Transport contract place of destination" },
		{ "86", "Country of valid transit guarantee" },
		{ "87", "Place/port of conveyance initial arrival" },
		{ "88", "Place of receipt" },
		{ "89", "Place of registration" },
		{ "90", "Place/location where special treatments have happened or must happen" },
		{ "91", "Place of document issue" },
		{ "92", "Routing" },
		{ "93", "Station of application of additional costs" },
		{ "94", "Previous port of call" },
		{ "95", "Sailing destination area" },
		{ "96", "Place of lodgement of documents" },
		{ "97", "Optional place of discharge" },
		{ "98", "Place of empty equipment despatch" },
		{ "99", "Place of empty equipment return" },
		{ "100", "Place/port of warehouse entry" },
		{ "101", "Country of first sale" },
		{ "102", "Country of purchase" },
		{ "103", "Place of transfer" },
		{ "104", "Place of deconsolidation" },
		{ "105", "Place of consumption" },
		{ "106", "Region of origin" },
		{ "107", "Place of consolidation" },
		{ "108", "Rate combination point" },
		{ "109", "Place of prolongation decision of delivery delay" },
		{ "110", "Recharging place/location" },
		{ "111", "Customs office of despatch" },
		{ "112", "Region of equipment availability" },
		{ "113", "Country of despatch" },
		{ "114", "Customs office of export" },
		{ "115", "Free zone of export" },
		{ "116", "Region of export/despatch" },
		{ "117", "Place of collection" },
		{ "118", "Customs office of departure" },
		{ "119", "Customs office of transit guarantee" },
		{ "120", "Country of transhipment" },
		{ "121", "Country of sale" },
		{ "122", "Customs office of destination" },
		{ "123", "Wagon-load railway station" },
		{ "124", "Siding" },
		{ "125", "Last place/port of call of conveyance" },
		{ "126", "Country of previous Customs procedure" },
		{ "127", "Customs office of registration of previous Customs declaration" },
		{ "128", "Participant sender location" },
		{ "129", "Wage negotiation district" },
		{ "130", "Place of ultimate destination of conveyance" },
		{ "131", "Place of loading of empty equipment" },
		{ "132", "Place of discharge of empty equipment" },
		{ "133", "Region of delivery" },
		{ "134", "Petroleum warehouse" },
		{ "135", "Place of entry (Customs)" },
		{ "136", "Living animals care place" },
		{ "137", "Re-icing place" },
		{ "138", "Weighting place" },
		{ "139", "Marshalling yard" },
		{ "140", "Shopping station" },
		{ "141", "Loading dock" },
		{ "142", "Port connection" },
		{ "143", "Place of expiry" },
		{ "144", "Place of negotiation" },
		{ "145", "Claims payable place" },
		{ "146", "Documentary credit available in" },
		{ "147", "Stowage cell" },
		{ "148", "For transportation to" },
		{ "149", "Loading on board/despatch/taking in charge at/from" },
		{ "150", "Container stack position" },
		{ "151", "Private box" },
		{ "152", "Next port of discharge" },
		{ "153", "Port of call" },
		{ "154", "Place/location of on-hire" },
		{ "155", "Place/location of off-hire" },
		{ "156", "Other carriers terminal" },
		{ "157", "Country of Value Added Tax (VAT) jurisdiction" },
		{ "158", "Contact location" },
		{ "159", "Additional internal destination" },
		{ "160", "Foreign port of call" },
		{ "161", "Maintenance location" },
		{ "162", "Place or location of sale" },
		{ "163", "Direct investment country" },
		{ "164", "Berth" },
		{ "165", "Construction country" },
		{ "166", "Donation acting country" },
		{ "167", "Payment transaction country" },
		{ "168", "Physical place of return of item" },
		{ "169", "Relay port" },
		{ "170", "Final port of discharge" },
		{ "171", "Place of destination for pre-stacking prior to stowage" },
		{ "172", "Reporting location" },
		{ "ZZZ", "Mutually defined" },
	};
}