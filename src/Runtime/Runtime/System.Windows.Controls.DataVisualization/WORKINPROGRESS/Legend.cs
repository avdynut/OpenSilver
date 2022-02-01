#if MIGRATION
namespace System.Windows.Controls.DataVisualization
{
    /// <summary>
    /// Represents a control that displays a list of items and has a title.
    /// </summary>
    [OpenSilver.NotImplemented]
    public class Legend : HeaderedItemsControl
    {
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
            DependencyProperty.Register("TitleStyle", typeof(Style), typeof(Legend), new PropertyMetadata());
    }
}
#endif
