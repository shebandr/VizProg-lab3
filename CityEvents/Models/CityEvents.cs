using DynamicData.Binding;

namespace CityEvents.Models;

public class CityEvent : AbstractNotifyPropertyChanged
{
    private string _HeaderValue;
    private string _DescriptionValue;
    private string _ImageValue;
    private string _DateValue;
    private EventCategory _CategoryValue;
    private decimal _PriceValue;

    private static string CheckStringLenght(string? str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return "";
        }
        else if (str.Length > 135)
        {
            return str.Substring(0, 132) + "...";
        }
        else
        {
            return str;
        }
    }

    public CityEvent()
    {
        _HeaderValue = "";
        _DescriptionValue = "";
        _ImageValue = "";
        _DateValue = "";
        _CategoryValue = null!;
        _PriceValue = 0;
    }

    public string Header
    {
        get => _HeaderValue;
        set => SetAndRaise(ref _HeaderValue, value);
    }

    public string Description
    {
        get => _DescriptionValue;
        set
        {
            SetAndRaise(ref _DescriptionValue, CheckStringLenght(value));
        }
    }

    public string Image
    {
        get => _ImageValue;
        set => SetAndRaise(ref _ImageValue, value);
    }

    public string Date
    {
        get => _DateValue;
        set => SetAndRaise(ref _DateValue, value);
    }

    public EventCategory Category
    {
        get => _CategoryValue;
        set => SetAndRaise(ref _CategoryValue, value);
    }

    public decimal Price
    {
        get => _PriceValue;
        set => SetAndRaise(ref _PriceValue, value);
    }
}
