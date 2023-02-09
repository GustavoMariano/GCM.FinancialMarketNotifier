using System.ComponentModel;

namespace GCM.FinancialMarketNotifier.Domain.Enums;

public enum EEndPoint
{
    [Description("https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL")]
    ExchangeCurrency
}
