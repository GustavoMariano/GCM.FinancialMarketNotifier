using GCM.FinancialMarketNotifier.Domain.Enums;
using GCM.FinancialMarketNotifier.Domain.Interfaces;
using GCM.FinancialMarketNotifier.Domain.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Reflection;

namespace GCM.FinancialMarketNotifier.AntiCorruption.HttpServices;

public class CurrencyExchangeService : ICurrencyExchangeService
{
    //private readonly IMapper _mapper;
    private readonly HttpClient _httpClient;

    public CurrencyExchangeService(HttpClient httpClient)//, IMapper mapper)
    {
        //_mapper = mapper;
        _httpClient = httpClient;
    }

    public async Task<ExchangeModel> GetCurrencyExchange(ExchangeModel model)
    {
        string uri = $"{GetEnumDescription(EEndPoint.ExchangeCurrency)}";

        try
        {
            var response = await _httpClient.GetAsync(uri);

            var result = await DeserializarObjetoResponseAsync<ExchangeModel>(response);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    protected static async Task<T> DeserializarObjetoResponseAsync<T>(HttpResponseMessage responseMessage)
    {
        return JsonConvert.DeserializeObject<T>(await responseMessage.Content.ReadAsStringAsync());
    }

    private string GetEnumDescription(Enum value)
    {
        // Get the Description attribute value for the enum value
        FieldInfo fi = value.GetType().GetField(value.ToString());
        DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

        if (attributes.Length > 0)
            return attributes[0].Description;
        else
            return value.ToString();
    }
}
