#if MIGRATION
using System.Collections.ObjectModel;

namespace System.Windows.Controls.DataVisualization.Charting
{
    [OpenSilver.NotImplemented]
    public abstract class Series : Control, ISeries
    {
        [OpenSilver.NotImplemented]
        public object Title { get; set; }

        [OpenSilver.NotImplemented]
        public ObservableCollection<object> LegendItems => throw new NotImplementedException();
    }
}
#endif
