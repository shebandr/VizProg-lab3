using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CityEvents.Models;
using System.Collections.ObjectModel;

namespace CityEvents.Views
{
    public partial class CategoryControl : UserControl
    {
        public static readonly StyledProperty<ReadOnlyObservableCollection<CityEvent>> EventsProperty =
            AvaloniaProperty.Register<CategoryControl, ReadOnlyObservableCollection<CityEvent>>(nameof(Events));

        public ReadOnlyObservableCollection<CityEvent> Events
        {
            get => GetValue(EventsProperty);
            set => SetValue(EventsProperty, value);
        }

        public CategoryControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}