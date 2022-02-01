#if MIGRATION
using System.Collections.ObjectModel;

namespace System.Windows.Controls.DataVisualization.Charting
{
    /// <summary>
    /// Represents a series in a chart.
    /// </summary>
    public interface ISeries
    {
        ObservableCollection<object> LegendItems { get; }
    }
}
#endif
