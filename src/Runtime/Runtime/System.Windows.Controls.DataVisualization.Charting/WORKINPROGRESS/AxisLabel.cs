#if MIGRATION
namespace System.Windows.Controls.DataVisualization.Charting
{
    [OpenSilver.NotImplemented]
    public class AxisLabel : Control
    {
        [OpenSilver.NotImplemented]
        public string StringFormat
        {
            get { return (string)GetValue(StringFormatProperty); }
            set { SetValue(StringFormatProperty, value); }
        }

        public static readonly DependencyProperty StringFormatProperty =
            DependencyProperty.Register("StringFormat", typeof(string), typeof(AxisLabel), new PropertyMetadata());
    }
}
#endif