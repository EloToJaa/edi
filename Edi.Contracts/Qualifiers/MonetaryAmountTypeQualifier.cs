using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Monetary amount type qualifier
/// </summary>
public class MonetaryAmountTypeQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator MonetaryAmountTypeQualifier(string s) => new MonetaryAmountTypeQualifier { Code = s };

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
		{ "1", "VAT, 1st value" },
		{ "2", "VAT, 2nd value" },
		{ "3", "VAT, 3rd value" },
		{ "4", "Additional royalties (Customs)" },
		{ "5", "Adjusted amount" },
		{ "6", "Amount reference currency" },
		{ "7", "Agreed charge" },
		{ "8", "Allowance or charge amount" },
		{ "9", "Amount due/amount payable" },
		{ "10", "Amount in charge currency" },
		{ "11", "Amount paid" },
		{ "12", "Amount remitted" },
		{ "13", "Amount subject to total monetary discount" },
		{ "14", "Amount target currency" },
		{ "15", "Average ledger balance" },
		{ "16", "Bank release fee" },
		{ "17", "Batch total" },
		{ "18", "Brokerage" },
		{ "19", "Buying commission" },
		{ "20", "Data value on carrier media (Customs)" },
		{ "21", "Cash discount" },
		{ "22", "Cash on delivery amount" },
		{ "23", "Charge amount" },
		{ "24", "Charge summary total" },
		{ "25", "Charge/allowance basis" },
		{ "26", "Charges collect fee" },
		{ "27", "Charges in destination currency" },
		{ "28", "Collect charge summary total" },
		{ "29", "Collect charges in destination currency" },
		{ "30", "Collect freight charge including VAT" },
		{ "31", "Collect freight charge without VAT" },
		{ "32", "Collect other charges due agent total" },
		{ "33", "Collect taxes total" },
		{ "34", "Collected balance required" },
		{ "35", "Container cost" },
		{ "36", "Converted amount" },
		{ "37", "Credit on consignment" },
		{ "38", "Invoice item amount" },
		{ "39", "Invoice total amount" },
		{ "40", "Customs value" },
		{ "41", "Assigned Customs value" },
		{ "42", "Total cash payments received by factor" },
		{ "43", "Declared total Customs value" },
		{ "44", "Declared value for carriage" },
		{ "45", "Deductible after importation charges (Customs)" },
		{ "46", "Deductions (Customs)" },
		{ "47", "Delivery fee" },
		{ "48", "Deposit total" },
		{ "49", "Development necessary for production of imported goods (Customs)" },
		{ "50", "Disbursements" },
		{ "51", "Disbursements fee" },
		{ "52", "Discount amount" },
		{ "53", "Discount amount due" },
		{ "54", "Distribution service fee" },
		{ "55", "Duty amount" },
		{ "56", "Duty/tax/fee basis amount" },
		{ "57", "Equivalent amount" },
		{ "58", "Fee amount" },
		{ "59", "Fees paid year to date" },
		{ "60", "Final (posted) amount" },
		{ "61", "Float (e.g. cash float)" },
		{ "62", "Total payments on account received by a factor" },
		{ "63", "FOB value" },
		{ "64", "Freight charge" },
		{ "65", "Total indirect amount payments made to a seller or his agent instead of to a factor" },
		{ "66", "Goods item total" },
		{ "67", "Insurance" },
		{ "68", "Insurance and transport charges (Customs)" },
		{ "69", "Insurance and transport charges incurred outside Customs territory" },
		{ "70", "Insurance charges (Customs)" },
		{ "71", "Insurance charges incurred outside of Customs territory" },
		{ "72", "Internal charges (Customs)" },
		{ "73", "Total amount of payments booked to the collateral account" },
		{ "74", "Amount to be paid in advance" },
		{ "75", "Registered capital" },
		{ "76", "Investable balance" },
		{ "77", "Invoice amount" },
		{ "78", "Landing charges" },
		{ "79", "Total line items amount" },
		{ "80", "Licence fees related to imported goods (Customs)" },
		{ "81", "Loading and handling cost" },
		{ "82", "Lock box total" },
		{ "83", "Lumpsum" },
		{ "84", "Material consumed in production of imported goods (Customs)" },
		{ "85", "Maximum charge" },
		{ "86", "Message total monetary amount" },
		{ "87", "Minimum charge" },
		{ "88", "National preference basis amount" },
		{ "89", "Negative collected balance" },
		{ "90", "Negative ledger balance" },
		{ "91", "Net adjustment" },
		{ "92", "Net fee position" },
		{ "93", "Net year to date excess (deficit)" },
		{ "94", "No amount of insurance" },
		{ "95", "No declared value for carriage" },
		{ "96", "No declared value for Customs" },
		{ "97", "Offer amount" },
		{ "98", "Original amount" },
		{ "99", "Other charges at destination" },
		{ "100", "Other charges due agent" },
		{ "101", "Other charges due carrier" },
		{ "102", "Other commissions" },
		{ "103", "Other deductible charges" },
		{ "104", "Other transport charges" },
		{ "105", "Other valuation charges (Customs)" },
		{ "106", "Packing cost" },
		{ "107", "Packing cost (Customs)" },
		{ "108", "Parts incorporated in imported goods (Customs)" },
		{ "109", "Payment discount amount" },
		{ "110", "Pick-up fee" },
		{ "111", "Positive collected balance" },
		{ "112", "Positive ledger balance" },
		{ "113", "Prepaid amount" },
		{ "114", "Prepaid charge summary total" },
		{ "115", "Prepaid taxes total" },
		{ "116", "Purchase amount" },
		{ "117", "Quantity discount" },
		{ "118", "Quota value" },
		{ "119", "Received amount" },
		{ "120", "Sales tax" },
		{ "121", "Shipment value in domestic currency" },
		{ "122", "Specific amount payable" },
		{ "123", "Statistical value" },
		{ "124", "Tax amount" },
		{ "125", "Taxable amount" },
		{ "126", "To collect" },
		{ "127", "Tools used in production of imported goods (Customs)" },
		{ "128", "Total amount" },
		{ "129", "Total amount subject to payment discount" },
		{ "130", "Total charge due" },
		{ "131", "Total charges/allowances" },
		{ "132", "Total collect charges" },
		{ "133", "Total collect charges at destination" },
		{ "134", "Total declared" },
		{ "135", "Total freight due" },
		{ "136", "Total invoice additional amount" },
		{ "138", "Total monetary discount amount" },
		{ "139", "Total payment amount" },
		{ "140", "Total service charge" },
		{ "141", "Cost, insurance and freight (CIF) value" },
		{ "142", "Trade discount" },
		{ "143", "Transfer amount" },
		{ "144", "Transport charges (Customs)" },
		{ "145", "Transport charges incurred outside Customs territory" },
		{ "146", "Unit price" },
		{ "147", "Acceptable quotation fluctuation amount" },
		{ "148", "Total payments under guarantee" },
		{ "149", "Valuation charge" },
		{ "150", "Value added tax" },
		{ "151", "Value insured" },
		{ "152", "Subsequent resale of imported goods (Customs)" },
		{ "153", "Weight charge" },
		{ "154", "Amount to be collected" },
		{ "155", "Standard duty" },
		{ "156", "G-Amount" },
		{ "157", "Insurance value" },
		{ "158", "Insurance and transport charges incurred inside Customs territory" },
		{ "159", "Licence (value deducted)" },
		{ "160", "Other costs" },
		{ "161", "Duty, tax or fee amount" },
		{ "162", "Customs duty paid" },
		{ "163", "Wage tax share" },
		{ "164", "Social securities premiums share" },
		{ "165", "Adjustment amount" },
		{ "166", "Guarantee amount (Customs)" },
		{ "167", "Actual versus calculated price difference" },
		{ "168", "Tax sub-totals" },
		{ "169", "Alternate currency total amount" },
		{ "170", "Document amount" },
		{ "171", "Total reassignments of factored invoices" },
		{ "172", "Stated amount" },
		{ "173", "Minimum amount" },
		{ "174", "Balance brought forward" },
		{ "175", "Message total additional amount" },
		{ "176", "Message total duty/tax/fee amount" },
		{ "177", "Message total amount prepaid" },
		{ "178", "Exact amount" },
		{ "179", "Maximum amount" },
		{ "180", "Amount up to" },
		{ "181", "Amount not exceeding" },
		{ "182", "Any other specification/tolerance" },
		{ "183", "No specification/tolerance" },
		{ "184", "Final net acquisition cost" },
		{ "185", "Labor cost" },
		{ "186", "Material cost" },
		{ "187", "Other cost" },
		{ "188", "Overhead cost" },
		{ "189", "Packaging cost" },
		{ "190", "Prototype set up cost" },
		{ "192", "Raw material per cart cost" },
		{ "193", "Raw material per unit of measure cost" },
		{ "194", "Total die model cost" },
		{ "195", "Total gauge cost" },
		{ "196", "Total material including purchased components cost" },
		{ "197", "Total purchased components cost" },
		{ "198", "Total tooling cost" },
		{ "199", "Delivery limitation amount" },
		{ "200", "Minimum amount due" },
		{ "201", "Penalty amount" },
		{ "202", "Interest amount" },
		{ "203", "Line item amount" },
		{ "204", "Allowance amount" },
		{ "205", "Additional amount covered: freight costs" },
		{ "206", "Additional amount covered: inspection costs" },
		{ "207", "Additional amount covered: insurance costs" },
		{ "208", "Additional amount covered: interest" },
		{ "209", "Agent commission amount" },
		{ "210", "Credit note amount" },
		{ "211", "Debit note amount" },
		{ "212", "Documentary credit amount" },
		{ "213", "Part of documentary credit amount" },
		{ "214", "Advance payment at the beginning of works" },
		{ "215", "Deduction of advance payment amount at the beginning of works" },
		{ "216", "Advance payment amount on building material" },
		{ "217", "Deduction of the advance payment amount on building material" },
		{ "218", "Advance payment amount on stock" },
		{ "219", "Deduction of the advance payment amount on stock" },
		{ "220", "Amount subject to guarantee retention" },
		{ "221", "Amount not subject of guarantee retention" },
		{ "222", "Amount subject to contractual retention" },
		{ "223", "Works amount, initial" },
		{ "224", "Works amount, variations" },
		{ "225", "Works amount, total" },
		{ "226", "Retention amount" },
		{ "227", "Deposit" },
		{ "228", "Deposit refund" },
		{ "229", "Guarantee on retention refund" },
		{ "230", "Amount subject to escalation" },
		{ "231", "Amount subject to escalation, initial" },
		{ "232", "Amount of variations subject to escalation" },
		{ "233", "Amount not subject to escalation" },
		{ "234", "Amount not subject to escalation, initial" },
		{ "235", "Amount of variations not subject to escalation" },
		{ "236", "Amount subject to price adjustment" },
		{ "237", "Amount subject to price adjustment, initial" },
		{ "238", "Amount of variations subject to price adjustment" },
		{ "239", "Amount not subject to price adjustment" },
		{ "240", "Amount not subject to price adjustment, initial" },
		{ "241", "Amount of variations not subject to price adjustment" },
		{ "242", "Escalation amount" },
		{ "243", "Provisional escalation amount" },
		{ "244", "Price adjustment amount" },
		{ "245", "Provisional price adjustment amount" },
		{ "246", "Price revaluation amount" },
		{ "247", "Provisional price revaluation amount" },
		{ "248", "Contractual retention amount total" },
		{ "249", "Valuation amount" },
		{ "250", "Deduction amount of direct payments to subcontractors" },
		{ "251", "Amortization total amount" },
		{ "252", "Amortization order amount" },
		{ "253", "Amortization cumulated amount" },
		{ "254", "Current credit cover" },
		{ "255", "New credit cover" },
		{ "256", "Order cover" },
		{ "257", "Amount subject to dispute" },
		{ "258", "Charge amount for information" },
		{ "259", "Total charges" },
		{ "260", "Total allowances" },
		{ "261", "Alternate currency amount" },
		{ "262", "Instalment amount" },
		{ "263", "Outstanding amount" },
		{ "264", "Gross contribution amount" },
		{ "265", "Commission amount" },
		{ "266", "Net contribution amount" },
		{ "267", "Regular contribution amount" },
		{ "268", "Previous regular contribution amount" },
		{ "269", "Variation amount" },
		{ "270", "Notional salary" },
		{ "271", "Nominal salary" },
		{ "272", "Taxable salary" },
		{ "273", "Superannuation salary" },
		{ "274", "Total remuneration" },
		{ "275", "Other salary" },
		{ "276", "Annual salary" },
		{ "277", "Total contributions amount" },
		{ "278", "Voluntary contribution amount" },
		{ "279", "Instalment first amount" },
		{ "280", "Instalment current amount" },
		{ "281", "Instalment last amount" },
		{ "282", "Current maintenance fee" },
		{ "283", "Current leasing fee" },
		{ "284", "Day works amount" },
		{ "285", "Manufacturer's bonus" },
		{ "286", "Administration charge" },
		{ "287", "Fuel charge" },
		{ "288", "Registration plate charge" },
		{ "289", "Subtotal amount" },
		{ "290", "Dumping export value" },
		{ "291", "Foreign inland freight" },
		{ "292", "Concession amount" },
		{ "293", "Chargeback" },
		{ "294", "Charge per credit cover" },
		{ "295", "Charge per unused credit cover" },
		{ "296", "Total authorised deduction" },
		{ "297", "Total chargebacks" },
		{ "298", "Total offsets" },
		{ "299", "Total special entries" },
		{ "300", "Balance carried forward" },
		{ "301", "Total outstanding invoices past due" },
		{ "302", "Off balance disputed items" },
		{ "303", "Commission invoices" },
		{ "304", "Other charges" },
		{ "305", "Amount remittances" },
		{ "306", "Total amount of payment commission invoices" },
		{ "307", "Total amount of payment other charges invoices" },
		{ "308", "Total amount credit notes" },
		{ "309", "Total adjustment invoices" },
		{ "310", "Total adjustment credit notes" },
		{ "311", "Total adjustment payments" },
		{ "312", "Base unit value" },
		{ "313", "International freight" },
		{ "314", "Own risk amount" },
		{ "315", "Opening balance" },
		{ "316", "Insurance premium" },
		{ "317", "Insurance commission" },
		{ "318", "Insurance tax" },
		{ "319", "Fee of insurer" },
		{ "320", "Fee of intermediary" },
		{ "321", "Debit flow" },
		{ "322", "Closing balance payable" },
		{ "323", "Opening balance payable" },
		{ "324", "Opening balance receivable" },
		{ "325", "Closing balance receivable" },
		{ "326", "Net assets and liabilities" },
		{ "327", "Adjustment to debit flow" },
		{ "328", "Adjustment to credit flow" },
		{ "329", "Credit flow" },
		{ "330", "Total prepaid other charges due carrier" },
		{ "331", "Total collect weight charge" },
		{ "332", "Total prepaid weight charge" },
		{ "333", "Total collect other charges due carrier" },
		{ "334", "Total prepaid other charges due agent" },
		{ "335", "Total collect valuation charge" },
		{ "336", "Total prepaid valuation charge" },
		{ "338", "Escalated value" },
		{ "339", "Original invoice gross total value" },
		{ "340", "Original total net invoice value" },
		{ "341", "Offset value" },
		{ "342", "Non-taxable amount" },
		{ "343", "Closing balance" },
		{ "344", "Value date balance" },
		{ "345", "Cost information for providing the statement" },
		{ "346", "Total credits" },
		{ "347", "Total debits" },
		{ "348", "Booked amount on the account" },
		{ "349", "Pending amount to be booked on the account" },
		{ "350", "Damage repair cost" },
		{ "351", "Labour rate per hour" },
		{ "352", "Total equipment labour costs for wear and tear" },
		{ "353", "Total equipment repair material costs for wear and tear" },
		{ "354", "Add to make market value" },
		{ "355", "Pro-ratable value" },
		{ "356", "Deduct to make market value" },
		{ "357", "Interim opening balance" },
		{ "358", "Interim closing balance" },
		{ "359", "Balance to be confirmed for audit reasons" },
		{ "360", "Accrued debit interest" },
		{ "361", "Accrued credit interest" },
		{ "362", "Part of booked amount" },
		{ "ZZZ", "Mutually defined" },
	};
}