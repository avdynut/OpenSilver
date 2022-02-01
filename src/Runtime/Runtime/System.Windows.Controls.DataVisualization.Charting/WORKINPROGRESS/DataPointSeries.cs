#if MIGRATION
using System.Collections;
using System.Windows.Data;

namespace System.Windows.Controls.DataVisualization.Charting
{
    [OpenSilver.NotImplemented]
    public abstract class DataPointSeries : Series
    {
        [OpenSilver.NotImplemented]
        public Binding DependentValueBinding { get; set; }

        [OpenSilver.NotImplemented]
        public Binding IndependentValueBinding { get; set; }

        #region public IEnumerable ItemsSource
        /// <summary>
        /// Gets or sets a collection used to contain the data points of the Series.
        /// </summary>
        [OpenSilver.NotImplemented]
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        /// <summary>
        /// Identifies the ItemsSource dependency property.
        /// </summary>
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(
                "ItemsSource",
                typeof(IEnumerable),
                typeof(DataPointSeries),
                new PropertyMetadata(OnItemsSourceChanged));

        /// <summary>
        /// ItemsSourceProperty property changed callback.
        /// </summary>
        /// <param name="o">Series for which the ItemsSource changed.</param>
        /// <param name="e">Event arguments.</param>
        private static void OnItemsSourceChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            ((DataPointSeries)o).OnItemsSourceChanged((IEnumerable)e.OldValue, (IEnumerable)e.NewValue);
        }

        /// <summary>
        /// Called when the ItemsSource property changes.
        /// </summary>
        /// <param name="oldValue">Old value of the ItemsSource property.</param>
        /// <param name="newValue">New value of the ItemsSource property.</param>
        protected virtual void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
        {
            //// Remove handler for oldValue.CollectionChanged (if present)
            //INotifyCollectionChanged oldValueINotifyCollectionChanged = oldValue as INotifyCollectionChanged;
            //if (null != oldValueINotifyCollectionChanged)
            //{
            //    // Detach the WeakEventListener
            //    if (null != _weakEventListener)
            //    {
            //        _weakEventListener.Detach();
            //        _weakEventListener = null;
            //    }
            //}

            //// Add handler for newValue.CollectionChanged (if possible)
            //INotifyCollectionChanged newValueINotifyCollectionChanged = newValue as INotifyCollectionChanged;
            //if (null != newValueINotifyCollectionChanged)
            //{
            //    // Use a WeakEventListener so that the backwards reference doesn't keep this object alive
            //    _weakEventListener = new WeakEventListener<DataPointSeries, object, NotifyCollectionChangedEventArgs>(this);
            //    _weakEventListener.OnEventAction = (instance, source, eventArgs) => instance.ItemsSourceCollectionChanged(source, eventArgs);
            //    _weakEventListener.OnDetachAction = (weakEventListener) => newValueINotifyCollectionChanged.CollectionChanged -= weakEventListener.OnEvent;
            //    newValueINotifyCollectionChanged.CollectionChanged += _weakEventListener.OnEvent;
            //}

            //if (TemplateApplied)
            //{
            //    Refresh();
            //}
        }
        #endregion public IEnumerable ItemsSource

        [OpenSilver.NotImplemented]
        public Style DataPointStyle { get; set; }

        [OpenSilver.NotImplemented]
        public Style LegendItemStyle { get; set; }
    }
}
#endif
