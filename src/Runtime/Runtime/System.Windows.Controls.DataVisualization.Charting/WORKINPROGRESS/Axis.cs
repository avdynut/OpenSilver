#if MIGRATION
using System.Collections.ObjectModel;

namespace System.Windows.Controls.DataVisualization.Charting
{
    [OpenSilver.NotImplemented]
    public abstract class Axis : Control, IAxis
    {
        [OpenSilver.NotImplemented]
        public AxisOrientation Orientation { get; set; }

        [OpenSilver.NotImplemented]
        public ObservableCollection<IAxis> DependentAxes => throw new NotImplementedException();

        [OpenSilver.NotImplemented]
        public bool CanPlot(object value)
        {
            throw new NotImplementedException();
        }
    }
}
#endif