using GCM.FinancialMarketNotifier.Domain.Models;

namespace GCM.FinancialMarketNotifier.Domain.Interfaces;

public interface ICurrencyExchangeService
{
    Task<ExchangeModel> GetCurrencyExchange(ExchangeModel model);
}
