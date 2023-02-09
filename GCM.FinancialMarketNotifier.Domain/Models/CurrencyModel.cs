namespace GCM.FinancialMarketNotifier.Domain.Models;

public class CurrencyModel
{
    public string Code { get; set; }
    public string CodeIn { get; set; }
    public string Name { get; set; }
    public string High { get; set; }
    public string Low { get; set; }
    public string VarBid { get; set; }
    public string PctChange { get; set; }
    public string Bid { get; set; }
    public string Ask { get; set; }
    public string Create_Date { get; set; }
}
