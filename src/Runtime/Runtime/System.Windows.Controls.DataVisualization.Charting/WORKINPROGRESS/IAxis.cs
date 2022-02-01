#if MIGRATION
using System.Collections.ObjectModel;

namespace System.Windows.Controls.DataVisualization.Charting
{
    [OpenSilver.NotImplemented]
    public interface IAxis
    {
        bool CanPlot(object value);
        //System.Windows.Controls.DataVisualization.UnitValue GetPlotAreaCoordinate(object value);
        ObservableCollection<IAxis> DependentAxes { get; }
        //System.Windows.Controls.DataVisualization.Charting.AxisOrientation Orientation { get; set; }
        //System.Collections.ObjectModel.ObservableCollection<System.Windows.Controls.DataVisualization.Charting.IAxisListener> RegisteredListeners { get; }
        //System.Windows.RoutedPropertyChangedEventHandler<System.Windows.Controls.DataVisualization.Charting.AxisOrientation> OrientationChanged;
    }
}
#endif
