#if MIGRATION
using System.Collections.ObjectModel;
using System.Windows.Markup;

namespace System.Windows.Controls.DataVisualization.Charting
{
    [OpenSilver.NotImplemented]
    [ContentProperty("Series")]
    public partial class Chart : Control //,ISeriesHost, IRequireSeriesHost, IResourceDictionaryDispenser
    {
        [OpenSilver.NotImplemented]
        public object Title { get; set; }

        [OpenSilver.NotImplemented]
        public object LegendTitle { get; set; }

        [OpenSilver.NotImplemented]
        public Collection<IAxis> Axes { get; set; }

        [OpenSilver.NotImplemented]
        public Collection<ISeries> Series { get; set; }

        /// <summary>
        /// Gets or sets a palette of ResourceDictionaries used by the children of the Chart.
        /// </summary>
        [OpenSilver.NotImplemented]
        public Collection<ResourceDictionary> Palette
        {
            get { return (Collection<ResourceDictionary>)GetValue(PaletteProperty); }
            set { SetValue(PaletteProperty, value); }
        }

        public static readonly DependencyProperty PaletteProperty =
            DependencyProperty.Register("Palette", typeof(Collection<ResourceDictionary>), typeof(Chart), new PropertyMetadata());

        /// <summary>
        /// Gets or sets the Style of the ISeriesHost's Title.
        /// </summary>
        [OpenSilver.NotImplemented]
        public Style TitleStyle
        {
            get { return (Style)GetValue(TitleStyleProperty); }
            set { SetValue(TitleStyleProperty, value); }
        }

        public static readonly DependencyProperty TitleStyleProperty =
            DependencyProperty.Register("TitleStyle", typeof(Style), typeof(Chart), new PropertyMetadata());

        /// <summary>
        /// Gets or sets the Style of the ISeriesHost's Legend.
        /// </summary>
        [OpenSilver.NotImplemented]
        public Style LegendStyle
        {
            get { return (Style)GetValue(LegendStyleProperty); }
            set { SetValue(LegendStyleProperty, value); }
        }

        public static readonly DependencyProperty LegendStyleProperty =
            DependencyProperty.Register("LegendStyle", typeof(Style), typeof(Chart), new PropertyMetadata());

        /// <summary>
        /// Gets or sets the Style of the ISeriesHost's ChartArea.
        /// </summary>
        [OpenSilver.NotImplemented]
        public Style ChartAreaStyle
        {
            get { return (Style)GetValue(ChartAreaStyleProperty); }
            set { SetValue(ChartAreaStyleProperty, value); }
        }

        public static readonly DependencyProperty ChartAreaStyleProperty =
            DependencyProperty.Register("ChartAreaStyle", typeof(Style), typeof(Chart), new PropertyMetadata());


        /// <summary>
        /// Gets or sets the Style of the ISeriesHost's PlotArea.
        /// </summary>
        [OpenSilver.NotImplemented]
        public Style PlotAreaStyle
        {
            get { return (Style)GetValue(PlotAreaStyleProperty); }
            set { SetValue(PlotAreaStyleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlotAreaStyle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlotAreaStyleProperty =
            DependencyProperty.Register("PlotAreaStyle", typeof(Style), typeof(Chart), new PropertyMetadata());
    }
}
#endif
