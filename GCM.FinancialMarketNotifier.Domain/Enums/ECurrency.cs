using System.ComponentModel;

namespace GCM.FinancialMarketNotifier.Domain.Enums;

public enum ECurrency
{
    [Description("Brazilian Real")]
    BRL,
    [Description("American Dollar")]
    USD,
    [Description("Euro")]
    EUR,
    [Description("Pound Sterling")]
    GBP
}
